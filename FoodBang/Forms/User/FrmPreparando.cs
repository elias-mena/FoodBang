using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace FoodBang.Forms.User
{
    public partial class FrmPreparando : Form
    {
        int hours, seconds = 0;
        static int minutes = 10;
        static int minDate = minutes;
        static int rest = minDate / 3;
        private string info;
        private PrintDocument Document = new PrintDocument();
        void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);

            Random r = new Random();
            int NdeFactura = r.Next(10, 50000000);
            DateTime now = DateTime.Now;
            String fecha = now.ToString();
            int cantidadProsutcos = int.Parse("2");

            String imprimir = "\t      Factura Electrónica\n\n" +
                "Nombre de la empresa: FoodBang\n" +
                "Fecha: " + fecha + "\n" +
                "Número de factura: " + NdeFactura.ToString() + "\n" +
                info + "\n"
                + Engine.totalPedido;
            //"Subtotal: " + (cantidadProsutcos * 500) + " CRC\n" +
            //"Total: " + ((cantidadProsutcos * 500) * 0.13 + (cantidadProsutcos * 500)) + " CRC\n";

            if (cantidadProsutcos <= 1)
            {
                MessageBox.Show("Se requeire comprar por lo menos dos productos.");
            }
            else
            {
                g.DrawString(imprimir, new Font("Arial", 30), Brush, 10, 10);
                Pen blackPen = new Pen(Color.Red, 10);// Crear el rectángulo
                Rectangle rect = new Rectangle(0, 0, 825, 1170);//
                g.DrawRectangle(blackPen, rect);
            }

        }
        public FrmPreparando(string inf)
        {
            InitializeComponent();
            Document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
            info = inf;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog PrintPreviewDlg = new PrintPreviewDialog();
            PrintPreviewDlg.Document = Document;
            ((Form)PrintPreviewDlg).WindowState = FormWindowState.Maximized;
            // Ejecutar maximizado.
            PrintPreviewDlg.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            string minutos = minutes.ToString();
            string hor = hours.ToString();
            string segundos = seconds.ToString();
            if (hours < 10)
            {
                hor = "0" + hours.ToString();
            }
            if (minutes < 10)
            {
                minutos = "0" + minutes.ToString();
            }
            if (seconds < 10)
            {
                segundos = "0" + seconds.ToString();
            }
            if (seconds == 0 && minutes > 0)
            {
                minutes -= 1;
                seconds = 60;
            }
            if (minutes == 0 && hours > 0 && seconds == 0)
            {
                seconds = 60;
                hours -= 1;
                minutes = 59;
            }
            if (minutes == 0 && hours == 0 && seconds == 0)
            {
                tempo.Stop();
            }

            temp.Text = hor + ":" + minutos + ":" + segundos;

            if (minutes == (minDate - rest) && seconds == 1)
            {
                proPreOrden.Increment(100);
            }
            if (minutes == minDate - (rest * 2) && seconds == 1)
            {
                proConCamino.Increment(100);
            }
            if (minutes == 0 && seconds == 1)
            {
                proEntregando.Increment(100);
                MessageBox.Show("El pedido ha llegado!");
            }
        }

        private void FrmPreparando_Load(object sender, EventArgs e)
        {
            seconds = 10;
            tempo.Start();
            progresoOrRecibido.Increment(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document.Print();
        }
    }
}
