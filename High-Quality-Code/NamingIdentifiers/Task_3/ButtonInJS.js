/**
 * Task 3. _ClickON_TheButton in JavaScript
 Refactor the following examples to produce code with well-named identifiers in JavaScript
 */

function checkBrowser() {
    console.log('Telerik');
    var currentTab = window,
        browser = currentTab.navigator.appCodeName,
        isMozilla = browser === "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}