/**
 Problem 1. Reverse string
 Write a JavaScript function that reverses a string and returns it.
 */

function reversedStr(string) {
 var i,
     reverse = '',
     len = string.length;

 for ( i = len - 1; i >= 0; i--) {
  reverse += string[i];
 }
 return reverse;
}
reversedStr('Jakubs');