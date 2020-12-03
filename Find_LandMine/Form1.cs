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
    public partial class Form1 : Form
    {
        MineSweeper mineSweeper;
        List<Rank> list;
        string name;
        int box = 0;

        public Form1()
        {
            InitializeComponent();
            list = new List<Rank>();
            list.Add(new Rank("", 5, 15.0));
            list.Add(new Rank("", 4, 10.0));
            list.Add(new Rank("", 3, 5.0));
            dataGridView1.DataSource = list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if (radioButton1.Checked == true) 
            { 
                box = 3;
                mineSweeper = new MineSweeper(name, box);
                mineSweeper.ShowDialog();
                if (mineSweeper.getFlag() == -1)
                {
                    double time = mineSweeper.getTime();
                    list.Add(new Rank(name, box, time));
                    var data = from num in list
                               orderby num.Box descending, num.Time ascending
                               select num;
                    List<Rank> listOut = data.ToList();
                    dataGridView1.DataSource = listOut;
                }
                else
                {
                    var data = from num in list
                               orderby num.Box descending, num.Time ascending
                               select num;
                    List<Rank> listOut = data.ToList();
                    dataGridView1.DataSource = listOut;
                }
            }
            else if (radioButton2.Checked == true) 
            { 
                box = 4;
                mineSweeper = new MineSweeper(name, box);
                mineSweeper.ShowDialog();
                if (mineSweeper.getFlag() == -1)
                {
                    double time = mineSweeper.getTime();
                    list.Add(new Rank(name, box, time));
                    var data = from num in list
                               orderby num.Box descending, num.Time ascending
                               select num;
                    List<Rank> listOut = data.ToList();
                    dataGridView1.DataSource = listOut;
                }
                else
                {
                    var data = from num in list
                               orderby num.Box descending, num.Time ascending
                               select num;
                    List<Rank> listOut = data.ToList();
                    dataGridView1.DataSource = listOut;
                }
            }
            else if (radioButton3.Checked == true) { 
                box = 5;
                mineSweeper = new MineSweeper(name, box);
                mineSweeper.ShowDialog();
                if (mineSweeper.getFlag() == -1)
                {
                    double time = mineSweeper.getTime();
                    list.Add(new Rank(name, box, time));
                    var data = from num in list
                               orderby num.Box descending, num.Time ascending
                               select num;
                    List<Rank> listOut = data.ToList();
                    dataGridView1.DataSource = listOut;
                }
                else
                {
                    var data = from num in list
                               orderby num.Box descending, num.Time ascending
                               select num;
                    List<Rank> listOut = data.ToList();
                    dataGridView1.DataSource = listOut;
                }
            }
            else { MessageBox.Show("Box의 개수를 선택하세요", "Error"); }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list = new List<Rank>();
            list.Add(new Rank("", 5, 15.0));
            list.Add(new Rank("", 4, 10.0));
            list.Add(new Rank("", 3, 5.0));
            dataGridView1.DataSource = list;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
