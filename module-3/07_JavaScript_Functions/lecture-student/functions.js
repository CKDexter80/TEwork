function newFunction(a, b=2, c){
    //console.log(a, b, c)
    console.log(b);
}

function newFunctionV2(){
    //console.log(a, b, c)
    console.log(arguments);
}

//can't call before definition
//doubleV2(2);

function doubleV1(num){
    return num + num;
}

const doubleV2 = function doubleV2(num){
    num + num;
}

const doubleV3 = (num) => {
    return num + num;
}

//return is implicit; don't need parentheses, 
//as only one param
const doubleV4 = num => num + num;

const alwaysX = () => 'X';

//don't pass in func as a function (func()), rather as
//a variable
function callDoubleV1(num, func){
    return func(num);
}

const callDoubleV2 = (num, func) => {
    return func(num);
}

const callDoubleV3 = (num, func) => func(num);

const callTwoFunctions = (func1, func2) => func1(func2);


const daysOfTheWeek = ["Monday", "Tuesday", "Wednesday"];

for (let i = 0; i < daysOfTheWeek.length; i++){
    const element = daysOfTheWeek[i];
    console.log(element);
}



//forEach can call a function for each iteration of loop
//equivalent to above

//daysOfTheWeek.forEach(
//    element => console.log(element)
//)


const logIt = element => console.log(element);
daysOfTheWeek.forEach(
    logIt()
)

