using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading; //coleção de funcões para a progress 
using MySql.Data.MySqlClient;
using System.Data;

namespace KibelzaDesktop
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        string usuario, senha,logado;

        public MainWindow()
        {
            InitializeComponent();
            TxtUsuario.Focus();
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            var sair = MessageBox.Show(
                "Tem certeza que dejesa ENCERRAR o sistema?",
                "Encerrar Sistema",
                MessageBoxButton.YesNo,
                MessageBoxImage.Exclamation);

            if (sair != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                //encerrar a aplicação corrente
                Application.Current.Shutdown();

            }

        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                senha = TxtSenha.Password;
                BtnEntrar.IsEnabled = true;
                BtnEntrar.Focus();
            }
        }

        private void BtnEntrar_Click(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();
            MySqlCommand comm = new MySqlCommand("SELECT * FROM funcionario WHERE emailFunc = @usuario AND senhaFunc = @senha", bd.conexao);
            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.String).Value = TxtUsuario.Text;
            comm.Parameters.Add("@senha", MySqlDbType.String).Value = TxtSenha.Password;

            //caso exista o usuario
            try
            {
               
                comm.CommandType = CommandType.Text;  //executa o comando 
                                                      // recebe o conteudo do banco
                MySqlDataReader dr = comm.ExecuteReader();
                dr.Read();

                acesso.nivelAcesso = dr.GetString(5);
                acesso.empresaAcesso = dr.GetString(1);

                BtnEntrar.IsEnabled = false;
                Thread.Sleep(10);//pausa de 10 milesimos de segundos
                PgbLogin.Value = 0;
                i = 0;
                Task.Run(() =>
                {
                    while (i < 100)
                    {
                        i++;
                        Thread.Sleep(50);// pausa de 50 milissigundos 
                        this.Dispatcher.Invoke(() => //usar para atualização imediata (obrigatorio)
                        {
                            PgbLogin.Value = i;
                            TxbCarrega.Text = i + "%";
                            while (i == 100)
                            {
                                logado = acesso.nivelAcesso;
                                if (acesso.nivelAcesso == "ADM")
                                {
                                    Hide();
                                    FrmMenu frm = new FrmMenu();
                                    frm.Show();
                                    frm.LblLogado.Content = logado;
                                    break;
                                }
                                else if (acesso.nivelAcesso == "NIVEL 1")
                                {
                                    Hide();
                                    FrmMenu frm = new FrmMenu();
                                    frm.Show();
                                    frm.LblLogado.Content = logado;
                                    frm.BtnRelatorio.IsEnabled = false;
                                    break;
                                }
                                else if (acesso.nivelAcesso == "NIVEL 2")
                                {
                                    Hide();
                                    FrmMenu frm = new FrmMenu();
                                    frm.Show();
                                    frm.LblLogado.Content = logado;
                                    frm.BtnCadastro.IsEnabled = false;
                                    frm.BtnRelatorio.IsEnabled = false;
                                    break;

                                }
                                else if (acesso.nivelAcesso == "NIVEL 3")
                                {
                                    Hide();
                                    FrmMenu frm = new FrmMenu();
                                    frm.Show();
                                    frm.LblLogado.Content = logado;
                                    frm.BtnCadastro.IsEnabled = false;
                                    frm.BtnConsulta.IsEnabled = false;
                                    frm.BtnRelatorio.IsEnabled = false;
                                    break;
                                }
                            }

                        });
                    }
                });

            }     
            //caso não exita o usuario 
            catch
            {
                MessageBox.Show("Favor preencher o usuário ou senha corretamente!!!");
                TxtUsuario.Clear();
                TxtSenha.Clear();
                TxtUsuario.Focus();
                PgbLogin.Value = 0;
                TxtSenha.IsEnabled = false;
                BtnEntrar.IsEnabled = false;
                TxbCarrega.Text = "0%";
            }
                                      
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                usuario = TxtUsuario.Text;
                TxtSenha.IsEnabled = true;
                TxtSenha.Focus();
            }
        }
    }
}
