
namespace Rechnerbeta
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.Multiplizieren = new System.Windows.Forms.Button();
            this.Dividieren = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.ergebnis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Prozent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(371, 189);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(39, 34);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(371, 229);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(39, 35);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Multiplizieren
            // 
            this.Multiplizieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplizieren.Location = new System.Drawing.Point(371, 270);
            this.Multiplizieren.Name = "Multiplizieren";
            this.Multiplizieren.Size = new System.Drawing.Size(39, 35);
            this.Multiplizieren.TabIndex = 2;
            this.Multiplizieren.Text = "*";
            this.Multiplizieren.UseVisualStyleBackColor = true;
            this.Multiplizieren.Click += new System.EventHandler(this.Multiplizieren_Click);
            // 
            // Dividieren
            // 
            this.Dividieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividieren.Location = new System.Drawing.Point(372, 311);
            this.Dividieren.Name = "Dividieren";
            this.Dividieren.Size = new System.Drawing.Size(38, 35);
            this.Dividieren.TabIndex = 3;
            this.Dividieren.Text = "/";
            this.Dividieren.UseVisualStyleBackColor = true;
            this.Dividieren.Click += new System.EventHandler(this.Dividieren_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(156, 155);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(142, 20);
            this.num1.TabIndex = 4;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(518, 155);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(185, 20);
            this.num2.TabIndex = 5;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // ergebnis
            // 
            this.ergebnis.Location = new System.Drawing.Point(279, 399);
            this.ergebnis.Name = "ergebnis";
            this.ergebnis.ReadOnly = true;
            this.ergebnis.Size = new System.Drawing.Size(226, 20);
            this.ergebnis.TabIndex = 6;
            this.ergebnis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ergebnis.TextChanged += new System.EventHandler(this.ergebnis_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Num 2";
            // 
            // Prozent
            // 
            this.Prozent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prozent.Location = new System.Drawing.Point(371, 352);
            this.Prozent.Name = "Prozent";
            this.Prozent.Size = new System.Drawing.Size(39, 35);
            this.Prozent.TabIndex = 9;
            this.Prozent.Text = "%";
            this.Prozent.UseVisualStyleBackColor = true;
            this.Prozent.Click += new System.EventHandler(this.Prozent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prozent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ergebnis);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.Dividieren);
            this.Controls.Add(this.Multiplizieren);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.Plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button Multiplizieren;
        private System.Windows.Forms.Button Dividieren;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox ergebnis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Prozent;
    }
}

