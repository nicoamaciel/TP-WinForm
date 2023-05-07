namespace TP_WinFormV01
{
    partial class frmModificador
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
            this.CbxArticulos = new System.Windows.Forms.ComboBox();
            this.DgvArticulo = new System.Windows.Forms.DataGridView();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxArticulos
            // 
            this.CbxArticulos.BackColor = System.Drawing.SystemColors.Window;
            this.CbxArticulos.FormattingEnabled = true;
            this.CbxArticulos.Location = new System.Drawing.Point(147, 10);
            this.CbxArticulos.Name = "CbxArticulos";
            this.CbxArticulos.Size = new System.Drawing.Size(121, 21);
            this.CbxArticulos.TabIndex = 0;
            // 
            // DgvArticulo
            // 
            this.DgvArticulo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvArticulo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvArticulo.Location = new System.Drawing.Point(3, 65);
            this.DgvArticulo.Name = "DgvArticulo";
            this.DgvArticulo.Size = new System.Drawing.Size(743, 62);
            this.DgvArticulo.TabIndex = 1;
            this.DgvArticulo.SelectionChanged += new System.EventHandler(this.DgvArticulo_SelectionChanged);
            // 
            // PbxImagen
            // 
            this.PbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxImagen.Location = new System.Drawing.Point(3, 126);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(743, 328);
            this.PbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImagen.TabIndex = 2;
            this.PbxImagen.TabStop = false;
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackgroundImage = global::TP_WinFormV01.Properties.Resources.verde;
            this.btnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(12, 10);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(119, 49);
            this.btnArticulos.TabIndex = 5;
            this.btnArticulos.Text = "Mostrar Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackgroundImage = global::TP_WinFormV01.Properties.Resources.verde;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(295, 10);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(119, 49);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackgroundImage = global::TP_WinFormV01.Properties.Resources.verde;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(450, 10);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(119, 49);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::TP_WinFormV01.Properties.Resources.verde;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(595, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 49);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmModificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.DgvArticulo);
            this.Controls.Add(this.CbxArticulos);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmModificador";
            this.Text = "frmModificador";
            this.Load += new System.EventHandler(this.frmModificador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxArticulos;
        private System.Windows.Forms.DataGridView DgvArticulo;
        private System.Windows.Forms.PictureBox PbxImagen;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnSalir;
    }
}