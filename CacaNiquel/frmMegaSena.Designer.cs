namespace CacaNiquel
{
    partial class frmMegaSena
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
            this.btnSortearNumeros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdeCartoes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 58);
            this.label1.TabIndex = 0;
            // 
            // btnSortearNumeros
            // 
            this.btnSortearNumeros.Location = new System.Drawing.Point(119, 373);
            this.btnSortearNumeros.Name = "btnSortearNumeros";
            this.btnSortearNumeros.Size = new System.Drawing.Size(115, 48);
            this.btnSortearNumeros.TabIndex = 1;
            this.btnSortearNumeros.Text = "Sortear";
            this.btnSortearNumeros.UseVisualStyleBackColor = true;
            this.btnSortearNumeros.Click += new System.EventHandler(this.btnSortearNumeros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qtde. de Cartões: ";
            // 
            // txtQtdeCartoes
            // 
            this.txtQtdeCartoes.Location = new System.Drawing.Point(118, 6);
            this.txtQtdeCartoes.Name = "txtQtdeCartoes";
            this.txtQtdeCartoes.Size = new System.Drawing.Size(100, 20);
            this.txtQtdeCartoes.TabIndex = 3;
            // 
            // frmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.txtQtdeCartoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSortearNumeros);
            this.Controls.Add(this.label1);
            this.Name = "frmMegaSena";
            this.Text = "Mega Sena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortearNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdeCartoes;
    }
}