/**
 Problem 1. Exchange if greater
 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 */

var a = 18,
    b = 8,
    c;

greater = Math.max(a, b);

if (a > b)
{
    c = a;
    a = b;
    b = c;

}

console.log(a + ' ' + b);

//You can check it with another random numbers. Example: a=9, b=17; a=5, b=22; a=29.5, b=7.5;
