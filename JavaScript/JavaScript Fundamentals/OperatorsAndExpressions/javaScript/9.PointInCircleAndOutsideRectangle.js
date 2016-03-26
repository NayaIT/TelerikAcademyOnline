/**
 Problem 9. Point in Circle and outside Rectangle
 Write an expression that checks for given point P(x, y) if it is within the
 circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2)
 */

function checkPoint(x, y) {
    var isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3 * 3;
    var isOutOfRectangle = !((x >= -1 && x <= -1 + 6) && (y <= 1 && y >= 1 - 2));
    return isInCircle && isOutOfRectangle;
}

console.log(checkPoint(5, 9));
console.log(checkPoint(3, 2));
console.log(checkPoint(5.9, 2));
console.log(checkPoint(3, 5));