
namespace exercicio_windows_forms
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCantor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musicas";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(22, 40);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(57, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "labelNome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelCantor
            // 
            this.labelCantor.AutoSize = true;
            this.labelCantor.Location = new System.Drawing.Point(22, 77);
            this.labelCantor.Name = "labelCantor";
            this.labelCantor.Size = new System.Drawing.Size(60, 13);
            this.labelCantor.TabIndex = 2;
            this.labelCantor.Text = "labelCantor";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCantor);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCantor;
    }
}