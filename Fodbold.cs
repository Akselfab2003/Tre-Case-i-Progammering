using System;


namespace ClassLibrary1
{
    public class Fodbold
    {
        //returnerer hvad der skal skrives an på hvad brugeren har indtaste i Goal og i Passes
        public string CelebrationLevel(bool Goal, int Passes)
        {
            string text ="";
            if (Goal == true)
            {
                 text = ("Olé Olé Olé");

            }
            else if (Passes <= 1)
            {
                text = ("shh");
            }
            else if (Passes >= 10)
            {
                 text = ("High Five - jubel!!!");
            }
            else
            {   
                for(int i = 0; i < Passes; i++)
                {
                 text=text+"Huh!";
                }
                
            }
            return text;
        }
    

    }
   
}
