using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConversordeMoedas
{
    public partial class Form1 : Form
    {
        List<Moeda> moedas = new List<Moeda>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            decimal valor;

            if(decimal.TryParse(textBoxPrincipal.Text, out valor))
            {
                TiposMoeda tipoMoedaEntrada = (TiposMoeda)comboBoxPrincipal.SelectedItem;
                TiposMoeda tipoMoedaSaida = (TiposMoeda)comboBoxResultado.SelectedItem;

                var moeda = moedas.FirstOrDefault(m => m.Tipo == tipoMoedaEntrada);

                Convercao conv = new Convercao();


                var valorConvertido = conv.Converte(moeda, tipoMoedaSaida, valor);

                var moedaConvertida = moedas.FirstOrDefault(m => m.Tipo == tipoMoedaSaida);

                var regiaoInfo = new RegionInfo(moedaConvertida.Regiao);

                textBoxResultado.Text = $"{regiaoInfo.CurrencySymbol} {valorConvertido}";
            }
            else
            {
                MessageBox.Show("Favor insira um valor válido a ser convertido ou ficará sem almoço");
                textBoxPrincipal.Focus();
            }
            

        }

        public void CriarMoedas()
        {
            Moeda moeda = new Moeda();
            moeda.Tipo = TiposMoeda.Real;
            moeda.Regiao = "pt-BR";
            moeda.Descricao = "Moeda Brasileira";
            moeda.ValorEmReal = 1;
            moeda.ValorEmDolar = 0.18M;
            moeda.ValorEmLibra_Esterlina = 0.14M;
            moeda.ValorEmEuro = 0.17M;
            moeda.ValorEmIene = 29.10M;

            moedas.Add(moeda);

            moeda = new Moeda();
            moeda.Tipo = TiposMoeda.Dolar;
            moeda.Descricao = "Moeda Norte Americana";
            moeda.Regiao = "en-US";
            moeda.ValorEmReal = 5.45M;
            moeda.ValorEmDolar = 1;
            moeda.ValorEmLibra_Esterlina = 0.78M;
            moeda.ValorEmEuro = 0.93M;
            moeda.ValorEmIene = 158.02M;

            moedas.Add(moeda);

            moeda = new Moeda();
            moeda.Tipo = TiposMoeda.Euro;
            moeda.Descricao = "Moeda Europeia";
            moeda.Regiao = "en-EU";
            moeda.ValorEmReal = 5.83M;
            moeda.ValorEmDolar = 1.07M;
            moeda.ValorEmLibra_Esterlina = 0.84M;
            moeda.ValorEmEuro = 1;
            moeda.ValorEmIene = 169.78M;

            moedas.Add(moeda);

            moeda = new Moeda();
            moeda.Tipo = TiposMoeda.Iene;
            moeda.Descricao = "Moeda Japonesa";
            moeda.Regiao = "ja-JP";
            moeda.ValorEmReal = 0.03M;
            moeda.ValorEmDolar = 0.006M;
            moeda.ValorEmLibra_Esterlina = 0.004M;
            moeda.ValorEmEuro = 0.005M;
            moeda.ValorEmIene = 1;

            moedas.Add(moeda);

            moeda = new Moeda();
            moeda.Tipo = TiposMoeda.Libra_Esterlina;
            moeda.Descricao = "Moeda do Reino Unido";
            moeda.Regiao = "en-GB";
            moeda.ValorEmReal = 6.90M;
            moeda.ValorEmDolar = 1.27M;
            moeda.ValorEmLibra_Esterlina = 1;
            moeda.ValorEmEuro = 1.18M;
            moeda.ValorEmIene = 201.01M;

            moedas.Add(moeda);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPrincipal.DataSource = Enum.GetValues(typeof(TiposMoeda));
            comboBoxResultado.DataSource = Enum.GetValues(typeof(TiposMoeda));

            CriarMoedas();
        }
    }
}
