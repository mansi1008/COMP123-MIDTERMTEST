using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MIDTERMTEST
{
    /**
     * <summary>
     * 
     * The driver class is here.
     * 
     *</summary>
     * 
     * @class Program
     */
    public class Program
    {
        // Instantiate lotto649 object
        static Lotto649 lotto649 = new Lotto649();
        // Instantiate lottoMax object
        static LottoMax lottoMax = new LottoMax();

        /**
         * @static
         * @method Main
         * @returns {void}
         */
        public static void Main(string[] args)
        {
            // Calling the Menu
            LottoMenu();
        }

        /**
         * <summary>
         * 
         *  The user is allowed to chooose a Lotto game for execution of a console menu created by this utility method.
         *  
         * </summary>
         * 
         * @static
         * @method LottoMenu
         * @returns {void}
         */
        public static void LottoMenu()
        {
            // declare a variable to record if menu is active
            bool menuActive = true;

            // While the menu is active...loop
            while (menuActive)
            {
                // show options in the console menu
                Console.WriteLine("+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+");

                Console.WriteLine("\n\t MAKE YOUR SELECTION ");
                Console.WriteLine("\n 1. LOTTO 6/49");
                Console.WriteLine(" 2. LOTTO MAX");
                Console.WriteLine(" 3. LEAVE");

                Console.WriteLine("\n+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+");

                // read the user selection
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // The "1" Key for selecting LOTTO 6 / 49
                        Console.Clear();
                        Console.WriteLine(" + LOTTO 6/49 ++++++++++++++++++++++++++");
                        lotto649.GenerateLottoNumbers();

                        Console.WriteLine("\n+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+");

                        Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2: // The "2" Key for selecting LOTTO MAX
                        Console.Clear();
                        Console.WriteLine(" + LOTTO MAX +++++++++++++++++++++++++++");
                        lottoMax.GenerateLottoNumbers();
                        Console.WriteLine("\n +_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+");
                        Console.WriteLine("\nPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3: // The "3" Key to exit the menu
                        menuActive = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}