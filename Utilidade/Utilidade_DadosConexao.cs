using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Utilidade
{
    public class Utilidade_DadosConexao
    {

        public static string Server = "localhost";
        public static string Database = "gestaofinanceira";
        public static string usuario = "root";
        public static string senha = "816633";

        public static string StringConexao
        {
            get
            {
                return @"Data Source =" + Server + ";Initial Catalog=" + Database +  ";User ID=" + usuario + ";Password=" + senha; 

            }
        }
    }
}
