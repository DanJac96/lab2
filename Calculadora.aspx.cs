using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio2
{
    delegate double Multi(double Num1);
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            uName.Text= Session["Usuario"].ToString();
        }

        protected void Calc_Click(object sender, EventArgs e)
        {
            Multi mult = Funcion.Nx2;
            double rest = Convert.ToDouble(Num.Text);
            double result = mult(rest);
            string a = Convert.ToString(result);
            Resultado.Text = a;

            Action<string> bitac = Funcion.bitacora;
            string hacerbitacora = String.Format("Se multiplica el numero {0} por 2 y da como resultado: {1}", rest, result);
            bitac(hacerbitacora);
        }
    }
}