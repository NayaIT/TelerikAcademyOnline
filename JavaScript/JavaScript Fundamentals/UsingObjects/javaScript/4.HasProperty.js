/**
 Problem 4. Has property
 Write a function that checks if a given object contains a given property.
 */

function hasProperty(obj, prop){
 for(var i in obj){
  if(i === prop){
   return true;
  }
 }
 return false;
}

var testObj = {
 name: 'Ivo',
 age: 28};

var hasProp = hasProperty(testObj, 'name');
console.log(hasProp);