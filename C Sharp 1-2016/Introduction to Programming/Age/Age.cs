//Write a program that reads your birthday(in the format MM.DD.YYYY) 
//from the console and prints on the console how old you are you now and how old will you be after 10 years.
using System;

class Age
{
    static void Main()
    {
        string birthdayDate = Console.ReadLine();
        string[] birthdayArray = birthdayDate.Split('.');
        DateTime yourBirthdayDate = new DateTime(int.Parse(birthdayArray[2]), int.Parse(birthdayArray[0]), int.Parse(birthdayArray[1]));
        DateTime currentDate = DateTime.Now;

        int result = (int)(currentDate - yourBirthdayDate).TotalDays / 365;

        Console.WriteLine(result);
        Console.WriteLine(result + 10);
    }
}

   
        
            
  
    

