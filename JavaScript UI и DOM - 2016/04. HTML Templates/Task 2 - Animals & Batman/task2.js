function solve(){
    return function(selector){
        var template = '<div class="container">' +
        '<h1>Animals</h1>' +
        '<ul class="animals-list">' +
            '{{#animals}}' +
            '<li>' +  
                    '{{#if url}}' +
                    '<a href="{{url}}">See a {{name}}</a>' +
                    '{{else}}' +
                    '<a href="http://vipovi.com/wp-content/uploads/2015/01/hechos-pokemons-3.jpg">{{name}}, cannot be seen, but you can see Pikachu</a>' +
                    '{{/if}}' +
            '</li>' +    
            '{{/animals}}' +                           
        '</ul>' +
        '</div>';

        $(selector).html(template);
    };
}
var html = document.getElementById('information').innerHTML;
var informationTemplate = Handlebars.compile(html);
var information = {
  animals: [{
   name: 'Lion',
   url: 'https://susanmcmovies.files.wordpress.com/2014/12/the-lion-king-wallpaper-the-lion-king-2-simbas-pride-4685023-1024-768.jpg'
  }, {
   name: 'Turtle',
    url: 'http://www.enkivillage.com/s/upload/images/a231e4349b9e3f28c740d802d4565eaf.jpg'
  }, {
    name: 'Dog'              
  }, {
    name: 'Cat',
    url: 'http://i.imgur.com/Ruuef.jpg'
  }, {
    name: 'Dog Again'              
  }] 
};

var informationResult = informationTemplate(information);
document.getElementById('finalResult').innerHTML = informationResult;