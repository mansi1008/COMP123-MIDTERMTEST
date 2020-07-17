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
      * Here this class is subclass of the LottoGame abstract superclass
      * 
      * </summary>
      * 
      * @class Lotto649
      */
    public class Lotto649 : LottoGame, IGenerateLottoNumbers
    {
        // CONSTRUCTORS +_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+_+

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
        public Lotto649()
            : base(6, 49)
        {

        }

        // CREATING the public GenerateLottoNumbers method here  -----------------------------------------------------
        public void GenerateLottoNumbers()
        {

            for (int i = 0; i < 6; i++)
            {
                this.PickElements();
                Console.Write($"TICKET   {i}= ");
                Console.WriteLine(ToString());
            }

        }
    }
}
