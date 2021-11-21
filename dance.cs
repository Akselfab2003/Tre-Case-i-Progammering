using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
  public class Dance
    {   // Bestemmer de to parametere for operator
        public string Name = "";
        public int SecondNumber = 0;
        // overbelaster operatoren
        public Dance(string name ,int secondNumber)
        {
            Name = name;
            SecondNumber = secondNumber;
        }
        // Tager de 2 object altså Name og SecondNumber og lægger dem sammen og returnere dem i en nyt object resultat   
        public static Dance operator +(Dance Number1 , Dance Number2)
        {
            Dance rectResult = new Dance(Number1.Name +" & "+ Number2.Name +" ",  Number1.SecondNumber + Number2.SecondNumber);
            return rectResult;

        }
       
    }
}



       
