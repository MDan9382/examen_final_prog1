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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownexistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownentienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownid)).BeginInit();
            this.groupBoxacciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtienda)).BeginInit();
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
            this.labelproducto.Location = new System.Drawing.Point(13, 50);
            this.labelproducto.Name = "labelproducto";
            this.labelproducto.Size = new System.Drawing.Size(71, 22);
            this.labelproducto.TabIndex = 2;
            this.labelproducto.Text = "producto";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprecio.Location = new System.Drawing.Point(13, 90);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(51, 22);
            this.labelprecio.TabIndex = 3;
            this.labelprecio.Text = "precio";
            // 
            // labelexistencias
            // 
            this.labelexistencias.AutoSize = true;
            this.labelexistencias.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexistencias.Location = new System.Drawing.Point(13, 130);
            this.labelexistencias.Name = "labelexistencias";
            this.labelexistencias.Size = new System.Drawing.Size(81, 22);
            this.labelexistencias.TabIndex = 4;
            this.labelexistencias.Text = "existencias";
            // 
            // labelentienda
            // 
            this.labelentienda.AutoSize = true;
            this.labelentienda.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelentienda.Location = new System.Drawing.Point(13, 170);
            this.labelentienda.Name = "labelentienda";
            this.labelentienda.Size = new System.Drawing.Size(72, 22);
            this.labelentienda.TabIndex = 5;
            this.labelentienda.Text = "en tienda";
            // 
            // labelcategoria
            // 
            this.labelcategoria.AutoSize = true;
            this.labelcategoria.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategoria.Location = new System.Drawing.Point(13, 210);
            this.labelcategoria.Name = "labelcategoria";
            this.labelcategoria.Size = new System.Drawing.Size(72, 22);
            this.labelcategoria.TabIndex = 6;
            this.labelcategoria.Text = "categoria";
            // 
            // labelmarca
            // 
            this.labelmarca.AutoSize = true;
            this.labelmarca.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmarca.Location = new System.Drawing.Point(13, 250);
            this.labelmarca.Name = "labelmarca";
            this.labelmarca.Size = new System.Drawing.Size(53, 22);
            this.labelmarca.TabIndex = 7;
            this.labelmarca.Text = "marca";
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Location = new System.Drawing.Point(136, 52);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(154, 20);
            this.textBoxproducto.TabIndex = 8;
            // 
            // numericUpDownprecio
            // 
            this.numericUpDownprecio.DecimalPlaces = 2;
            this.numericUpDownprecio.Location = new System.Drawing.Point(136, 93);
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
            this.textBoxmarca.Location = new System.Drawing.Point(136, 252);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(154, 20);
            this.textBoxmarca.TabIndex = 12;
            // 
            // textBoxcategoria
            // 
            this.textBoxcategoria.Location = new System.Drawing.Point(136, 212);
            this.textBoxcategoria.Name = "textBoxcategoria";
            this.textBoxcategoria.Size = new System.Drawing.Size(154, 20);
            this.textBoxcategoria.TabIndex = 13;
            // 
            // numericUpDownexistencias
            // 
            this.numericUpDownexistencias.Location = new System.Drawing.Point(136, 132);
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
            this.numericUpDownentienda.Location = new System.Drawing.Point(136, 172);
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
            this.numericUpDownid.Location = new System.Drawing.Point(136, 12);
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
            // 
            // buttonborrar
            // 
            this.buttonborrar.Location = new System.Drawing.Point(6, 71);
            this.buttonborrar.Name = "buttonborrar";
            this.buttonborrar.Size = new System.Drawing.Size(86, 20);
            this.buttonborrar.TabIndex = 19;
            this.buttonborrar.Text = "borrar";
            this.buttonborrar.UseVisualStyleBackColor = true;
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.Location = new System.Drawing.Point(6, 97);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(86, 20);
            this.buttonactualizar.TabIndex = 20;
            this.buttonactualizar.Text = "actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = true;
            // 
            // groupBoxacciones
            // 
            this.groupBoxacciones.Controls.Add(this.buttoninsertar);
            this.groupBoxacciones.Controls.Add(this.buttonbuscar);
            this.groupBoxacciones.Controls.Add(this.buttonactualizar);
            this.groupBoxacciones.Controls.Add(this.buttonborrar);
            this.groupBoxacciones.Location = new System.Drawing.Point(334, 26);
            this.groupBoxacciones.Name = "groupBoxacciones";
            this.groupBoxacciones.Size = new System.Drawing.Size(107, 126);
            this.groupBoxacciones.TabIndex = 22;
            this.groupBoxacciones.TabStop = false;
            this.groupBoxacciones.Text = "acciones";
            // 
            // dataGridViewtienda
            // 
            this.dataGridViewtienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtienda.Location = new System.Drawing.Point(323, 172);
            this.dataGridViewtienda.Name = "dataGridViewtienda";
            this.dataGridViewtienda.Size = new System.Drawing.Size(505, 150);
            this.dataGridViewtienda.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.groupBoxacciones);
            this.Controls.Add(this.dataGridViewtienda);
            this.Controls.Add(this.numericUpDownid);
            this.Controls.Add(this.numericUpDownentienda);
            this.Controls.Add(this.numericUpDownexistencias);
            this.Controls.Add(this.textBoxcategoria);
            this.Controls.Add(this.textBoxmarca);
            this.Controls.Add(this.numericUpDownprecio);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.labelmarca);
            this.Controls.Add(this.labelcategoria);
            this.Controls.Add(this.labelentienda);
            this.Controls.Add(this.labelexistencias);
            this.Controls.Add(this.labelprecio);
            this.Controls.Add(this.labelproducto);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labeltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownexistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownentienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownid)).EndInit();
            this.groupBoxacciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtienda)).EndInit();
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
    }
}

