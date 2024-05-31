namespace examen_final_prog1
{
    partial class Form1
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
            this.labeltitulo = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelproducto = new System.Windows.Forms.Label();
            this.labelprecio = new System.Windows.Forms.Label();
            this.labelexistencias = new System.Windows.Forms.Label();
            this.labelentienda = new System.Windows.Forms.Label();
            this.labelcategoria = new System.Windows.Forms.Label();
            this.labelmarca = new System.Windows.Forms.Label();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.numericUpDownprecio = new System.Windows.Forms.NumericUpDown();
            this.textBoxmarca = new System.Windows.Forms.TextBox();
            this.textBoxcategoria = new System.Windows.Forms.TextBox();
            this.numericUpDownexistencias = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownentienda = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownid = new System.Windows.Forms.NumericUpDown();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttonborrar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.groupBoxacciones = new System.Windows.Forms.GroupBox();
            this.dataGridViewtienda = new System.Windows.Forms.DataGridView();
            this.groupBoxparametros = new System.Windows.Forms.GroupBox();
            this.buttonrefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownexistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownentienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownid)).BeginInit();
            this.groupBoxacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtienda)).BeginInit();
            this.groupBoxparametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(490, 12);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(278, 26);
            this.labeltitulo.TabIndex = 0;
            this.labeltitulo.Text = "base de datos para una tienda";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(13, 10);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(27, 22);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "ID";
            // 
            // labelproducto
            // 
            this.labelproducto.AutoSize = true;
            this.labelproducto.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproducto.Location = new System.Drawing.Point(6, 15);
            this.labelproducto.Name = "labelproducto";
            this.labelproducto.Size = new System.Drawing.Size(71, 22);
            this.labelproducto.TabIndex = 2;
            this.labelproducto.Text = "producto";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprecio.Location = new System.Drawing.Point(6, 54);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(51, 22);
            this.labelprecio.TabIndex = 3;
            this.labelprecio.Text = "precio";
            // 
            // labelexistencias
            // 
            this.labelexistencias.AutoSize = true;
            this.labelexistencias.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexistencias.Location = new System.Drawing.Point(6, 95);
            this.labelexistencias.Name = "labelexistencias";
            this.labelexistencias.Size = new System.Drawing.Size(81, 22);
            this.labelexistencias.TabIndex = 4;
            this.labelexistencias.Text = "existencias";
            // 
            // labelentienda
            // 
            this.labelentienda.AutoSize = true;
            this.labelentienda.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelentienda.Location = new System.Drawing.Point(6, 135);
            this.labelentienda.Name = "labelentienda";
            this.labelentienda.Size = new System.Drawing.Size(72, 22);
            this.labelentienda.TabIndex = 5;
            this.labelentienda.Text = "en tienda";
            // 
            // labelcategoria
            // 
            this.labelcategoria.AutoSize = true;
            this.labelcategoria.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategoria.Location = new System.Drawing.Point(6, 175);
            this.labelcategoria.Name = "labelcategoria";
            this.labelcategoria.Size = new System.Drawing.Size(72, 22);
            this.labelcategoria.TabIndex = 6;
            this.labelcategoria.Text = "categoria";
            // 
            // labelmarca
            // 
            this.labelmarca.AutoSize = true;
            this.labelmarca.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmarca.Location = new System.Drawing.Point(6, 214);
            this.labelmarca.Name = "labelmarca";
            this.labelmarca.Size = new System.Drawing.Size(53, 22);
            this.labelmarca.TabIndex = 7;
            this.labelmarca.Text = "marca";
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Location = new System.Drawing.Point(124, 15);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(154, 20);
            this.textBoxproducto.TabIndex = 8;
            // 
            // numericUpDownprecio
            // 
            this.numericUpDownprecio.DecimalPlaces = 2;
            this.numericUpDownprecio.Location = new System.Drawing.Point(124, 56);
            this.numericUpDownprecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownprecio.Name = "numericUpDownprecio";
            this.numericUpDownprecio.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownprecio.TabIndex = 11;
            // 
            // textBoxmarca
            // 
            this.textBoxmarca.Location = new System.Drawing.Point(124, 217);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(154, 20);
            this.textBoxmarca.TabIndex = 12;
            // 
            // textBoxcategoria
            // 
            this.textBoxcategoria.Location = new System.Drawing.Point(124, 177);
            this.textBoxcategoria.Name = "textBoxcategoria";
            this.textBoxcategoria.Size = new System.Drawing.Size(154, 20);
            this.textBoxcategoria.TabIndex = 13;
            // 
            // numericUpDownexistencias
            // 
            this.numericUpDownexistencias.Location = new System.Drawing.Point(124, 97);
            this.numericUpDownexistencias.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownexistencias.Name = "numericUpDownexistencias";
            this.numericUpDownexistencias.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownexistencias.TabIndex = 14;
            // 
            // numericUpDownentienda
            // 
            this.numericUpDownentienda.Location = new System.Drawing.Point(124, 137);
            this.numericUpDownentienda.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownentienda.Name = "numericUpDownentienda";
            this.numericUpDownentienda.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownentienda.TabIndex = 15;
            // 
            // numericUpDownid
            // 
            this.numericUpDownid.Location = new System.Drawing.Point(141, 14);
            this.numericUpDownid.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownid.Name = "numericUpDownid";
            this.numericUpDownid.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownid.TabIndex = 16;
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(6, 19);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(86, 20);
            this.buttoninsertar.TabIndex = 17;
            this.buttoninsertar.Text = "insertar";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(6, 45);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(86, 20);
            this.buttonbuscar.TabIndex = 18;
            this.buttonbuscar.Text = "buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttonborrar
            // 
            this.buttonborrar.Location = new System.Drawing.Point(6, 71);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(86, 20);
            this.buttonborrar.TabIndex = 19;
            this.buttonborrar.Text = "borrar";
            this.buttonborrar.UseVisualStyleBackColor = true;
            this.buttonborrar.Click += new System.EventHandler(this.buttonborrar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.Location = new System.Drawing.Point(6, 97);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(86, 20);
            this.buttonactualizar.TabIndex = 20;
            this.buttonactualizar.Text = "actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = true;
            this.buttonactualizar.Click += new System.EventHandler(this.buttonactualizar_Click);
            // 
            // groupBoxacciones
            // 
            this.groupBoxacciones.Controls.Add(this.buttoninsertar);
            this.groupBoxacciones.Controls.Add(this.buttonbuscar);
            this.groupBoxacciones.Controls.Add(this.buttonactualizar);
            this.groupBoxacciones.Controls.Add(this.buttonborrar);
            this.groupBoxacciones.Location = new System.Drawing.Point(335, 12);
            this.groupBoxacciones.Name = "groupBoxacciones";
            this.groupBoxacciones.Size = new System.Drawing.Size(107, 126);
            this.groupBoxacciones.TabIndex = 22;
            this.groupBoxacciones.TabStop = false;
            this.groupBoxacciones.Text = "acciones CRUD";
            // 
            // dataGridViewtienda
            // 
            this.dataGridViewtienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtienda.Location = new System.Drawing.Point(335, 180);
            this.dataGridViewtienda.Name = "dataGridViewtienda";
            this.dataGridViewtienda.Size = new System.Drawing.Size(601, 228);
            this.dataGridViewtienda.TabIndex = 21;
            // 
            // groupBoxparametros
            // 
            this.groupBoxparametros.Controls.Add(this.labelproducto);
            this.groupBoxparametros.Controls.Add(this.labelprecio);
            this.groupBoxparametros.Controls.Add(this.labelexistencias);
            this.groupBoxparametros.Controls.Add(this.numericUpDownexistencias);
            this.groupBoxparametros.Controls.Add(this.numericUpDownentienda);
            this.groupBoxparametros.Controls.Add(this.numericUpDownprecio);
            this.groupBoxparametros.Controls.Add(this.labelentienda);
            this.groupBoxparametros.Controls.Add(this.textBoxproducto);
            this.groupBoxparametros.Controls.Add(this.labelcategoria);
            this.groupBoxparametros.Controls.Add(this.textBoxcategoria);
            this.groupBoxparametros.Controls.Add(this.labelmarca);
            this.groupBoxparametros.Controls.Add(this.textBoxmarca);
            this.groupBoxparametros.Location = new System.Drawing.Point(17, 83);
            this.groupBoxparametros.Name = "groupBoxparametros";
            this.groupBoxparametros.Size = new System.Drawing.Size(295, 266);
            this.groupBoxparametros.TabIndex = 23;
            this.groupBoxparametros.TabStop = false;
            this.groupBoxparametros.Text = "parametros de insercion";
            // 
            // buttonrefrescar
            // 
            this.buttonrefrescar.Location = new System.Drawing.Point(581, 143);
            this.buttonrefrescar.Name = "buttonrefrescar";
            this.buttonrefrescar.Size = new System.Drawing.Size(75, 23);
            this.buttonrefrescar.TabIndex = 24;
            this.buttonrefrescar.Text = "refrescar";
            this.buttonrefrescar.UseVisualStyleBackColor = true;
            this.buttonrefrescar.Click += new System.EventHandler(this.buttonrefrescar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.buttonrefrescar);
            this.Controls.Add(this.groupBoxacciones);
            this.Controls.Add(this.dataGridViewtienda);
            this.Controls.Add(this.numericUpDownid);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.groupBoxparametros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownexistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownentienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownid)).EndInit();
            this.groupBoxacciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtienda)).EndInit();
            this.groupBoxparametros.ResumeLayout(false);
            this.groupBoxparametros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelproducto;
        private System.Windows.Forms.Label labelprecio;
        private System.Windows.Forms.Label labelexistencias;
        private System.Windows.Forms.Label labelentienda;
        private System.Windows.Forms.Label labelcategoria;
        private System.Windows.Forms.Label labelmarca;
        private System.Windows.Forms.TextBox textBoxproducto;
        private System.Windows.Forms.NumericUpDown numericUpDownprecio;
        private System.Windows.Forms.TextBox textBoxmarca;
        private System.Windows.Forms.TextBox textBoxcategoria;
        private System.Windows.Forms.NumericUpDown numericUpDownexistencias;
        private System.Windows.Forms.NumericUpDown numericUpDownentienda;
        private System.Windows.Forms.NumericUpDown numericUpDownid;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.GroupBox groupBoxacciones;
        private System.Windows.Forms.DataGridView dataGridViewtienda;
        private System.Windows.Forms.GroupBox groupBoxparametros;
        private System.Windows.Forms.Button buttonrefrescar;
    }
}

