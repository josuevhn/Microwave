using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave
{

    class MessageService
    {

        private Cook cook;

        public MessageService(Cook currentCook) {

            cook = currentCook;

            cook.timeoutEvent += OnTimeout;

        } // Constructor

        public int showMenu()
        {

            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("Seleccione una función a ejecutar: ");

            Console.WriteLine();

            Console.WriteLine("1 - Defrost.");
            Console.WriteLine("2 - Keep Warm.");
            Console.WriteLine("3 - Finalizar.");

            Console.WriteLine();

            Console.Write("Opción: ");

            return int.Parse(Console.ReadLine().ToString());

        } // showMenu

        public void OnTimeout(object source, TimeoutEventArgs args)
        {

            Console.WriteLine();

            Console.WriteLine(String.Format("{0}: Finalizado!!!", args.function));

            Console.WriteLine();

            Console.WriteLine("Presione una tecla para continuar!");

            Console.ReadKey();

        } // OnTimeout

    } // MessageService

} // Microwave
