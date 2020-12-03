using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_LandMine
{
    public partial class MineSweeper : Form
    {
        Control[] button;
        Form1 form1 = new Form1();
        string name;
        int box;
        double time = 0.0;
        int num;

        int flagCnt;
        int flag = 0;
        bool nearMineFlag = false;
        public MineSweeper(string name, int box)
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.name = name;
            this.box = box;
            flagCnt = box;

            Random r = new Random();
            num = r.Next(0, box);

            textBox2.Click += new EventHandler(btnHintClick);

            Point initLocation = new Point(13, 63);
            Size initSize = new Size(100, 100);
            int x = 0;

            button = new Control[box];
            for (int i = 0; i < box; i++)
            {
                button[i] = new Button();
                button[i].Location = new Point(initLocation.X + x, initLocation.Y);
                button[i].Size = new Size(initSize.Width, initSize.Height);
                button[i].Click += new EventHandler(btnClick);
                button[i].Tag = " ";
                Controls.Add(button[i]);
                x += 106;
            }

            button[num].Click -= new EventHandler(btnClick);
            button[num].Click += new EventHandler(btnMineClick);
            if (num != 0 && num != box - 1)
            {
                button[num + 1].Tag = "1";
                button[num - 1].Tag = "1";
            }
            else if (num == 0) { button[num + 1].Tag = "1"; }
            else if (num == box - 1) { button[num - 1].Tag = "1"; }
        }
        void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            btn.BackColor = Color.Gray;
            btn.Font = new Font("맑은 고딕", 15.0F);
            btn.Text = btn.Tag.ToString();
            flagCnt--;
            if (flagCnt == 1)
            {
                flag = -1;
                timer1.Enabled = false;
                MessageBox.Show("성공하셨습니다", "성공");
                this.Visible = false;
            }
        }
        void btnMineClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Font = new Font("맑은 고딕", 15.0F);
            btn.Text = "💣";
            btn.Enabled = false;
            btn.BackColor = Color.Gray;
            timer1.Enabled = false;
            MessageBox.Show("실패하셨습니다", "실패");
            this.Visible = false;
        }
        void btnHintClick(object sender, EventArgs e)
        {
            button[num].Font = new Font("맑은 고딕", 15.0F);
            button[num].Text = "💣";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time + 0.1;
            textBox1.Text = time.ToString("0.0");
        }
        public double getTime()
        {
            return Math.Truncate(time * 10) / 10;
        }
        public int getFlag()
        {
            return flag;
        }
        private void MineSweeper_Load(object sender, EventArgs e)
        {

        }
    }
}
