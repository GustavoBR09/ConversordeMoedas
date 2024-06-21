using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversordeMoedas
{
    public class Convercao
    {
        public decimal Converte(Moeda moedaEntrada, TiposMoeda tipoMoedaSaida, decimal valor)
        {
            if (moedaEntrada.Tipo == tipoMoedaSaida)
            {
                return valor;
            }

            switch (tipoMoedaSaida)
            {
                case TiposMoeda.Real:
                    return moedaEntrada.ValorEmReal * valor;
                case TiposMoeda.Dolar:
                    return moedaEntrada.ValorEmDolar * valor;
                case TiposMoeda.Euro:
                    return moedaEntrada.ValorEmEuro * valor;
                case TiposMoeda.Iene:
                    return moedaEntrada.ValorEmIene * valor;
                case TiposMoeda.Libra_Esterlina:
                    return moedaEntrada.ValorEmLibra_Esterlina * valor;
                default:
                    return 0;
            }
        }
    }
}
