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
    public partial class Form3 : Form
    {
        Form1 form;
        public Form3(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucenik[] arr = form.ucenici.ToArray();
            listBox1.Items.Clear();
            string found = textBox1.Text;
                foreach (var item in arr)
                {
                if (item.Prezime.Contains(found) || item.Telefon.Contains(found))
                {
                    listBox1.Items.Add("Ime i prezime: " + item.Ime +
                        " " + item.Prezime + " Broj telefona: " + item.Telefon);
                }
                else
                    MessageBox.Show("Trazeni ucenik ne postoji! Da li zelite da pokusate ponovo?", "Greska!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
