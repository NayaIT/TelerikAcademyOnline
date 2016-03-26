/* globals $ */

/*
 Create a function that takes an id or DOM element and an array of contents
 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function () {

    return function (element, contents) {
        var elem,
            firstChild,
            fragment,
            newDiv,
            divToAdd;

        if(typeof(element) !== 'string' && !(element instanceof HTMLElement)){
            throw '';
        }
        if (typeof(element) === 'string') {
            elem = document.getElementById(element)
        } else {
            elem = element;
        }

        if(!contents || contents.some(function(item){
                return (typeof(item) !== 'string' && typeof(item) !== 'number');
            })){
            throw '';
        }

        firstChild = elem.firstChild;
        while(elem.firstChild){
            elem.removeChild(firstChild);
            firstChild = firstChild.nextSibling;
        }

        newDiv = document.createElement('div');
        fragment = document.createDocumentFragment();

        for(var j = 0, len = contents.length; j < len; j += 1){
            divToAdd = newDiv.cloneNode(true);
            divToAdd.innerHTML = contents[j];
            fragment.appendChild(divToAdd);
        }

        elem.appendChild(fragment);
    };
};