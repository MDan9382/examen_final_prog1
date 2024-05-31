using examen_final_prog1.Datos;
using examen_final_prog1.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_final_prog1
{
    public partial class Form1 : Form
    {
        coneccionsql con = new coneccionsql();

        producto prd = new producto();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            prd.id = numericUpDownid.Value;
            prd.nombre = textBoxproducto.Text;
            prd.precio = numericUpDownprecio.Value;
            prd.existencias = numericUpDownexistencias.Value;
            prd.en_tienda = numericUpDownentienda.Value;
            prd.categoria = textBoxcategoria.Text;
            prd.marca =  textBoxmarca.Text;
            MessageBox.Show($"id={prd.id}  nombre={prd.nombre}  precio={prd.precio}  existecias={prd.existencias}  en tienda={prd.en_tienda}  categoria=  marca={prd.marca}");
        }
    }
}
