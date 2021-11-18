document.addEventListener("DOMContentLoaded",
    () => {
        //dom is intialized
        console.log("DOM ready")

        const button = document.getElementById("button");


        button.addEventListener("click",
            () => {
                //console.log("button was clicked");
                const ul = document.getElementById("ul");
                const li = document.createElement('li');

                li.innerText = 'third';
                ul.appendChild(li);

            }
        )



        const ul = document.getElementById("ul");

        ul.addEventListener('click',
            (e) => {
                console.log(e.currentTarget);
                console.log(e.target);
                e.target.style.backgroundColor = "yellow";
            }
        )


        // const allLi = document.querySelectorAll('li');
        // console.log(allLi);

        // allLi.forEach(
        //     (element) => {
        //         element.addEventListener("click",
        //             (event) => {
        //                 console.log(event.target)
        //                 event.target.style.backgroundColor = "yellow";
        //             }
        //         )
        //     }
        // )

        const div = document.getElementById("div");
        const paragraph = document.getElementById("paragraph");

        div.addEventListener("mouseover",
            (event) => {
                paragraph.innerText = event.x + " " + event.y;
                //console.log(event);
            }
        )




    }
);

const button = document.getElementById("button");
button.addEventListener("click",
    () => {
        console.log("button was clicked");
    }
)
