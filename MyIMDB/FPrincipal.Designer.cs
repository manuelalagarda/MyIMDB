namespace MyIMDB
{
    partial class FPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdNuevaPelicula = new System.Windows.Forms.Button();
            this.cmdEditar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmdNuevoDirector = new System.Windows.Forms.Button();
            this.cmdNuevoActor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(50, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(636, 23);
            this.txtFiltro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encuentra peliculas, series y actores";
            // 
            // cmbTipoFiltro
            // 
            this.cmbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoFiltro.FormattingEnabled = true;
            this.cmbTipoFiltro.Items.AddRange(new object[] {
            "Todos",
            "Peliculas",
            "Series",
            "Actores"});
            this.cmbTipoFiltro.Location = new System.Drawing.Point(692, 32);
            this.cmbTipoFiltro.Name = "cmbTipoFiltro";
            this.cmbTipoFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoFiltro.TabIndex = 2;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(19)))));
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(819, 31);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(111, 26);
            this.cmdBuscar.TabIndex = 3;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdNuevaPelicula
            // 
            this.cmdNuevaPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(19)))));
            this.cmdNuevaPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevaPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevaPelicula.Location = new System.Drawing.Point(819, 97);
            this.cmdNuevaPelicula.Name = "cmdNuevaPelicula";
            this.cmdNuevaPelicula.Size = new System.Drawing.Size(111, 26);
            this.cmdNuevaPelicula.TabIndex = 5;
            this.cmdNuevaPelicula.Text = "Nueva pelicula";
            this.cmdNuevaPelicula.UseVisualStyleBackColor = false;
            this.cmdNuevaPelicula.Click += new System.EventHandler(this.cmdNuevaPelicula_Click);
            // 
            // cmdEditar
            // 
            this.cmdEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(19)))));
            this.cmdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditar.Location = new System.Drawing.Point(819, 193);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(111, 26);
            this.cmdEditar.TabIndex = 6;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.UseVisualStyleBackColor = false;
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.AllowUserToAddRows = false;
            this.lstResultado.AllowUserToDeleteRows = false;
            this.lstResultado.AllowUserToResizeColumns = false;
            this.lstResultado.AllowUserToResizeRows = false;
            this.lstResultado.AutoGenerateColumns = false;
            this.lstResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.campo1DataGridViewTextBoxColumn,
            this.Tipo});
            this.lstResultado.DataSource = this.elementoBindingSource;
            this.lstResultado.Location = new System.Drawing.Point(50, 97);
            this.lstResultado.MultiSelect = false;
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.ReadOnly = true;
            this.lstResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstResultado.Size = new System.Drawing.Size(763, 335);
            this.lstResultado.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // campo1DataGridViewTextBoxColumn
            // 
            this.campo1DataGridViewTextBoxColumn.DataPropertyName = "Campo1";
            this.campo1DataGridViewTextBoxColumn.HeaderText = "";
            this.campo1DataGridViewTextBoxColumn.Name = "campo1DataGridViewTextBoxColumn";
            this.campo1DataGridViewTextBoxColumn.ReadOnly = true;
            this.campo1DataGridViewTextBoxColumn.Width = 600;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 120;
            // 
            // elementoBindingSource
            // 
            this.elementoBindingSource.DataSource = typeof(MyIMDB.Elemento);
            // 
            // cmdNuevoDirector
            // 
            this.cmdNuevoDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(19)))));
            this.cmdNuevoDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevoDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoDirector.Location = new System.Drawing.Point(819, 129);
            this.cmdNuevoDirector.Name = "cmdNuevoDirector";
            this.cmdNuevoDirector.Size = new System.Drawing.Size(111, 26);
            this.cmdNuevoDirector.TabIndex = 8;
            this.cmdNuevoDirector.Text = "Nueva serie";
            this.cmdNuevoDirector.UseVisualStyleBackColor = false;
            this.cmdNuevoDirector.Click += new System.EventHandler(this.cmdNuevoDirector_Click);
            // 
            // cmdNuevoActor
            // 
            this.cmdNuevoActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(19)))));
            this.cmdNuevoActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNuevoActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoActor.Location = new System.Drawing.Point(819, 161);
            this.cmdNuevoActor.Name = "cmdNuevoActor";
            this.cmdNuevoActor.Size = new System.Drawing.Size(111, 26);
            this.cmdNuevoActor.TabIndex = 9;
            this.cmdNuevoActor.Text = "Nuevo actor";
            this.cmdNuevoActor.UseVisualStyleBackColor = false;
            this.cmdNuevoActor.Click += new System.EventHandler(this.cmdNuevoActor_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(961, 462);
            this.Controls.Add(this.cmdNuevoActor);
            this.Controls.Add(this.cmdNuevoDirector);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.cmdNuevaPelicula);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmbTipoFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(977, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(977, 500);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My IMDB";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoFiltro;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdNuevaPelicula;
        private System.Windows.Forms.Button cmdEditar;
        private System.Windows.Forms.DataGridView lstResultado;
        private System.Windows.Forms.Button cmdNuevoDirector;
        private System.Windows.Forms.Button cmdNuevoActor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource elementoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn campo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}

