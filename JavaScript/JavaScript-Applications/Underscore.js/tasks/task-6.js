/*
 Create a function that:
 *   **Takes** a collection of books
 *   Each book has propeties `title` and `author`
 **  `author` is an object that has properties `firstName` and `lastName`
 *   **finds** the most popular author (the author with biggest number of books)
 *   **prints** the author to the console
 *	if there is more than one author print them all sorted in ascending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve(){
    return function (books) {
        var sortedBooks =
           _.chain(books)
            .map(function(book) {
                var title = book.title;
                var authorFullName = book.author.firstName + ' ' + book.author.lastName;

                return {
                    title: title,
                    author: authorFullName
                }
            })
            .groupBy('author')
            .map(function(group) {
                   return group;
               })
            .sortBy(function(group) {
                return group.length;
            })
            .reverse()
            .value();

        var maxBooks = sortedBooks[0].length;

        _.chain(sortedBooks)
            .filter(function(book) {
                return book.length === maxBooks;
            })
            .map(function(book) {
                return book[0].author;
            })
            .sortBy()
            .each(function(author) {
                console.log(author);
            });
    };
}

module.exports = solve;