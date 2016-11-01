function solve () { 
  var canvas = document.getElementById('vesko');
  var ctx = canvas.getContext('2d');
  ctx.fillRect(100,100,10,10);
  var image = new Image();
  image.onload = function (){
  ctx.drawImage(image,10,10);  
  };
  image.src ='icon.png';
  canvas.style.border = '2px solid black';
  canvas.style.width = '1000px';
  canvas.style.height = '1000px';
    var x = 100;
    var y = 100;
  window.document.body.addEventListener('keydown', function(event){

    
      switch (event.keyCode) {
        case 37:
          if (x<0 || y<=100) {
          ctx.clearRect(0,0,canvas.width,canvas.height);
          ctx.drawImage(image,10,10);    
          x-=10;
          ctx.fillRect(x,y,10,10); 
          }
          
        break;
        case 38:
        ctx.clearRect(0,0,canvas.width,canvas.height); 
        y-=10;       
        ctx.fillRect(x,y,10,10);        
        break;
        case 39:
        ctx.clearRect(0,0,canvas.width,canvas.height); 
        x+=10;       
        ctx.fillRect(x,y,10,10);       
        break;
        case 40:
        ctx.clearRect(0,0,canvas.width,canvas.height);
        y+=10;        
        ctx.fillRect(x,y,10,10);        
        break;
    
      default:
        break;
    }
  });

}

solve();