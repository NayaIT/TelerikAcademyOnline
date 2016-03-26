/**
 Problem 7. The biggest of five numbers
 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 */

var  a = 3,
     b = 1,
     c = 29,
     d = 17,
     e = 9;


if ((a > b)&&(a > c)&&(a > d)&&(a > e)){
    console.log('The biggest number is a = ' + a);
}else if((b > a)&&(b > c)&&(b > d)&&(b > e)){
    console.log('The biggest number is b = ' + b);
}else if ((c > a)&&(c > b)&&(c > d)&&(c > e)){
    console.log('The biggest number is c = ' + c);
}else if ((d > a)&&(d > b)&&(d > c)&&(d > e)){
    console.log('The biggest number is d = ' + d);
}else {
    console.log('The biggest number is e = ' + e);
}

// second way to solve the problem

// function getBiggest(a, b, c, d, e){
//     var biggest = Math.max();
//
//     if(a > biggest){
//         biggest = a;
//     }
//     if(b > biggest){
//         biggest = b;
//     }
//     if(c > biggest){
//         biggest = c;
//     }
//     if(d > biggest){
//         biggest = d;
//     }
//     if(e > biggest){
//         biggest = e;
//     }
//
//     return biggest;
// }
//
// console.log(getBiggest(5, 6, 7, 2, 1));
// console.log(getBiggest(18, 9, 17, 3, 5));
// console.log(getBiggest(22, 30, 5, 17, 18));
// console.log(getBiggest(24, 18, 22, 29, 17));