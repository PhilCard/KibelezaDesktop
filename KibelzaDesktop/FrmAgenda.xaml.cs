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
    /// Lógica interna para FrmAgenda.xaml
    /// </summary>
    public partial class FrmAgenda : Window
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda1_Loaded(object sender, RoutedEventArgs e)
        {
            Banco bd = new Banco();
            bd.Conectar();

            string selecionar = "SELECT reserva.idreserva,cliente,nomeCli,servico.nomeServico,reserva.dataReserva,reserva.statusReserva FROM reserva INNER JOIN cliente ON reserva.idCliente = cliente.idCliente INNER";
            MySqlCommand com = new MySqlCommand(selecionar, bd.conexao);
            //com.Parameters.Clear();
            //com.Parameters.Add("@idCliente", MySqlDbType.String).Value = TxtCodigo.Text;
        }

    }
}
