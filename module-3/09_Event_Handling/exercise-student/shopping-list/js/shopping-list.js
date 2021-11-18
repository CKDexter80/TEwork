let allItemsIncomplete = true;
const pageTitle = 'My Shopping List';
const groceries = [
  { id: 1, name: 'Oatmeal', completed: false },
  { id: 2, name: 'Milk', completed: false },
  { id: 3, name: 'Banana', completed: false },
  { id: 4, name: 'Strawberries', completed: false },
  { id: 5, name: 'Lunch Meat', completed: false },
  { id: 6, name: 'Bread', completed: false },
  { id: 7, name: 'Grapes', completed: false },
  { id: 8, name: 'Steak', completed: false },
  { id: 9, name: 'Salad', completed: false },
  { id: 10, name: 'Tea', completed: false }
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const title = document.getElementById('title');
  title.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const ul = document.querySelector('ul');
  groceries.forEach((item) => {
    const li = document.createElement('li');
    li.innerText = item.name;
    const checkCircle = document.createElement('i');
    checkCircle.setAttribute('class', 'far fa-check-circle');
    li.appendChild(checkCircle);
    ul.appendChild(li);
  });
}

function markItemComplete(item) {

  const circle = item.querySelector("i");
  item.classList.add("completed");
  circle.classList.add("completed");

}

function markItemIncomplete(item) {

  const circle = item.querySelector("i");
  item.classList.remove("completed");
  circle.classList.remove("completed");

}



document.addEventListener('DOMContentLoaded',
  () => {
    setPageTitle();
    displayGroceries();

    const listItem = document.querySelector("ul");

    listItem.addEventListener("click",
      (event) => {
        if (!event.target.classList.contains("completed")) {
          markItemComplete(event.target);
          console.log("did it");
        }        
      }
    )

    listItem.addEventListener("dblclick",
      (event) => {
        if (event.target.classList.contains("completed")) {
          markItemIncomplete(event.target)
          console.log("did it");
        }        
        
      }
    )

    const allButton = document.getElementById("toggleAll");

    allButton.addEventListener("click",
      (event) => {
        if (allItemsIncomplete) {
          allItemsIncomplete = false;         

          for (let index = 0; index < listItem.children.length; index++) {
            markItemComplete(listItem.children[index]);            
          }
          allButton.innerText = "Mark All Incomplete";
        }
        else {
          allItemsIncomplete = true;
          for (let index = 0; index < listItem.children.length; index++) {
            markItemIncomplete(listItem.children[index]);            
          }
          allButton.innerText = "Mark All Complete";
        }
       
      }
    )

  }
)
