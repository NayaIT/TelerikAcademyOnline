/**
 Problem 3. Typeof variables
 Try typeof on all variables you created
 */

var string = 'Telerik Academy';
typeof 'Telerik Academy';

var int = 18;
typeof 18;

var float = 18.9;
typeof 18.9;

var bool = true;
typeof true;

var arr = [5, 9, 17, 18, 22, 29, 30];
typeof [5, 9, 17, 18, 22, 29, 30];

var nullValue = null;
typeof null;

var nanValue = NaN;
typeof NaN;

var undefinedValue = undefined;
typeof undefined;

var object = {season: 'Summer', year: 2015};
typeof {season: 'Summer', year: 2015};

var func = function () {alert('Exemple for function literal')};
typeof function () {alert('Exemple for function literal')};

/**
 or second way with Array of all defined variables and using for loop
 */

var variables = [string, int, float, arr, object, func, nullValue, undefinedValue, bool, nanValue];

for(var variable in variables){
    console.log(getTypeString(variables[variable]));
}