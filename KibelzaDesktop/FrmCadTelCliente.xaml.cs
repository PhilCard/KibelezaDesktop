using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KibelzaDesktop
{
    /// <summary>
    /// Lógica interna para FrmCadTelCliente.xaml
    /// </summary>
    public partial class FrmCadTelCliente : Window
    {
        string codigo;
        public FrmCadTelCliente()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.Show();
            this.Close();
        }

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            TxtTelefone.Clear();
            CmbTipo.Text = "";
            CmbDescricao.Text = "";

            TxtTelefone.IsEnabled = false;
            CmbTipo.IsEnabled = false;
            CmbDescricao.IsEnabled = false;
            BtnLimpar.IsEnabled = false;
            BtnSalvar.IsEnabled = false;

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();
            string inserir = "INSERT INTO fonecli(idCliente,numeroFone,tipoFone,descFone)VALUES('" + codigo + "','" +
                TxtTelefone.Text + "','" + CmbTipo.Text + "','" + CmbDescricao.Text + "')";

            MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
            comandos.ExecuteNonQuery();

            bd.Desconectar();
            MessageBox.Show("Telefone cadastrado com sucesso!!!", "Cadastro de Telefones");
            BtnLimpar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            TxtTelefone.IsEnabled = true;
            TxtTelefone.Focus();
        }

        private void FrmCadTelCliente1_Loaded(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();

            string selecionar = "SELECT idCliente,nomeCli FROM cliente";

            MySqlCommand com = new MySqlCommand(selecionar, bd.conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbNome.DisplayMemberPath = "nomeCli";
            CmbNome.ItemsSource = dt.DefaultView;

        }

        private void CmbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Banco bd = new Banco();
                bd.Conectar();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM cliente WHERE nomeCli = ?", bd.conexao);
                comm.Parameters.Clear();
                comm.Parameters.Add("@nomeCli", MySqlDbType.String).Value = CmbNome.Text;
                /* Aqui o commandType tem que definir se vai atualizar uma Stored Procedure o */

                comm.CommandType = CommandType.Text; /* Executa o comando*/
                                       //recebe o conteudo do banco
                MySqlDataReader dr = comm.ExecuteReader();
                dr.Read();

                codigo = dr.GetString(0);

                BtnLimpar.IsEnabled = true;
                TxtTelefone.IsEnabled = true;
                TxtTelefone.Focus();

            }
        }

        private void TxtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CmbTipo.IsEnabled = true;
                CmbDescricao.Focus();

            }
        }

        private void CmbTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CmbDescricao.IsEnabled = true;
            CmbDescricao.Focus();
        }

        private void CmbDescricao_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnSalvar.IsEnabled = true;
            BtnSalvar.Focus();
        }
    }
}
