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
    /// Lógica interna para FrmCadFuncionario.xaml
    /// </summary>
    public partial class FrmCadFuncionario : Window
    {
        string status, codigoEmp;



        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, RoutedEventArgs e)
        {
            TxtNome.IsEnabled = true;  //habilitar o nome
            TxtNome.Focus(); //focar no nome
            BtnLimpar.IsEnabled = true; //habilitar o Botao limpar
            BtnNovo.IsEnabled = false; //desabilitar o botao

        }

        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TxtEmail.IsEnabled = true;
                TxtEmail.Focus();

            }
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TxtSenha.IsEnabled = true;
                TxtSenha.Focus();

            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TxtDataCadastro.Text = DateTime.Now.ToShortDateString();
                CmbNivel.IsEnabled = true;
                CmbNivel.Focus();

            }
        }

        private void CmbNivel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbNivel.SelectedValue != null)
            {
                ChkStatus.IsEnabled = true;
                MessageBox.Show("Não esqueça o status do Funcionario!");
                CmbEmpresa.IsEnabled = true;
                CmbEmpresa.Focus();

            }
        }

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtSenha.Clear();
            TxtDataCadastro.Clear();
            CmbNivel.SelectedValue = null;
            CmbEmpresa.SelectedValue = null;

            ChkStatus.IsChecked = false;

            TxtNome.IsEnabled = false;
            TxtEmail.IsEnabled = false;
            TxtSenha.IsEnabled = false;
            ChkStatus.IsEnabled = false;
            CmbNivel.IsEnabled = false;
            CmbEmpresa.IsEnabled = false;

            BtnSalvar.IsEnabled = false;
            BtnLimpar.IsEnabled = false;
            BtnNovo.IsEnabled = true;
            BtnNovo.Focus();

        }

        private void FrmCadFuncionario1_Loaded(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();

            string selecionar = "SELECT idEmpresa, nomeEmp FROM empresa";

            MySqlCommand com = new MySqlCommand(selecionar, bd.conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbEmpresa.DisplayMemberPath = "nomeEmp";
            CmbEmpresa.ItemsSource = dt.DefaultView;

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

                comm.CommandType = CommandType.Text; // Executa o comando 
                                                     //recebe o conteudo do banco
                MySqlDataReader dr = comm.ExecuteReader();
                dr.Read();

                codigoEmp = dr.GetString(0);
                MessageBox.Show(codigoEmp);

                BtnSalvar.IsEnabled = true;
                BtnSalvar.Focus();
                
            }
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            DateTime dataCadastro = DateTime.Today;

            Banco bd = new Banco();
            bd.Conectar();
            if (ChkStatus.IsChecked == true)
            {
                status = "ATIVO";
                string inserir = "INSERT INTO funcionario(nomeFunc,emailFunc,senhaFunc,nivelFunc,statusFunc,dataCadFunc,idEmpresa)Values('" +
                    TxtNome.Text + "','" +
                    TxtEmail.Text + "','" +
                    TxtSenha.Text + "','" +
                    CmbNivel.Text + "','" +
                    status + "','" +
                    dataCadastro.ToString("yyyy-MM-dd") + "','" +
                    codigoEmp + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
                comandos.ExecuteNonQuery();
            }
            else
            {
                status = "INATIVO";
                string inserir = "INSERT INTO funcionario(nomeFunc,emailFunc,senhaFunc,nivelFunc,statusFunc,dataCadFunc,idEmpresa)Values('" +
                    TxtNome.Text + "','" +
                    TxtEmail.Text + "','" +
                    TxtSenha.Text + "','" +
                    CmbNivel.Text + "','" +
                    status + "','" +
                    dataCadastro.ToString("yyyy-MM-dd") + "','" +
                    codigoEmp + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
                comandos.ExecuteNonQuery();
            }
            bd.Desconectar();
            MessageBox.Show("Funcionário cadastrado com sucesso!!!", "Cadastro de Funcionários");
            BtnLimpar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            var tel = MessageBox.Show(
                "Deseja inserir um número de telefone para esse funcionário?",
                "Cadastro Telefone",
                MessageBoxButton.YesNo,
                MessageBoxImage.Exclamation);
            if (tel != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                FrmCadTelFuncionario frm = new FrmCadTelFuncionario();
                frm.Show();
                this.Close();
            }
                

        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.Show();
            this.Close();
            //Voltar ao menu 
        }

        
    }
}
