using static System.Net.Mime.MediaTypeNames;

namespace Cuota_Prestamo_9_2_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Double Monto, Tasa_Interes, Cuotas, Total;
            int A�os;

            Monto = Double.Parse(txt_Monto.Text);
            A�os = int.Parse(txt_A�os.Text);

            Tasa_Interes = ((Monto * 16)/100) * A�os;

            Total = Monto + Tasa_Interes;
            Cuotas = Total/(A�os * 12);


            txt_Tasa_Interes.Text = Tasa_Interes.ToString();
            txt_Cuotas.Text = Cuotas.ToString();
            txt_Total.Text = Total.ToString();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Monto.Clear();
            txt_Tasa_Interes.Clear();
            txt_A�os.Clear();
            txt_Total.Clear();
            txt_Cuotas.Clear();
        }
    }
}