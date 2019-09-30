using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento
{
    public partial class Mantenimiento : Form
    {
        private int n = 0;


        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dtgvMantenimiento.Rows.Add();

            dtgvMantenimiento.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvMantenimiento.Rows[n].Cells[1].Value = txtNombre.Text ;
            dtgvMantenimiento.Rows[n].Cells[2].Value = txtDetalle.Text ;
            dtgvMantenimiento.Rows[n].Cells[3].Value = txtCosto.Text ;
            dtgvMantenimiento.Rows[n].Cells[4].Value = txtPrecio.Text ;
            dtgvMantenimiento.Rows[n].Cells[5].Value = txtFechaCreacion.Text ;
            dtgvMantenimiento.Rows[n].Cells[6].Value = txtFechaVencimiento.Text;
            dtgvMantenimiento.Rows[n].Cells[7].Value = txtCategoria.Text;
            dtgvMantenimiento.Rows[n].Cells[8].Value = txtEstado.Text;

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDetalle.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";
            txtFechaCreacion.Text = "";
            txtFechaVencimiento.Text = "";
            txtCategoria.Text = "";
            txtEstado.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(n!=-1)
            {
                dtgvMantenimiento.Rows.RemoveAt(n);


            }

        }
    }
}
