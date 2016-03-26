/**
 Problem 2. Reverse number
 Write a function that reverses the digits of given decimal number.
 */

function getReverseDigits (number) {
 var reverse;

 for(reverse = 0; number; number = Math.floor(number / 10)) {
  reverse *= 10;
  reverse += number % 10;
 }
 return reverse;
}

getReverseDigits(1718);
getReverseDigits(95);
getReverseDigits(189);

//You can check with random number