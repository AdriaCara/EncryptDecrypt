using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class Form1 : Form
    {

        private string messageInput = "Result";
        private char[] code = { 'ú', 'q', '!', 'ì', 'w', '·', 'e', '$', '%', 'ë', 'r', '&', 't', 'à', '/', 'ù', 'y', '(', 'á', 'u', ')', 'ü', 'i', '=', 'è', 'o', '?', 'p', '*', 'é', 'a', 'ò', '0', 'í', 'ó', 's', '1', 'd', 'ï', '2', 'ö', 'f', '3', 'ä', 'g', '4', 'h', ' ', '5', 'j', '6', 'k', '7', 'l', '8', 'ñ', '9', 'z', '.', 'x', ':', 'c', ',', 'v', ';', 'b', '-', 'n', '<', 'm', '>' };
        private int key;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            result.Text = EncryptDecrypt.Encrypt(messageInput, key, code);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            result.Text = EncryptDecrypt.Decrypt(messageInput, key, code);

        }

        private void label3_Click(object sender, EventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {

            

        }

        private void label5_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            messageInput = textBox1.Text;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            key = (int) numericUpDown1.Value;

        }
    }
}
