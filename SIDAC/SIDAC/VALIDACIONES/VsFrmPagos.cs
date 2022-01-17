using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        //validacion para el ingreso de cantidades correctas en las cajas
        public void VerificarValoresNumericos(String identificadorAccion, Guna.UI2.WinForms.Guna2TextBox caja, Guna.UI2.WinForms.Guna2Button botonActivo, string montoPagar, string cancelado)
        {

            caja.FillColor = Color.White;
            try
            {
                double monto = Convert.ToDouble(caja.Text);
                botonActivo.Enabled = true;

                if (monto > 0)
                {
                    caja.FillColor = Color.LimeGreen;

                    //realizar la operacion de restar lo cancelado del monto base
                    if (identificadorAccion.Equals("montoCancelado"))
                    {
                        double valorcancelado = Convert.ToDouble(cancelado);
                        double montoBase = Convert.ToDouble(montoPagar);
                        if (valorcancelado > montoBase)
                        {
                            botonActivo.Enabled = false;
                            caja.FillColor = Color.Crimson;
                        }
                        else
                        {
                            caja.FillColor = Color.LimeGreen;
                            botonActivo.Enabled = true;
                        }
                    }

                }
                else
                {

                    caja.FillColor = Color.Crimson;

                    if (botonActivo.Enabled)
                    {
                        botonActivo.Enabled = false;
                    }


                }
                if (identificadorAccion.Equals("mora") && monto == 0)
                {
                    caja.FillColor = Color.LimeGreen;
                    if (botonActivo.Enabled == false)
                    {
                        botonActivo.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                caja.FillColor = Color.Crimson;
                if (botonActivo.Enabled)
                {
                    botonActivo.Enabled = false;
                }
            }

        }
    }
}
