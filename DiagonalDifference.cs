using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3_1Examen
{
   public class DiagonalDifference
    {
        //Haniel Sandino Rivera
        public void matrix(String Number)//Metemos por parametro la cadena de caracter.
        {
            String[] vector = Number.Split('|');//vamos a empezar a separar por el caracter |.
            int[,] Matriz = new int[vector.Length, vector.Length];//vamos a meter en la matriz los numeros que van separados por |.

            for (int i = 0; i < vector.Length; i++)//recorremos la matriz.
            {
                for (int j = 0; j < 1; j++)
                {
                    String[] v = vector[i].Split(' ');//luego empezamos a separar por espacios

                    for (int k = 0; k < v.Length; k++)//recorremos el vector con espacios para separarlos
                    {
                        Matriz[i, k] = int.Parse(v[k].ToString());//y convertimos de String a Integer.
                    }
                }
            }

            for (int i = 0; i < Matriz.GetLength(0); i++)//recorremos toda la matriz nuevamente.
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.Write(Matriz[i, j].ToString() + " ");//imprimimos la matriz numero por numero.
                }
                Console.WriteLine();//metemos un espacio para que se vaya acomodando como matriz
            }
            Suma(Matriz);//llamamos al metodo suma para ejecutar las usmas y la diferencia.
        }
        public void Suma(int[,] M)//Metodo que va a sumar y a sacar la diferencica.
        {
            int suma = 0;//declaracion de  2 variables las cuales vamos a ir sumando respectivas diagonales.
            int suma2 = 0;
            for (int i = 0; i < M.GetLength(0); i++)//for que recorre la matriz desde la posicion 0, dado que asi es como se inicia.
            {
                suma += M[i, i];//va a sumar los numeros que se encuentren en la misma posicion, por ejemplo 1,1 ya que la primera diagonal va a ir con el mismo numero.
            }
            int f = 0;//esta variable va a ser la fila.
            int c = M.GetLength(1) - 1;// y esta va a ser la comumna, tomamos como indice la ultima posicion de la fila.
            for (int i = 0; i < M.GetLength(0); i++)//nuevamente recorremos la matriz.
            {
                suma2 += M[f,c];//solo vamos a sumar las respectivas posiciones de la otra diagonal de atras para adelante.
                f++;//aumentamos la fila.
                c--;//disminuimos la columna
            }
            int diferencia = suma - suma2;//sacamos la diferencia de las 2 diagonales
            Console.WriteLine("La suma de la primera diagonal es: " + suma);//Imprimimos las sumas y la diferencia.
            Console.WriteLine("La suma de la segunda diagonal es: " + suma2);
            Console.WriteLine("La diferencia de las 2 diagonales es: " + diferencia);
        }
    }
}
