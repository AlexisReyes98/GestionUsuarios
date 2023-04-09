namespace GestionUsuarios
{
    partial class GestionClientes
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
            listClientes = new ListBox();
            label1 = new Label();
            textNombre = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            textApellido = new TextBox();
            textTelefono = new TextBox();
            textCard = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label_ID = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(12, 12);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(259, 259);
            listClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 57);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(384, 54);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(160, 23);
            textNombre.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(469, 222);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(196, 280);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(384, 98);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(160, 23);
            textApellido.TabIndex = 5;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(384, 140);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(160, 23);
            textTelefono.TabIndex = 6;
            // 
            // textCard
            // 
            textCard.Location = new Point(384, 184);
            textCard.Name = "textCard";
            textCard.Size = new Size(160, 23);
            textCard.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 101);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 143);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 187);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 10;
            label4.Text = "Credit Card";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 19);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 12;
            label5.Text = "ID:";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(384, 19);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(0, 15);
            label_ID.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(384, 222);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Limpiar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(104, 280);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 315);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label_ID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textCard);
            Controls.Add(textTelefono);
            Controls.Add(textApellido);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(textNombre);
            Controls.Add(label1);
            Controls.Add(listClientes);
            Name = "GestionClientes";
            Text = "GestionClientes";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Label label1;
        private TextBox textNombre;
        private Button btnGuardar;
        private Button btnEliminar;
        private TextBox textApellido;
        private TextBox textTelefono;
        private TextBox textCard;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label_ID;
        private Button btnAgregar;
        private Button btnEditar;
    }
}