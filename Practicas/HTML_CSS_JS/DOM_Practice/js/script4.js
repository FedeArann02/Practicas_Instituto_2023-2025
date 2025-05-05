//MANIPULANDO EL CCSOM o CSS OBJECT MODEL

const title = document.querySelector('.title');

const inputColor = document.querySelector('[type = "color"]');

const inputRange = document.querySelector('[type = "range"]');

//CUSTOM PROPERTYS
document.documentElement.style.setProperty('--color-bg-darkMode', 'black');
document.documentElement.style.setProperty('--color-fg-darkMode', 'white');

title.style.backgroundColor = "var(--color-bg-darkMode)";
title.style.color = "var(--color-fg-darkMode)";
//------


//la propiedad style devuelve los valores EN LINEA es decir en el html, no en el css

title.style.fontFamily = "cursive";

//console.log(title.style.fontFamily);
console.log(title.style.getPropertyValue('font-family')); //esto es ideal cuando quiero obtener una custom property!

inputColor.addEventListener('change', function(e){

    const newColor = e.target.value; //obtiene el valor seleccionado cuando se cambia de estado

    title.style.color = newColor;

})

inputRange.addEventListener('change', function(e){

    const newSize = e.target.value;

    //dos formas de realiar el cambio
    title.style.setProperty('font-size', newSize + 'px', 'important') //se escribe la propiedad tal cual como en css. Ademas title tiene una propiedad mas que es IMPORTANT para darle Prioridad.
    //title.style.fontSize = newSize + 'px'; //se usa camell case para definir la propiedad

    console.log(title.style.getPropertyPriority('font-family')); //no hay prioridad important en la propiedad font-familiy
    console.log(title.style.getPropertyPriority('font-size'));

})

console.log(
    getComputedStyle(title) //este metodo me devuelve los estilos finales de un elemento
);

console.log(
    getComputedStyle(title).background //selecciono un atributo
);