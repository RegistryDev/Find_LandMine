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
        string name;
        int box = 0;
        public Form1()
        {
            InitializeComponent();
            Rank.initList();
            dataGridView1.DataSource = Rank.list;
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
                    Rank.addList(name, box, time);
                    dataGridView1.DataSource = Rank.listOut;
                }
                else
                {
                    Rank.sortList();
                    dataGridView1.DataSource = Rank.listOut;
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
                    Rank.addList(name, box, time);
                    dataGridView1.DataSource = Rank.listOut;
                }
                else
                {
                    Rank.sortList();
                    dataGridView1.DataSource = Rank.listOut;
                }
            }
            else if (radioButton3.Checked == true) { 
                box = 5;
                mineSweeper = new MineSweeper(name, box);
                mineSweeper.ShowDialog();
                if (mineSweeper.getFlag() == -1)
                {
                    double time = mineSweeper.getTime();
                    Rank.addList(name, box, time);
                    dataGridView1.DataSource = Rank.listOut;
                }
                else
                {
                    Rank.sortList();
                    dataGridView1.DataSource = Rank.listOut;
                }
            }
            else { MessageBox.Show("Box의 개수를 선택하세요", "Error"); }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rank.initList();
            dataGridView1.DataSource = Rank.list;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
