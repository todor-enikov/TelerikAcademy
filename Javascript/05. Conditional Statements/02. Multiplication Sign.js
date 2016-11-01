function solve(Args){
    var a =+Args[0];
    var b =+Args[1];
    var c =+Args[2];
    var result = a*b*c;

    if (result<0) {
         console.log('-');     
    }
    else if (result>0) {
         console.log('+');             
    }    
    else{
         console.log('0');             
    }
}

 solve(["5,5","4,5","3,2"]);