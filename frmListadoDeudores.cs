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
    public partial class frmListadoDeudores : Form
    {
        public frmListadoDeudores()
        {
            InitializeComponent();
        }

        clsCliente objCliente = new clsCliente();

        private void frmListadoDeudores_Load(object sender, EventArgs e)
        {
            objCliente.Deudores(dgvListado);
            lblCantidadClientes.Text = objCliente.CantidadDeudores.ToString();
            lblTotalDeuda.Text = objCliente.DeudaTotal.ToString();
            lblPromedioDeuda.Text = objCliente.PromedioDeuda.ToString();
        }
    }
}
