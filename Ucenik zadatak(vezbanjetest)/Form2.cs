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
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            string telefon = textBox3.Text;

            form.ucenik = new Ucenik(ime, prezime, telefon);
            label4.Text = "Ucenik je uspesno dodat!";
            label4.ForeColor = Color.Green;
            label4.Visible = true;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
