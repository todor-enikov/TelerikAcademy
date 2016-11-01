function solve(Args) {

    var word = Args[0],
        replacedWord = word.replace(/ /g, '&nbsp;');
    console.log(replacedWord);
}

solve([ 'This text contains 4 spaces!!' ]);