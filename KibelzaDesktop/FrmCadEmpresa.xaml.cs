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
    /// Lógica interna para FrmCadEmpresa.xaml
    /// </summary>
    public partial class FrmCadEmpresa : Window
    {
        string arquivoSelecionado;

        public FrmCadEmpresa()
        {
            InitializeComponent();
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
                TxtCnpj.IsEnabled = true;
                TxtCnpj.Focus();
            }
        }

        private void TxtRazaoSocial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TxtEmail.IsEnabled = true;
                TxtEmail.Focus();
            }
        }

        private void TxtCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TxtRazaoSocial.IsEnabled = true;
                TxtRazaoSocial.Focus();
            }
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TxtDataCadastro.Text = DateTime.Now.ToShortDateString();
                ChkStatus.IsEnabled = true;
                MessageBox.Show("Não esqueça do status da Empresa");
                BtnSalvar.IsEnabled = true;
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
                string inserir = "INSERT INTO empresa(nomeEmp,CNPJ,RazaoSocial,email,statusEmp,dataCadEmp)VALUES('" +
                    TxtNome.Text + "','" +
                    TxtCnpj.Text + "','" +
                    TxtRazaoSocial.Text + "','" +
                    TxtEmail.Text + "','" +
                    status + "','" +
                    dataCadastro.ToString("yyyy-MM-dd") + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
                comandos.ExecuteNonQuery();
            }
            else
            {
                status = "INATIVO";
                string inserir = "INSERT INTO empresa(nomeEmp,CNPJ,RazaoSocial,email,statusEmp,dataCadEmpresa)VALUES('" +
                   TxtNome.Text + "','" +
                   TxtCnpj.Text + "','" +
                   TxtRazaoSocial.Text + "','" +
                   TxtEmail.Text + "','" +
                   status + "','" +
                   dataCadastro.ToString("yyyy-MM-dd") + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
                comandos.ExecuteNonQuery();
            }
            bd.Desconectar();
            MessageBox.Show("Empresa cadastrado com sucesso!!!", "Cadastro de Empresa");
            BtnLimpar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            var tel = MessageBox.Show(
                "Deseja inserir um número de telefone para essa Empresa?",
                "Cadastro Empresa",
                MessageBoxButton.YesNo,
                MessageBoxImage.Exclamation);
            if (tel != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                FrmCadTelEmpresa frm = new FrmCadTelEmpresa();
                frm.Show();

                this.Close();

            }
        }
    }
}
