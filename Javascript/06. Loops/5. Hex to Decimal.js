function solve(Args){
    var hexidecimalNumber = Args[0];
    var decimalNumber=0;
    var power = 1;
     for (var i = hexidecimalNumber.length-1; i >= 0; i--)
        {
            switch (hexidecimalNumber[i])
            {
                case 'A': decimalNumber += 10 * power; break;
                case 'B': decimalNumber += 11 * power; break;
                case 'C': decimalNumber += 12 * power; break;
                case 'D': decimalNumber += 13 * power; break;
                case 'E': decimalNumber += 14 * power; break;
                case 'F': decimalNumber += 15 * power; break;
                default: decimalNumber += (hexidecimalNumber[i] - '0') * power; break;
            }
            power *= 16;
        }
    console.log(decimalNumber);
}

 solve(['4ED528CBB4']);


        // long decimalNumber = 0;
        // long power = 1;
        // for (int i = hexNumber.Length - 1; i >= 0; i--)
        // {
        //     switch (hexNumber[i])
        //     {
        //         case 'A': decimalNumber += 10 * power; break;
        //         case 'B': decimalNumber += 11 * power; break;
        //         case 'C': decimalNumber += 12 * power; break;
        //         case 'D': decimalNumber += 13 * power; break;
        //         case 'E': decimalNumber += 14 * power; break;
        //         case 'F': decimalNumber += 15 * power; break;
        //         default: decimalNumber += (hexNumber[i] - '0') * power; break;
        //     }
        //     power *= 16;
        // }
        // Console.WriteLine(decimalNumber);