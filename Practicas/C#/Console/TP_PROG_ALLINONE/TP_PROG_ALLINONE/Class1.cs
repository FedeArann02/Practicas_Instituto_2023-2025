using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TP_PROG_ALLINONE
{
    internal class Ejercicios
    {
        public static bool SN = true;

        public static void Menú()
        {
            Console.WriteLine("Hola usuario. ¿Qué ejercicio desea ver?\n");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"\tEjercicio {i + 1}");
            }
            try
            {
                Console.WriteLine("\n\tIngrese el ejercicio a ver:");
                int valor = Convert.ToInt32(Console.ReadLine());
                switch (valor)
                {
                    case 1:
                        Console.Clear();
                        EJE1();
                        break;
                    case 2:
                        Console.Clear();
                        EJE2();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicios.EJE3();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicios.EJE4();
                        break;
                    case 5:
                        Console.Clear();
                        Ejercicios.EJE5();
                        break;
                    case 6:
                        Console.Clear();
                        Ejercicios.EJE6();
                        break;
                    case 7:
                        Console.Clear();
                        Ejercicios.EJE7();
                        break;
                    default:
                        Console.WriteLine("El número debe ser mayor a 0");
                        break;
                }
            }
            catch
            {
                Console.Write("Error, ingrese un valor numérico del 1 al 7");
                SN = false;
            }
            pregunta();
        }
    
    public static void pregunta()
        {
            Console.WriteLine("\n\n¿Desea ver otro ejercicio?");
            Console.Write(" 1 : Si" + "\n 2 : No \n");
            int YN = Convert.ToInt32(Console.ReadLine());
            if (YN == 1)
            {
                Ejercicios.SN = false;
                Console.Clear();
            }
            else Ejercicios.SN = true;
        }

        public static void EJE1()
        {
            int[,] Matriz4x4 = new int[4, 4];
            int suma = 0;
            Random Rnd_Mat = new Random();


            Console.WriteLine("La matriz original es: ");

            for (int f = 0; f < Matriz4x4.GetLength(0); f++)
            {
                for (int c = 0; c < Matriz4x4.GetLength(1); c++)
                {
                    Matriz4x4[f, c] = Rnd_Mat.Next(1, 6);
                    Console.Write(Matriz4x4[f, c] + " ");
                    suma += Matriz4x4[f, c];
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.Write("La suma de todos los valores es: " + suma);
            Console.WriteLine(" ");
        }
        public static void EJE2()
        {
            int[,] Ary_Mat5x5 = new int[5, 5];
            int suma = 0;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Ary_Mat5x5[f, c] = (f + c);
                    suma += Ary_Mat5x5[f, c];
                    Console.Write(Ary_Mat5x5[f, c] + " ");
                }
                Console.Write(" = " + suma);
                suma = 0;
                Console.WriteLine(" ");
            }

        }
        public static void EJE3()
        {
            Console.WriteLine("Matriz original: ");
            Console.WriteLine("\t");

            int[,] Matriz1 = {
                { 1, 8, 4, 9, 3 },
                { 8, 6, 3, 5, 2 },
                { 1, 7, 6, 1, 2 }
        };
            int[,] MatrizTrans = new int[3, 5];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)

                {
                    MatrizTrans[i, j] = Matriz1[i, j];
                    Console.Write(Matriz1[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            Console.WriteLine("La matriz transpuesta es: ");
            Console.WriteLine("\t");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(MatrizTrans[j, i] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public static void EJE4()
        {
            Random Mat_Rand = new Random(); //
            int[,] Matriz1 = new int[6, 6]; //DECLARO E INSTANCIO UN ARRAY BIDIMENSIONAL
            int[] Matriz_Diag = new int[6]; //DECLARO E INSTANCIO UN ARRAY PARA ALMACENAR LOS VALORES DE LA DIAGONAL

            for (int f = 0; f < 6; f++) //RECORRO FILAS O INDICE MEDIANTE LA INSTRUCCION FOR Y LO MISMO CON LAS COLUMNAS
            {
                for (int c = 0; c < 6; c++)
                {
                    Matriz1[f, c] = Mat_Rand.Next(1, 9);
                    {
                        if (f == c)
                        {
                            Matriz_Diag[c] = Matriz1[f, c];
                        }
                    }
                    Console.Write(Matriz1[f, c] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\n");
            Console.Write("La diagonal de la matriz es: ");

            for (int i = 0; i < 6; i++) //RECORRO FILAS O INDICE MEDIANTE LA INSTRUCCION FOR
            {
                {
                    Console.Write(Matriz_Diag[i] + " "); //IMPRIMO EN PANTALLA EL ARRAY DE LA DIAGONAL OBTENIDA DE MI MATRIZ ANTERIOR
                }
            }
        }
        public static void EJE5()
        {
            Random random = new Random();
            int[] array1 = new int[5];
            int[] array2 = new int[5];

            StreamWriter Hist = File.AppendText("Historial_MultiArray_ALLINONE.txt");
            Hist.WriteLine("\n" + DateTime.Now.ToString());

            for (int i = 0; i < 5; i++)
            {
                array1[i] = random.Next(1, 10);
                array2[i] = random.Next(1, 10);
            }
            //Si imprimia los arrays con bucle for me quedaba bastante largo. Así que usé el método "String.Join" que aprendimos en la clase. :)
            Console.WriteLine("Array 1 = " + string.Join(" ", array1));
            Hist.WriteLine("Array 1 = " + string.Join(" ", array1));
            Hist.WriteLine("Array 2 = " + string.Join(" ", array2));
            Console.WriteLine("Array 2 = " + string.Join(" ", array2));

            Console.Write("\nResultante = ");
            Hist.Write("\nResultante = ");

            for (int i = 0; i < 5; i++)
            {
                int resultado = array1[i];
                for (int j = 0; j < 5; j++)
                {
                    resultado *= array2[j];
                }
                Console.Write(resultado + " ");
                Hist.Write(resultado + " ");
            }
            Hist.WriteLine("\n");
            Hist.Close();
        }
        public static void EJE6()
        {
            string[,] Array = new string[5, 3];
            string[] Array_S = new string[5];
            List<string> Lista_Nombres = new List<string>();

            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("ingrese Nombre, Apellido y Edad (en ese orden). Y presione ENTER entre cada uno");
                for (int c = 2; c >= 0; c--)
                {
                    Array[f, c] = Console.ReadLine();
                }
                Lista_Nombres.Add(Array_S[f] = Array[f, 0] + ";" + Array[f, 1] + ", " + Array[f, 2]);
            }
            string[] listado = new string[2];
            Lista_Nombres.Sort();
            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            {
                listado = Lista_Nombres[i].Split(';');
                Console.WriteLine(listado[1] + " " + listado[0]);
            }
        }
        public static void EJE7()
        {
            int[,] tiradas = new int[5, 5];
            int[] caras_result = new int[6];
            Random caras_rnd = new Random();
            StreamWriter Hist = File.AppendText("Historial_Dados_ALLINONE.txt");
            Hist.WriteLine("\n" + DateTime.Now.ToString());

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Presione una tecla para realizar el tiro número {i + 1}...");
                Console.ReadKey();
            }

            for (int f = 0; f < 5; f++)
            {
                Console.Write($"\nTiro {f + 1}: ");
                Hist.Write($"\nTiro {f + 1}: ");
                for (int c = 0; c < 5; c++)
                {
                    tiradas[f, c] = caras_rnd.Next(1, 7);
                    Console.Write(" " + tiradas[f, c]);
                    Hist.Write(" " + tiradas[f, c]);
                }
                Console.WriteLine(" ");
                Hist.WriteLine(" ");
            }

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    int recorrer_caras = tiradas[f, c];
                    caras_result[recorrer_caras - 1]++;
                }
            }

            for (int f = 0; f < 6; f++)
            {
                Console.Write($"\n{f + 1} = " + caras_result[f] + " veces");
                Hist.Write($"\n{f + 1} = " + caras_result[f] + " veces");
            }
            Console.WriteLine(" ");
            Hist.WriteLine(" ");
            Hist.Close();
        }
    }
}