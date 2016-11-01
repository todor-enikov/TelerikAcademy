function solve(Args){
    var len = Args.length;
    var min = +Args[0];
    var max = +Args[0];
    var sum = +Args[0];
    var average = 0;

    for (var i = 1; i < len; i+=1) {
       if (min>+Args[i]) {
           min=+Args[i];
       }
       if (max<+Args[i]) {
           max=+Args[i];
       }
       sum += +Args[i];
    }
    average = sum/len;
    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + average.toFixed(2));
}

 solve(['1','2','3','4']);