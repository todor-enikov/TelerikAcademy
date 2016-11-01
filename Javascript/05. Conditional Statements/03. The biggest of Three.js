function solve(Args){
    var a =+Args[0];
    var b =+Args[1];
    var c =+Args[2];

    if (a>=b&&a>=c) {
         console.log(a);     
    }
    else if (b>=a&&b>=c) {
         console.log(b);             
    }    
    else if (c>=a&&c>=b) {
         console.log(c);                     
    }
}

 solve(["-2","4","3"]);