function solve(Args){
    var a =+Args[0];
    var b =+Args[1];
    var c =+Args[2];

    if (a>=b&&a>=c) {
        if (b>c) {
            console.log(a +" "+ b +" "+ c);     
        }
        else if (c>=b) {
            console.log(a +" "+ c +" "+ b);  
        }
    }
    else if (b>=a&&b>=c) {
        if (a>=c) {
            console.log(b +" "+ a +" "+ c);     
        }
        else if (c>a) {
            console.log(b +" "+ c +" "+ a);  
        }
    } 
    else if (c>=b&&c>=a) {
        if (a>=b) {
            console.log(c +" "+ a +" "+ b);     
        }
        else if (b>a) {
            console.log(c +" "+ b +" "+ a);  
        }
    }
}

 solve(["-2","4","3"]);