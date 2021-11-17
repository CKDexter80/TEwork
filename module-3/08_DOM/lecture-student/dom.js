const h1 = document.getElementById("header");
//console.log(h1);

h1.innerText = "Hi World";
h1.setAttribute("class", "header");

//selects all elements
const listItems = document.querySelectorAll("li");
//console.log(listItems);
listItems.forEach(
    (li, index) => {
        if (index % 2 === 0){
        li.style.backgroundColor = "red";
        }
        li.innerText = index
    }
)

//selects first element found
const paragraph = document.querySelector(".paragraph");
const newSpan = document.createElement("span");
newSpan.innerText = "did i do that?";

//console.log(newSpan);
//console.log(paragraph);

//paragraph.appendChild(newSpan);

//beforebegin, beforeend, afterend, afterbegin, 
paragraph.insertAdjacentElement("afterbegin", newSpan)