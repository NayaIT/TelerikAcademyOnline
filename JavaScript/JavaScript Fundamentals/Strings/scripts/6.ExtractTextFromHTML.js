/**
 Problem 6. Extract text from HTML
 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 */

var text = '<div><!DOCTYPE html><htmla <head lang="en"> <meta charset="UTF-8"> <title>Extract text from HTML</title> </head>' +
    +' <body> <div>Write a function that extracts the content of a html page given as text.</div> <div>The function should return anything that is in a tag, without the tags.' +
    '</div> <p>This was the test!</p> </script>';

function extractText(html) {
 var i,
     result = '';

 for (i = 0; i < html.length; i += 1) {
  if (html[i] === '<') {
   i = html.indexOf('>', i);
  }
  if (html[i] !== '>') {
   result += html[i];
  }
 }
 return result;
}

var extracted = extractText(text);

console.log('Result: \n' + extracted);