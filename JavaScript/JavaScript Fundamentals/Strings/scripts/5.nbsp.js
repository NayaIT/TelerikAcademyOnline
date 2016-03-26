/**
 Problem 5. nbsp
 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */
var text = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. ' +
    'Integer sodales ante et sollicitudin sodales. In interdum, sapien eu tristique mattis, ' +
    'lectus metus hendrerit felis, eu malesuada sapien turpis eget sapien. Aliquam eget augue felis.';


function replaceWithNbsps(text) {

 for (var i = 0; i < text.length; i += 1) {
  text = text.replace(' ', '&nbsp');
 }
 return text;
}
console.log(replaceWithNbsps(text));