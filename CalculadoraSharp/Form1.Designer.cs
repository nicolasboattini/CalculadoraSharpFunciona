
namespace CalculadoraSharp
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
            this.TxtNumeros = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Divi = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNumeros
            // 
            this.TxtNumeros.Location = new System.Drawing.Point(85, 51);
            this.TxtNumeros.Name = "TxtNumeros";
            this.TxtNumeros.Size = new System.Drawing.Size(643, 23);
            this.TxtNumeros.TabIndex = 0;
            this.TxtNumeros.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(449, 123);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(49, 39);
            this.Suma.TabIndex = 4;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(196, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 39);
            this.button6.TabIndex = 6;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(319, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 39);
            this.button7.TabIndex = 7;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(449, 201);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(49, 39);
            this.Resta.TabIndex = 8;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(85, 277);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 39);
            this.button9.TabIndex = 9;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(196, 277);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 39);
            this.button10.TabIndex = 10;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(319, 277);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 39);
            this.button11.TabIndex = 11;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Divi
            // 
            this.Divi.Location = new System.Drawing.Point(449, 277);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(49, 39);
            this.Divi.TabIndex = 12;
            this.Divi.Text = "/";
            this.Divi.UseVisualStyleBackColor = true;
            this.Divi.Click += new System.EventHandler(this.Divi_Click);
            // 
            // Cero
            // 
            this.Cero.Location = new System.Drawing.Point(85, 349);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(49, 39);
            this.Cero.TabIndex = 13;
            this.Cero.Text = "C";
            this.Cero.UseVisualStyleBackColor = true;
            this.Cero.Click += new System.EventHandler(this.Cero_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(196, 349);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(49, 39);
            this.button14.TabIndex = 14;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Igual
            // 
            this.Igual.Location = new System.Drawing.Point(319, 349);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(49, 39);
            this.Igual.TabIndex = 15;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Multi
            // 
            this.Multi.Location = new System.Drawing.Point(449, 349);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(49, 39);
            this.Multi.TabIndex = 16;
            this.Multi.Text = "*";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(319, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Cero);
            this.Controls.Add(this.Divi);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.TxtNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumeros;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Divi;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

