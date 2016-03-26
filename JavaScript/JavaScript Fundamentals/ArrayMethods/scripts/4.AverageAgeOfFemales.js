/**
 Problem 4. Average age of females
 Write a function that calculates the average age of all females, extracted from an
 array of persons. Use Array#filter
 Use only array methods and no regular loops (for, while)
 */

function Person(name, lastName, age, gender){
 this.firstName = name;
 this.secondName = lastName;
 this.age = age;
 this.gender = !gender ? 'male' : 'female';
}

function averageAgeOfFemales(arr){
 arr = arr.filter(function(item){
  return item.gender == 'female' && item.age <= 18;
 });

 var sum = 0;
 arr.forEach(function(item){
  sum += item.age;
 });

 return (sum / arr.length).toFixed(2);
}

var arr = [
 new Person('Asya', 'Petrova', 16, true),
 new Person('Ivo', 'Kenov', 28, false),
 new Person('Niki', 'Kostov', 25, false),
 new Person('Doncho', 'Minkov', 29, false),
 new Person('Evlogi', 'Hristov', 27, false),
 new Person('Aya', 'Koleva', 17, true),
 new Person('Maya', 'Alexieva', 15, true)
];

console.log(averageAgeOfFemales(arr));