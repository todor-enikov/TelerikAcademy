function solve(Args){

   var mathExpression =Args[0],
      firstCounter=0,
      secondCounter=0,
      i;
  for (i = 0; i < mathExpression.length; i++) {
      
      if (mathExpression[i]==='(') {
          firstCounter+=1;
      }
      else if (mathExpression[i]===')') {
          secondCounter+=1;
      }
  }
  if (firstCounter===secondCounter) {
        console.log('Correct');       
  }
  else{
        console.log('Incorrect');          
  }
}

 solve(['((a+b)/5-d)']);