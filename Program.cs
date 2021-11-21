using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;





namespace Tre_Case_i_Progammering
{
    class Program
    {
        static void Main(string[] args)
        { // Køre login metoden indtil at man skriver brugernavn og adgangskoden rigtig 
            int n = 0;
            TextFileClass File = new TextFileClass();
            Input Inputclass = new Input();
            for (int i = 0; i == n;)
            {
                
                string YouCanPass = File.Readfile(Inputclass.loginUsername(), Inputclass.getPasswordLogin());
                Console.WriteLine(YouCanPass);
                if (YouCanPass == "Der er ikke et Brugernavnet eller Passwordet angivet i Nu")
                {
                    File.textFile(Inputclass.GetNewUsername(), Inputclass.GetNewPassword());
                    i = 1;
                }
               else if (YouCanPass == "Succes")
                {
                    Console.Clear();
                    i = 1;
                }
                
            }
            // Køre et menu loop uendeligt ind til at brugeren siger stop eller lukker programmet 
            for (int menuLoop= 0; menuLoop == n;)
            {
                // Input Inputclass = new Input();// GetMenunow();
                var Menu = Inputclass.GetMenunow();
                if (Menu == 1)
                {
                    int Passes = Inputclass.Aflevering();
                    bool Goal = Inputclass.GoaleOrNoGoal();
                    Fodbold CelebrationlevelVærdi = new Fodbold();        
                  Console.WriteLine(CelebrationlevelVærdi.CelebrationLevel(Goal,Passes));

                }
                else if (Menu==2)

                {
                    for(int i = 0; i == 0;)
                    {
                        string UserName = Inputclass.GetNewUsername();

                        string password = Inputclass.GetNewPassword();
                        string Result = File.textFile(UserName, password);
                        Console.WriteLine(Result);
                        if (Result == "Sucess")
                        {
                            i = 1;
                        }
                       
                    }
                   

                }
                else if (Menu == 3)
                {   //Får navnet og karakteren for personen og sender det til dance klassen
                    Dance Number1 = new Dance(Inputclass.GetDancersName(), Inputclass.GetDancersGrade());
                    Dance Number2 = new Dance(Inputclass.GetDancersName(), Inputclass.GetDancersGrade());
                    //Modtager det tilbage og gemmer resultatet i result
                    Dance result = Number1 + Number2;
                    // Udskriver resultatet på skærmen
                    Console.WriteLine(result.Name + result.SecondNumber);
                }
                else if (Menu == 4)
                {
                    for (string i = ""; i != "Succes";)
                    {
                        string Result = File.Readfile(Inputclass.loginUsername(), Inputclass.getPasswordLogin());
                    Console.WriteLine(Result);
                     if (Result == "Succes")
                        {
                            i = Result;
                        }
                       else if (Result == "Der er ikke et Brugernavnet eller Passwordet angivet i Nu")
                        {
                           File.textFile(Inputclass.GetNewUsername(), Inputclass.GetNewPassword());
                            break;
                        }
                       
                    }
                  

                }
                else if (Menu == 5)
                {
                    break;
                }
                
            }
            

        }
      
       
       
    }
}
