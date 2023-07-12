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
    /// Lógica interna para FrmSair.xaml
    /// </summary>
    public partial class FrmSair : Window
    {
        public FrmSair()
        {
            InitializeComponent();
        }

        private void BtnEncerrar_Click(object sender, RoutedEventArgs e)
        {
            //encerrar a aplicação corrente
            Application.Current.Shutdown();         
        }

        private void BtnTrocar_Click(object sender, RoutedEventArgs e)
        {
            //Abrir novamente a tela de login
            MainWindow frm = new MainWindow();
            frm.Show();
            this.Close();
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            //fecha a janela
            this.Close();
        }
    }
}
