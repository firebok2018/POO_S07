﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Encriptacion
{
    public partial class Form2 : Form
    {
        DESCryptoServiceProvider servicio = new DESCryptoServiceProvider();
        byte[] key = new byte[] { 70, 71, 72, 73, 74, 75, 76, 77 };
        byte[] iv = new byte[] { 60, 61, 62, 63, 64, 65, 66, 67 };
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEncriptat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Archivo Cifrado|*.cyt";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                MemoryStream ms = new MemoryStream();
                StreamWriter escritor = new StreamWriter(ms);
                escritor.Write(txtS.Text);
                escritor.Flush();

                FileStream file = new FileStream(sv.FileName, FileMode.Create);
                CryptoStream crypto = new CryptoStream(file,servicio.CreateEncryptor(key,iv), CryptoStreamMode.Write);
                crypto.Write(ms.ToArray(), 0, ms.ToArray().Length);
                crypto.Close();
                file.Close();
            }

        }

        private void brnDesencriptar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo de Encriptacion|*.cyt";
            if (op.ShowDialog()==DialogResult.OK)
            {
                FileStream file = new FileStream(op.FileName, FileMode.Open);
                CryptoStream decryt = new CryptoStream(file, servicio.CreateDecryptor(key, iv), CryptoStreamMode.Read);
                byte[] datos = new byte[4096];
                decryt.Read(datos, 0, datos.Length);

                MemoryStream ms = new MemoryStream();
                ms.Write(datos, 0, datos.Length);
                ms.Position = 0;
                txtS.Text = new StreamReader(ms).ReadToEnd();

            }
        }
    }
}
