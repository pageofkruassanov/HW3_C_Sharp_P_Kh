using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_C_Sharp_P_Kh
{
    public class AmountOf
    {
        private int[] _array;
        public AmountOf(int[] arr) 
        {
            _array = arr;
        }

        public int GetAmountOfPairNumbers() 
        {
            int amount = 0;
            for(int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 == 0)
                    amount++;
            }
            return amount; 
        }

        public int GetAmountOfUnpairedNumbers()
        { 
            int amount = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 == 1)
                    amount++;
            }
            return amount;
        }
        
        public int GetAmountOfUniqueNumbers()
        {
            int amount = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                bool isReapeat = false;
                for(int j = 0; j < _array.Length; j++)
                {
                    if(i == j)
                    {
                        j++;
                        continue;
                    }    
                    if (_array[i] == _array[j] )
                    {
                        isReapeat = true;
                        break;
                    }
                }
                if (!isReapeat)
                    amount++;
            }
            return amount;
        }

    }
}
