using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressBAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delegado = new ThreadStart(CorrerProceso);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        public void CorrerProceso()
        {
            CambiarProgreso(" ", 0);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                CambiarProgreso(string.Format("position{0}%", i), i);
            }
            CambiarProgreso("completado!!!", 100);
            MessageBox.Show("prosesp finalizado");
        }
        public void CambiarProgreso(string texto, int valor)
        {
            if (this.InvokeRequired)
            {
                CambiarProgresoDelegado delegado = new CambiarProgresoDelegado(CambiarProgreso);
               
                object[] parametros = new object[] { texto, valor };
                this.Invoke(delegado, parametros);
            }
            else
            {
                lbprogress.Text = texto;
                pbPROFGE.Value = valor;

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(pp);
            hilo.Start();
        }

        private void pp()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                CambiarProgreso(string.Format("position{0}%", i), i);
                label1.Text = progressBar1.Value.ToString();
            };
        }
    }

    delegate void CambiarProgresoDelegado(string texto, int valor);
}
