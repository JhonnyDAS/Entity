using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Entity.Controller
{
    class UsuarioController
    {
        modelClaseEntityContainer _ta = new modelClaseEntityContainer();

        public List<Usuario> Listar()
        {
            return _ta.Usuario.ToList();
        }
        /// <summary>
        /// Este metodo lista segun un parametro que envie
        /// </summary>
        /// <param name="pBuscar"></param>
        /// <returns></returns>
        public List<Usuario> Listar(string pBuscar)
        {
            return _ta.Usuario.Where(x => x.Nombre.Contains(pBuscar) || x.Apellido.Contains(pBuscar)).ToList();
        }
        public bool Insertar(Usuario reg)
        {
            try
            {
                //INSERT INTO Usuario VALUES('Nombre','Apellido','Cuenta','Clave','Estado')
                reg.Estado = true;
                _ta.Usuario.Add(reg);
                MessageBox.Show("Datos guardados correctamente");
                return _ta.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}
