namespace Pim_testarea
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_sqlconnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sqlconnection
            // 
            this.button_sqlconnection.Location = new System.Drawing.Point(12, 12);
            this.button_sqlconnection.Name = "button_sqlconnection";
            this.button_sqlconnection.Size = new System.Drawing.Size(153, 23);
            this.button_sqlconnection.TabIndex = 0;
            this.button_sqlconnection.Text = "Conectar SQL";
            this.button_sqlconnection.UseVisualStyleBackColor = true;
            this.button_sqlconnection.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_sqlconnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_sqlconnection;
    }
}

