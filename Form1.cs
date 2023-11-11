using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7_visual_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonImprime_Click(object sender, EventArgs e)
        //
        {
            int rangoinferio, rangosuperior, suma = 0;
            rangoinferio = int.Parse(textBox1.Text);    
            rangosuperior = int.Parse(textBox2.Text);
            for (int i = rangoinferio; i <= rangosuperior; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
            }
            textBox3.Text = suma.ToString();
       
            
            
        }
    }
}
