/**
 Problem 2. People of age
 Write a function that checks if an array of person contains only people of age
 (with age 18 or greater)
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
 new Person('Evlogi', 'Hristov', 27, false)
// new Person('Aya', 'Koleva', 16, true) //if  You want to check other option uncomment it
];

var result;
result = personArr.every(function(item){
 return item.age >= 18;
});

if (result) {
 console.log('All persons are at age 18 or greater!');
} else {
 console.log('Not every person is at age 18 or greater!');
}

//You can check with random person's properties