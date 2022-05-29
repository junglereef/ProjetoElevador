using System;
using ProjetoElevador.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Models;



namespace ProjetoElevador.Controllers
{
    internal class ElevadorController
    {
		//Inicialização do método
		public void Initial()
		{
			Console.WriteLine("*-*-Sejam Todos(as) bem-vindos -*-*");
			Console.WriteLine();
			Console.WriteLine("-->Quantos andares tem no edificio <--");
			Console.WriteLine();
			Console.WriteLine("Quantidade de andares");


			var andares = int.Parse(Console.ReadLine());
			Console.WriteLine();


			Console.WriteLine("-->Informe a capacidade de pessoas permitidas no elevador<--");
			Console.WriteLine();

			Console.WriteLine("Quantidades de pessoas permitidas");


			var capacidade = int.Parse(Console.ReadLine());


			Console.Clear();



			var elevador = new Elevador(capacidade, andares);


			var viewElevador = new ElevadorView();

			viewElevador.Projeto(elevador);

		}

	}
}
