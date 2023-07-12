using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KibelzaDesktop
{
    public class Banco //mudar a classe para pública
    {
        //string caminho = "SERVER=localhost;USER=root;DATABASE=ki_beleza_novo";
        string caminho = "SERVER=opresidente.mysql.dbaas.com.br;USER ID=opresidente;DATABASE=opresidente;PWD=opresideTi04;includesecurityasserts=true";

        public MySqlConnection conexao; //instalar a referência MySQL.Data e usar a diretiva using

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar estabelecer conexão com o Banco de Dados", "ERRO!");
                //usar a diretiva using
            }
        }
        public void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar se comunicar com o Banco de Dados", "ERRO!"); //usar a diretiva using
            }
        }
    }
}
