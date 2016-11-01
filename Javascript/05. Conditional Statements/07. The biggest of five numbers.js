function solve(Args) {
    var firstNumber = +Args[0];
    var secondNumber = +Args[1];
    var thirdNumber = +Args[2];
    var fourthNumber = +Args[3];
    var fifthNumber = +Args[4];

    if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber) {
        console.log(firstNumber);
    }
    else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber) {
        console.log(secondNumber);
    }
    else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber) {
        console.log(thirdNumber);
    }
    else if (fourthNumber > fifthNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber) {
        console.log(fourthNumber);
    }
    else if (fifthNumber > firstNumber && fifthNumber > secondNumber && fifthNumber > thirdNumber && fifthNumber > fourthNumber) {
        console.log(fifthNumber);
    }
    else {
        console.log(firstNumber);
    }
}