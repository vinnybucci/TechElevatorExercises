let shopping = [];

document.addEventListener('DOMContentLoaded', () => {
    const button = document.querySelector('.loadingButton');
    button.addEventListener('click', (event) =>{
        loadList();
        button.disabled = true;
    });
});

function loadList(){
    console.log("Loading List");
    fetch('https://techelevator-pgh-teams.azurewebsites.net/api/techelevator/shoppinglist')
    .then((headers) =>{
        return headers.json();
    })
    .then((data) => {
        shopping = data;
        displayList();
   
    })
}
function displayList() 
{
if('content' in document.createElement('template')) {
    const container = document.querySelector("ul");
    shopping.forEach((item) => {
      const tmpl = document.getElementById('shopping-list-item-template').content.cloneNode(true);
      tmpl.querySelector('li').insertAdjacentText("afterbegin",item.name);
      if (item.completed){
          tmpl.querySelector('i').classList.add('completed');
      }
      container.appendChild(tmpl);
    })
  } else {
    console.error('Your browser does not support templates');
  }
}
