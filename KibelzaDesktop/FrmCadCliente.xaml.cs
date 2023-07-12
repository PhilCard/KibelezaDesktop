using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace KibelzaDesktop
{
    /// <summary>
    /// Lógica interna para FrmCadCliente.xaml
    /// </summary>
    public partial class FrmCadCliente : Window
    {
        string arquivoSelecionado;

        public FrmCadCliente()
        {
            InitializeComponent();
            BtnNovo.Focus();
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Close();
        }

        private void BtnNovo_Click(object sender, RoutedEventArgs e)
        {
            TxtNome.IsEnabled = true;
            TxtNome.Focus();
            BtnLimpar.IsEnabled = true;
            BtnNovo.IsEnabled = false;
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
                ChkStatus.IsEnabled = true;
                MessageBox.Show("Não esqueça do status do Cliente");
                BtnFoto.IsEnabled = true;
                BtnFoto.Focus();
                BtnSalvar.IsEnabled = true;
            }
        }

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtSenha.Clear();
            TxtDataCadastro.Clear();
            TxtFoto.Clear();
            ChkStatus.IsChecked = false;

            ImgFoto.Source = null;

            TxtNome.IsEnabled = false;
            TxtEmail.IsEnabled = false;
            TxtSenha.IsEnabled = false;
            ChkStatus.IsEnabled = false;
            BtnFoto.IsEnabled = false;
            BtnLimpar.IsEnabled = false;
            BtnSalvar.IsEnabled = false;
            BtnNovo.IsEnabled = true;
            BtnNovo.Focus();

        }

        private void BtnFoto_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*jog|All Files (*.*|*.*";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                arquivoSelecionado = dlg.FileName;
                TxtFoto.Text = arquivoSelecionado;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(arquivoSelecionado);
                bitmap.EndInit();
                ImgFoto.Source = bitmap;
            }
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            string status;
            DateTime dataCadastro = DateTime.Today;

            Banco bd = new Banco();
            bd.Conectar();
            if (ChkStatus.IsChecked == true)
            {

                status = "ATIVO";
                string inserir = "INSERT INTO cliente(nomeCli,emailCli,senhaCli,statusCli,dataCadCli,fotoCli)VALUES('" + 
                    TxtNome.Text + "' , '" + 
                    TxtEmail.Text + "','" +
                    TxtSenha.Text + "','" +
                    status + "','" +
                    dataCadastro.ToString("yyyy-mm-dd") + "','" +
                    ImgFoto.Source + "')";

                MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
                comandos.ExecuteNonQuery();
                
            }
            bd.Desconectar();
            MessageBox.Show("Cliente cadastrado com sucesso!!!", "Cadastro de clientes");
            BtnLimpar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            var tel = MessageBox.Show(
                "Deseja inserir um número de telefone para esse cliente?",
                "Cadastro Telefone",
                MessageBoxButton.YesNo,
                MessageBoxImage.Exclamation);

            if (tel != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                FrmCadTelCliente frm = new FrmCadTelCliente();
                frm.Show();

                this.Close();
            }
        }
    }
}
