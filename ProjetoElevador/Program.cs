using ProjetoElevador.Models;
using ProjetoElevador.Controllers;
using System;

namespace ProjetoElevador
{
 static class Program
    {
        static void Main(string[] args)
        {
            
            var controllerElevador = new ElevadorController();

            controllerElevador.Initial();
        }
    }
}
