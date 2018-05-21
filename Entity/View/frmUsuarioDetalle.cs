using Entity.Controller;
using Entity.Model;
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
    public partial class frmUsuarioDetalle : Form
    {
        UsuarioController _objUsuario = new UsuarioController();
        public frmUsuarioDetalle()
        {
            InitializeComponent();
        }

        private void frmUsuarioDetalle_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _objUsuario.Insertar((Usuario)usuarioBindingSource.Current);
        }
    }
}
