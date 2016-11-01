function solve (Args) {
  var a = +Args[0];
  var b = +Args[1];
  var c = +Args[2];
  var determinant = Math.sqrt((b * b) - (4 * a * c));
  if (determinant === 0) {
    var result = -b / (2 * a);
    console.log('x1=x2=' + result.toFixed(2));
  }
  else if (determinant > 0) {
    var firstResult = (-b - determinant) / (2 * a);
    var secondResult = (-b + determinant) / (2 * a);
    console.log('x1=' + firstResult.toFixed(2) + '; ' + 'x2=' + secondResult.toFixed(2));
  } else {
    console.log('no real roots');
  }
}


solve(['5', '2', '8']);
