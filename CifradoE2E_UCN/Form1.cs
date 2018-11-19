using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifradoE2E_UCN
{
    public partial class Form1 : Form
    {
        private RSACryptoServiceProvider RSA;
                
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Al crear una instancia de RSACryptoServiceProvider se genera un par de claves publica/privada.
            RSA = new RSACryptoServiceProvider();
            // Save the public key information to an RSAParameters structure.  
            RSAParameters RSAKeyInfo = RSA.ExportParameters(true);
                        
            txtClavePublicaEsteExtremo.Text = representarBytesAString(RSAKeyInfo.Modulus);
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            byte[] ClavePrivadaOtroExtremo = representarStringABytes(txtClavePublicaOtroExtremo.Text);

            byte[] Exponent = { 1, 0, 1 };

            // Create a new instance of the RSACryptoServiceProvider class.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            // Establecer la clave punlica del otro extremo
            rsa.ImportParameters(new RSAParameters() {
                Modulus = ClavePrivadaOtroExtremo,
                Exponent = Exponent
            });

            byte[] mensajeCifrar = Encoding.Default.GetBytes(txtMensajeACifrar.Text);

            //Encriptar el mensaje
            byte[] mensajeCifrado = rsa.Encrypt(mensajeCifrar, false);

            // mostrar el mensaje cifrado en pantalla
            txtMensajeADecifrar.Text = representarBytesAString(mensajeCifrado);
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            byte[] datosEncriptados = representarStringABytes(txtMensajeADecifrar.Text);
            byte[] datosDesencriptados = RSA.Decrypt(datosEncriptados, false);
            txtMensajeACifrar.Text = Encoding.Default.GetString(datosDesencriptados);
        }


        private string representarBytesAString(byte[] datos)
        {
            StringBuilder datosEnString = new StringBuilder();
            foreach (var d in datos)
            {
                datosEnString.Append(((int)d).ToString() + ",");
            }
            return datosEnString.ToString();
        }

        private byte[] representarStringABytes(string datos)
        {
            string[] numericos = datos.Split(new char[] { ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] datosByte = new byte[numericos.Length];
            int i = 0;
            foreach (var n in numericos)
            {
                datosByte[i] = (byte)int.Parse(n);
                i++;
            }
            return datosByte;
        }

    }
}
