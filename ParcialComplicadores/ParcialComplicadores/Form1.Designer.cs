namespace ParcialComplicadores
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLatino = new System.Windows.Forms.TextBox();
            this.txtMorse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkLatinoAMorse = new System.Windows.Forms.CheckBox();
            this.chkMorseALatino = new System.Windows.Forms.CheckBox();
            this.btnConvAMorse = new System.Windows.Forms.Button();
            this.btnConvertirALatino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLatino
            // 
            this.txtLatino.Location = new System.Drawing.Point(52, 86);
            this.txtLatino.Multiline = true;
            this.txtLatino.Name = "txtLatino";
            this.txtLatino.Size = new System.Drawing.Size(259, 169);
            this.txtLatino.TabIndex = 0;
            this.txtLatino.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMorse
            // 
            this.txtMorse.Enabled = false;
            this.txtMorse.Location = new System.Drawing.Point(445, 86);
            this.txtMorse.Multiline = true;
            this.txtMorse.Name = "txtMorse";
            this.txtMorse.Size = new System.Drawing.Size(259, 169);
            this.txtMorse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Morse Code";
            // 
            // chkLatinoAMorse
            // 
            this.chkLatinoAMorse.AutoSize = true;
            this.chkLatinoAMorse.Location = new System.Drawing.Point(52, 40);
            this.chkLatinoAMorse.Name = "chkLatinoAMorse";
            this.chkLatinoAMorse.Size = new System.Drawing.Size(92, 17);
            this.chkLatinoAMorse.TabIndex = 8;
            this.chkLatinoAMorse.Text = "latino a Morse";
            this.chkLatinoAMorse.UseVisualStyleBackColor = true;
            this.chkLatinoAMorse.CheckedChanged += new System.EventHandler(this.chkLatinoAMorse_CheckedChanged);
            // 
            // chkMorseALatino
            // 
            this.chkMorseALatino.AutoSize = true;
            this.chkMorseALatino.Location = new System.Drawing.Point(445, 40);
            this.chkMorseALatino.Name = "chkMorseALatino";
            this.chkMorseALatino.Size = new System.Drawing.Size(96, 17);
            this.chkMorseALatino.TabIndex = 9;
            this.chkMorseALatino.Text = "Morse a Latino";
            this.chkMorseALatino.UseVisualStyleBackColor = true;
            this.chkMorseALatino.CheckedChanged += new System.EventHandler(this.chkMorseALatino_CheckedChanged);
            // 
            // btnConvAMorse
            // 
            this.btnConvAMorse.Location = new System.Drawing.Point(117, 312);
            this.btnConvAMorse.Name = "btnConvAMorse";
            this.btnConvAMorse.Size = new System.Drawing.Size(113, 31);
            this.btnConvAMorse.TabIndex = 10;
            this.btnConvAMorse.Text = "Convertir a Morse";
            this.btnConvAMorse.UseVisualStyleBackColor = true;
            this.btnConvAMorse.Click += new System.EventHandler(this.btnConvAMorse_Click);
            // 
            // btnConvertirALatino
            // 
            this.btnConvertirALatino.Location = new System.Drawing.Point(519, 312);
            this.btnConvertirALatino.Name = "btnConvertirALatino";
            this.btnConvertirALatino.Size = new System.Drawing.Size(113, 31);
            this.btnConvertirALatino.TabIndex = 11;
            this.btnConvertirALatino.Text = "Convertir a Morse";
            this.btnConvertirALatino.UseVisualStyleBackColor = true;
            this.btnConvertirALatino.Click += new System.EventHandler(this.btnConvertirALatino_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertirALatino);
            this.Controls.Add(this.btnConvAMorse);
            this.Controls.Add(this.chkMorseALatino);
            this.Controls.Add(this.chkLatinoAMorse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMorse);
            this.Controls.Add(this.txtLatino);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLatino;
        private System.Windows.Forms.TextBox txtMorse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkLatinoAMorse;
        private System.Windows.Forms.CheckBox chkMorseALatino;
        private System.Windows.Forms.Button btnConvAMorse;
        private System.Windows.Forms.Button btnConvertirALatino;
    }
}

