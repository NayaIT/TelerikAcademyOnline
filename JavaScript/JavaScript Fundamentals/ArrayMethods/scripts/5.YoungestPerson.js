/**
 Problem 5. Youngest person
 Write a function that finds the youngest male person in a given array of
 people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */

function Person(name, lastName, age, gender){
 this.firstName = name;
 this.secondName = lastName;
 this.age = age;
 this.gender = !gender ? 'male' : 'female';
}

var personArr = [
 new Person('Asya', 'Petrova', 16, true),
 new Person('Ivo', 'Kenov', 28, false),
 new Person('Niki', 'Kostov', 25, false),
 new Person('Doncho', 'Minkov', 29, false),
 new Person('Evlogi', 'Hristov', 27, false),
 new Person('Aya', 'Koleva', 17, true),
 new Person('Maya', 'Alexieva', 15, true)
];

function youngestPerson(arr){
 var minAge = arr[0].age;
 arr.forEach(function(item){
  if(minAge > item.age){
   minAge = item.age;
  }
 });

 var yongest = arr.filter(function(element){
  if(element.age === minAge){
   return element;
  }
 });

 return yongest[0].firstName + ' ' + yongest[0].secondName;
}

console.log(youngestPerson(personArr));