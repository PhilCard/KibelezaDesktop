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
    /// Lógica interna para FrmConsulta.xaml
    /// </summary>
    public partial class FrmConsulta : Window
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void BtnConVoltar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void BtnConCliente_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            FrmConCliente frm = new FrmConCliente();
            frm.Show();
        }
    }
}
