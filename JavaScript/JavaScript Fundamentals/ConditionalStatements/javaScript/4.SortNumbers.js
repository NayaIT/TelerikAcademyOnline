/**
 Problem 4. Sort 3 numbers
 Sort 3 real values in descending order.
 Use nested if statements.
 */

var a = 5,
    b = 18,
    c = 9;

if ((a > b)&&(a > c)){
    if (b > c){
        console.log(a + ', ' + b + ', ' + c);
    }else {
        console.log(a + ', ' + c + ', ' + b);
    }
} else if ((b > a)&&(b > c)){
    if (a > c){
        console.log(b + ', ' + a + ', ' + c);
    }else {
        console.log(b + ', ' + c + ', ' + a);
    }
} else if ((c > a)&&(c > b)){
    if (b > a){
        console.log(c + ', ' + b + ', ' + a);
    }else {
        console.log(c + ', ' + a + ', ' + b);
    }
}

//You can check it with another random numbers. Example: a=9, b=17, c=5; a=22, b=20, c=55; a=29.5, b=-7.5, c=-5;