using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_C_Sharp_P_Kh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1:
            const int SIZE_ARR = 200;
            int[] arrayOfNum = new int[SIZE_ARR];
            Random rnd = new Random();
            for (int i = 0; i < SIZE_ARR; i++)
            {
                arrayOfNum[i] = rnd.Next(0, 10000);
            }
            AmountOf amount = new AmountOf(arrayOfNum);
            Console.WriteLine($"Количество парных чисел в массиве: {amount.GetAmountOfPairNumbers()} \nКоличество непарных чисел: {amount.GetAmountOfUnpairedNumbers()} \nКоличество уникальных чисел: {amount.GetAmountOfUniqueNumbers()}\n\n");

            // Task 5: completed! (Выполнил на паре, отправлю отдельно ссылку на репозиторий на гитхабе)

            // Task 8:

            string someStr = "Привет, меня зовут Паша"; // 8 гласных
            FindVowel fVowels = new FindVowel(someStr);
            Console.WriteLine($"Срока: {someStr}\nКол-во гласных звуков: {fVowels.GetAmountOfVowels()}");
            Console.ReadLine();

        }
    }
}
