using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;



namespace sprint2_AuroraEdwinRut
{
    public partial class config_balises : Form
    {
        SerialPort portArduino;
        public config_balises()
        {
            InitializeComponent();
        }
        private void cmb_ports_Enter(object sender, EventArgs e)
        {
            cmb_ports.Items.Clear();
            String[] ports;
            ports = SerialPort.GetPortNames();
            cmb_ports.Items.AddRange(ports);
        }

        private void btn_connectar_Click(object sender, EventArgs e)
        {
            portArduino = new SerialPort(cmb_ports.Text);
            portArduino.Open();
            //portArduino.Write("\n");
            //if (portArduino.IsOpen)
            //{
            //    portArduino.Close();
            //}
            SerialReceive();
        }


        Thread filEscolta;

        private void SerialReceive()
        {
            filEscolta = new Thread(ReceiveData);
            filEscolta.Start();
        }



        private void ReceiveData()
        {
            while (portArduino.IsOpen)
            {
                string response = portArduino.ReadLine();
            }
        }



        private void btn_config_Click(object sender, EventArgs e)
        {
            int num_cicle = int.Parse(txt_cicle.Text);
            int num_divisor = int.Parse(txt_divisor.Text);
            string envio_datos;
            int compt_grafic = 0; //comptador per guardar les dades que rebem d arduino

            if (num_cicle >= num_divisor)
            {
                lbl_inc_cicle.Visible = true;
                envio_datos = txt_cicle.Text + "#" + txt_divisor.Text;
                portArduino.Write(envio_datos + "\n");

            }
        }

        private void txt_validating(object sender, CancelEventArgs e)
        {
            //TextBox ctr = (TextBox)sender;
            //int valor;

            //if (!int.TryParse(ctr.Text, out valor))
            //{
            //    ctr.Text = "";
            //    e.Cancel = true;
            //}

            int num_grups = int.Parse(txt_cicle.Text);

            if (num_grups < 5 || num_grups > 20)
            {
                lbl_inc_cicle.Visible = true;
                timer1.Enabled = true;

                txt_cicle.Text = "";
            }

        }

        private void txt_divisor_Validating(object sender, CancelEventArgs e)
        {
            int num_divisor = int.Parse(txt_divisor.Text);
            const int num1 = 2;
            const int num2 = 3;
            const int num3 = 5;
            const int num4 = 7;

            if (num_divisor != num1 && num_divisor != num2 && num_divisor != num3 && num_divisor != num4)
            {
                lbl_inc_divisor.Visible = true;
                timer1.Enabled = true;

                txt_divisor.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_inc_cicle.Visible = false;
            lbl_inc_divisor.Visible = false;
        }


    }
}