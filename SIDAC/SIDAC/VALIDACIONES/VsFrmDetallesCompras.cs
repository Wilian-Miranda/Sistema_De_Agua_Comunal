using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDAC.VALIDACIONES
{
    public class VsFrmDetallesCompras
    {
        public Boolean ValidarCajas(
            System.Windows.Forms.ErrorProvider validadorCajas,
            Guna.UI2.WinForms.Guna2TextBox txtCantidad,
            Guna.UI2.WinForms.Guna2TextBox txtPrecioUnitario,
            Guna.UI2.WinForms.Guna2TextBox txtDescripcion
            )
        {
            Boolean validador = true;
            validadorCajas.SetError(txtCantidad, "");
            validadorCajas.SetError(txtPrecioUnitario, "");
            validadorCajas.SetError(txtDescripcion, "");


            if (txtCantidad.Text.Equals(""))
            {
                validadorCajas.SetError(txtCantidad, "Este campo es obligatorio.");
                validador = false;
            }

            if (txtPrecioUnitario.Text.Equals(""))
            {
                validadorCajas.SetError(txtPrecioUnitario, "Este campo es obligatorio.");
                validador = false;
            }
            else
            {
                try
                {
                    Convert.ToDecimal(txtPrecioUnitario.Text);
                    validadorCajas.SetError(txtPrecioUnitario, "");
                }
                catch (Exception)
                {
                    validadorCajas.SetError(txtPrecioUnitario, "Valor inválido");
                    validador = false;
                }
            }

            if (txtDescripcion.Text.Equals(""))
            {
                validadorCajas.SetError(txtDescripcion, "Este campo es obligatorio.");
                validador = false;
            }


            return validador;
        }
    }
}
