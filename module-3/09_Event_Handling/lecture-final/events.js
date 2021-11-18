document.addEventListener('DOMContentLoaded',
    () => {
        //dom is initialized
        console.log('dom ready');

        const button = document.getElementById('button');
        button.addEventListener('click', 
            () => {
                //console.log('button was clicked');
                const ul = document.getElementById('ul');
                const li = document.createElement('li');
                li.innerText = 'third';
                ul.appendChild(li);
            }
        )

            const ul = document.getElementById('ul');
            ul.addEventListener('click',
                (e) =>{
                    console.log(e.currentTarget);
                    console.log(e.target);
                    if( e.target.style.backgroundColor == 'yellow'){
                        e.target.style.backgroundColor = 'green';
                    }else{
                        e.target.style.backgroundColor = 'yellow';
                    }
                    
                }
            )

        //const allLi = document.querySelectorAll('li');
        //console.log(allLi);
        /* //non-dynamic only runs once
        allLi.forEach(
            (element) =>{
                element.addEventListener('click',
                    (event) => {
                       console.log(event);
                       console.log(event.target);
                       event.target.style.backgroundColor = 'yellow';
                    }
                )
            }
        );
        */
        const div  = document.getElementById('div');
        const paragraph = document.getElementById('paragraph');
        div.addEventListener('mousemove',
            (e) => {
                paragraph.innerText = e.x + ", " + e.y;
                //console.log(e);
            }
        )
    }
);



/*
button.addEventListener('click', 
    function(){
        console.log('non arrow func');
    }
)
const handleClick = () => {
    console.log('func as expression');
}

button.addEventListener('click', handleClick)
*/
