/**
 Problem 3. Rectangle area
 Write an expression that calculates rectangle’s area by given width and height.
 */

var msgStr = 'The Rectangle area is: ';

function rectangleArea(width, height){
    return width * height;
}

console.log(msgStr + rectangleArea(5, 9));
console.log(msgStr + rectangleArea(9, 18));
console.log(msgStr + rectangleArea(17, 18));
console.log(msgStr + rectangleArea(5, 22));
console.log(msgStr + rectangleArea(5, 29));