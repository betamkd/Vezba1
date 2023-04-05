using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba1
{
    public class Functions
    {
        // Function 1                                    // "1" ili "text1"
        public bool IsNumber(string imeNaVlezenParametarString)
        {
            // mesto za logika da proveri dali vlezniot parametar e number ili ne e
            int _imeNaVlezenParametarString;
            bool checkIfItsNumber = int.TryParse(imeNaVlezenParametarString, out _imeNaVlezenParametarString);

            return checkIfItsNumber;
        }


        // Function 2
        public void TestMethod()
        {
            // method/funkcija koja sto pravi nesto i nisto ne vrakja
            Console.WriteLine("Test Method za Void funkcija koja sto nisto ne vrakja!");
        }


        // Function 3
        // ...
        // ... 
        // ...

        //public void TestMethod(int number)
        //{
        //	// method/funkcija koja sto pravi nesto i nisto ne vrakja

        //}

        // od string vo integer                         // "2"
        public int ConvertFromStringToInteger(string valueimeNaVlezenParametarString)
        {        //2                    // "2"
            var result = int.Parse(valueimeNaVlezenParametarString);
            //2
            return result;
        }

        // proveri dali ocenkata e 5
        public bool CheckIfItsFive(int checkNumber)
        {
            if (checkNumber == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
