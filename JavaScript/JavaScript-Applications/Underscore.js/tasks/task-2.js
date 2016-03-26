/*
 Create a function that:
 *   Takes an array of students
 *   Each student has a `firstName`, `lastName` and `age` properties
 *   **finds** the students whose age is between 18 and 24
 *   **prints**  the fullname of found students, sorted lexicographically ascending
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve(){
    return function (students) {
        _.chain(students)
            .filter(function(person) {
                return 18 <= person.age && person.age <= 24;
            })
            .map(function(person) {
                return person.firstName + ' ' + person.lastName;
            })
            .sortBy(function(fullName) {
                return fullName;
            })
            .each(function(fullName) {
                console.log(fullName);
            })
    };
}

module.exports = solve;