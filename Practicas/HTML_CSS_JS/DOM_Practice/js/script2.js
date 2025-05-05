/*
NODOS SUPERIORES: DOCUMENT.HEAD/BODY
NODOS: 
de tipo ELEMENTO(Cualquier etiqueta HTML H1, DIV, FORM, MAIN, ETC.)
de tipo TEXTO(representan los textos <h1>TEXTO</h1>) LOS ESPACIOS Y TABS tambien cuentan como TEXTO.
de tipo ATRIBUTO(representan atributos como Href o Class)
de tipo COMENTARIO (representan a los comentarios <!--Comentario html-->)
de tipo RAIZ (DOCUMENT) y solo puede existir un solo objeto Raiz por documento.
*/

/*
childNodes retorna una lista de nodos con todos 
los hijos directos de un nodo Padre en este caso BODY. nodos de TODO tipo. 
const body = document.body.childNodes;

const wrapper = document.body.childNodes[1]; //selecciono el indice donde se ubica el atributo wrapper

const wrapperElements = document.body.children; //Children me trae nodos de tipo ELEMENTO (HTML COLLECTIONS)

const wrapperFirstNode = document.body.firstChild; //retorna el primer nodo DE CUALQUIER TIPO de un padre
//caso contrario está lastChild

const wrapperFirstElementNode = document.body.firstElementChild; //retorna el primer nodo tipo ELEMENTO de un padre
//caso contrario está lastElementChild

const wrapperHasChildNodes = document.body.hasChildNodes();//retorna true o false dependiendo de si tiene Nodos hijos de cualquier tipo

console.log(body);
console.log(wrapper.childNodes);
console.log(wrapperElements);
console.log(wrapperFirstNode);
console.log(wrapperFirstElementNode);



const wrapper = document.body.children[0];
const div = wrapper.children[1];

console.log(div.nextSibling); //nextSibling retorna el hermano siguiente del nodo actual (CUALQUIER TIPO DE NODO)
console.log(div.nextElementSibling); //nextSibling retorna el hermano siguiente del nodo actual (SOLO ELEMENTOS)
//Para estos dos tambien hay Previous, previousSibling o previousElementSibling

const h1 = div.previousElementSibling;

h1.textContent = "Estoy siendo modificado desde el DOM"; //Accedemos a la propiedad del h1 y modifico su texto


const wrapper = document.body.children[0];
const div = wrapper.children[1];
const h1 = wrapper.children[0];
const anchor1 = div.children[0];
const anchor2 = anchor1.nextElementSibling;
const anchor3 = anchor2.nextElementSibling;


//al elemento anchor que esta dentro del div (que funciona como boton) le agregamos un evento que al hacer click llama a una funcion
anchor1.addEventListener('click', function(){
    h1.textContent = "Estoy siendo modificado desde el DOM";
})

anchor2.addEventListener('click', function(){
    h1.textContent = "DOM (Document Object Model)";
})

anchor3.addEventListener('click', function(){
    document.documentElement.style.backgroundColor = "black";
    document.documentElement.style.color = "white";
})

const parentNode = anchor2.parentNode; //retorna el nodo padre que contiene el nodo actual, se puede concatenar varios y subir de padre en padre.
const parentNodeElement = anchor1.parentElement; //parecido al anterior pero este solo retorna padres de tipo ELEMENTO de HTML, no retornaria por ejemplo el Document ya que es un nodo de tipo Document

PERO ESTA FORMA NO ES LA IDEAL PARA ACCEDER A ELEMENTOS

const wrapper = document.getElementById("wrapper"); //de esta manera accedo a un elemento por si id, este método solo esta disponible en el nodo raiz Document.
const links = wrapper.getElementsByClassName("link"); //este metodo esta disponible en todos los tipos de nodos aunque no sea el raiz.

    getElementsByClassName("nombreClass") = obtiene una lista de elementos html que contengan el valor ingresado en el metodo que coincidan con CLASS.
    getElementsByTagName("div") = retorna una lista de elementos html que coincidan con el tipo especificado en el metodo (div, h1, footer, etc)
    getElementsByName("telefono") = retorna una lista de nodos html con los que contenga en su atributo name el valor que coincida con el valor del metodo
    este metodo sirve bastante para los INPUTS.

    getElementById & getElementByName solo se pueden usar con Document = document.getElementBy....,
    en cambio los otros se pueden utilizar con cualquier otro nodo, por ejemplo: wrapper.getElementByTagName.



const wrapperByClass = document.querySelector('#wrapper'); //este metodo utiliza el selector de CSS
const wrapperById = document.querySelector('.wrapper'); 
const wrapperByAtribute = document.querySelector('[class="wrapper"]');

const div = document.querySelector('div'); //retorna el primer elemento que coincida con el selector.
const allDivs = document.querySelectorAll('div'); //retorna la lista de nodos que coincidan con la query.
const allLinksInWrapper = wrapperByClass.querySelectorAll('.link');//ahora dentro del nodo wrapper

const linkBold = wrapperByClass.querySelector('.bold');
const linkLastType = wrapperByClass.querySelector('.link:last-of-type');//o podemos utilizar pseudo clases como en CSS

console.log(allLinksInWrapper);
console.log(allDivs);
console.log(linkBold);
console.log(linkLastType);



const title = document.querySelector('.title');
const link = document.querySelector('.link.bold');
const inputNumber = document.querySelector('[type="number"]');
const wrapper = document.querySelector('#wrapper');


console.dir(wrapper); //dir accede y muestra a las propiedades de un nodo.

*/

//------------------------------

/*
Metodos para obtener, crear, modificar y eliminar Atributos.
- setAttribute() //crea o sobreescribe un atributo ("TYPE", "VALUE")
- hasAttribute() //true or false si tiene el atributo especificado en el metodo
- getAttribute() //remueve un atributo especificado en el metodo
- removeAttribute()



//EVENTOS ADD/REMOVEEVENTLISTENER Y HANDLERS O MANEJADORES function NameFunct(e/event)
const title = document.querySelector('.title');
const firstChild = document.querySelector('.link.bold');
const secondChild = firstChild.nextElementSibling;
 
function showTitle(){
    title.className = "show";
}

function hideTitle(){
    title.className = "hide";
}


firstChild.addEventListener('click', showTitle);
secondChild.addEventListener('click', hideTitle);

*/

//DELEGADO DE EVENTOS arpopvechando el event bubblging o la propagacion de eventos.
const divParent = document.querySelector('.wrapper div');

function eventDelegation(e){
    if(e.target.matches('.link')){
        const getColor = e.target.getAttribute('data-color');
        
        document.body.style.backgroundColor = getColor;
    }
}

divParent.addEventListener('click', eventDelegation);




