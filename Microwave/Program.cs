using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave
{

    class Program
    {

        static void Main(string[] args)
        {

            Cook cook = new Cook(); // Emisor

            MessageService messageService = new MessageService(cook); // Suscriptor

            bool finalizar = false;

            while (!finalizar)
            {

                int function = messageService.showMenu();

                switch (function)
                {

                    case 1:

                        cook.askForTime();

                        cook.defrost();

                        break;

                    case 2:

                        cook.askForTime();

                        cook.keepWarm();

                        break;

                    case 3:

                        finalizar = true;

                        break;

                    default:

                        continue;

                } // switch

            } // while

            Console.WriteLine();

            Console.WriteLine("Presione una tecla para salir!");

            Console.ReadKey();

        } // Main

    } // Program

} // Microwave
