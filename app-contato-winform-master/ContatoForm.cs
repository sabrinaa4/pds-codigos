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


//sab
namespace AppContatoForm
{
    public partial class ContatoForm : Form
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;

        public ContatoForm()
        {
            InitializeComponent();

            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var dataNascimento = dateDataNascimento.Value;

                if (!rdSexo1.Checked && !rdSexo2.Checked)
                {
                    MessageBox.Show("Marque uma opção!");
                }

                else
                {
                    var nome = txtNome.Text;
                    var email = txtEmail.Text;
                    var telefone = txtTelefone.Text;
                    var sexo = rdSexoGroup.Text;
                   // var dataNascimento = dateDataNascimento.Text;


                    if (!rdSexo1.Checked && !rdSexo2.Checked)
                    {
                        sexo = "Masculino";
                    }

                    string query = "INSERT INTO contato (nome_con, email_con, telefone_con, sexo_con, data_nasc_con) VALUES (@_nome, @_email, @_telefone, @_sexo, @_dataNasc)";
                    var comando = new MySqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_dataNasc", dataNascimento);

                    comando.ExecuteNonQuery();


                    var opcao = MessageBox.Show("Informações salva com sucesso!\n Deseja realizar um novo cadastro?", "informação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcao == DialogResult.Yes)
                    {
                        LimparInputs();
                    }

                    else
                    {
                        this.Close();
                    }

                     txtNome.Clear();
                     rdSexoGroup.Clear();
                     txtEmail.Clear();
                     txtTelefone.Clear();
                     dateDataNascimento.Checked = false;
                     rdSexo1.Checked = false;
                     rdSexo2.Checked = false;
                     txtNome.Focus();

                     //  conexao.Open();
                }





            } catch (Exception ex){
                /* MessageBox.Show($"Ocorreram erros ao tentar salvar os dados." +
                     $" Contate o suporte do sistema. (CAD 25)"); */

                MessageBox.Show(ex.Message);
            }
            
        }

        private void LimparInputs()
        {
            throw new NotImplementedException();
        }
    }
}
