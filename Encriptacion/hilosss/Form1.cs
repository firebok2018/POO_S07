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

namespace hilosss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delegado = new ThreadStart(Mostrar);
            Thread hilo = new Thread(delegado);
            hilo.Start();
        }

        private void Mostrar()
        {
            MessageBox.Show("Bienvenido");
        }
    }
}
