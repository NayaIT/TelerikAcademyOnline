/**
 Problem 1. Planar coordinates
 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending
 L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */


function point(x, y) {
 return { X: x, Y: y };
}

function line(pointOne, pointTwo) {
 return { pointA: pointOne, pointB: pointTwo };
}

function calculateDistance(pointOne, pointTwo) {
 return parseInt(Math.sqrt(Math.abs(pointOne.X - pointTwo.X) * Math.abs(pointOne.X - pointTwo.X)
     + Math.abs(pointOne.Y - pointTwo.Y) * Math.abs(pointOne.Y - pointTwo.Y)));
}

function canFormATriangle(lineOne, lineTwo, lineThree) {
 var a = calculateDistance(lineOne.pointA, lineOne.pointB);
 var b = calculateDistance(lineTwo.pointA, lineTwo.pointB);
 var c = calculateDistance(lineThree.pointA, lineThree.pointB);
 if (a + b > c && a + c > b && b + c > a) {
  console.log('Lines can form a triangle');
 } else {
  console.log('Lines cannot form a triangle!');
 }
}

var firstPoint = point(1, 1), // check with random numbers
    secPoint = point(2, 2),
    thirdPoint = point(3, 3);

var firstLine = line(firstPoint, secPoint),
    secLine = line(secPoint, thirdPoint),
    thirdLine = line(firstPoint, thirdPoint);

var distance = calculateDistance(firstPoint, secPoint);

console.log(distance);
canFormATriangle(firstLine, secLine, thirdLine);

//You can check it with random numbers for point's coordinate