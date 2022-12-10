
namespace WinFormsApp
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
            this.btn_Jsonkurgu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Jsonkurgu
            // 
            this.btn_Jsonkurgu.Location = new System.Drawing.Point(211, 51);
            this.btn_Jsonkurgu.Name = "btn_Jsonkurgu";
            this.btn_Jsonkurgu.Size = new System.Drawing.Size(175, 23);
            this.btn_Jsonkurgu.TabIndex = 0;
            this.btn_Jsonkurgu.Text = "Json Data Çek ve Kaydet";
            this.btn_Jsonkurgu.UseVisualStyleBackColor = true;
            this.btn_Jsonkurgu.Click += new System.EventHandler(this.btn_Jsonkurgu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Jsonkurgu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Jsonkurgu;
    }
}

