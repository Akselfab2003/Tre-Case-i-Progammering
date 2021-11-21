using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tre_Case_i_Progammering
{
   public class Input
    {//Skriver Menu og retunerer brugerens svar 
         public int GetMenunow()
        {
            Console.Write("[1] for Fodbold [2] for At Ændre login [3] for Danse konkurrence [4] for Login [5] for at Afslutte ---->");
            int menu = Convert.ToInt32(Console.ReadLine());
           return menu;
        }
        //læser en linje og sender inhold tilbage
         public int Aflevering()
        {
            Console.Write("Hvor mange afleveringer var der? ---->");
            int Afleveringer = Convert.ToInt32(Console.ReadLine());
            return Afleveringer;
        }
       //Spørg om der er mål?
        public  bool GoaleOrNoGoal()
        {
            Console.Write("Var der mål? Skriv mål hvis der var mål ellers skriv Nej ---->");

            string Goalinput = Console.ReadLine();
            bool Goal = false;
            if (Goalinput.ToLower() == "mål")
            {
                Goal = true;
            }
            else { Goal = false; }
            return Goal;
        }
        // Får navnet fra personen til danse konkurrencen og retunere det
        public  string GetDancersName()
        {
            Console.Write("Hvad er dit navn? ---->");
            string Name = Console.ReadLine();
            return Name;
        }
        // Får karakteren fra person til danse konkurrencen og retunere det
        public  int GetDancersGrade()
        {
            Console.Write("Hvad var Karekteren? ---->");
            int Grade = Convert.ToInt32(Console.ReadLine());
            return Grade;
        }
        //Får passwordet til login
        public  string getPasswordLogin()
        {
            Console.Write("Skriv password --->");
         string password=   Console.ReadLine();
            return password;
        }
        //Får det nye Username
        public  string GetNewUsername()
        {
            Console.Write("Skriv dit nye brugernavn --->");
            string UserName = Console.ReadLine();
            return UserName;
        }
        //Får det nye password
        public  string GetNewPassword()
        {
           
            Console.Write("Skriv dit nye password ----->");
            string password = Console.ReadLine();
            return password;
        }
        //Får Usernamet til login
         public string loginUsername()
        {
            Console.Write("Hvad er dit brugernavn? ---->");
            string Username = Console.ReadLine();
            return Username;
        }

    }
}
