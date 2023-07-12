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
    /// Lógica interna para FrmCadServico.xaml
    /// </summary>
    public partial class FrmCadServico : Window
    {
        string foto1, foto2, foto3, codicoEmp;

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            FrmCadastro frm = new FrmCadastro();
            frm.Show();
            this.Close();
            //Voltar ao menu 
        }

        private void CmbEmpresa_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (CmbEmpresa.Text != "")
            {
                Banco bd = new Banco();
                bd.Conectar();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM empresa WHERE nomeEmp = ?", bd.conexao);
                comm.Parameters.Clear();
                comm.Parameters.Add("@nomeEmp", MySqlDbType.String).Value = CmbEmpresa.Text;

                comm.CommandType = CommandType.Text;/*Executa o Comando*/
                                                    // Recebe o conteudo do banco

                MySqlDataReader dr = comm.ExecuteReader();
                dr.Read();

                codicoEmp = dr.GetString(0);

                TxtServico.IsEnabled = true;
                TxtServico.Focus();                
            }
        }

        private void TxtServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                TxtValor.IsEnabled = true;
                TxtValor.Focus();
            }
            
        }

        private void TxtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                valor = double.Parse(TxtValor.Text); // passar o valor da txt para a variavel 
                TxtValor.Text = "R$" + valor.ToString("N2"); //devolver para txt em formato moeda
                TxtDataCadastro.Text = DateTime.Now.ToShortDateString();// colocar a data atual na txt
                ChkStatus.IsEnabled = true;//habilitar a check box 
                MessageBox.Show("Não esqueça do status do serviço!");//mostra mensagem 
                TxtDescricao.IsEnabled = true;//habilitar a txt
                TxtDescricao.Focus();

            }
        }

        private void TxtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnFoto1.IsEnabled = true;
                BtnFoto1.Focus();
                BtnSalvar.IsEnabled = true;

            }
        }

        private void BtnFoto1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foto1 = dlg.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(foto1);
                bitmap.EndInit();
                //ImgFoto1.Source = bitmap; nao precisa mas desse caralho

                int imagem1 = foto1.IndexOf("servico");
                string nomeFoto1 = foto1.Substring(imagem1 + 8);
                TxtFoto1.Text = nomeFoto1;


                BtnFoto2.IsEnabled = true;
                BtnFoto2.Focus();

            }
        }

        private void BtnFoto2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foto2 = dlg.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(foto2);
                bitmap.EndInit();
                //  ImgFoto2.Source = bitmap;  nao precisa mais dessa poha

                int imagem2 = foto2.IndexOf("servico");
                string nomeFoto2 = foto2.Substring(imagem2 + 8);
                TxtFoto2.Text = nomeFoto2;


                BtnFoto3.IsEnabled = true;
                BtnFoto3.Focus();

            }
        }

        private void BtnFoto3_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foto3 = dlg.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(foto3);
                bitmap.EndInit();
                // ImgFoto3.Source = bitmap;     DESGRAÇA

                int imagem3 = foto3.IndexOf("servico");
                string nomeFoto3 = foto3.Substring(imagem3 + 8);
                TxtFoto3.Text = nomeFoto3;


            }
        }

        private void FrmCadServico1_Loaded(object sender, RoutedEventArgs e)
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

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            CmbEmpresa.Text = null;
            TxtServico.Clear();
            TxtValor.Clear();
            ChkStatus.IsChecked = false;
            TxtDataCadastro.Clear();
            TxtDescricao.Clear();

            TxtFoto1.Text = null;
            TxtFoto2.Text = null;
            TxtFoto3.Text = null;

            CmbEmpresa.IsEnabled = false;
            TxtServico.IsEnabled = false;
            TxtValor.IsEnabled   = false;
            ChkStatus.IsEnabled  = false;
            TxtDescricao.IsEnabled = false;
            BtnFoto1.IsEnabled = false;
            BtnFoto2.IsEnabled = false;
            BtnFoto3.IsEnabled = false;

            BtnLimpar.IsEnabled = false;
            BtnSalvar.IsEnabled = false;
            BtnNovo.IsEnabled = true;
            BtnNovo.Focus();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            string status;
            DateTime dataCadastro = DateTime.Today;


            Banco bd = new Banco();
            bd.Conectar();


            if(ChkStatus.IsChecked == true)
            {
                status = "ATIVO";
                string inserir = "INSERT INTO servico(idEmpresa,nomeServico,valorServico,statusServivo,dataCadServico,foto1,foto2,foto3,descServico)VALUES('" +
                    codicoEmp + "' , '" +
                    TxtServico.Text + "','" +
                    valor + "','" +
                    status + "','" +
                    dataCadastro.ToString("yyyy-MM-dd") + "','" +
                    TxtFoto1.Text + "','" +
                    TxtFoto2.Text + "','" +
                    TxtFoto3.Text + "','" +
                    TxtDescricao.Text + "')";

                MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
                comandos.ExecuteNonQuery();
            }
            else
            {
                status = "INATIVO";
                string inserir = "INSERT INTO servico(idEmpresa,nomeServico,valorServico,statusServico,dataCadServico,foto1,foto2,foto3,descServico)VALUES('" +
                    codicoEmp + "' , '" +
                    TxtServico.Text + "','" +
                    valor + "','" +
                    status + "','" +
                    dataCadastro.ToString("yyyy-MM-dd") + "','" +
                    TxtFoto1.Text + "','" +
                    TxtFoto2.Text + "','" +
                    TxtFoto3.Text + "','" +
                    TxtDescricao.Text + "')";

                MySqlCommand comandos = new MySqlCommand(inserir, bd.conexao);
                comandos.ExecuteNonQuery();
            }
            bd.Desconectar();
            MessageBox.Show("Serviço Cadastrado com Sucesso!!!", "Cadastro de Serviços");
            BtnLimpar.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

        double valor;

        private void BtnNovo_Click(object sender, RoutedEventArgs e)
        {
            CmbEmpresa.IsEnabled = true;  //habilitar o nome
            CmbEmpresa.Focus(); //focar no nome
            BtnLimpar.IsEnabled = true; //habilitar o Botao limpar
            BtnNovo.IsEnabled = false; //desabilitar o botao
        }

       
    
        public FrmCadServico()
        {
            InitializeComponent();
            BtnNovo.Focus();
        }
    }
}
