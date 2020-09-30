using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimeraTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO NUMERO 1 (CUADRADO Y CUBO DE N NUMERO)<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //double numero, resultadoCuadrado, resultadoCubo;
            //Console.WriteLine("Digite el numero que desea procesar: ");
            //numero = Convert.ToDouble(Console.ReadLine());
            //resultadoCuadrado = Math.Pow(numero, 2);
            //resultadoCubo = Math.Pow(numero, 3);
            //Console.WriteLine("El cuadrado de " + numero + " es: " + resultadoCuadrado);
            //Console.WriteLine("El Cubo de " + numero + " es: " + resultadoCubo);
            //Console.ReadKey();

            // EJERCICIO NUMERO 2 (SUMA DE LOS ANTECEDENTES DE N)<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //double numero, resultado;
            //Console.WriteLine("Digite el numero que desea procesar: ");
            //numero = Convert.ToDouble(Console.ReadLine());
            //resultado = 0;
            //for (Double i = numero; i <= numero; i--)
            //{
            //    resultado += i;
            //    if (i == 0)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("La suma de los antecedentes de " + numero + " es: " + resultado);
            //Console.ReadKey();

            // EJERCICIO NUMERO 3 (MOSTRAR NUMEROS DEL 1 A N)<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            //double numero, numeroFinal;
            //Console.WriteLine("Digite el numero que desea procesar: ");
            //numero = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Los números anteriores a "+ numero + " son:");
            //for (Double i = 1; i <= numero; i++)
            //{
            //    numeroFinal = i;
            //    Console.WriteLine(numeroFinal);
            //    if (numeroFinal == numero - 1) {
            //        break;

            //    }
            //}
            //Console.ReadKey();

            // EJERCICIO NUMERO 4 (EL NUMERO MAYOR Y EL MENOR)<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //List<double> listaNumeros = new List<double>();
            //double numero1, numero2, numero3, numero4, numero5, mayor, menor;
            //mayor = 0;
            //menor = 100000000000;
            //Console.WriteLine("Digite el primer número: ");
            //numero1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite el segundo número: ");
            //numero2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite el tercer número: ");
            //numero3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite el cuarto número: ");
            //numero4 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite el quinto número: ");
            //numero5 = Convert.ToDouble(Console.ReadLine());
            //listaNumeros.Add(numero1);
            //listaNumeros.Add(numero2);
            //listaNumeros.Add(numero3);
            //listaNumeros.Add(numero4);
            //listaNumeros.Add(numero5);
            //foreach (double numero in listaNumeros)
            //{
            //    if (numero > mayor) {
            //        mayor = numero;
            //    }
            //    if (numero < menor) {
            //        menor = numero;
            //    }
            //    if (numero == listaNumeros[4]) {
            //        break;
            //    }
            //}
            //Console.WriteLine("El número mayor es: " + mayor + " y el número menor es: " + menor);
            //Console.ReadKey();

            // EJERCICIO NUMERO 5 (Dias lluviosos)<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //Double lunes, martes, miercoles, jueves, viernes, sabado, domingo, diaMasLluvioso, diaMenoslluvioso, promedio;
            //string diaMasLluviosoLetras, diaMenosLluviosoLetras;
            //diaMasLluviosoLetras = " ";
            //diaMenosLluviosoLetras = " ";
            //diaMasLluvioso = 0;
            //diaMenoslluvioso = 1000000000000000;
            //promedio = 0;

            //List<double> listaMililitrosLlovidos = new List<double>();

            //Console.WriteLine("Digite los mililitros llovidos el lunes : ");
            //lunes = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite los mililitros llovidos el martes : ");
            //martes = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite los mililitros llovidos el miercoles : ");
            //miercoles = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite los mililitros llovidos el jueves : ");
            //jueves = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite los mililitros llovidos el viernes : ");
            //viernes = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite los mililitros llovidos el sabado : ");
            //sabado = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite los mililitros llovidos el domingo : ");
            //domingo = Convert.ToDouble(Console.ReadLine());

            //listaMililitrosLlovidos.Add(lunes);
            //listaMililitrosLlovidos.Add(martes);
            //listaMililitrosLlovidos.Add(miercoles);
            //listaMililitrosLlovidos.Add(jueves);
            //listaMililitrosLlovidos.Add(viernes);
            //listaMililitrosLlovidos.Add(sabado);
            //listaMililitrosLlovidos.Add(domingo);

            //List<string> listaDiasLlovidos = new List<string>();

            //listaDiasLlovidos.Add("Lunes");
            //listaDiasLlovidos.Add("Martes");
            //listaDiasLlovidos.Add("Miércoles");
            //listaDiasLlovidos.Add("Jueves");
            //listaDiasLlovidos.Add("Viernes");
            //listaDiasLlovidos.Add("Sábado");
            //listaDiasLlovidos.Add("Domingo");

            //for (int contador = 0; contador < listaMililitrosLlovidos.Count; contador++)
            //{
            //    if (listaMililitrosLlovidos[contador] > diaMasLluvioso) {
            //        promedio += listaMililitrosLlovidos[contador];
            //        diaMasLluvioso = listaMililitrosLlovidos[contador];
            //        diaMasLluviosoLetras = listaDiasLlovidos[contador];

            //    }
            //    if (listaMililitrosLlovidos[contador] < diaMenoslluvioso) {
            //        diaMenoslluvioso = listaMililitrosLlovidos[contador];
            //        diaMenosLluviosoLetras = listaDiasLlovidos[contador];

            //    }


            //}
            //Console.WriteLine("El día que menos lluvia cayó fue el " + diaMenosLluviosoLetras + "\nEl día que más lluvia cayó fue el " + diaMasLluviosoLetras + "\nEl promedio de lluvia caída fue: " + (promedio/7) + " mililítros") ;
            //Console.ReadKey();

            // EJERCICIO NUMERO 6 (Numeros entre N y NU)<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //double numero1, numero2, cantidadDeNumerosIntermedios;
            //string numerosIntermedios;
            //numerosIntermedios = "";
            //cantidadDeNumerosIntermedios = 0;
            //Console.WriteLine("Digite el primer número: ");
            //numero1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite el segundo número: ");
            //numero2 = Convert.ToDouble(Console.ReadLine());
            //for (double i = numero1; i < numero2; i++)
            //{
            //    if (i > numero1 && i < numero2)
            //    {
            //        cantidadDeNumerosIntermedios += 1;
            //        numerosIntermedios += i + ".";
            //    }
            //}
            //Console.WriteLine("La cantidad de números intermedios son: " + cantidadDeNumerosIntermedios  + "\nLa los números intermedios son: "+ numerosIntermedios);
            //Console.ReadKey();

            // EJERCICIO NUMERO 7 (Ingresar y procesar 10 números)<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            //double numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8,
            //    numero9, numero10, resultadoPositivo, resultadoNegativo;

            //resultadoPositivo = 0;
            //resultadoNegativo = 0;

            //List<double> listaDeNumeros = new List<double>();

            //Console.WriteLine("Ingrese el primer número: ");
            //numero1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el segundo número: ");
            //numero2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el tercer número: ");
            //numero3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el cuarto número: ");
            //numero4 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el quinto número: ");
            //numero5 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el sexto número: ");
            //numero6 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el séptimo número: ");
            //numero7 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el octavo número: ");
            //numero8 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el noveno número: ");
            //numero9 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ingrese el décimo número: ");
            //numero10 = Convert.ToDouble(Console.ReadLine());

            //listaDeNumeros.Add(numero1);
            //listaDeNumeros.Add(numero2);
            //listaDeNumeros.Add(numero3);
            //listaDeNumeros.Add(numero4);
            //listaDeNumeros.Add(numero5);
            //listaDeNumeros.Add(numero6);
            //listaDeNumeros.Add(numero7);
            //listaDeNumeros.Add(numero8);
            //listaDeNumeros.Add(numero9);
            //listaDeNumeros.Add(numero10);

            //foreach (double numero in listaDeNumeros)
            //{
            //    if (numero > 0)
            //    {
            //        resultadoPositivo += numero;
            //    }
            //    if (numero < 0)
            //    {
            //        resultadoNegativo *= numero;
            //    }
            //    if (numero == listaDeNumeros[9])
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("El resultado de los numeros positivos es: " + resultadoPositivo + "\nEl resultado de los números negativos es: " + resultadoNegativo);
            //Console.ReadKey();





        }
    }
}
