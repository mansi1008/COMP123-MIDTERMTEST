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
   * This class is a subclass of the LottoGame abstract superclass.
   * 
   * </summary>
   * 
   * @class LottoMax
   */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * 
         * Here is the constructor which satisfifies the base constructor requirements by sending the elementNumber and setSize 
         * and donot take any parameters.
         * 
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            : base(7, 49)
        {

        }

        // CREATING the public GenerateLottoNumbers method here ------------------------------
        public void GenerateLottoNumbers()
        {
            for (int i = 0; i < 7; i++)
            {
                this.PickElements();
                Console.Write($"TICKET   {i}= ");
                Console.WriteLine(ToString());
            }
        }
    }
}
