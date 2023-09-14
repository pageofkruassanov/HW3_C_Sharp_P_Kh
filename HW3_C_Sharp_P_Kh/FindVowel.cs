using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_C_Sharp_P_Kh
{
    public class FindVowel
    {
        private char[] _str;
        private char[] _vowelSymbols;

        public FindVowel(string str)
        {
            const int SIZE_VOWELS = 20;
            this._str = str.ToCharArray();
            _vowelSymbols = new char[SIZE_VOWELS];
            _vowelSymbols[0] = 'а';
            _vowelSymbols[1] = 'у';
            _vowelSymbols[2] = 'о';
            _vowelSymbols[3] = 'и';
            _vowelSymbols[4] = 'э';
            _vowelSymbols[5] = 'ы';
            _vowelSymbols[6] = 'я';
            _vowelSymbols[7] = 'ю';
            _vowelSymbols[8] = 'е';
            _vowelSymbols[9] = 'ё';
            _vowelSymbols[10] = 'А';
            _vowelSymbols[11] = 'У';
            _vowelSymbols[12] = 'О';
            _vowelSymbols[13] = 'И';
            _vowelSymbols[14] = 'Э';
            _vowelSymbols[15] = 'Ы';
            _vowelSymbols[16] = 'Я';
            _vowelSymbols[17] = 'Ю';
            _vowelSymbols[18] = 'Е';
            _vowelSymbols[19] = 'Ё';
        }

        public int GetAmountOfVowels()
        {
            int amount = 0;
            for(int i = 0; i < _str.Length; i++)
            {
                for(int j = 0; j < _vowelSymbols.Length;j++)
                {
                    if (_str[i] == _vowelSymbols[j])
                    { 
                        amount++; 
                    }
                }
            }
            return amount;
        }

    }
}
