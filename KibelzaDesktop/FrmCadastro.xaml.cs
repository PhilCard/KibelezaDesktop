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
    /// Lógica interna para FrmCadastro.xaml
    /// </summary>
    public partial class FrmCadastro : Window
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void BtnCadCliente_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FrmCadCliente frm = new FrmCadCliente();
            frm.Show();
        }

        private void BtnCadVoltar_Click(object sender, RoutedEventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Close();
        }

        private void BtnCadFuncionario_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FrmCadFuncionario frm = new FrmCadFuncionario();
            frm.Show();
        }
    }
}
