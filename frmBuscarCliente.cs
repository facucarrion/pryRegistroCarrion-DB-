using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRegistroCarrion_DB_
{
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            clsCliente objCliente = new clsCliente();

            Int32 idCliente = Convert.ToInt32(txtCodigo.Text);

            objCliente.BuscarCliente(idCliente);

            if (objCliente.IdCliente == 0)
            {
                MessageBox.Show("El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMostrarNombre.Text = "";
                lblMostrarDeuda.Text = "";
                lblMostrarLimite.Text = "";
            } else
            {
                lblMostrarNombre.Text = objCliente.Nombre;
                lblMostrarDeuda.Text = objCliente.Deuda.ToString();
                lblMostrarLimite.Text = objCliente.Limite.ToString();
            }
        }
    }
}
