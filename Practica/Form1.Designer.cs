namespace Practica
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
            cmbClientes = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmpresa = new TextBox();
            txtContacto = new TextBox();
            txtCargo = new TextBox();
            txtCiudad = new TextBox();
            txtTelefono = new TextBox();
            lstPedidos = new ListBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtCodigoPedido = new TextBox();
            txtFechaEntrega = new TextBox();
            txtFormaEnvio = new TextBox();
            txtImporte = new TextBox();
            button1 = new Button();
            btnElimiarPedio = new Button();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(35, 57);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(121, 23);
            cmbClientes.TabIndex = 0;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 33);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 95);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Contacto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 151);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 218);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Ciudad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 280);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 6;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 33);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 7;
            label7.Text = "Pedidos";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(187, 51);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(100, 23);
            txtEmpresa.TabIndex = 8;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(187, 113);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 9;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(187, 169);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 10;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(187, 236);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(100, 23);
            txtCiudad.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(187, 298);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 12;
            // 
            // lstPedidos
            // 
            lstPedidos.FormattingEnabled = true;
            lstPedidos.Location = new Point(339, 57);
            lstPedidos.Name = "lstPedidos";
            lstPedidos.Size = new Size(143, 259);
            lstPedidos.TabIndex = 13;
            lstPedidos.SelectedIndexChanged += lstPedidos_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 33);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 14;
            label8.Text = "Codigo pedido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(517, 95);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 15;
            label9.Text = "Fecha entrega";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(517, 167);
            label10.Name = "label10";
            label10.Size = new Size(89, 15);
            label10.TabIndex = 16;
            label10.Text = "Forma de envio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(517, 236);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 17;
            label11.Text = "Importe";
            // 
            // txtCodigoPedido
            // 
            txtCodigoPedido.Location = new Point(515, 51);
            txtCodigoPedido.Name = "txtCodigoPedido";
            txtCodigoPedido.Size = new Size(100, 23);
            txtCodigoPedido.TabIndex = 18;
            // 
            // txtFechaEntrega
            // 
            txtFechaEntrega.Location = new Point(517, 113);
            txtFechaEntrega.Name = "txtFechaEntrega";
            txtFechaEntrega.Size = new Size(100, 23);
            txtFechaEntrega.TabIndex = 19;
            // 
            // txtFormaEnvio
            // 
            txtFormaEnvio.Location = new Point(517, 185);
            txtFormaEnvio.Name = "txtFormaEnvio";
            txtFormaEnvio.Size = new Size(100, 23);
            txtFormaEnvio.TabIndex = 20;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(517, 254);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(512, 308);
            button1.Name = "button1";
            button1.Size = new Size(105, 27);
            button1.TabIndex = 22;
            button1.Text = "Nuevo pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnElimiarPedio
            // 
            btnElimiarPedio.Location = new Point(512, 341);
            btnElimiarPedio.Name = "btnElimiarPedio";
            btnElimiarPedio.Size = new Size(105, 24);
            btnElimiarPedio.TabIndex = 23;
            btnElimiarPedio.Text = "Eliminar pedido";
            btnElimiarPedio.UseVisualStyleBackColor = true;
            btnElimiarPedio.Click += btnElimiarPedio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 417);
            Controls.Add(btnElimiarPedio);
            Controls.Add(button1);
            Controls.Add(txtImporte);
            Controls.Add(txtFormaEnvio);
            Controls.Add(txtFechaEntrega);
            Controls.Add(txtCodigoPedido);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lstPedidos);
            Controls.Add(txtTelefono);
            Controls.Add(txtCiudad);
            Controls.Add(txtCargo);
            Controls.Add(txtContacto);
            Controls.Add(txtEmpresa);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbClientes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEmpresa;
        private TextBox txtContacto;
        private TextBox txtCargo;
        private TextBox txtCiudad;
        private TextBox txtTelefono;
        private ListBox lstPedidos;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtCodigoPedido;
        private TextBox txtFechaEntrega;
        private TextBox txtFormaEnvio;
        private TextBox txtImporte;
        private Button button1;
        private Button btnElimiarPedio;
    }
}
