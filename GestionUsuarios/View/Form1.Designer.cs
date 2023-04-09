namespace GestionUsuarios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClientes = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(173, 98);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(125, 58);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Gestionar Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 47);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 1;
            label1.Text = "Gestión de clientes en el sistema:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 234);
            Controls.Add(label1);
            Controls.Add(btnClientes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Label label1;
    }
}