/**
 Problem 6. Group people
 Write a function that groups an array of persons by first letter of
 first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 */

function Person(name, lastName, age, gender){
 this.firstName = name;
 this.secondName = lastName;
 this.age = age;
 this.gender = !gender ? 'male' : 'female';
}

var personArr = [
 new Person('Asya', 'Petrova', 30, true),
 new Person('Ivo', 'Kenov', 28, false),
 new Person('Niki', 'Kostov', 25, false),
 new Person('Doncho', 'Minkov', 29, false),
 new Person('Evlogi', 'Hristov', 27, false),
 new Person('Aya', 'Koleva', 16, true),
 new Person('Bibi', 'Krusteva', 17, true)
];

function compareNames(n, m){
 if(n.firstName < m.secondName){
  return -1;
 }else if(n.firstName > m.secondName){
  return 1;
 }
 return 0;
}

function groupPeople(arr){
 var result = {};
 arr = personArr.sort(compareNames);
 arr.forEach(function(item){
  result[item.firstName.charAt(0).toLowerCase()] = {firstname: item.firstName};
 });
 return JSON.stringify(result);
}

console.log(groupPeople(personArr));