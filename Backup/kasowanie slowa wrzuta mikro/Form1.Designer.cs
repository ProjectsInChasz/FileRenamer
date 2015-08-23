namespace kasowanie_slowa_wrzuta
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
            this.zmien = new System.Windows.Forms.Button();
            this.wybor = new System.Windows.Forms.FolderBrowserDialog();
            this.wyraz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zmien
            // 
            this.zmien.Location = new System.Drawing.Point(47, 50);
            this.zmien.Name = "zmien";
            this.zmien.Size = new System.Drawing.Size(151, 44);
            this.zmien.TabIndex = 3;
            this.zmien.Text = "zmien nazwe";
            this.zmien.UseVisualStyleBackColor = true;
            this.zmien.Click += new System.EventHandler(this.zmien_Click);
            // 
            // wyraz
            // 
            this.wyraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyraz.Location = new System.Drawing.Point(47, 12);
            this.wyraz.Name = "wyraz";
            this.wyraz.Size = new System.Drawing.Size(163, 26);
            this.wyraz.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 129);
            this.Controls.Add(this.wyraz);
            this.Controls.Add(this.zmien);
            this.Name = "Form1";
            this.Text = "usuwanie wrzuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zmien;
        private System.Windows.Forms.FolderBrowserDialog wybor;
        private System.Windows.Forms.TextBox wyraz;
    }
}

