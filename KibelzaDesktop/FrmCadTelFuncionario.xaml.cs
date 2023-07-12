using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Lógica interna para FrmCadTelFuncionario.xaml
    /// </summary>
    public partial class FrmCadTelFuncionario : Window
    {
        string codigo;
        
        public FrmCadTelFuncionario()
        {
            InitializeComponent();
            CmbNome.Focus();
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

        private void CmbNome_KeyDown(object sender, KeyEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();
            MySqlCommand comm = new MySqlCommand("SELECT * FROM funcionario WHERE nomeFunc = ?", bd.conexao);
            comm.Parameters.Clear();
            comm.Parameters.Add("@nomeFunc", MySqlDbType.String).Value = CmbNome.Text;
            //Aqui no commandtype tem que definir se vai atualizar um stored procedure 0//

            comm.CommandType = CommandType.Text; //executa o comando
            //recebe o conteudo do banco
            MySqlDataReader dr = comm.ExecuteReader();
            dr.Read();

            codigo = dr.GetString(0);

            BtnLimpar.IsEnabled = true;
            TxtTelefone.IsEnabled = true;
            TxtTelefone.Focus();            
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

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();

            string inserir = "INSERT INTO fonefunc(idFuncionario,numeroFone,tipoFone,descFone)VALUES('" +
                codigo + "','" +
                TxtTelefone.Text + "','" +
                CmbTipo.Text + "','" +
                CmbDescricao.Text + "')";

            MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
            comandos.ExecuteNonQuery();

            bd.Desconectar();
            MessageBox.Show("Telefone Cadastrado com Sucesso!!!", "Cadastro de Telefones");
            BtnLimpar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            TxtTelefone.IsEnabled = true;
            TxtTelefone.Focus();
        }

        private void FrmCadTelFuncionario1_Loaded(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();

            string selecionar = "SELECT idFuncionario, nomeFunc FROM Funcionario";

            MySqlCommand com = new MySqlCommand(selecionar, bd.conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbNome.DisplayMemberPath = "nomeFunc";
            CmbNome.ItemsSource = dt.DefaultView;
        }
    }
}
