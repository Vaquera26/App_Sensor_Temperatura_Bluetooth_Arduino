using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace PuertoSerie
{
    public partial class frmSerie : Form
    {
        SerialPort sp = new SerialPort();

        public frmSerie()
        {
            InitializeComponent();
        }

        int initialPanelTop;

        private void frmSerie_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();

           
            cmbPuertos.DataSource = new List<string>(puertos);
            cmbPuertos_Salida.DataSource = new List<string>(puertos);

            panel1.Height = 0;
            panel1.BackColor = Color.Blue;

            initialPanelTop = panel1.Top;
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            sp.WriteLine(txtEnviar.Text);
            txtEnviar.Clear();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = cmbPuertos.Text;
                sp.Open();
                MessageBox.Show("Conectado");

                sp.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort actualSP = (SerialPort)sender;
            string inData = actualSP.ReadLine();

            rtbLog.Invoke(new MethodInvoker(
                delegate
                {
                    try
                    {
                        int temperature = int.Parse(inData);

                        rtbLog.AppendText("Temperatura: " + temperature.ToString() + "\n");

                        UpdatePanelBasedOnTemperature(temperature);
                    }
                    catch (FormatException)
                    {
                        rtbLog.AppendText("Error: datos no validos\n");
                    }
                }
            ));
        }

        private void UpdatePanelBasedOnTemperature(int temperature)
        {
            int factorMultiplicador = 2;

            int panelHeight = Math.Max(0, Math.Min(temperature * factorMultiplicador, initialPanelTop));

            panel1.Height = panelHeight;

            panel1.Top = initialPanelTop - panelHeight;

            lbl_Grados.Text = temperature.ToString() + "°C";

            if (temperature <= 10)
            {
                panel1.BackColor = ColorTranslator.FromHtml("#1FBDB5");
                lbl_Estado.Text = "Frio";
            }
            else if (temperature <= 20)
            {
                panel1.BackColor = ColorTranslator.FromHtml("#5DCC27");
                lbl_Estado.Text = "Templado Bajo";
            }
            else if (temperature <= 30)
            {
                panel1.BackColor = ColorTranslator.FromHtml("#FFCD25");
                lbl_Estado.Text = "Templado Alto";
            }
            else if (temperature <= 45)
            {
                panel1.BackColor = ColorTranslator.FromHtml("#FF8702");
                lbl_Estado.Text = "Caliente Moderado";
            }
            else if (temperature <= 60)
            {
                panel1.BackColor = ColorTranslator.FromHtml("#E4341E");
                lbl_Estado.Text = "Muy Caliente";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            cmbPuertos.DataSource = puertos;
        }
    }
}
