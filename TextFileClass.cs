using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ClassLibrary1
{
   public class TextFileClass
    { //Gemmer brugernavnet og adgangskoden i en text fil og ændre adgangskoden hvis brugeren vil og gemmer den nye adgangskode 
        public string textFile(string UserName, string password)
        {
            Password PasswordClass = new Password();

            var path = @"E:\File.txt";

            bool PasswordVerified = PasswordClass.getpassword(password);

            if (PasswordVerified == true && (password.ToLower() != UserName.ToLower()) == true)
            {

                StreamWriter Sw = new StreamWriter(path);
                Sw.Write(UserName + ":" + password);
                Sw.Close();

                return ("Sucess");
            }
            else
            {
                return ("Username eller password opfylder ikke kravnene");
            }





        }
        //Læser filen og tjekker om der er nogen brugernavne og adgangskoder i filen og sørger for at adgangskoden 
         public string Readfile(string loginUsername,string getPasswordLogin)
        {
            string Result = "";
            StreamReader sr = new StreamReader(@"E:\File.txt");
            int Linecount = File.ReadAllLines(@"E:\File.txt").Length;

            string[] Username = new string[Linecount];
            string[] password = new string[Linecount];
            string line = sr.ReadLine();
            sr.Close();
            if (Linecount == 0)
            {

                Result = "Der er ikke et Brugernavnet eller Passwordet angivet i Nu";
                return Result;
            }
            for (int i = 0; i < 1; i++)
            {
                string[] splitpasswordAndUsername = line.Split(':');
                Username[i] = splitpasswordAndUsername[0];
                password[i] = splitpasswordAndUsername[1];
            }
            string UsernameFromUserinput = loginUsername;
            var SearchArray = Array.FindIndex<string>(Username, element => element == UsernameFromUserinput);

            string PasswordUserInput = getPasswordLogin;

            
             if (SearchArray == -1 || PasswordUserInput != password[SearchArray])
            {

                Result = "Brugernavnet eller Passwordet er angivet forkert";

            }
            else if (PasswordUserInput == password[SearchArray])
            {
               Result = "Succes";
            }
            

            return Result;
           
        }
    }
}
