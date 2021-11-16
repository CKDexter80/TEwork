function newFunction(a, b = 2, c){
    console.log(b);
    //console.log(a, b, c);
    return 0;
}

function newFunctionV2(a=0){
    console.log(arguments[0]);
    return 0;
}
//cant call before definition
//doubleV2(2);

function doubleV1(num){
    return num + num;
}

const doubleV2 = function doubleV2(num){
   return num + num;
}

const doubleV3 = (num) => {
    return num + num;
}
//return is implicit dont need parens because only 1 parm
//and function is body is single line
const doubleV4 = (num) => num + num;
const alwaysX = () => 'X';
const always4 = () => 4;

function callDoubleV1(num, func){
    return func(num);
}

const callDoubleV2 = (num, func) =>{
    return func(num);
}

const callDoubleV3 = (num, func) => func(num);
//look at us, who would have thought?
const callTwoFunctions = (func1, func2) => func1(func2());

const daysOfTheWeek = ['monday', 'tuesday','wednesday'];

for (let index = 0; index < daysOfTheWeek.length; index++) {
    const element = daysOfTheWeek[index];
   // console.log(element);
}

const logit = element => console.log(element);

//daysOfTheWeek.forEach(
 //   element => console.log(element)
//)

daysOfTheWeek.forEach(logit);