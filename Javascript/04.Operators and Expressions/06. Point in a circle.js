function solve(Args){
    var x =+Args[0];
    var y =+Args[1];
    var calculation = (x*x) + (y*y);
    var distance = Math.sqrt(calculation);
    if (distance>2) {
        console.log('no '+ distance.toFixed(2));                
    }
    else{
        console.log('yes '+ distance.toFixed(2));                
    }
}

 solve(["-2","0"]);

