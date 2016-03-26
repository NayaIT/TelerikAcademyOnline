/**
 Problem 5. Selection sort
 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at
 the first position, find the smallest from the rest, move it at the second
 position, etc.
 position, etc.
 */

function selectionSort(arr) {
 for (var i = 0; i < arr.length; i += 1) {
  var smallestElement = i;
  for (var j = i + 1; j < arr.length; j += 1) {
   if (arr[smallestElement] > arr[j]) {
    smallestElement = j;
   }
  }
  var helper = arr[i];
  arr[i] = arr[smallestElement];
  arr[smallestElement] = helper;
 }

 console.log(arr.join(', '));
}

selectionSort([3, 5, 1, 2, 7, 9, 8, 0, -9, -5, 18]);

// or You can check selectionSort with random numbers.