function solve(Args){
    var input = Args[0].split(' ');
    var firstNumber = +input[0],
        secondNumber = +input[1],
        thirdNumber = +input[2],
        currentResult = GetMax(firstNumber,secondNumber),
        finalResult = GetMax(currentResult,thirdNumber);
        console.log(finalResult);
    function GetMax(firstNumber, secondNumber) {
        return Math.max(firstNumber,secondNumber);
    }
}

 solve(['8 3 6']);