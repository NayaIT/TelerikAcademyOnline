/**
 Problem 6. Point in Circle
 Write an expression that checks if given point P(x, y) is within a circle
 K({0,0}, 5). //{0,0} is the centre and 5 is the radius
 */

var msgStr = 'The point is in the circle? - ';
function checkPoint(x, y) {
    return (x * x + y * y) < 5 * 5;
}

console.log(msgStr + checkPoint(1, 3));
console.log(msgStr + checkPoint(3, 5));
console.log(msgStr + checkPoint(8, 5));
console.log(msgStr + checkPoint(9, 5));