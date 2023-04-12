using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_cadastro_de_palestra
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
           Form4 j2 = new Form4();
            j2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 j3 = new Form3();
            j3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 j1 = new Form2();
            j1.Show();
        }
    }
}
