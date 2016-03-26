/**
 Problem 3. Deep copy
 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */

function deepCopy(obj){
 if (typeof obj !== 'object') {
  return obj;
 }

 var clone = {};
 for (var prop in obj) {
  clone[prop] = deepCopy(obj[prop]);
 }

 return clone;
}

console.log(deepCopy(9));
console.log(deepCopy({name: 'Jack', age: 15}));
