function solve(Args){
    var input = Args[0].split('\n');
    var firstCharArray = new Array(input[0]);
    var secondCharArray = new Array(input[1]);
    var counter = 0;

        if (firstCharArray.length > secondCharArray.length)
        {
            console.log('>');
        }
        else if (firstCharArray.length < secondCharArray.length)
        {
            console.log('<');
        }
        else
        {
            for (var i = 0; i < firstCharArray.length; i+=1)
            {
                if (firstCharArray[i] > secondCharArray[i])
                {
                    console.log('>');
                    break;
                }
                else if (firstCharArray[i] < secondCharArray[i])
                {
                    console.log('<');
                    break;
                }
                else if (firstCharArray[i] === secondCharArray[i])
                {
                    counter++;
                    if (counter === firstCharArray.length)
                    {
                        console.log('=');
                    }
                }

            }
        }
}

 solve(["food\nfood"]);

//  string firstArray = Console.ReadLine();
//         char[] firstCharArray = firstArray.ToCharArray();
//         string secondArray = Console.ReadLine();
//         char[] secondCharArray = secondArray.ToCharArray();
//         int counter = 0;

//         if (firstCharArray.Length > secondCharArray.Length)
//         {
//             Console.WriteLine(">");
//         }
//         else if (firstCharArray.Length < secondCharArray.Length)
//         {
//             Console.WriteLine("<");
//         }
//         else if (firstCharArray.Length == secondCharArray.Length)
//         {
//             for (int i = 0; i < Math.Min(firstCharArray.Length, secondCharArray.Length); i++)
//             {
//                 if (firstCharArray[i] > secondCharArray[i])
//                 {
//                     Console.WriteLine(">");
//                     break;
//                 }
//                 else if (firstCharArray[i] < secondCharArray[i])
//                 {
//                     Console.WriteLine("<");
//                     break;
//                 }
//                 else if (firstCharArray[i] == secondCharArray[i])
//                 {
//                     counter++;
//                     if (counter == firstCharArray.Length)
//                     {
//                         Console.WriteLine("=");
//                     }
//                 }

//             }