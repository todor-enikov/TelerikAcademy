function solve(Args) {
    var number = +Args[0];
    var thirdDigit = Math.floor(number/100);
    var digit = thirdDigit%10;
    if (digit===7) {
        console.log('true');
    }
    else{
        console.log('false ' + digit);
    }  
}