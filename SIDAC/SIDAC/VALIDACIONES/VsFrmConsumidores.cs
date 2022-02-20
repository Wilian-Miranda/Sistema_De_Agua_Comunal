using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace SIDAC.VALIDACIONES
{
    public class VsFrmConsumidores
    {
        internal Boolean ValidarCajas(System.Windows.Forms.ErrorProvider validacion, 
            Guna2TextBox txtApellidos, Guna2ComboBox cbEstado, Guna2TextBox txtNombres)
        {
            Boolean validar = true;

            validacion.SetError(txtApellidos, "");
            validacion.SetError(cbEstado, "");
            validacion.SetError(txtNombres, "");

            if (txtNombres.Text.Equals(""))
            {
                validacion.SetError(txtNombres, "Este campo es obligatorio");
                validar = false;
            }

            if (txtApellidos.Text.Equals(""))
            {
                validacion.SetError(txtApellidos, "Este campo es obligatorio");
                validar = false;
            }

            if (cbEstado.SelectedValue == null)
            {
                validacion.SetError(cbEstado, "Este campo es obligatorio");
                validar = false;
            }

            return validar;
        }
    }
}
