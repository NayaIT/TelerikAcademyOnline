/**
 Problem 4. Lexicographically smallest
 Write a script that finds the lexicographically smallest
 and largest property in document, window and navigator objects.
 */

function solveProblem(objects) {
    for (var object in objects) {
        var properties = [];

        for (var property in objects[object]) {
            properties.push(property);
        }

        properties.sort();

        console.log('\n' + 'Smallest property: ' + properties.shift());
        console.log('Largest property: ' + properties.pop());
        console.log(new Array(11).join('*'));
    }
}

solveProblem([document, window, navigator]);


// or second way for solve the task
//
// console.log('window');
// getProperties(window);
// console.log('navigator');
// getProperties(navigator);
// console.log('document');
// getProperties(document);
//
// function getProperties(obj){
//     var min = 0;
//     var max = 0;
//
//     for(var property in obj){
//         if(!min){
//             min = property;
//         }
//         if(!max){
//             max = property;
//         }
//
//         if(property < min){
//             min = property;
//         }
//
//         if(property > max){
//             max = property;
//         }
//     }
//
//     console.log('min: ' + min);
//     console.log('max: ' + max + '\n\r');
// }