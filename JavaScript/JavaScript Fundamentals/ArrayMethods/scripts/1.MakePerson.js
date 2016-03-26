/**
 Problem 1. Make person
 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */

function Person(name, lastName, age, gender){
    this.firstName = name;
    this.secondName = lastName;
    this.age = age;
    this.gender = !gender ? 'male' : 'female';
}

console.log([
    new Person('Ivo', 'Kenov', 28, false),
    new Person('Niki', 'Kostov', 25, false),
    new Person('Doncho', 'Minkov', 29, false),
    new Person('Evlogi', 'Hristov', 27, false),
    new Person('Asya', 'Petrova', 30, true)
]);

//You can check with random people: names, age and gender