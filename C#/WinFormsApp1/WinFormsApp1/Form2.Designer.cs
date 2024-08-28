namespace WinFormsApp1
{
    partial class Form2
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
            Label_ID = new Label();
            textBox_ID = new TextBox();
            label_Nome = new Label();
            textBox_Nome = new TextBox();
            button_Inserir = new Button();
            button_Apagar = new Button();
            SuspendLayout();
            // 
            // Label_ID
            // 
            Label_ID.AutoSize = true;
            Label_ID.Location = new Point(12, 47);
            Label_ID.Name = "Label_ID";
            Label_ID.Size = new Size(18, 15);
            Label_ID.TabIndex = 0;
            Label_ID.Text = "ID";
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(36, 44);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(100, 23);
            textBox_ID.TabIndex = 1;
            textBox_ID.TextChanged += textBox1_TextChanged;
            // 
            // label_Nome
            // 
            label_Nome.AutoSize = true;
            label_Nome.Location = new Point(157, 47);
            label_Nome.Name = "label_Nome";
            label_Nome.Size = new Size(40, 15);
            label_Nome.TabIndex = 2;
            label_Nome.Text = "Nome";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(203, 44);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(100, 23);
            textBox_Nome.TabIndex = 3;
            // 
            // button_Inserir
            // 
            button_Inserir.Location = new Point(331, 44);
            button_Inserir.Name = "button_Inserir";
            button_Inserir.Size = new Size(75, 23);
            button_Inserir.TabIndex = 4;
            button_Inserir.Text = "Inserir";
            button_Inserir.UseVisualStyleBackColor = true;
            button_Inserir.Click += button_Inserir_Click;
            // 
            // button_Apagar
            // 
            button_Apagar.Location = new Point(424, 43);
            button_Apagar.Name = "button_Apagar";
            button_Apagar.Size = new Size(75, 23);
            button_Apagar.TabIndex = 5;
            button_Apagar.Text = "Apagar";
            button_Apagar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Apagar);
            Controls.Add(button_Inserir);
            Controls.Add(textBox_Nome);
            Controls.Add(label_Nome);
            Controls.Add(textBox_ID);
            Controls.Add(Label_ID);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_ID;
        private TextBox textBox_ID;
        private Label label_Nome;
        private TextBox textBox_Nome;
        private Button button_Inserir;
        private Button button_Apagar;
    }
}