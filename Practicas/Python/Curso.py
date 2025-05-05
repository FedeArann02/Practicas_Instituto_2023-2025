import math #IMPORTAR CLASES







""" 
FRASE PALINDROMO:

nene = "pedro"
nene_reversa = ""
nrev = len(nene)

for reversa in range (0, len(nene)):
    nene_reversa += nene[nrev-1]
    nrev -= 1
    
print (nene_reversa)

#EJERCICIOS

print("Hola QUE tal".upper()) #comentando una línea de codigo y conviertiendola en mayuscula con el metodo upper de la clase string.
type Saludo = "Hola" muestra el typo de dato, en este caso es un string
print (Saludo) imprime en terminal
Podemos utilizar la f-string (formateo de cadenas) para incrustar variables directamente dentro de una cadena de texto.

nombre = "Juan"
edad = 25

print(f"Hola, mi nombre es {nombre} y tengo {edad} años.")

Variables
nombre = "federico aran"
pepe = "222"
numeros = 23131
flotante = 3.14

Algunos Métodos del dato String
 valida si es digito: print (nombre.isdigit())
 encontrar indice de caracter: print (nombre.find("e"))
 print (pepe.isdigit()) = True
 todo a minuscula: print (nombre.lower())
 todo a mayuscula: print (nombre.upper())
 cuantas veces aparece el caracter: print (nombre.count("e"))
 remplazar caracter: print (nombre.replace("e", "x"))

ENTRADA DE TEXTO = nombre = input("Hola usuario, ¿Cuál es tu nombre?: ")

Algunos métodos de la clase Math
round(3.5) redondea el número
math.Metodos
math.ceil(3.5) redondea hacia arriba
math.floor(3.5) redondea hacia abajo
print (abs(3.5)) devuelve el valor absoluto
pow = potencia (base, exponente)
math.sqrt = raíz cuadrada de un número
max(A,B,C,ETC) devuelve el número más alto de los caracteres que le pasemos como argumentos
min(A,B,C,ETC) devuelve el número más bajo de los caracteres que le pasemos como argumentos

OPERADORES LÓGICOS
AND & OR en condiciones como IF
NOT = invierte el valor de una condicion, devuelve True si la condicion es falsa y False si es verdadera.


-ESTRUCTURAS DE CONTROL:

INSTRUCCIONES (IF, ELSE, ELIF)
Al parecer es igual o parecido a C# (C sharp)

edad = int(input("¿Cuál es tu edad?: "))

if edad >= 18:
    print ("Sos mayor de edad, pasa pibe!")
elif edad > 99:
    print ("Raja de aca viej sucio")   
else :
    print ("Tomatela pendejo")


BUCLE FOR (como foreach)
for i in Variable:
   codigo


BUCLES WHILE
while (condicion)
si se cumple entra en el buclem sino lo salta:

numero = 1
while (numero < 11):
    print (numero)
    input ("presione una tecla")
    numero += 1

comprobar si una variable está vacía: 
 print (not numero) = false, porque esta variable no está vacía.
podemos usarlo para condiciones y nucles
while not numero or len(nombre) == 0:    bucle que no para hasta que haya un valor dentro de la variable numero
etc, etc...


BUCLES ANIDADOS (como en C#)

filas = int(input("¿Cuántas filas quiere?: "))
columnas = int(input("¿Cuántas columnas quiere?: "))
simbolo = input("¿Qupe simbolo quiere?: ")
 EL BUCLE INTERNO TERMINARA TODA SU ITERACION ANTES DE QUE TERMINE LA ITERACION DEL BUCLE EXTERNO
for i in range(filas):
    for j in range(columnas):
        print(simbolo, end="")
    print()    

BREAK, CONTINUE, PASS (break y continue funcionan como en C#)
break = fuerza a salir del bucle
continue = no continua con el código sino que salta al siguiente indice
PASS = marcador de posicion


-ESTRUCTURAS DE DATOS:

LISTAS
se usan para almacenar multiples elementos edentro de una variable
articulos = ['papa', 'cebolla', 'morron', 'ajo', 'tomate']
print(articulos[2]) = morron [0,1,(2),3,4]
for i in articulos:
print(i)

METODOS DE LISTAS
append(elemento): agrega un elemento al final de la lista.
insert(indice, elemento): inserta un elemento en una posición específica de la lista.
remove(elemento): elimina la primera aparición de un elemento en la lista.
pop(indice): elimina y devuelve el elemento en una posición específica de la lista.
sort(): ordena los elementos de la lista en orden ascendente.
reverse(): invierte el orden de los elementos en la lista.
clear() vacía la lista
 LAS LISTAS ALMACENAN CUALQUIER TIPO (MÚLTIPLE) VALORES.
sirven para almacenar colecciones de datos

LISTAS BIDIMENCIONALES (array bidimencionales)
indice 0: bebidas = ["café", "gaseosa", "té"]
indice 1: cena = ["pizza", "hamburguesas", "pancho"]
indice 2: postres = ["helado", "tiramisú"]

comidas = [bebidas, cena, postres]

 print (comidas[0][2])
 imprime de la lista comidas el indice [0] = "bebidas", y dentro de este indice, el indice [2] = "té"

arryas o control de cadenas (indexacion)
primer_nombre = nombre[indice inicial : indice final]
nombre_dos = nombre [indice inicial : indice final : indice de saltos] ejemplo: "federico aran" [1:len(nombre):2] = fEdErIcO aRaN = las mayusculas son las letras cortadas osea = fdrc aa
-- nombre_invertido = nombre [::-1]
print (nombre_invertido)
sitio_web = "http://www.pagina_web_o_nombre_de_sitio.com"
slice = slice(11, -4, 1) Objetos de corte
print (sitio_web[slice])

TUPLAS 
Son colecciones ordenadas e INMUTABLES similares a la listas solo que las tuplas están ordenadas no pueden modificarse.
son utiles para agrupar datos relacionados, y dependiendo de lo que queremos hacer, estas son más rápidas que las listas.
EJEMPLOS:
estudiantes = ('Fede', 22, 'Masculino', 'Jorge', 22, 'Masculino')
index para ver indices index('dato')
print(estudiantes.count('Fede'))

for i in estudiantes:
    print (i)
if 'Fede' in estudiantes:
    print ("Fede está aquí")


-DICCIONARIOS:
Un diccionario es una estructura de datos mutable y no ordenada 
que permite almacenar pares de clave-valor. 
Cada elemento en un diccionario consiste en una clave única y su valor correspondiente.
Los diccionarios se encierran entre llaves {}, y los pares clave-valor se separan por comas.

Para crear un diccionario, utiliza llaves y separa las claves y valores con dos puntos.

persona = {"nombre": "Juan", "edad": 25, "ciudad": "Madrid"}

Para acceder a los valores de un diccionario, utiliza la clave correspondiente entre corchetes:

Métodos de diccionarios
Los diccionarios en Python tienen varios métodos incorporados para manipular y acceder a los elementos. Algunos métodos comunes son:

También puedes utilizar el método get() para obtener el valor de una clave. Si la clave no existe, devuelve un valor predeterminado (por defecto, None).

keys(): devuelve una vista de todas las claves del diccionario.
values(): devuelve una vista de todos los valores del diccionario.
items(): devuelve una vista de todos los pares clave-valor del diccionario.
update(otro_diccionario): actualiza el diccionario con los pares clave-valor de otro diccionario


persona = {"nombre":"Federico", "apellido":"Aran", "edad":22, "carrera": "Sistemas", "curso": "2do A", "aprobado": "Sí", "nota": 9 }
print (persona["nombre"],)


-SETS (CONJUNTOS)
mutable y no ordenada
Los conjuntos se encierran entre llaves {} o se crean utilizando la función set().
Los conjuntos admiten operaciones matemáticas de conjuntos, como la unión (|), la intersección (&), la diferencia (-) y la diferencia simétrica (^).

Métodos de conjuntos
Los conjuntos en Python tienen varios métodos incorporados para manipular y acceder a los elementos. Algunos métodos comunes son:

add(elemento): agrega un elemento al conjunto.
remove(elemento): elimina un elemento del conjunto. Si el elemento no existe, genera un error.
discard(elemento): elimina un elemento del conjunto si está presente. Si el elemento no existe, no hace nada.
clear(): elimina todos los elementos del conjunto.

Las estructuras de datos en Python nos brindan una gran flexibilidad y potencia para almacenar y manipular datos en nuestros programas. 
Las listas son útiles para colecciones ordenadas y mutables,
las tuplas para colecciones ordenadas e inmutables, 
los diccionarios para almacenar pares clave-valor y 
los conjuntos para colecciones no ordenadas de ELEMENTOS ÚNICOS.


-FUNCIONES (def) 
Las funciones son bloques de código reutilizables que nos permiten encapsular tareas específicas y ejecutarlas cuando sea necesario. 
Las funciones nos ayudan a organizar nuestro código, evitar la repetición y hacer que nuestros programas sean más modulares y fáciles de mantener.

Python permite definir funciones que acepten un número variable de argumentos. 
Esto se logra utilizando el operador * antes del nombre del parámetro.

def suma_variable(*numeros):
    total = 0
    for numero in numeros:
        total += numero
    return total


print(suma_variable(1, 2, 3))  Imprime 6
print(suma_variable(4, 5, 6, 7))  Imprime 22


-- MANEJO DE EXCEPCIONES:
El manejo de excepciones nos permite capturar y manejar errores de manera controlada utilizando las declaraciones try, except y opcionalmente finally.
(como try catch & finally)

try:
    # Código que puede generar una excepción
    resultado = 10 / 0  # División por cero
    print(resultado)
except ZeroDivisionError:
    print("Error: División por cero")


El bloque finally es opcional y se ejecuta siempre
finally:
    archivo.close()  # Cerrar el archivo siempre, incluso si ocurre una excepción.
    

Además de las excepciones incorporadas en Python, también puedes crear tus propias excepciones personalizadas. 
Esto es útil cuando deseas manejar situaciones específicas de tu programa.
Para crear una excepción personalizada, debes crear una clase que herede de la clase base Exception o de una de sus subclases.

def funcion():
    # Código que puede generar una excepción personalizada
    if condicion:
        raise Exception("Descripción del error")


try:
    funcion()
except Exception as e:
    print(f"Error: {str(e)}")



-LECTURA Y ESCRITURA DE ARCHIVOS:

Lectura de archivos
Para leer el contenido de un archivo, primero debemos abrirlo utilizando la función open() en modo de lectura ("r"). 
Luego, podemos leer el contenido del archivo utilizando métodos como read() o readlines().

archivo = open("datos.txt", "r") ABRE EL PUNTERO
contenido = archivo.read() LEE CON EL PUNTERO
print(contenido) IMPRIME EL CONTENIDO ALMACENADO EN LA VARIABLE.
archivo.close() SIEMPRE SE CIERRA EL PUNTERO AL FINAL.

Escritura de archivos
Para escribir datos en un archivo, lo abrimos en modo de escritura ("w") utilizando la función open(). 
Si el archivo no existe, se creará automáticamente. 
Si el archivo ya existe, su contenido se sobrescribirá.

archivo = open("datos.txt", "w")
archivo.write(d"Hola, muno!")
archivo.close()

En este ejemplo, se abre el archivo "datos.txt" en modo de escritura utilizando open(). 
Luego, se escribe la cadena "¡Hola, mundo!" en el archivo utilizando el método write(). 
Finalmente, se cierra el archivo utilizando el método close().

También puedes utilizar la declaración with para manejar la apertura y cierre de archivos de manera automática.

with open("datos.txt", "r") as archivo:
    contenido = archivo.read()
    print(contenido)


CON RUTA ESPECIFICADA:
import os

ruta_escritorio = os.path.join(os.path.join(os.environ['USERPROFILE']), 'Desktop')
ruta_archivo = os.path.join(ruta_escritorio, "datos.txt")

with open(ruta_archivo, "w") as archivo:
    archivo.write("Hola, mundo!")



-IMPORTACIÓN Y CREACIÓN DE MÓDULOS:
En Python, un módulo es un archivo que contiene definiciones de funciones, clases y variables que se pueden utilizar en otros programas. 
La importación de módulos nos permite acceder a la funcionalidad definida en otros archivos y reutilizar código de manera eficiente. 
Además, podemos crear nuestros propios módulos para organizar y modularizar nuestro código.

EJEMPLO:
import math

resultado = math.sqrt(25)
print(resultado)  # Imprime 5.0

ALGUNAS:
import random
import datetime

numero_aleatorio = random.randint(1, 10)
print(numero_aleatorio)  # Imprime un número entero aleatorio entre 1 y 10

fecha_actual = datetime.datetime.now()
print(fecha_actual)  # Imprime la fecha y hora actual

MIS MÓDULOS (como Clases en C#)
Para crear un módulo personalizado, simplemente creamos un nuevo archivo Python con el nombre deseado y definimos las funciones, clases y variables que queremos incluir en el módulo.
Por ejemplo, creamos un archivo (en el mismo directorio donde estamos ejecutando Python) llamado mi_modulo.py con el siguiente contenido:

#mi_modulo.py
def saludar(nombre):
    print(f"Hola, {nombre}!")


def calcular_suma(a, b):
    return a + b
    
Luego, podemos importar y utilizar las funciones definidas en mi_modulo.py en otro archivo Python.

import mi_modulo


mi_modulo.saludar("Juan")  # Imprime "Hola, Juan!"
resultado = mi_modulo.calcular_suma(5, 3)
print(resultado)  # Imprime 8


-PAQUETES:
Un paquete es una forma de organizar módulos relacionados en una estructura jerárquica de directorios. 
Los paquetes nos permiten agrupar módulos relacionados y evitar conflictos de nombres entre módulos.

Para crear un paquete, creamos un directorio con el nombre deseado y agregamos un archivo especial llamado __init__.py dentro del directorio. Este archivo puede estar vacío o contener código de inicialización del paquete.

Por ejemplo, creamos un directorio llamado mi_paquete con la siguiente estructura:
mi_paquete/
    __init__.py
    modulo1.py
    modulo2.py
    
  
Luego, podemos importar y utilizar los módulos del paquete en nuestro programa:

from mi_paquete import modulo1, modulo2

modulo1.funcion1()
modulo2.funcion2()
    
    
"""

