/**
 Problem 3. Underage people
 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */

function Person(firstname, lastname, age, gender) {
 var per = {
     firstname: firstname,
     lastname: lastname,
     age: age,
     gender: gender
 };
 return per;
}

var personsArr = [
 new Person('Asya', 'Petrova', 16, true),
 new Person('Ivo', 'Kenov', 28, false),
 new Person('Niki', 'Kostov', 25, false),
 new Person('Doncho', 'Minkov', 29, false),
 new Person('Evlogi', 'Hristov', 27, false),
 new Person('Aya', 'Koleva', 17, true),
 new Person('Maya', 'Alexieva', 15, true)
];

var result;

result = personsArr.filter(function(item) {
 return item.age < 18;
});

console.log('All persons under 18 years old are: \n');

result.forEach(function(item, i) {
 var gend,
     str;

 if (result[i].gender) {
  gend = 'female';
 } else {
  gend = 'male';
 }

 str = (+i + 1) + '. ' + result[i].firstname + ' ' + result[i].lastname +
     ' is ' + gend + ' and is ' + result[i].age + ' years old.';

 console.log(str);
});

//You can check with random person's properties

