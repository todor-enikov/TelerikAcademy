function solve(Args){

   var searchedWord = Args[0].toLowerCase(),
       text = Args[1].toLowerCase(),
       currentIndex = +text.indexOf(searchedWord),
       counter = 0;
        while (currentIndex >= 0)
        {
            counter++;                  
            currentIndex = currentIndex + 1;
            currentIndex = text.indexOf(searchedWord, currentIndex);
        }
        console.log(counter);
}

 solve(['in','We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight.']);