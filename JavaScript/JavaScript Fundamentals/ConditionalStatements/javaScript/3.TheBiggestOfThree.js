/**
 Problem 3. The biggest of Three
 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 */

var a = 5,
    b = 9,
    c =17;

if (a > b && a > c){
    console.log('The biggest number is a =' + a);
}else if (a < b && b > c){
    console.log('The biggest number is b =' + b);
}else if ((a < b && b < c)||(a > b && a < c)){
    console.log('The biggest number is c =' + c);
}

//with nested if statements

function getBiggest(a, b, c){
    if(a > b){
        if(a > c){
            return a;
        }
        return c;
    }
    if(c > b){
        return c;
    }

    return b;
}

console.log('The biggest number is ' + getBiggest(a, b, c));

// or second way to solve the problem

// greaterAB = Math.max(a, b);
//
// greater = Math.max(greaterAB, c);
//
// console.log('The biggest number is ' + greater);

//You can check it with another random numbers. Example: a=9, b=17, c=5; a=22, b=20, c=55; a=29.5, b=-7.5, c=-5;