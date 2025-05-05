def calcular():
    while True:
        print("1. Suma \n2. Resta \n3. Multiplicación \n4. División \n5. Salir")
    
        operacion = input("Hola usuario, ¿qué operación desea realizar?: ")
    
        if operacion == "5":
            print("¡Adiós!")
            break
    
        try:
            valor_1 = int(input("Ingrese el valor 1: "))
            valor_2 = int(input("Ingrese el valor 2: "))
        except ValueError:
            print("Por favor, ingrese valores numéricos válidos.")
            continue
    
        calcular_operaciones = operaciones(operacion, valor_1, valor_2)
        if calcular_operaciones is not None:
            print(f"El resultado es: {calcular_operaciones}")

def operaciones(operacion, valor_1, valor_2):
    resultado = 0
    
    if operacion == "1":
        resultado = valor_1 + valor_2
    elif operacion == "2":
        resultado = valor_1 - valor_2   
    elif operacion == "3":
        resultado = valor_1 * valor_2 
    elif operacion == "4":
        if valor_2 != 0:
            resultado = valor_1 / valor_2
        else:
            print("Error: No se puede dividir por cero.")
            return None
    else:
        print("Introduzca una opción válida.")
        return None
        
    return resultado

def palindromo (frase):
    frase_reversa = ""
    frase_len = len(frase)

    for reversa in range (0, frase_len):
        frase_reversa += frase[frase_len -1]
        frase_len -= 1
    
    if frase_reversa.upper() == frase.upper():
            frase_reversa = "Esta frase es palíndromo."
    else:
            frase_reversa = "Esta frase no es palíndromo."
            
    return frase_reversa


def contador_Palabras(frase):
    palabras = [
    "de", "al", "si", "del", "el", "los", "la", "en", "no", "sin", "las", "con",
    "tan", "por", "muy", "es", "soy", "son", "y", "o", "e", "a", "u", "&", ".", 
    "", " ", ";", "?", "¿", "/", "b", "c", "d", "f", "g", "h", "i", "j", "k", 
    "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", 
    "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "(", ")", "{", "}", 
    "[", "]", ":", ",", "'", '"', "¬", "¡", ">", "<", "+", "-", "*", "=", 
    "~", "^", "|", "°", "©", "®", "™"
]
  
    frase_indexada = frase.split(" ")

    for i in palabras:
        while i in frase_indexada:
            frase_indexada.remove(i)
        
    return str(len(frase_indexada))


def lista_palabras (Path):
    with open(Path, "r", encoding='utf-8') as archivo:
        frase = archivo.read()

        palabras = [
        "de", "al", "si", "del", "el", "los", "la", "en", "no", "sin", "las", "con",
        "tan", "por", "muy", "es", "soy", "son", "y", "o", "e", "a", "u", "&", ".", 
        "", " ", ";", "?", "¿", "/", "b", "c", "d", "f", "g", "h", "i", "j", "k", 
        "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", 
        "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "(", ")", "{", "}", 
        "[", "]", ":", ",", "'", '"', "¬", "¡", ">", "<", "+", "-", "*", "=", 
        "~", "^", "|", "°", "©", "®", "™", "tu", "que", "un", "se", "una", "lo", "sus", "da"
        ]
  
        frase_indexada = frase.lower().split(" ") #convierte la frase en minuscula y la separa en indices cada vez que hay un espacio

        for palabra in palabras: #itera sobre las palabras precargadas
            while palabra in frase_indexada: #mientras exista una palabra similar que en la lista de palabras:
                frase_indexada.remove(palabra) #remueve las palabras que no deseamos, es decir las que hagan match con las que están en la lista

        datos = {} # inicializamos el diccionario

        for palabra in frase_indexada: # El bucle for itera sobre cada elemento en la lista frase_indexada
            if palabra in datos: # si el value esta en el diccionario 'datos' entonces le suma 1, si no está la agrega con el valor: 1
                datos[palabra] += 1 #suma 1
            else:
                datos[palabra] = 1 #agrega 1
        
        datos_lista = list(datos.items()) #Convierte el diccionario en una lista de tuplas con el metodo list que recibe una vista iterable del diccionario con el metodo items

        datos_ordenados = [] #inicializa la lista

        while datos_lista: #mientaras la lista esté llena (True) sigue iterando
            par_max = datos_lista[0] #el par máximo es igualado al indice 0
            for par in datos_lista: # El bucle for itera sobre cada elemento en la lista datos_listas
                if par [1] > par_max[1]: # si par es mayor al maximo par
                    par_max = par #entonces el par maximo ahora es el par, esto recorre toda la lista encontrando el indice más alto
            datos_ordenados.append(par_max) #agrega el par maximo a la lista
            datos_lista.remove(par_max) # elimina el par maximo de la lista vieja para que no lo repita, y como la lista antigua no está vacía la vuelve a iterar

        c = 1
        
        for clave, valor in datos_ordenados:
            print(f"{c}. {clave}: {valor}\n")
            input("Presione enter para ver la siguiente palabra: ")
            print("\n")
            c += 1
              