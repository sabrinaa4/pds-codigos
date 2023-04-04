using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting;
using MySql.Data.MySqlClient;
using AppContatoForm.RegraDeNegocio;

namespace AppContatoForm
{
    public partial class dgvLista : Form
    {
        private List<Contato> listaDeContatos = new List<Contato>();
        private MySqlConnection conexao; 
        private MySqlCommand comando; 

        public dgvLista()
        {
            InitializeComponent();
            CarregarListaContatos();
            Conexao();
        }

        private void CarregarListaContatos()
        {
            MySqlCommand cmd = new MySqlCommand("select * from contato", conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dvgLista.DataSource = dt;
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }


    }
}
