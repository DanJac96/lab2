using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Laboratorio2
{
    public class Funcion
    {
        public static double Nx2 (double x){
            return x * 2;
        }
        public static void bitacora(string txt)
        {
            using (StreamWriter objStrem = new StreamWriter(@"C:\Users\Daniel\Desktop\Bitacora de Multiplicacion.txt", true))
            {
                objStrem.WriteLine(txt);
                objStrem.Flush();
            }
        }
    }
}