using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventanas_DAL.Check_DAL; 

namespace Ventanas_BLL.Check_BLL
{
	public class cls_Check_BLL
	{
        
        private Random _random;

		public cls_Check_BLL()
		{
            this._random = new Random();
        }

		public int generarNumeroAleatorio(int min, int max)
        {
            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }

            return this._random.Next(min, max + 1);
        }

        public int[] generarNumerosAleatoriosNoRepetidos(int longitud, int min, int max)
        {

            if (min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }

            if (longitud <= 0 || (max - min) < longitud - 1)
            {
                return null;
            }

            int[] numeros = new int[longitud];

            bool repetido;
            int numero;
            int indice = 0;

            while (indice < numeros.Length)
            {

                repetido = false;

                numero = generarNumeroAleatorio(min, max);

                for (int i = 0; i < indice; i++)
                {
                    if (numeros[i] == numero)
                    {
                        repetido = true;
                    }
                }

                if (!repetido)
                {
                    numeros[indice] = numero;
                    indice++;
                }


            }

            return numeros;

        }
    }
}
