/*
 Create a function that:
 *   Takes an array of students
 *   Each student has:
 *   `firstName`, `lastName` and `age` properties
 *   Array of decimal numbers representing the marks
 *   **finds** the student with highest average mark (there will be only one)
 *   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (students) {
        _.chain(students)
            .map(function (person) {
                person.fullName = person.firstName + ' ' + person.lastName;

                var avarageMark = _.reduce(person.marks, function (base, currentMark) {
                    return base + currentMark;
                }, 0);
                person.averageMark = avarageMark / person.marks.length;

                return person;
            })
            .sortBy('averageMark')
            .last()
            .tap(function (person) {
                console.log(person.fullName + ' has an average score of ' + person.averageMark);
            })
            .value();
    }
}

module.exports = solve;