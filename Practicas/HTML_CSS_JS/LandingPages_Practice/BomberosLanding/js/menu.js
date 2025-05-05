const hamburguerIcon = document.querySelector('.nav__hamburguer');
const navOverlay = document.querySelector('.nav__overlay');
const LoginButtons = document.querySelector('.nav__login')

hamburguerIcon.addEventListener('click', ()=>{
    hamburguerIcon.classList.toggle('nav__hamburguer--open');

    navOverlay.classList.toggle('nav__overlay--show');
});

navOverlay.addEventListener('click', (e)=>{
    e.preventDefault();
    const currentElement = e.target;
    console.log(currentElement);

    if(isActive(currentElement, 'nav__parent')){

        const subMenu = currentElement.parentElement.children[1];

        if(window.innerWidth < 768){

            let height = (subMenu.clientHeight == 0) ? subMenu.scrollHeight : 0;  
            subMenu.style.height = height + "px";

        }
        else{
            subMenu.classList.toggle('nav__inner--show')
        }
       
    }
});

function isActive(element, string){
    return element.classList.value.includes(string);
}

window.addEventListener('resize', ()=>{
    if(window.innerWidth > 768){
        const navInners = document.querySelectorAll('.nav__inner');

        navInners.forEach(navInner => {
            navInner.style.height = '';
        });
    }
})

LoginButtons.addEventListener('hover', ()=>{
    const anchorText = LoginButtons.childNodes;
    console.log(anchorText);
})


/*.nav__login:hover{
    transition: .5s;
    background-color: var(--crimson-red-light);
}*/