/**
 Problem 6. Larger than neighbours
 Write a function that checks if the element at given position in given array of
 integers is bigger than its two neighbours (when such exist).
 */

function largerThanNeighbours(arr, index) {
var i,
    len = arr.length;

 for ( i = 1; i < len - 1; i += 1)
 {
  if (index > 0 && index < len - 1 && arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
  {
   return true;
  }
 }
 return false;
}

largerThanNeighbours([1,3,5,7,9,11], 4);

//You can check with random array and index
//
//or second way with if-else statement

function largerThanNeighbours(arr, index) {
 var len = arr.length;
 if (index <= 0 || index >= len - 1) {
  console.log("Please take another element's position.");
 }
 else {
  if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) {
   console.log(true);
  }
  else {
   console.log(false);
  }
 }
}

largerThanNeighbours([1,3,5,7,9,1], 4);

//You can check with random array and index