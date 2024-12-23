namespace sayitahmin
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
            this.tahminhak_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tahmin_txt = new System.Windows.Forms.TextBox();
            this.tahminet_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tahminhak_lbl
            // 
            this.tahminhak_lbl.AutoSize = true;
            this.tahminhak_lbl.Location = new System.Drawing.Point(368, 90);
            this.tahminhak_lbl.Name = "tahminhak_lbl";
            this.tahminhak_lbl.Size = new System.Drawing.Size(21, 16);
            this.tahminhak_lbl.TabIndex = 0;
            this.tahminhak_lbl.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "tahmin hakkı:";
            // 
            // tahmin_txt
            // 
            this.tahmin_txt.Location = new System.Drawing.Point(91, 84);
            this.tahmin_txt.Name = "tahmin_txt";
            this.tahmin_txt.Size = new System.Drawing.Size(100, 22);
            this.tahmin_txt.TabIndex = 3;
            // 
            // tahminet_btn
            // 
            this.tahminet_btn.Location = new System.Drawing.Point(91, 178);
            this.tahminet_btn.Name = "tahminet_btn";
            this.tahminet_btn.Size = new System.Drawing.Size(75, 23);
            this.tahminet_btn.TabIndex = 4;
            this.tahminet_btn.Text = "Tahmin Et";
            this.tahminet_btn.UseVisualStyleBackColor = true;
            this.tahminet_btn.Click += new System.EventHandler(this.tahminet_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tahminet_btn);
            this.Controls.Add(this.tahmin_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tahminhak_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tahminhak_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tahmin_txt;
        private System.Windows.Forms.Button tahminet_btn;
    }
}

