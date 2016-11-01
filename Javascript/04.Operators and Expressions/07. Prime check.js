function solve(Args){
    var number =+Args[0];
    var divider = 2;
    var isPrime = true;
    if (number<=1) {
            isPrime=false;
    }
    while (divider<number) {
        if (number%divider===0) {
               isPrime=false;
               break;           
        }
        divider++;
    }
    console.log(isPrime);
}

 solve(["2"]);
 solve(["23"]);
 solve(["-3"]);
 solve(["0"]);
 solve(["1"]);

 

