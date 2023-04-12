using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {
        MySqlConnection Conexao;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_suorce = "datasource=localhost;username=root;passaword=;database=DbProjetoIII";

                Conexao = new MySqlConnection(data_suorce);

                string sql = "INSERT INTO TbAluno (Nome, Idade, Curso, Email, Fone) VALUES "
                + "('" + txtNomeAluno.Text + "', '" + CboxIdadeAluno.Text + "', '" + txtCursoAluno.Text + "', " +
                "'" + txtEmailAluno.Text + "', '" + txtFoneAluno.Text + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Deu tudo certo! Inserido!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
            Form1 j4 = new Form1();
            j4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFoneAluno_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtFoneAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNomeAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }
    }
    }

