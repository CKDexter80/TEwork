/**
 * Write a function called isAdmitted. It will check entrance
 * scores and return true if the student is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * Admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa is above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */

    function isAdmitted (gpa, satScore = 0, recommendation = false){
        if (gpa > 4.0 || satScore > 1300){
            return true;
        }
        else if (recommendation){
            if (gpa > 3.0 || satScore > 1200){
                return true;
            }
        }
        return false;
 }

/**
 * Write a function called useParameterToFilterArray that takes a function and uses that in the 
 *`unfilteredArray` filter function. Return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */
    let unfilteredArray = [1, 2, 3, 4, 5, 6];

    const useParameterToFilterArray = filterFunction => unfilteredArray.filter(filterFunction);

/**
 * Write a function called makeNumber that takes two strings
 * of digits, concatenates them together, and returns
 * the value as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * returns the number 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */

    const makeNumber = (first, second = '') => parseInt(first + second);

/**
 * Write a function called addAll that takes an unknown number of parameters
 * and adds all of them together. Return the sum.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */
    
    function addAll(){
        if (arguments.length === 0)
        {
            return 0;
        } 
        else 
        {
        const reduceArr = Array.from(arguments);
       
        return reduceArr.reduce(
            (reducer, num) => reducer + num
        );
        }
    }

/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */
/**
 * Takes an array of strings and prepends 'Happy ' to each item.
 * 
 * @param {string[]} words an array of strings to map
 * @return {string[]} an array of strings
 */    

    function makeHappy(words) {

        const happyMap = word => 'Happy ' + word;
        const happyWords = words.map(happyMap);

        return happyWords;
 }

/*
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of JavaScript objects. Each object contains the
 * following properties:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * and returns an array of strings that turns the JavaScript objects
 * into a mailing address in the form of:
 *     streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 */

 /**
  * Takes an array of JSON objects and maps their properties into
  * a readable address format.
  * 
  * @param {object[]} objectsToMap an array of JSON objects to be mapped into an address format
  * @return {string[]} an array of strings converted to an address format
  */

    function getFullAddressesOfProperties(objectsToMap){
        
        const addressMap = obj => `${obj.streetNumber} ${obj.streetName} ${obj.streetType} ${obj.city} ${obj.state} ${obj.zip}`
        const convertedtoAddress = objectsToMap.map(addressMap);

        return convertedtoAddress;
    }

/*
 * Write and document a function called findLargest.
 *
 * Using `forEach`, find the largest element in an array.
 * It must work for strings and numbers.
 */

 /**
  * Takes an array and returns the largest item.  For an array of strings, it will return the string latest in the
  * alphabet; for an array of numbers, it will return the largest number;
  * @param {string[] | number[]} items an array of strings or number to be evaluated
  * @returns {string | number} the largest item in array
  */
    function findLargest(items) {
        let largestItem = "";

        const evaluateLargest = item => {
            if (item > largestItem){
                largestItem = item;
            }
        };

        items.forEach(evaluateLargest);

        return largestItem;        
    }

/*
 * CHALLENGE
 * Write and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays, adds up all sub values, and returns
 * the sum. For example, if you got this array as a parameter:
 * [
 *   [1, 2, 3],
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * The function returns 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */

 /**
  * This function takes an array of arrays of numbers and returns the sum of every sub value.
  * 
  * @param {array[number[]]} collectionOfArrays an array of an array of numbers
  * @return {number}
  */

 function getSumOfSubArrayValues(collectionOfArrays) {

    if (arguments.length === 0){
        return 0;
    }

    return collectionOfArrays.reduce(
        (previousValue, currentValue) =>  previousValue + currentValue.reduce(
            (previous, current) => previous + current
        ), 0
    )


 }
