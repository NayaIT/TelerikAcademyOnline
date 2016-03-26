/**
 Problem 7. Parse URL
 Write a script that parses an URL address given in the format:
 [protocol]://[server]/[resource] and extracts from it the [protocol],
 [server] and [resource] elements.
 Return the elements in a JSON object.
 */

var url = 'http://academy.telerik.com/academy/curriculum-detailed/';

function parseURL(url) {
 var json = {},
     index;

 index = url.indexOf(':');
 json.protocol = url.substring(0, index);
 index += 3;
 json.server = url.substring(index, url.indexOf('/', index));
 index = url.indexOf('/', index);
 json.resource = url.substring(index);

 return json;
}

result = parseURL(url);

console.log(result);