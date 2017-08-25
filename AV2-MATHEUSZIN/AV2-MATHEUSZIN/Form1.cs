using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV2_MATHEUSZIN
{
    public partial class Form1 : Form
    {

        public int Ataque;
        public int Defesa;

        public int dano;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ataque = 0;
            int.TryParse(textBox1.Text, out Ataque);

            Defesa = 0;
            int.TryParse(textBox2.Text, out Defesa);

            if (comboBox1.Text == "Ar" && comboBox2.Text == "Fogo")
            {
                Ataque *= 2;
            }
            if (comboBox1.Text == "Ar" && comboBox2.Text == "Agua")
            {
                Defesa *= 2;
            }
            if (comboBox1.Text == "Fogo" && comboBox2.Text == "Ar")
            {
                Ataque *= 2;
            }
            if (comboBox1.Text == "Agua" && comboBox2.Text == "Fogo")
            {
                Ataque *= 2;
            }
            if (comboBox1.Text == "Agua" && comboBox2.Text == "Ar")
            {
                Defesa *= 2;
            }

            dano = Ataque - Defesa;
             
            if(dano < 0)
            {
                dano = 0;
            }
            label1.Text = dano.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
