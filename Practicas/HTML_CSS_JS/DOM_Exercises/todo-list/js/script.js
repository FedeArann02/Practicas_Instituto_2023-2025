const button = document.querySelector('.button');
const form = document.querySelector('.form');
const input = form.querySelector('.input');
const listContainer = document.querySelector('.list-container');

form.addEventListener('submit', handleSubmit);

message();

function message(){
    const h3 = document.createElement("h3");
    
    h3.classList.add("task-message");

    h3.textContent = listContainer.firstElementChild ? 
    'tareas por hacer' : 'no hay tareas aún'

    const prevMessage = document.querySelector('.task-message') //aca obtenemos el mensaje previo que por primera vez será nulo hasta que se agregen tareas.

    if(prevMessage){ //si hay un mensaje previo es porque se agregaron tareas en la funcion handleSubmit
        prevMessage.replaceWith(h3); //remplazamos el antiguo titulo por el nuevo!
        return;// cancelamos el metodop before porque ya no necesitamos agregar un titulo solo remplazarlo.
    }

    listContainer.before(h3); //agregamos el titulo como hermano anterior al nodo list-container

}


function handleSubmit(e){
    e.preventDefault();

    const inputValue = input.value; //obtengo el value del input
    createTask(inputValue); //llamo a la funcion y le paso por parametro el value
    this.reset(); //resetea el input
    message(); //llamo a la funcion message cada vez que agrego un elemento al dom para poder cambiar el titulo de las tareas
}


function createTask(value){
    const newTask = document.createElement("li"); // creo un nuevo elemento li 
    newTask.textContent = value; //le asigno al li el value recibido por argumento
    listContainer.appendChild(newTask); //agrego como nuevo hijo el elemento li con sus valores
    //listContainer.prepend(newTask); //agrega al nodo como primer hijo del elemento, contrario de append

    addEvents(newTask);

}


function addEvents(element){
    element.addEventListener('dblclick', function(){

        element.remove();
        message();

    })
}

/*
INSERTAR HTML CON JS mediante insertAdjacentHTML:
beforebegin: el HTML se inserta ANTES del elemento de referencia, como un HERMANO del anterior.
afterbegin: el HTML se inserta como primer hijo del elemento
beforeend: el HTML se inserta como ultimo hijo del elemento
afterend: el HTML se inserta DESPUES del elemento de referencia, como un HERMANO del siguiente
*/

/*------------------------------------------------
const wrapper = document.querySelector('.wrapper');
wrapper.insertAdjacentHTML('afterend',
    `
    <h1>Hola, html creado con js</h1>
    <button>Dame click</button>
    `);


const h4 = document.createElement('h4');
h4.textContent = "SOY UN ELEMENTO CREADO CON JS MEDIANTE EL METODO 'insertAdjacentElement.'"
wrapper.insertAdjacentElement('beforeend', h4);
-----------------------------------------------*/

/*

//const section = document.querySelector('.section');
//section.insertAdjacentHTML('after/before/begin/end', `HTML CODE`); Para especificar que se va a escribir codigo HTML se utiliza `` .

BEFOREBEGIN

<section> 

    AFTER BEGIN

    <p>soy un parrafo</p>
    <p>soy un parrafo</p>

    BEFOREEND

</section>

AFTEREND

*/

//DE TODAS MANERAS HAY QUE TENER CUIDADO CON AGREGAR CODIGO HTML DESDE JS.



/*CLONAR NODOS:

const wrapper = document.querySelector('.wrapper'); 
const copiaWrapper = wrapper.cloneNode(true); // si el valor es false solo copia el nodo sin descendientes/hijos. caso contrario lo clona entero.

wrapper.before(copiaWrapper) //lo agregamos al dom, pero los EventListeners no funcionaran!
*/



