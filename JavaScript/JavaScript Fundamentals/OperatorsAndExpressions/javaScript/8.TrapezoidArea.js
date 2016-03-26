/**
 Problem 8. Trapezoid area
 Write an expression that calculates trapezoid's area by given sides a and b
 and height h.
 */

var msgStr = 'Trapezoid area is: ';
function trapezoidArea(sideA, sideB, height){
    return ((sideA + sideB) * height) / 2;
}

console.log(msgStr + trapezoidArea(5, 9, 18));
console.log(msgStr + trapezoidArea(9, 18, 2));
console.log(msgStr + trapezoidArea(17, 18, 22));
console.log(msgStr + trapezoidArea(555, 22.3, 30.18));
console.log(msgStr + trapezoidArea(5, 29, 3));