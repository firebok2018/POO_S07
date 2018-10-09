using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Encriptacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncritpar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            StreamWriter code = new StreamWriter(ms);
            code.Write(txtTExt.Text);
            code.Flush();

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            byte[] datos = sha.ComputeHash(ms.ToArray());
            txtEncript.Text = "";
            foreach(byte bt in datos)
            {
                txtEncript.Text += bt.ToString();
            }
        }
    }
}
