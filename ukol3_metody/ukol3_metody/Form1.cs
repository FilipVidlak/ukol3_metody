using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol3_metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void JeAlfaNum()
        {
            int countnotalfanum = 0;
            foreach (char lol in textBox1.Text)
            {
                if (Char.IsLetterOrDigit(lol)) {
                    label1.Text = "Ano, je!";
                }
                else { label1.Text = "Ne, není!"; countnotalfanum++; }
            }
            MessageBox.Show("Obsahuje " + countnotalfanum + " jiných znaků", "NOT ALFANUM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MalaPismena()
        {
            int lowerchar = 0;
            foreach (char lol in textBox1.Text) {
                if (Char.IsLower(lol)) { lowerchar++; }
            }
            MessageBox.Show("Obsahuje " + lowerchar + " malých písmen", "LOWERCASE LETTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void VelkaPismena()
        {
            int upperchar = 0;
            foreach (char lol in textBox1.Text) {
                if (Char.IsUpper(lol)) { upperchar++; }
            }
            MessageBox.Show("Obsahuje " + upperchar + " velkých písmen", "UPPERCASE LETTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            private void button1_Click(object sender, EventArgs e)
            {
             JeAlfaNum();
             MalaPismena();
             VelkaPismena();
            textBox1.Clear();
            label1.Text = "---";
            }
    }
}
