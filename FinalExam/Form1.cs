using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace FinalExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog op = new OpenFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            op.InitialDirectory = "";
            if(op.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = op.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           using (StreamWriter sw = new StreamWriter(op.FileName))
           {
               sw.WriteLine(Encrypt.EncryptString(op.FileName,op.FileName));
           }      
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
           
        }
    }
}
