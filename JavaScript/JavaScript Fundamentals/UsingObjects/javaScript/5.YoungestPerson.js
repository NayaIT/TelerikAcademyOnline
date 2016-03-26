/**
 Problem 5. Youngest person
 Write a function that finds the youngest person in a given array of people
 and prints his/hers full name
 Each person has properties firstname, lastname and age.
 */

var lowestAge = 100;
    position = 0;

function findYoungestPerson(personsArr){
 var i;
 for(i in personsArr){
  if(personsArr[i].age < lowestAge){
   lowestAge = personsArr[i].age;
   position = i;
  }
 }
 return personsArr[position].firstname + ' ' + personsArr[position].lastname + ' ' + personsArr[position].age;
}

var persons = [
 {firstname: 'Doncho', lastname: 'Minkov', age: 30},
 {firstname: 'Ivo', lastname: 'Kenov', age: 28 },
 {firstname: 'Evlogi', lastname: 'Georgiev', age: 26}];

var lowestAgeOfPerson = findYoungestPerson(persons);
console.log(lowestAgeOfPerson);