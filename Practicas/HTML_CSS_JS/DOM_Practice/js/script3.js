/* MANEJO DE CLASES EN EL DOM */

/*MI FORMA/METODO
function closeModal(e){
    const modal = document.querySelector('.show');
    modal.className = "modal";
}

function openModal(e){
    const modal = document.querySelector('.modal');
    modal.className = "modal show";
}

const buttonCloseModal = document.querySelector('.modal__close');
const buttonOpenModal = document.querySelector('button');

buttonCloseModal.addEventListener('click', closeModal);
buttonOpenModal.addEventListener('click', openModal);
*/

/* COMO DEBE SER: 

const button = document.querySelector('.button');
const modal = document.querySelector('.modal');
const buttonClose = document.querySelector('.modal__close');

button.addEventListener('click', function(){
    modal.classList.add('show');  //agrega una clase sin eliminar las existentes
})

buttonClose.addEventListener('click', function(){
    modal.classList.remove('show'); //elimina una clase que pase por parametro
})

*/

//OTRO EJEMPLO USANDO UN DELEGADO Y OTRO USANDO TOGGLE:

const button = document.querySelector('.button');
const modal = document.querySelector('.modal');
const buttonClose = document.querySelector('.modal__close');

/*
button.addEventListener('click', function(){
    if(button.matches('.red')){
        button.classList.remove('red');
    }
    else{
        button.classList.add('red');
    }
})

button.addEventListener('click', function(){
    button.classList.toggle('red'); //toggle permite alternar una clase entre add y remove del metodo classlist
})


console.log(modal.classList.contains('red')); //devuelve true o false dependiendo si la clase pasada como argumento existe o no
console.log(modal.classList.replace('red', 'nueva-clase.mejorada'));  //remplaza la clase existente (si la encuentra, sino devuelve false) por la que pasamos por argumento
console.log(modal.classList.contains('red'));

*/

console.log(button)

button.addEventListener('click', function(){
    modal.classList.toggle('show');
});

buttonClose.addEventListener('click', function(){
    modal.classList.toggle('show');
});
