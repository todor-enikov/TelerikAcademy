function solve(Args){
    var a =+Args[0];
    var b =+Args[1];
    if (a>b) {
        var currentNumber=a;
        a=b;
        b=currentNumber;
    }    
    console.log(a +" "+ b);
}

 solve(["5,5","4,5"]);
//  solve(["23"]);
//  solve(["-3"]);
//  solve(["0"]);
//  solve(["1"]);

 