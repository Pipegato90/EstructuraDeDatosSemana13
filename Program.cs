using System;  
using System.Collections.Generic;  
using System.Linq;  
  
namespace CatalogoRevistas  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            // 1. Crear un catálogo de revistas (lista de strings)  
            List<string> catalogoRevistas = new List<string>()  
            {  
                "National Geographic",  
                "Time",  
                "Forbes",  
                "Science",  
                "Nature",  
                "Wired",  
                "The Economist",  
                "Harvard Business Review",  
                "Sports Illustrated",  
                "Vogue"  
            };  
  
            // 2. Menú interactivo  
            bool continuar = true;  
            while (continuar)  
            {  
                Console.WriteLine("\n--- Catálogo de Revistas ---");  
                Console.WriteLine("1. Buscar un título");  
                Console.WriteLine("2. Mostrar catálogo");  
                Console.WriteLine("3. Salir");  
                Console.Write("Seleccione una opción: ");  
  
                string opcion = Console.ReadLine();  
  
                switch (opcion)  
                {  
                    case "1":  
                        BuscarTitulo(catalogoRevistas);  
                        break;  
                    case "2":  
                        MostrarCatalogo(catalogoRevistas);  
                        break;  
                    case "3":  
                        continuar = false;  
                        Console.WriteLine("Saliendo...");  
                        break;  
                    default:  
                        Console.WriteLine("Opción inválida. Intente nuevamente.");  
                        break;  
                }  
            }  
  
            Console.ReadKey();  
        }  
  
        // Método para buscar un título en el catálogo (Iterativo)  
        static void BuscarTitulo(List<string> catalogo)  
        {  
            Console.Write("Ingrese el título de la revista a buscar: ");  
            string tituloBuscado = Console.ReadLine();  
  
            // Búsqueda iterativa (Lineal)  
            bool encontrado = false;  
            foreach (string titulo in catalogo)  
            {  
                if (titulo.ToLower() == tituloBuscado.ToLower()) // Comparación sin distinción de mayúsculas/minúsculas  
                {  
                    encontrado = true;  
                    break;  
                }  
            }  
  
            // Mostrar el resultado de la búsqueda  
            if (encontrado)  
            {  
                Console.WriteLine("Encontrado");  
            }  
            else  
            {  
                Console.WriteLine("No encontrado");  
            }  
        }  
  
        // Método para mostrar el catálogo de revistas  
        static void MostrarCatalogo(List<string> catalogo)  
        {  
            Console.WriteLine("\nCatálogo de Revistas:");  
            for (int i = 0; i < catalogo.Count; i++)  
            {  
                Console.WriteLine($"{i + 1}. {catalogo[i]}");  
            }  
        }  
  
        //Implementación de Búsqueda recursiva (Opcional, como alternativa al método iterativo)  
        //static bool BuscarTituloRecursivo(List<string> catalogo, string tituloBuscado, int indice = 0)  
        //{  
        //    if (indice >= catalogo.Count)  
        //    {  
        //        return false; // No se encontró el título  
        //    }  
  
        //    if (catalogo[indice].ToLower() == tituloBuscado.ToLower())  
        //    {  
        //        return true; // Se encontró el título  
        //    }  
  
        //    return BuscarTituloRecursivo(catalogo, tituloBuscado, indice + 1); // Llamada recursiva con el siguiente índice  
        //}  
  
  
        //Ejemplo de uso con LINQ (opcional, para demonstrar alternativas)  
        //static void BuscarTituloLINQ(List<string> catalogo)  
        //{  
        //    Console.Write("Ingrese el título de la revista a buscar: ");  
        //    string tituloBuscado = Console.ReadLine();  
  
        //    bool encontrado = catalogo.Any(titulo => titulo.ToLower() == tituloBuscado.ToLower());  
  
        //    if (encontrado)  
        //    {  
        //        Console.WriteLine("Encontrado (usando LINQ)");  
        //    }  
        //    else  
        //    {  
        //        Console.WriteLine("No encontrado (usando LINQ)");  
        //    }  
        //}  
    }  
}  