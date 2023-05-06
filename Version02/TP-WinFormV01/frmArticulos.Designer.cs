
namespace TP_WinFormV01
{
    partial class frmArticulos
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
            this.dgvBuscarArt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArticulos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFisico = new System.Windows.Forms.Button();
            this.btnListaTdo = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.CbCriterio = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PbxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarArt
            // 
            this.dgvBuscarArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarArt.Location = new System.Drawing.Point(-10, 123);
            this.dgvBuscarArt.Name = "dgvBuscarArt";
            this.dgvBuscarArt.Size = new System.Drawing.Size(762, 407);
            this.dgvBuscarArt.TabIndex = 0;
            this.dgvBuscarArt.SelectionChanged += new System.EventHandler(this.dgvBuscarArt_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(265, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por codigo";
            // 
            // txtArticulos
            // 
            this.txtArticulos.Location = new System.Drawing.Point(270, 69);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(181, 20);
            this.txtArticulos.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(268, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 1);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(516, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listar todo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(517, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 1);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(704, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Eliminar Articulo Seleccionado";
            // 
            // btnFisico
            // 
            this.btnFisico.BackgroundImage = global::TP_WinFormV01.Properties.Resources.CarpetaEliminada;
            this.btnFisico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFisico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFisico.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFisico.Location = new System.Drawing.Point(833, 43);
            this.btnFisico.Name = "btnFisico";
            this.btnFisico.Size = new System.Drawing.Size(42, 38);
            this.btnFisico.TabIndex = 12;
            this.btnFisico.UseVisualStyleBackColor = true;
            this.btnFisico.Click += new System.EventHandler(this.btnFisico_Click);
            // 
            // btnListaTdo
            // 
            this.btnListaTdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnListaTdo.BackgroundImage = global::TP_WinFormV01.Properties.Resources.evaluacion;
            this.btnListaTdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListaTdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaTdo.FlatAppearance.BorderSize = 0;
            this.btnListaTdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaTdo.Location = new System.Drawing.Point(652, 10);
            this.btnListaTdo.Name = "btnListaTdo";
            this.btnListaTdo.Size = new System.Drawing.Size(46, 39);
            this.btnListaTdo.TabIndex = 9;
            this.btnListaTdo.UseVisualStyleBackColor = false;
            this.btnListaTdo.Click += new System.EventHandler(this.btnListaTdo_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnFiltro.BackgroundImage = global::TP_WinFormV01.Properties.Resources.lupa;
            this.btnFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Location = new System.Drawing.Point(457, 49);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(46, 39);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP_WinFormV01.Properties.Resources.hojeada;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(127, 31);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 14;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // CbCriterio
            // 
            this.CbCriterio.FormattingEnabled = true;
            this.CbCriterio.Location = new System.Drawing.Point(127, 96);
            this.CbCriterio.Name = "CbCriterio";
            this.CbCriterio.Size = new System.Drawing.Size(121, 21);
            this.CbCriterio.TabIndex = 15;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnModificar.BackgroundImage = global::TP_WinFormV01.Properties.Resources.evaluacion;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(652, 78);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(46, 39);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(139, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Buscar en";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(151, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Criterio";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(137, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 1);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(138, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 1);
            this.panel3.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(517, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 1);
            this.panel5.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(516, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Modificar";
            // 
            // PbxImagen
            // 
            this.PbxImagen.Location = new System.Drawing.Point(753, 123);
            this.PbxImagen.Name = "PbxImagen";
            this.PbxImagen.Size = new System.Drawing.Size(444, 407);
            this.PbxImagen.TabIndex = 24;
            this.PbxImagen.TabStop = false;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1209, 545);
            this.Controls.Add(this.PbxImagen);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.CbCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFisico);
            this.Controls.Add(this.btnListaTdo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtArticulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvBuscarArt);
            this.MinimumSize = new System.Drawing.Size(1041, 581);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarArt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArticulos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnListaTdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFisico;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.ComboBox CbCriterio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PbxImagen;
    }
}