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
    /// Lógica interna para FrmConCliente.xaml
    /// </summary>
    public partial class FrmConCliente : Window
    {
        string arquivoSelecionado;

        public FrmConCliente()
        {
            InitializeComponent();
            CmbCliente.Focus();
        }

        private void Limpar()
        {
            TxtCodigo.Clear();
            TxtNome.Clear();
            TxtEmail.Clear();
            TxtSenha.Clear();
            TxtDataCad.Clear();
            TxtFoto.Clear();
            ChkStatus.IsChecked = false;
            ImgFoto.Source = null;

            
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            FrmConsulta frm = new FrmConsulta();
            frm.Show();
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
                ChkStatus.IsEnabled = true;
                MessageBox.Show("Não esqueça do Status do Cliente!");
                BtnAltFoto.IsEnabled = true;
                BtnAltFoto.Focus();


            }
        }

        private void BtnAltFoto_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.InitialDirectory = "c://";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All files(*.*)|*.*";
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

        private void FrmConCliente1_Loaded(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();
            string selecionar = "SELECT idCliente, nomeCli FROM cliente";

            MySqlCommand com = new MySqlCommand(selecionar, bd.conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbCliente.DisplayMemberPath = "nomeCli";
            CmbCliente.ItemsSource = dt.DefaultView;
        }

        private void CmbCliente_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            string foto;
            Banco bd = new Banco();
            bd.Conectar();
            string selecionar = "SELECT * FROM cliente WHERE nomeCli = ? ";
            MySqlCommand com = new MySqlCommand(selecionar, bd.conexao);
            com.Parameters.Clear();
            com.Parameters.Add("@nomeEmp", MySqlDbType.String).Value = CmbCliente.Text;
            com.CommandType = CommandType.Text; /*Executa o comando */
                                                //recebe o conteúdo do banco 
            MySqlDataReader dr = com.ExecuteReader();
            dr.Read();
            if (CmbCliente.Text != "")
            {
                TxtCodigo.Text = dr.GetString(0);
                TxtNome.Text = dr.GetString(1);
                TxtEmail.Text = dr.GetString(2);
                TxtSenha.Text = dr.GetString(3);

                if (dr.GetString(4) == "ATIVO")
                {
                    ChkStatus.IsChecked = true;

                }
                else
                {
                    ChkStatus.IsChecked = false;


                }
                TxtDataCad.Text = dr.GetString(5);
                foto = dr.GetString(6);
                if (foto != "")
                {
                    TxtFoto.Text = foto.Remove(0, 8);
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(TxtFoto.Text);
                    bitmap.EndInit();
                    ImgFoto.Source = bitmap;
                }
            }

        }

        private void TxtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();

            string telefone = "SELECT numeroFone,tipoFone,descFone FROM foneCli WHERE idCliente = ?";

            MySqlCommand com1 = new MySqlCommand(telefone, bd.conexao);
            com1.Parameters.Clear();
            com1.Parameters.Add("@idCliente", MySqlDbType.String).Value = TxtCodigo.Text;

            com1.CommandType = CommandType.Text; /*Execute o comando*/

            MySqlDataAdapter da1 = new MySqlDataAdapter(com1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            DtgTelefones.DisplayMemberPath = "numeroFone";
            DtgTelefones.ItemsSource = dt1.DefaultView;
        }

        private void BtnDeletar1_Click(object sender, RoutedEventArgs e)
        {
            var del = MessageBox.Show(
                "Tem certeza que deseja DELETAR esse cliente?",
                "Deletar Cliente",
                MessageBoxButton.YesNo,
                MessageBoxImage.Exclamation);
            if (del != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                Banco bd = new Banco();
                bd.Conectar();
                string deletar = "DELETE FROM cliente WHERE idCliente= '" + TxtCodigo.Text + "'";
                MySqlCommand comandos = new MySqlCommand(deletar, bd.conexao);
                comandos.ExecuteNonQuery();
                MessageBox.Show("Cliente exluido com sucesso!");
                bd.Desconectar();
                Limpar();
                //carregar novamente o comboboxcliente
                Banco bd1 = new Banco();
                string selecionar = "SELECT idCliente, nomeCli FROM cliente";
                MySqlCommand com = new MySqlCommand(selecionar, bd1.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CmbCliente.DisplayMemberPath = "nomeCli";
                CmbCliente.ItemsSource = dt.DefaultView;

            }
        }

        private void BtnAlterar1_Click(object sender, RoutedEventArgs e)
        {
            string status;
            DateTime dataCadastro = DateTime.Today;
            Banco bd = new Banco();
            bd.Conectar();
            if (ChkStatus.IsChecked == true)
            {
                status = "ATIVO";
                string alterar = "UPDATE cliente SET " +
                    "nomeCli='" + TxtNome.Text + "'," +
                    "emailCli='" + TxtEmail.Text + "'," +
                    "senhaCli='" + TxtSenha.Text + "'," +
                    "statusCli='" + status + "'," +
                    "fotoCli='" + ImgFoto.Source + "'" +
                    "WHERE idCliente='" + TxtCodigo.Text + "'";
                MySqlCommand comandos = new MySqlCommand(alterar, bd.conexao);
                comandos.ExecuteNonQuery();
            }
            else
            {
                status = "INATIVO";
                string alterar = "UPDATE cliente SET " +
                    "nomeCli='" + TxtNome.Text + "'," +
                    "emailCli='" + TxtEmail.Text + "'," +
                    "senhaCli='" + TxtSenha.Text + "'," +
                    "statusCli='" + status + "'," +
                    "fotoCli='" + ImgFoto.Source + "'" +
                    "WHERE idCliente='" + TxtCodigo.Text + "'";
                MySqlCommand comandos = new MySqlCommand(alterar, bd.conexao);
                comandos.ExecuteNonQuery();
            }
            bd.Desconectar();
            MessageBox.Show("Cliente alterado com sucesso!! ", "Consulta Cliente");
            Limpar();
            //Carregar novamente a comboxCliente
            string selecionar = "SELECT idcliente, nomeCli FROM cliente";
            MySqlCommand com = new MySqlCommand(selecionar, bd.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbCliente.DisplayMemberPath = "nomeCli";
            CmbCliente.ItemsSource = dt.DefaultView;
        }

        private void DtgTelefones_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();
            TextBox t = e.EditingElement as TextBox;
            DataRowView dataRow = (DataRowView)DtgTelefones.SelectedItem;
            int index = DtgTelefones.CurrentCell.Column.DisplayIndex;
            string nomecoluna = DtgTelefones.CurrentCell.Column.Header.ToString();
            string novoValor = t.Text;
            int id = (int)dataRow.Row.ItemArray[0];
            string alterarfone = "UPDATE foneCli SET" + nomecoluna + "=\"" + novoValor + "\" WHERE idfonecli=" + id;
            MySqlCommand comandos = new MySqlCommand(alterarfone, bd.conexao);
            comandos.ExecuteNonQuery();
            MessageBox.Show("Telefone alterado com sucesso!");
        }

        private void DtgTelefones_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                Banco bd = new Banco();
                bd.Conectar();
                if (DtgTelefones.SelectedItem == null)
                {
                    return;
                }
                DataRowView rowView = (DataRowView)DtgTelefones.SelectedItem;

                string deletar = "DELETE FROM foneCli WHERE idfonecli='" + rowView["idfonecli"] + "'";
                using (MySqlCommand comandos = new MySqlCommand(deletar, bd.conexao))
                {
                    comandos.ExecuteNonQuery();
                    MessageBox.Show("Cliente Excluído com sucesso");

                }
                bd.Desconectar();
            }
        }
    }
}
