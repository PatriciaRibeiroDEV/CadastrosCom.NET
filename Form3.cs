using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Projeto_cadastro_de_palestra
{
    public partial class Form3 : Form
    {
        MySqlConnection Conexao;

        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_suorce = "datasource=localhost;username=root;passaword=;database=DbProjetoIII";

                Conexao = new MySqlConnection(data_suorce);

                string sql= "INSERT INTO TbConvidado (Nome, Idade, Email, Fone) VALUES " 
                + "('" + txtNomeConv.Text + "', '" + CboIdadeConv.Text + "', " +
                "'" + txtEmailConv.Text + "', '" + txtFoneConv.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                
                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo! Inserido!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            Form1 j4 = new Form1();
            j4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeConv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFoneConv_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtFoneConv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
    }
