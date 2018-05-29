using Entity.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Entity.View
{
    public partial class frmUsuarioLista : Form
    {
        UsuarioController _objUsuario = new UsuarioController();
        public frmUsuarioLista()
        {
            InitializeComponent();
        }

        private void frmUsuarioLista_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            usuarioBindingSource.DataSource = _objUsuario.Listar(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuarioDetalle vn = new frmUsuarioDetalle();
            vn.ShowDialog();

            Listar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
