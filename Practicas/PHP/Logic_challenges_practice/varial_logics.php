<?php



//------------------------------ OTRO EJ ----------------------------------







//------------------------------ OTRO EJ ----------------------------------

//--------------------- OPERACIONES MATEMATICAS ---------------------------

function OperacionesMatematicas(){

    echo "Ingrese el primer valor: ";
    $valor_A = readline();
    
    echo "Ingrese el segundo valor: ";
    $valor_B = readline();
    
    
    if(validarLineas($valor_A, $valor_B) == false){
        echo "valores A o B erroneos!";
    }
    else
    {
        echo "¿que operación desea realizar?: \n" . 
        "+ : suma \n" . 
        "- : resta \n" .
        "/ : division \n" .
        "*: multiplicacion \n" .
        "^ : potencia \n" .
        "\n ingrese la operación a realizar (+, -, /, *, ^): ";
    
        if(validarOperaciones($operacion = readline())){
            echo "Resultado de la operacion (". $operacion ."):" . " " . realizarOperacion($operacion, $valor_A, $valor_B);
        }
        else
        {
            echo 'ingrese una operación válida!';
        }
    }
}

function validarLineas($valor_A, $valor_B){
    if(is_numeric($valor_A) == false || is_numeric($valor_B) == false){
        return false;
    }
    else{
        return true;
    }
}

function realizarOperacion($operacion, $valor_A, $valor_B){

    $result = 0;
    
        switch($operacion){
            case "+": $result = $valor_A + $valor_B;
            break;
            case "-": $result = $valor_A - $valor_B;
            break;
            case "/": $result = $valor_A / $valor_B;
            break;
            case "*": $result = $valor_A * $valor_B;
            break;
            case "^": $result = PowOperation($valor_A, $valor_B);
            break;
        }

    return $result;

}

function validarOperaciones($operacion){

    $operaciones = ['+', '-', '/', '*', '^',];
    $valid = true;

    foreach($operaciones as $op){
        if($operacion != $op){ 
            $valid = false;
        }
        else{
            $valid = true;
        }
    }

    return $valid;
}

function PowOperation($base, $potenica){
    $result = $base;
    for ($i = 1; $i < $potenica; $i++){

        $result = $result * $base;

    }

    return $result;
}

//--------------------- OPERACIONES MATEMATICAS ---------------------------