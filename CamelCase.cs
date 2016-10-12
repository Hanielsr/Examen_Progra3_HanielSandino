using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3_1Examen
{
    // Haniel Sandino Rivera.
   public class CamelCase
    {
        public int calculate(String oracion)
        {
            int numero_palabras = 0;
            if (char.IsLower(oracion[0]))//indico si la primera letra de la palabra es minuscula pa contarla como palabra.
            {
                numero_palabras++;//si eso pasa sumo 1 al contador.
            }
            else
            {
                numero_palabras--;//de lo contrario le resto 1
            }
            for (int i = 0; i < oracion.Length; i++)//se recorre la palabra letra or letra.
            {
                if (char.IsUpper(oracion[i]))//Si una palabra la encuentra con mayuscula la tomara como palabra.
                {
                    numero_palabras++;//le sumamos 1 al haber encontrado la letra en mayuscula.
                }
            }
            return numero_palabras;//retornamos la cantodad de palabras que ingreso el usuario.
        }
    }
}
