using examen_final_prog1.Datos;
using examen_final_prog1.Datos.Modelos;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Tls;
using System;
using System.Collections;
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

        List<producto> datos;

        cursor crs = new cursor();

        public Form1()
        {
            InitializeComponent();
            dataGridViewtienda.DataSource = con.obtenertabla();
        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            prd.Id = numericUpDownid.Value;
            prd.Nombre = textBoxproducto.Text;
            prd.Precio = numericUpDownprecio.Value;
            prd.Existencias = numericUpDownexistencias.Value;
            prd.En_tienda = numericUpDownentienda.Value;
            prd.Categoria = textBoxcategoria.Text;
            prd.Marca =  textBoxmarca.Text;

            con.insertar(prd);

            //MessageBox.Show($"id={prd.id}  nombre={prd.nombre}  precio={prd.precio}  existecias={prd.existencias}  en tienda={prd.en_tienda}  categoria=  marca={prd.marca}");

        }
        

        private void buttonrefrescar_Click(object sender, EventArgs e)
        {
            datos = con.obtenertabla();
            if (datos.Count > 0)
            {
                crs.totalregistros = datos.Count;
                crs.actual = 0;

                
            }
            else
            {
                MessageBox.Show("No se encontro ningun registro de datos");
            }
            dataGridViewtienda.DataSource = datos;
        }
        
        

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            decimal id=numericUpDownid.Value;
            dataGridViewtienda.DataSource = con.buscar(id);
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            prd.Id = numericUpDownid.Value;
            prd.Nombre = textBoxproducto.Text;
            prd.Precio = numericUpDownprecio.Value;
            prd.Existencias = numericUpDownexistencias.Value;
            prd.En_tienda = numericUpDownentienda.Value;
            prd.Categoria = textBoxcategoria.Text;
            prd.Marca = textBoxmarca.Text;

            con.actualizar(prd);
        }

        private void buttonborrar_Click(object sender, EventArgs e)
        {
            decimal id = numericUpDownid.Value;
            con.borrar(id);
        }
    }
}
