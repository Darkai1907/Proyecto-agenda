using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {

        private int n = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void dtgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dtgvAgenda.Rows.Add();

            dtgvAgenda.Rows[n].Cells[0].Value = txtNombre.Text;
            dtgvAgenda.Rows[n].Cells[1].Value = txtApellido.Text;
            dtgvAgenda.Rows[n].Cells[2].Value = txtEdad.Text;
            dtgvAgenda.Rows[n].Cells[3].Value = txtFechaNacimiento.Text;
            dtgvAgenda.Rows[n].Cells[4].Value = txtDireccion.Text;
            dtgvAgenda.Rows[n].Cells[5].Value = txtProvincia.Text;
            dtgvAgenda.Rows[n].Cells[6].Value = txtPais.Text;
            dtgvAgenda.Rows[n].Cells[7].Value = txtTelefono.Text;
            dtgvAgenda.Rows[n].Cells[8].Value = txtCelular.Text;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtFechaNacimiento.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";



        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvAgenda.Rows.RemoveAt(n);


            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
