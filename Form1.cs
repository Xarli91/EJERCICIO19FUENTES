using System.Drawing.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO19FUENTES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InstalledFontCollection fuentesInstaladas = new InstalledFontCollection();
            FontFamily[] fuentes = fuentesInstaladas.Families;
            lbl_Texto.Font = new Font(fuentes[lbox_Fuentes.SelectedIndex].Name, lbl_Texto.Font.Size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fuentesInstaladas = new InstalledFontCollection();
            FontFamily[] fuentes = fuentesInstaladas.Families;
            foreach (FontFamily x in fuentes)
            {
                lbox_Fuentes.Items.Add(x.Name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumPurple;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width + 5, this.Size.Height + 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width - 5, this.Size.Height - 5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.MediumPurple;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.Red;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Texto.Font = new Font(lbl_Texto.Font.Name, Int32.Parse(comboBox1.SelectedItem.ToString()));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (vNegrita.Checked)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style | FontStyle.Bold);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Bold);
            }
        }

        private void vCursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (vCursiva.Checked)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style | FontStyle.Italic);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Italic);
            }
        }

        private void vSubrayado_CheckedChanged(object sender, EventArgs e)
        {
            if (vSubrayado.Checked)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style | FontStyle.Underline);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, lbl_Texto.Font.Style ^ FontStyle.Underline);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lbl_Texto.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lbl_Texto.Visible = true;
        }
    }
}