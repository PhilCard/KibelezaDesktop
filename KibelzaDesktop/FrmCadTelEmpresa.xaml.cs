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
    /// Lógica interna para FrmCadTelEmpresa.xaml
    /// </summary>
    public partial class FrmCadTelEmpresa : Window
    {
        string codigo;

        public FrmCadTelEmpresa()
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

            string inserir = "INSERT INTO foneempresa(idEmpresa,numeroFone,tipoFone,descFone)VALUES('" +
            codigo + "','" +
            TxtTelefone.Text + "','" +
            CmbTipo.Text + "','" +
            CmbDescricao.Text + "')";

            MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
            comandos.ExecuteNonQuery();

            bd.Desconectar();
            MessageBox.Show("Telefone cadastrado com sucesso !! ", "Cadastro de Telefones");
            BtnLimpar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            BtnSair.IsEnabled = true;
            BtnSair.Focus();
        }

        private void FrmCadTelEmpresa1_Loaded(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();

            string selecionar = "SELECT idEmpresa, nomeEmp FROM empresa";

            MySqlCommand com = new MySqlCommand(selecionar, bd.conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(selecionar, bd.conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbEmpresa.DisplayMemberPath = "nomeEmp";
            CmbEmpresa.ItemsSource = dt.DefaultView;
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

        private void CmbEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Banco bd = new Banco();
                bd.Conectar();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM empresa WHERE nomeEmp = ?", bd.conexao);
                comm.Parameters.Clear();
                comm.Parameters.Add("@nomeEmp", MySqlDbType.String).Value = CmbEmpresa.Text;
                /*Aqui no ComandType tem que definir se vai atualizar um Stored Procedure 0*/

                comm.CommandType = CommandType.Text; /* Executa o comando*/
                                                     // Recebe o conteúdo dop banco
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
                CmbTipo.Focus();
            }
        }
    }
}
