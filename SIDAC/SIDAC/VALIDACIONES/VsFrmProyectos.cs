using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDAC.VALIDACIONES
{
    class VsFrmProyectos
    {
        #region Validacion de las cantidades ingresadas
        public void SoloNumeros(System.Windows.Forms.KeyPressEventArgs e, String tipo)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (e.KeyChar.ToString() == ".")
                {
                    if (tipo.Equals("Entero"))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        //se evalua cada char para verificar si se permite o no
        //simplemente se convierte el dato de la caja al tipo de dato correspondiente, si da erroe
        //entonces el datos no es correcto y se bloquea la opcion de agregar y/o modificar
        public void ValidarNumEnCajas(Guna.UI2.WinForms.Guna2TextBox caja, String tipo, String accion, Guna.UI2.WinForms.Guna2Button btnAccion)
        {
            try
            {
                if (tipo.Equals("Decimal"))
                {
                    decimal valor1 = Convert.ToDecimal(caja.Text);
                }
                else
                {
                    int valor2 = Convert.ToInt32(caja.Text);
                }

                if (accion.Equals("Agregar"))
                {
                    btnAccion.Enabled = true;
                }
                else
                {
                    btnAccion.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                if (accion.Equals("Agregar"))
                {
                    btnAccion.Enabled = false;
                }
                else
                {
                    btnAccion.Enabled = false;
                }
            }
        }
        #endregion
    }
}
