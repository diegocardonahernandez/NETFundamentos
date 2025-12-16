namespace WinFormsApp1
{
    partial class Form13TiendaProductos
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
            lblProducto = new Label();
            txtNuevoProducto = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblTienda = new Label();
            listProductos = new ListBox();
            lblAlmacen = new Label();
            listAlmacen = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(105, 34);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // txtNuevoProducto
            // 
            txtNuevoProducto.Location = new Point(105, 65);
            txtNuevoProducto.Name = "txtNuevoProducto";
            txtNuevoProducto.Size = new Size(100, 23);
            txtNuevoProducto.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(105, 112);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(105, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(105, 205);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(100, 23);
            btnBorrarTodo.TabIndex = 4;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblTienda
            // 
            lblTienda.AutoSize = true;
            lblTienda.Location = new Point(285, 28);
            lblTienda.Name = "lblTienda";
            lblTienda.Size = new Size(42, 15);
            lblTienda.TabIndex = 5;
            lblTienda.Text = "Tienda";
            // 
            // listProductos
            // 
            listProductos.FormattingEnabled = true;
            listProductos.Location = new Point(285, 59);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(120, 169);
            listProductos.TabIndex = 6;
            // 
            // lblAlmacen
            // 
            lblAlmacen.AutoSize = true;
            lblAlmacen.Location = new Point(533, 28);
            lblAlmacen.Name = "lblAlmacen";
            lblAlmacen.Size = new Size(54, 15);
            lblAlmacen.TabIndex = 7;
            lblAlmacen.Text = "Almacen";
            // 
            // listAlmacen
            // 
            listAlmacen.FormattingEnabled = true;
            listAlmacen.Location = new Point(533, 59);
            listAlmacen.Name = "listAlmacen";
            listAlmacen.Size = new Size(120, 169);
            listAlmacen.TabIndex = 8;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(433, 68);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 9;
            btnSeleccion.Text = "Selección";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(433, 121);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 10;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(listAlmacen);
            Controls.Add(lblAlmacen);
            Controls.Add(listProductos);
            Controls.Add(lblTienda);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtNuevoProducto);
            Controls.Add(lblProducto);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private TextBox txtNuevoProducto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblTienda;
        private ListBox listProductos;
        private Label lblAlmacen;
        private ListBox listAlmacen;
        private Button btnSeleccion;
        private Button btnTodos;
    }
}