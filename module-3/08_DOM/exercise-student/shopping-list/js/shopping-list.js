// add pageTitle

const pageTitle = "My Shopping List";

// add groceries

const groceries = [
  "bananas",
  "eggs",
  "milk",
  "ice cream",
  "bread",
  "pasta",
  "apples",
  "chips",
  "chocolate",
  "tabloid"  
];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {

  document.getElementById("title").innerText = pageTitle;

}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {

  const list = document.getElementById("groceries");
  
  groceries.forEach(element => {
    const listItem = document.createElement("li");
    list.appendChild(listItem);
    listItem.innerText = element;    
  });  

}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {

  const listItems = document.getElementById("groceries").children;

  Array.from(listItems).forEach(element => {

    element.setAttribute("class", "completed")

  });


  // const listItems = document.querySelectorAll('li');
   
  // listItems.forEach(element => {
    
  //   element.setAttribute("class", "completed")

  // });

  }

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
