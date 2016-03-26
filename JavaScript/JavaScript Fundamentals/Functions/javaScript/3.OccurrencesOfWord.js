/**
 Problem 3. Occurrences of word
 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
 */

function countOccurrencesOfWord (text, word, isCaseSensitive) {
 isCaseSensitive = isCaseSensitive || false;     // validation for the variable isCaseSensitive
 var subStr = text.split(word);
 return subStr.length - 1;
}
var text = 'JavaScript is the programming language of HTML and the Web.' + 'Programming makes computers do what you want them to do.' + 'JavaScript is easy to learn.' +
           'This tutorial will teach you JavaScript from basic to advanced.';
var word = 'JavaScript';

countOccurrencesOfWord(text, word, true);

//You can check with random text. Example from: http://www.lipsum.com