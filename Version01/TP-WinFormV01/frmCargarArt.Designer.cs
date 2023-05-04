namespace TP_WinFormV01
{
    partial class frmCargarArt
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
            this.lblCod = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIDMarca = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarArt = new System.Windows.Forms.Button();
            this.IDMarca = new System.Windows.Forms.TextBox();
            this.IDCategoria = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(70, 140);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(70, 20);
            this.lblCod.TabIndex = 3;
            this.lblCod.Text = "Codigo:";
            this.lblCod.Click += new System.EventHandler(this.lblCod_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(70, 195);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 20);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(397, 142);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIDMarca
            // 
            this.lblIDMarca.AutoSize = true;
            this.lblIDMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMarca.Location = new System.Drawing.Point(397, 199);
            this.lblIDMarca.Name = "lblIDMarca";
            this.lblIDMarca.Size = new System.Drawing.Size(87, 20);
            this.lblIDMarca.TabIndex = 6;
            this.lblIDMarca.Text = "ID Marca:";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCategoria.Location = new System.Drawing.Point(70, 253);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(116, 20);
            this.lblIDCategoria.TabIndex = 7;
            this.lblIDCategoria.Text = "ID Categoria:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(397, 253);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 20);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(188, 144);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(142, 20);
            this.Codigo.TabIndex = 9;
            this.Codigo.TextChanged += new System.EventHandler(this.Codigo_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(494, 142);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(142, 20);
            this.Nombre.TabIndex = 9;
            this.Nombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(188, 197);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(142, 20);
            this.Descripcion.TabIndex = 9;
            this.Descripcion.TextChanged += new System.EventHandler(this.Descripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "AGREGAR NUEVO ARTICULO";
            // 
            // btnCargarArt
            // 
            this.btnCargarArt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargarArt.Location = new System.Drawing.Point(494, 347);
            this.btnCargarArt.Name = "btnCargarArt";
            this.btnCargarArt.Size = new System.Drawing.Size(157, 40);
            this.btnCargarArt.TabIndex = 13;
            this.btnCargarArt.Text = "Cargar Articulo";
            this.btnCargarArt.UseVisualStyleBackColor = false;
            this.btnCargarArt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IDMarca
            // 
            this.IDMarca.Location = new System.Drawing.Point(494, 199);
            this.IDMarca.Name = "IDMarca";
            this.IDMarca.Size = new System.Drawing.Size(142, 20);
            this.IDMarca.TabIndex = 14;
            this.IDMarca.TextChanged += new System.EventHandler(this.IDMarca_TextChanged);
            this.IDMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDMarca_KeyPress);
            // 
            // IDCategoria
            // 
            this.IDCategoria.Location = new System.Drawing.Point(188, 255);
            this.IDCategoria.Name = "IDCategoria";
            this.IDCategoria.Size = new System.Drawing.Size(142, 20);
            this.IDCategoria.TabIndex = 15;
            this.IDCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDCategoria_KeyPress);
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(494, 257);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(142, 20);
            this.Precio.TabIndex = 16;
            this.Precio.TextChanged += new System.EventHandler(this.Precio_TextChanged);
            this.Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_KeyPress);
            // 
            // frmCargarArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 465);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.IDCategoria);
            this.Controls.Add(this.IDMarca);
            this.Controls.Add(this.btnCargarArt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblIDCategoria);
            this.Controls.Add(this.lblIDMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCod);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmCargarArt";
            this.Tag = "";
            this.Text = "frmCargarArt";
            this.Load += new System.EventHandler(this.frmCargarArt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIDMarca;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarArt;
        private System.Windows.Forms.TextBox IDMarca;
        private System.Windows.Forms.TextBox IDCategoria;
        private System.Windows.Forms.TextBox Precio;
    }
}