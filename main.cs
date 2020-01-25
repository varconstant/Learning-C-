using System;

class MainClass {
  public static void Main (string[] args) {
      //make a array of strings 
      string[] hangman = {"APPLEPIE", "PINEAPPLE", "CARPENTER", "AMSTERDAM", "LONDON", "BEAUTIFUL", "JEOPARDIZE", "CONSEQUENCES", "WONDERFUL"};
      //take a string out of it
      Random generator = new Random();
      
      do{
          int pos = generator.Next(0,hangman.Length);
          string randomString = hangman[pos];

          string astString = "";
          foreach(var i in randomString){
            astString+='*';
          }
          int astLeft=astString.Length;
          char[] astStringArray = astString.ToCharArray();
          Console.WriteLine();
          Console.WriteLine("Let's Start the Game");
          int attemptCount=0;
          while(astLeft>0){
            Console.WriteLine("Choose your character");
            char character = char.Parse(Console.ReadLine().ToUpper());
            attemptCount++;
            bool guess=false;
            for(int i=0; i<randomString.Length; i++){
              if(randomString[i]==character){
                guess=true;
                // astString[i]=character;
                astStringArray[i]=character;
                astLeft--;
              }
            }
            if(guess){
              Console.WriteLine($"Wow, you were right, the string is {new String(astStringArray)}");
            }
            else{
              Console.WriteLine("oho that was an incorrect guess");
            }
            guess=false;
          }
          Console.WriteLine();
          Console.WriteLine($"Great, You found all the characters in {attemptCount} guesses" );
          attemptCount=0;
          Console.WriteLine();
          Console.WriteLine("Do You waana play the game again reply 1 for yes 0 for no");
      }while(Console.ReadLine()=="1");
      
  }
}