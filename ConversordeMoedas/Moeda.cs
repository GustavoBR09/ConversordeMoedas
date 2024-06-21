using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversordeMoedas
{
    public class Moeda
    { 
        public TiposMoeda Tipo { get; set; }
        public string Descricao {  get; set; }
        public string Regiao { get; set; }
        public decimal ValorEmReal { get; set; }
        public decimal ValorEmDolar { get; set; }
        public decimal ValorEmEuro { get; set; }
        public decimal ValorEmIene { get; set; }
        public decimal ValorEmLibra_Esterlina { get; set; }

    }
}
