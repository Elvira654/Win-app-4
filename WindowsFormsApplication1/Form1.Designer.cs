namespace WindowsFormsApplication1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPuta = new System.Windows.Forms.Button();
            this.btnDijeljenje = new System.Windows.Forms.Button();
            this.btnJednako = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 60);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(46, 44);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(87, 60);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(46, 44);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPuta
            // 
            this.btnPuta.Location = new System.Drawing.Point(155, 60);
            this.btnPuta.Name = "btnPuta";
            this.btnPuta.Size = new System.Drawing.Size(46, 44);
            this.btnPuta.TabIndex = 3;
            this.btnPuta.Text = "*";
            this.btnPuta.UseVisualStyleBackColor = true;
            // 
            // btnDijeljenje
            // 
            this.btnDijeljenje.Location = new System.Drawing.Point(226, 60);
            this.btnDijeljenje.Name = "btnDijeljenje";
            this.btnDijeljenje.Size = new System.Drawing.Size(46, 44);
            this.btnDijeljenje.TabIndex = 4;
            this.btnDijeljenje.Text = "/";
            this.btnDijeljenje.UseVisualStyleBackColor = true;
            // 
            // btnJednako
            // 
            this.btnJednako.Location = new System.Drawing.Point(12, 119);
            this.btnJednako.Name = "btnJednako";
            this.btnJednako.Size = new System.Drawing.Size(260, 44);
            this.btnJednako.TabIndex = 5;
            this.btnJednako.Text = "=";
            this.btnJednako.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.btnJednako);
            this.Controls.Add(this.btnDijeljenje);
            this.Controls.Add(this.btnPuta);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPuta;
        private System.Windows.Forms.Button btnDijeljenje;
        private System.Windows.Forms.Button btnJednako;
    }
}

