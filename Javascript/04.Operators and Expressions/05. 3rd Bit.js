function solve(Args) {
    var number =+Args[0];
    var mask = 1<<3;
    if ((number&mask)===0) {
        console.log('0');                
    }
    else{
        console.log('1');                
    }
}

solve(["15"]);
solve(["1024"]);
