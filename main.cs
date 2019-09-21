//Malinda Miller
//september 17 2019
//Hogwarts pets

using System;

class HogwartsPets  {
  static void Main() {


      string AnswerString;
      string AnswerString2;
      
      //only a yes or no input

    Console.WriteLine ("Congrats! You made it into Hogwarts, got assigned into your house, and now, you have a big decision to make. Which pet should you get? The rules say, you are allowed a cat, a rat, or an owl, but that's still a lot to decide. Well, I'm here to help. Please answer 'yes' or 'no' answers only.");

    Console.WriteLine ("Do you want a pet that's predominantly independent?");
    
    AnswerString = Console.ReadLine();
      if (AnswerString == "yes")
      {
        Console.WriteLine("Would you like a pet that's less cuddly, but more utilitarian?");
        AnswerString2 = Console.ReadLine();
            if (AnswerString2 == "yes")
            {Console.WriteLine ("You'd probably do best with an owl.");    }
            else if(AnswerString2 != "yes" || AnswerString2 != "no")
            {Console.WriteLine("Hey, ya squib. I said to type 'yes' or 'no' answers only. Don't throw a niffler in my gringotts. Start over.");
            }
            if (AnswerString2 == "no")
            {Console.WriteLine("Then a cat seems more up your alley. Hah, get it? Alley Cat?");
            }

            
      }
      else if  
      (AnswerString != "yes" || AnswerString != "no")
      {Console.WriteLine("Hey, ya squib. I said to type 'yes' or 'no' answers only. Don't throw a niffler in my gringotts. Start over.");  
      }

      

      if (AnswerString == "no")

        {
          Console.WriteLine("So, you want a pet that's less independent? How about one that's cuddly, playful, and totally not a creepy death eater in disguise?");
          AnswerString = Console.ReadLine();
        
          if (AnswerString == "yes")
          {Console.WriteLine("A rat! A better one than Scabbers.");
        
          }
          if (AnswerString == "no")
          {Console.WriteLine("Well, Neville had a frog, Dean had that tarantula, and Hagrid...don't be like Hagrid. How about a pet rock.");}

      }
  }
}
  
