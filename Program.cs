using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> listaoperadores = new List<int>();
			Console.WriteLine($"Empezamos con {listaoperadores.Count} elementos.");

			int Nuevovalor = 0;

			do
			{
				Console.WriteLine($"Ingrese número de operador {listaoperadores.Count}. Presione 0 para finalizar.");
				bool ok = false;
				while (!ok)
				{
					string ingreso = Console.ReadLine();
					ok = int.TryParse(ingreso, out Nuevovalor);
					if (!ok)
					{
						Console.WriteLine("No ha ingresado un entero válido");
					}
					else if (Nuevovalor == 0)
					{
						break;
					}
					else
					{
						listaoperadores.Add(Nuevovalor);
						break;
					}
				}
			}
			while (Nuevovalor != 0);

			List<int> listaordenes = new List<int>();
			Console.WriteLine($"Empezamos con {listaordenes.Count} elementos.");

			int Nuevovalor1 = 0;

			do
			{
				Console.WriteLine($"Ingrese numero de órdenes de trabajo {listaordenes.Count}. Presione 0 para finalizar.");
				bool ok1 = false;
				while (!ok1)
				{
					string ingreso1 = Console.ReadLine();
					ok1 = int.TryParse(ingreso1, out Nuevovalor1);
					if (!ok1)
					{
						Console.WriteLine("No ha ingresado un entero válido");
					}
					else if (Nuevovalor1 == 0)
					{
						break;
					}
					else
					{
						listaordenes.Add(Nuevovalor1);
						break;
					}
				}
			}
			while (Nuevovalor1 != 0);
						
			for (int indice = 0; indice < listaoperadores.Count; indice++)
            {
				Console.WriteLine($"Operador {indice}: {listaoperadores[indice]}");
            }
			for (int indice = 0; indice < listaordenes.Count; indice++)
			{
				Console.WriteLine($"Órden {indice}: {listaordenes[indice]}");
			}

			int Nuevovalor2 = 0;
			do
			{
				Console.WriteLine($"Ingrese número de operador.");
				bool ok1 = false;
				while (!ok1)
				{
					string ingreso1 = Console.ReadLine();
					ok1 = int.TryParse(ingreso1, out Nuevovalor2);
					if (!ok1)
					{
						Console.WriteLine("No ha ingresado un entero válido");
					}
					else
							Console.WriteLine($"Le corresponde la orden: { listaordenes.Count}");
				}
			}while (Nuevovalor2 != 0);
			
		}
	}
}
