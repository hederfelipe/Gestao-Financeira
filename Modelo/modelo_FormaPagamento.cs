using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Modelo
{
    public class modelo_FormaPagamento
    {
        private int forma_id;
        private string forma_descricao;

        /// <summary>
        /// variavel global da classe
        /// </summary>
        public modelo_FormaPagamento()
        {
            this.Forma_id = 0;
            this.Forma_descricao = "";
        }
        /// <summary>
        /// propriedade da classe
        /// </summary>
        public int Forma_id { get => forma_id; set => forma_id = value; }
        public string Forma_descricao { get => forma_descricao; set => forma_descricao = value; }
    }
}
