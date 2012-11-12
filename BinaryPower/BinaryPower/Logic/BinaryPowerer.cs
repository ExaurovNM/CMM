using System;

namespace BinaryPower.Logic
{
    public class BinaryPowerer
    {
        public int Rize(int baseValue, int index, int mod)
        {
            // check inputs 

            if (index < 0 )
            {
                throw new ArgumentException(string.Format("Invalid index {0}", index));
            }

            if (mod <= 0)
            {
                throw new ArgumentException(string.Format("Invalid mod {0}", mod));
            }
            
            baseValue = baseValue % mod;

            return RizeToPower(baseValue, index, mod);
        }

        private int RizeToPower(int baseValue, int index, int mod)
        {
            int resault = 1;
            while (index != 0)
                if ( (index & 1) == 1)
                {
                    resault = (resault * baseValue) % mod;
                    index--;
                }
                else
                {
                    baseValue = (baseValue*baseValue) % mod;
                    index = index >> 1;
                }
            return resault;
        }
    }
}
