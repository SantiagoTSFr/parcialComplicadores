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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLatino
            // 
            this.txtLatino.Location = new System.Drawing.Point(69, 106);
            this.txtLatino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLatino.Multiline = true;
            this.txtLatino.Name = "txtLatino";
            this.txtLatino.Size = new System.Drawing.Size(344, 207);
            this.txtLatino.TabIndex = 0;
            this.txtLatino.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMorse
            // 
            this.txtMorse.Enabled = false;
            this.txtMorse.Location = new System.Drawing.Point(593, 106);
            this.txtMorse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMorse.Multiline = true;
            this.txtMorse.Name = "txtMorse";
            this.txtMorse.Size = new System.Drawing.Size(344, 207);
            this.txtMorse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Morse Code";
            // 
            // chkLatinoAMorse
            // 
            this.chkLatinoAMorse.AutoSize = true;
            this.chkLatinoAMorse.Location = new System.Drawing.Point(69, 49);
            this.chkLatinoAMorse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLatinoAMorse.Name = "chkLatinoAMorse";
            this.chkLatinoAMorse.Size = new System.Drawing.Size(111, 20);
            this.chkLatinoAMorse.TabIndex = 8;
            this.chkLatinoAMorse.Text = "latino a Morse";
            this.chkLatinoAMorse.UseVisualStyleBackColor = true;
            this.chkLatinoAMorse.CheckedChanged += new System.EventHandler(this.chkLatinoAMorse_CheckedChanged);
            // 
            // chkMorseALatino
            // 
            this.chkMorseALatino.AutoSize = true;
            this.chkMorseALatino.Location = new System.Drawing.Point(593, 49);
            this.chkMorseALatino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMorseALatino.Name = "chkMorseALatino";
            this.chkMorseALatino.Size = new System.Drawing.Size(115, 20);
            this.chkMorseALatino.TabIndex = 9;
            this.chkMorseALatino.Text = "Morse a Latino";
            this.chkMorseALatino.UseVisualStyleBackColor = true;
            this.chkMorseALatino.CheckedChanged += new System.EventHandler(this.chkMorseALatino_CheckedChanged);
            // 
            // btnConvAMorse
            // 
            this.btnConvAMorse.Location = new System.Drawing.Point(156, 384);
            this.btnConvAMorse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvAMorse.Name = "btnConvAMorse";
            this.btnConvAMorse.Size = new System.Drawing.Size(151, 38);
            this.btnConvAMorse.TabIndex = 10;
            this.btnConvAMorse.Text = "Convertir a Morse";
            this.btnConvAMorse.UseVisualStyleBackColor = true;
            this.btnConvAMorse.Click += new System.EventHandler(this.btnConvAMorse_Click);
            // 
            // btnConvertirALatino
            // 
            this.btnConvertirALatino.Location = new System.Drawing.Point(692, 384);
            this.btnConvertirALatino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvertirALatino.Name = "btnConvertirALatino";
            this.btnConvertirALatino.Size = new System.Drawing.Size(151, 38);
            this.btnConvertirALatino.TabIndex = 11;
            this.btnConvertirALatino.Text = "Convertir a Latino";
            this.btnConvertirALatino.UseVisualStyleBackColor = true;
            this.btnConvertirALatino.Click += new System.EventHandler(this.btnConvertirALatino_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archives TXT (\".txt\")|*.txt";
            // 
            // btnOpenArchive
            // 
            this.btnOpenArchive.Location = new System.Drawing.Point(426, 384);
            this.btnOpenArchive.Name = "btnOpenArchive";
            this.btnOpenArchive.Size = new System.Drawing.Size(151, 38);
            this.btnOpenArchive.TabIndex = 12;
            this.btnOpenArchive.Text = "Seleccionar archivo";
            this.btnOpenArchive.UseVisualStyleBackColor = true;
            this.btnOpenArchive.Click += new System.EventHandler(this.btnOpenArchive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOpenArchive);
            this.Controls.Add(this.btnConvertirALatino);
            this.Controls.Add(this.btnConvAMorse);
            this.Controls.Add(this.chkMorseALatino);
            this.Controls.Add(this.chkLatinoAMorse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMorse);
            this.Controls.Add(this.txtLatino);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenArchive;
    }
}

