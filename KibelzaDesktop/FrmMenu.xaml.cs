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
    /// Lógica interna para FrmMenu.xaml
    /// </summary>
    public partial class FrmMenu : Window
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            FrmSair frm = new FrmSair();
            frm.Show();
        }

        private void BtnCadastro_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FrmCadastro frm = new FrmCadastro();
            frm.Show();
        }
    }
}
