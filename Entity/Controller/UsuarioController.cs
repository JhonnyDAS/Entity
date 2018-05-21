using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity.Controller
{
    class UsuarioController
    {
        modelClaseEntityContainer _ta = new modelClaseEntityContainer();

        public bool Insertar(Usuario reg)
        {
            try
            {
                //INSERT INTO Usuario VALUES('Nombre','Apellido','Cuenta','Clave','Estado')
                reg.Estado = true;
                _ta.Usuario.Add(reg);
                return _ta.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
