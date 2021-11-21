using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary1
{
    public class Password
    {// lægger alle boolsne fra de andre metoder sammen og hvis de er sande er Adgangskoden godkendt
        public bool getpassword(string password)
        {

            bool PasswordVerified = false;


            string[] passwordsingelcarekters = new string[password.Length];
            for (int i = 0; i < password.Length; i++)
            {
                passwordsingelcarekters[i] = password.Substring(i, 1);
            }
            bool lengthPasswordsuccessful = LengthPassword(password);
            bool UppercaseAndLowercasesuccessful = UppercaseAndLowercase(password, passwordsingelcarekters);
            bool SpecialCarekterssuccessful = SpecialCarekters(passwordsingelcarekters);
            bool Numberssuccessful = Numbers(passwordsingelcarekters, password);
            bool CheckSpacesuccessful = CheckSpace(password);
            
            if (lengthPasswordsuccessful && UppercaseAndLowercasesuccessful && SpecialCarekterssuccessful && Numberssuccessful && CheckSpacesuccessful)
            {
                PasswordVerified = true;
            }
            return PasswordVerified;

        }
        // Tjekker om adgangskoden er lang nok 
        public bool LengthPassword(string password)
        {
            bool Verifiedpassword = false;

            if (password.Length >= 12)
            {
                Verifiedpassword = true;
            }
            return Verifiedpassword;
        }
        // Tjekker om Adgangskoden har store og små bogstaver og retunere resultatet
        public bool UppercaseAndLowercase(string password, string[] passwordsingelcarekteres)
        {
            bool VerifiedUppperAndLower = false;
            bool HigherVerified = false;
            bool LowerVerified = false;
            for (int i = 0; i < password.Length; i++)
            {

                if (char.IsUpper(Convert.ToChar(passwordsingelcarekteres[i])) == true)
                { HigherVerified = true; }
                if (char.IsLower(Convert.ToChar(passwordsingelcarekteres[i])) == true)
                { LowerVerified = true; }



            }
            if (HigherVerified == true && LowerVerified == true)
            {
                VerifiedUppperAndLower = true;
            }
            return VerifiedUppperAndLower;

        }
        //Tjekker om der specialekarakter og tal i adgangskoden og retunere resultatet
        public bool SpecialCarekters(string[] passwordsingelcarekteres)
        {
            string[] Numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] specialThings = { "!", "%", "#","&"};
            bool SpecialCarektersVerified = false;
            bool NumbersVerified = false;
            bool SpecialCarektersAndNumbersVerified = false;
            for (int i = 0; i < passwordsingelcarekteres.Length; i++)
            {
                var ArraySpecialCheck = Array.Find<string>(specialThings, Element => Element == passwordsingelcarekteres[i]);
                if (ArraySpecialCheck == passwordsingelcarekteres[i])
                {
                    SpecialCarektersVerified = true;
                }
                var ArrayNumbersCheck = Array.Find<string>(Numbers, Element => Element == passwordsingelcarekteres[i]);
                if (ArrayNumbersCheck == passwordsingelcarekteres[i])
                {
                    NumbersVerified = true;
                }
                if(SpecialCarektersVerified && NumbersVerified)
                {
                    SpecialCarektersAndNumbersVerified = true;
                }
            }
            return SpecialCarektersAndNumbersVerified;

        }
        // Tjekker om der tal i starten eller slutningen af adgangskoden og returnere resultatet
        public bool Numbers(string[] passwordsingelcarekteres, string password)
        {
            string[] Numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            
            bool StartVithNumber = false;
            bool EndsVithNumber = false;
            bool resultVerified = false;
           
            
              
               
                for (int number = 0; number < Numbers.Length; number++)
                {
                    if (password.Substring(0, 1) == Numbers[number])
                    {
                        StartVithNumber = true;
                    }
                    if (passwordsingelcarekteres[password.Length - 1].Substring(0, 1) == Numbers[number])
                    {
                        EndsVithNumber = true;
                    }
                }


            
            if (StartVithNumber == false && EndsVithNumber == false)
            {
                resultVerified = true;
            }
            return resultVerified;

        }
        // Tjekker om der er mellemrum i Adgangskoden og returnere resultatet
        public bool CheckSpace(string password)
        { bool SpaceVerified = true;
            for(int i = 0; i < password.Length; i++)
            {
             int SpaceIndex = password.IndexOf(' ');
                if (SpaceIndex != -1)
                {
                    SpaceVerified = false;
                }
            }
            return SpaceVerified;
           

        }

       

    }
}
