const h1 = document.getElementById("header");
//console.log(h1);
h1.innerText = "Hello World";
h1.setAttribute("class","header");

const listItems = document.querySelectorAll("li");
//console.log(listItems);
listItems.forEach(
    (li, index) => {
        if(index % 2 !== 0){
            li.style.backgroundColor = "lightgray"
        //console.log(li);
        }
        li.innerText = index +1;
    }
)

const paragraph = document.querySelector(".paragraph");
const newSpan = document.createElement('span');
newSpan.innerText = "SPAN";
//console.log(newSpan);
//console.log(paragraph);

//paragraph.appendChild(newSpan);
//beforebegin, afterend, afterbegin, beforeend
paragraph.insertAdjacentElement("beforeend", newSpan);