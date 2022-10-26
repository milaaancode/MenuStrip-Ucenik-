using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucenik_zadatak_vezbanjetest_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Queue<Ucenik> ucenici;
        public Ucenik ucenik;
        int count = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();

            if(ucenik != null)
            {
                if (count < 10)
                {
                    ucenici.Enqueue(ucenik);
                    count++;
                    ShowListBox();
                }
                else
                {
                    ucenici.Dequeue();
                    count--;
                    ShowListBox();
                }
            }
        }

        public void ShowListBox()
        {
            listBox1.Items.Clear();
            Ucenik[] arr = ucenici.ToArray();
            for(int i=0; i<ucenici.Count; i++)
            {
                listBox1.Items.Add((arr[i] as Ucenik).Ime + 
                    " " + (arr[i] as Ucenik).Prezime + 
                    " " + (arr[i] as Ucenik).Telefon);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ucenici.Count > 0)
            {
                ucenici.Dequeue();
                ShowListBox();
            }
            else
                MessageBox.Show("Red je prazan!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
            ShowListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucenici = new Queue<Ucenik>();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            btnRemove_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void dODAJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void iZBRISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ucenici.Count == 0)
            {
                MessageBox.Show("Brisanje nije moguce! Red je prazan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ucenici.Dequeue();
                ShowListBox();
            }
        }

        private void pRETRAZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void pretragaPoPrezimenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }
    }
}
