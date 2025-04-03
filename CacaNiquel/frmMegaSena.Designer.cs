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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.btnSortearNumeros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdeCartoes = new System.Windows.Forms.TextBox();
            this.lstCartoes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeros.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.Location = new System.Drawing.Point(22, 64);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(308, 58);
            this.lblNumeros.TabIndex = 0;
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
            // lstCartoes
            // 
            this.lstCartoes.FormattingEnabled = true;
            this.lstCartoes.Location = new System.Drawing.Point(22, 153);
            this.lstCartoes.Name = "lstCartoes";
            this.lstCartoes.Size = new System.Drawing.Size(308, 186);
            this.lstCartoes.TabIndex = 4;
            // 
            // frmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.lstCartoes);
            this.Controls.Add(this.txtQtdeCartoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSortearNumeros);
            this.Controls.Add(this.lblNumeros);
            this.Name = "frmMegaSena";
            this.Text = "Mega Sena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Button btnSortearNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdeCartoes;
        private System.Windows.Forms.ListBox lstCartoes;
    }
}