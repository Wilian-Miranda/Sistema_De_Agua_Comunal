using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDAC.VALIDACIONES
{
    class VsFrmPagos
    {
        public Boolean ValidarCajas(int filtro, TextBox txtID, TextBox txtNombres, TextBox txtApellidos, TextBox txtMontoBase,
                                        TextBox txtCancelado, TextBox txtMora, object cbConsumidorValue, System.Windows.Forms.ErrorProvider Validacion)
        {
            Boolean validar = true;

            Validacion.SetError(txtID, "");
            Validacion.SetError(txtNombres, "");
            Validacion.SetError(txtApellidos, "");
            Validacion.SetError(txtMontoBase, "");
            Validacion.SetError(txtCancelado, "");
            Validacion.SetError(txtMora, "");


            if (filtro == 0)
            {
                if (cbConsumidorValue == null || txtID.Text.Equals(""))
                {
                    Validacion.SetError(txtID, "Este campo es obligatorio");
                    Validacion.SetError(txtNombres, "Este campo es obligatorio");
                    Validacion.SetError(txtApellidos, "Este campo es obligatorio");
                    validar = false;
                }
            }
            else
            {
                if (txtID.Text.Equals(""))
                {
                    Validacion.SetError(txtID, "Este campo es obligatorio");
                    Validacion.SetError(txtNombres, "Este campo es obligatorio");
                    Validacion.SetError(txtApellidos, "Este campo es obligatorio");
                    validar = false;
                }
            }


            if (txtMontoBase.Text.Equals(""))
            {
                Validacion.SetError(txtMontoBase, "Este campo es obligatorio");
                validar = false;
            }

            if (txtCancelado.Text.Equals(""))
            {
                Validacion.SetError(txtCancelado, "Este campo es obligatorio");
                validar = false;
            }

            if (txtMora.Text.Equals(""))
            {
                Validacion.SetError(txtMora, "Este campo es obligatorio");
                validar = false;
            }

            return validar;
        }
    }
}
