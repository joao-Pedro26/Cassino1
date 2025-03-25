namespace CacaNiquel
{
    partial class CacaNiquel
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
            this.lblNiquel1 = new System.Windows.Forms.Label();
            this.lblNiquel2 = new System.Windows.Forms.Label();
            this.lblNiquel3 = new System.Windows.Forms.Label();
            this.btnGirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNiquel1
            // 
            this.lblNiquel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel1.Location = new System.Drawing.Point(32, 71);
            this.lblNiquel1.Name = "lblNiquel1";
            this.lblNiquel1.Size = new System.Drawing.Size(89, 85);
            this.lblNiquel1.TabIndex = 0;
            this.lblNiquel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel2
            // 
            this.lblNiquel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel2.Location = new System.Drawing.Point(140, 71);
            this.lblNiquel2.Name = "lblNiquel2";
            this.lblNiquel2.Size = new System.Drawing.Size(90, 85);
            this.lblNiquel2.TabIndex = 1;
            this.lblNiquel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel3
            // 
            this.lblNiquel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNiquel3.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel3.Location = new System.Drawing.Point(248, 71);
            this.lblNiquel3.Name = "lblNiquel3";
            this.lblNiquel3.Size = new System.Drawing.Size(90, 85);
            this.lblNiquel3.TabIndex = 2;
            this.lblNiquel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGirar
            // 
            this.btnGirar.Font = new System.Drawing.Font("Dutch801 XBd BT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirar.Location = new System.Drawing.Point(130, 274);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(113, 48);
            this.btnGirar.TabIndex = 3;
            this.btnGirar.Text = "&Girar";
            this.btnGirar.UseVisualStyleBackColor = true;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // CacaNiquel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.btnGirar);
            this.Controls.Add(this.lblNiquel3);
            this.Controls.Add(this.lblNiquel2);
            this.Controls.Add(this.lblNiquel1);
            this.Name = "CacaNiquel";
            this.Text = "Caça Niquel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNiquel1;
        private System.Windows.Forms.Label lblNiquel2;
        private System.Windows.Forms.Label lblNiquel3;
        private System.Windows.Forms.Button btnGirar;
    }
}

