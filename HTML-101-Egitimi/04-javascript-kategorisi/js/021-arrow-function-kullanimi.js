// Arrow function Kullanimi
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/Arrow_functions

function hello(firstName) {
    console.log(`Merhaba ${firstName}`)
}

hello("JavaScript")

const helloFuncV1 = (firstName) => { console.log(`Merhaba ${firstName}`) } 
helloFuncV1("helloFuncV1")


const helloFuncV2 = firstName => console.log(`Merhaba ${firstName}`) // bir parametre, bir donus islemi
helloFuncV2("helloFuncV2")


const helloFuncV3 = (firstName, lastName) => console.log(
    `Merhaba ${firstName} ${lastName}`
) // console.log parantezi

helloFuncV3("helloFuncV3", "Last Name info")

const helloFuncV4 = (firstName, lastName) => {
    let info = `Merhaba ${firstName} ${lastName}`
    console.log(info) 
    return info
}
helloFuncV4("helloFuncV4", "Other Info")


const newArray = (nums) => {

    const newNums = nums.map(e=>{      
        if(e%2==0){
            return e*2
        }else if(e%2==1){
            return e*3
        }
    });
   return newNums 
}

console.log(newArray([1,2,3,4,5]));  // output: [3,4,9,8,15]

const seriesList = list => {
  
    list.forEach((series, index) => {
      console.log(`${index+1}. ${series}`) 
    });
  };
  
  seriesList(["Firefly", "The Mandalorian","Breaking Bad"]);
  /* output:
  1. Firefly
  2. The Mandalorian
  3. Breaking Bad
  */

  let movie = { 

    name: "La la land",
    
    thisInArrow:() => { 
    console.log("Movie name is " + this.name); // 'this' window'u referans gösterir. Bu yüzden name'yi bulamaz.
    }, 
    
    thisInRegular(){ 
    console.log("Movie name is " + this.name); // 'this' kendisini referans gösterir ve çalışır.
    } 
    
    };
    movie.thisInArrow(); // output : Movie name is
    movie.thisInRegular(); // output : Movie name is La la land