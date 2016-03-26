/**
 Problem 3. Sub-string in text
 Write a JavaScript function that finds how many times a substring
 is contained in a given text (perform case insensitive search).
 */

var text = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. ' +
    'Integer sodales ante et sollicitudin sodales. In interdum, sapien eu tristique mattis, ' +
    'lectus metus hendrerit felis, eu malesuada sapien turpis eget sapien. Aliquam eget augue felis.';

function checkForSubStr(text, word){
 var regex = new RegExp(word, 'gi');
 return (text.match(regex)).length;
}

console.log(checkForSubStr(text, 'in'));