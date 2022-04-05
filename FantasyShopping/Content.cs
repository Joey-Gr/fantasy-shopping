using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FantasyShopping
{
    class Content
    {
        public static void Index(int progress)
        {
            switch (progress)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;

                default:
                    Console.WriteLine("Error");
                    Thread.Sleep(3000);
                    Game.End();
                    break;
            }

        } 
    }
}
