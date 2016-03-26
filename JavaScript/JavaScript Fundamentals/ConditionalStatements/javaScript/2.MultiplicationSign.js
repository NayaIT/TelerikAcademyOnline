/**
 Problem 2. Multiplication Sign
 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 */

var a = 5,
    b = -18,
    c = 9;

if ( a === 0 || b === 0 || c === 0){
    console.log(0);
}else if (a < 0 && b < 0 && c < 0){
    console.log('-')
}else if (a > 0 && b > 0 && c > 0){
    console.log('+');
}else if ((a > 0 && b < 0 && c > 0)||(a < 0 && b > 0 && c > 0)||(a > 0 && b > 0 && c < 0)){
    console.log('-');
}else if ((a < 0 && b < 0 && c > 0)||(a < 0 && b > 0 && c < 0)||(a > 0 && b < 0 && c < 0)){
    console.log('+');
}

//You can check it with another random numbers. Example: a=9, b=17, c=5; a=5, b=22, c=-5; a=29.5, b=-7.5, c=-5;