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
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vSubrayado = new System.Windows.Forms.CheckBox();
            this.vCursiva = new System.Windows.Forms.CheckBox();
            this.vNegrita = new System.Windows.Forms.CheckBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lbox_Fuentes = new System.Windows.Forms.ListBox();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 185);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(15, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 69);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color del formulario";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(111, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 29);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Location = new System.Drawing.Point(65, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 29);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(17, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 29);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reducir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aumentar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Propiedades del FORM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 175);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.comboBox1.Location = new System.Drawing.Point(15, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(15, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 69);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color del texto";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(111, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 29);
            this.button6.TabIndex = 2;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumPurple;
            this.button7.Location = new System.Drawing.Point(65, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 29);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Green;
            this.button8.Location = new System.Drawing.Point(17, 26);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 29);
            this.button8.TabIndex = 0;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tamaño del texto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.vSubrayado);
            this.panel3.Controls.Add(this.vCursiva);
            this.panel3.Controls.Add(this.vNegrita);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Location = new System.Drawing.Point(12, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 95);
            this.panel3.TabIndex = 2;
            // 
            // vSubrayado
            // 
            this.vSubrayado.AutoSize = true;
            this.vSubrayado.Location = new System.Drawing.Point(401, 59);
            this.vSubrayado.Name = "vSubrayado";
            this.vSubrayado.Size = new System.Drawing.Size(102, 24);
            this.vSubrayado.TabIndex = 5;
            this.vSubrayado.Text = "Subrayado";
            this.vSubrayado.UseVisualStyleBackColor = true;
            this.vSubrayado.CheckedChanged += new System.EventHandler(this.vSubrayado_CheckedChanged);
            // 
            // vCursiva
            // 
            this.vCursiva.AutoSize = true;
            this.vCursiva.Location = new System.Drawing.Point(234, 59);
            this.vCursiva.Name = "vCursiva";
            this.vCursiva.Size = new System.Drawing.Size(78, 24);
            this.vCursiva.TabIndex = 4;
            this.vCursiva.Text = "Cursiva";
            this.vCursiva.UseVisualStyleBackColor = true;
            this.vCursiva.CheckedChanged += new System.EventHandler(this.vCursiva_CheckedChanged);
            // 
            // vNegrita
            // 
            this.vNegrita.AutoSize = true;
            this.vNegrita.Location = new System.Drawing.Point(49, 59);
            this.vNegrita.Name = "vNegrita";
            this.vNegrita.Size = new System.Drawing.Size(81, 24);
            this.vNegrita.TabIndex = 3;
            this.vNegrita.Text = "Negrita";
            this.vNegrita.UseVisualStyleBackColor = true;
            this.vNegrita.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(401, 15);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(119, 29);
            this.button11.TabIndex = 2;
            this.button11.Text = "Salir";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(212, 15);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(131, 29);
            this.button10.TabIndex = 1;
            this.button10.Text = "Mostrar texto";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(32, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 29);
            this.button9.TabIndex = 0;
            this.button9.Text = "Ocultar texto";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // lbox_Fuentes
            // 
            this.lbox_Fuentes.FormattingEnabled = true;
            this.lbox_Fuentes.ItemHeight = 20;
            this.lbox_Fuentes.Location = new System.Drawing.Point(586, 24);
            this.lbox_Fuentes.Name = "lbox_Fuentes";
            this.lbox_Fuentes.Size = new System.Drawing.Size(187, 484);
            this.lbox_Fuentes.TabIndex = 3;
            this.lbox_Fuentes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Location = new System.Drawing.Point(348, 292);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(52, 20);
            this.lbl_Texto.TabIndex = 4;
            this.lbl_Texto.Text = "TEXTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 531);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.lbox_Fuentes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private GroupBox groupBox2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panel3;
        private CheckBox vSubrayado;
        private CheckBox vCursiva;
        private CheckBox vNegrita;
        private Button button11;
        private Button button10;
        private Button button9;
        private ListBox lbox_Fuentes;
        private Label lbl_Texto;
        private ComboBox comboBox1;
    }
}