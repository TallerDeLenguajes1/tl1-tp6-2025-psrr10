[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
¿String es una tipo por valor o un tipo por referencia?
Aunque string es un tipo de referencia, su inmutabilidad y el hecho de que su contenido no se modifica directamente hacen que se comporte como si fuera un tipo por valor en ciertas situaciones. Si una variable de tipo string es pasada a un método, por ejemplo, no se modifica el objeto original, sino que se pasa una nueva referencia al valor del string.


¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape en el tipo string son caracteres especiales que se usan para representar ciertos caracteres que no se pueden escribir directamente en un string. Algunas de las más comunes son:

    \n: Salto de línea (nueva línea).

    \t: Tabulación.

    \\: Barra invertida (para representar una barra invertida literal).

    \": Comillas dobles (para incluir comillas dobles dentro de un string).

    \r: Retorno de carro.

    \b: Retroceso.

    \f: Salto de página (form feed).

    \v: Tabulación vertical.


¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
@ (Cadenas literales):
El carácter @ se usa antes de un string para crear un string literal. Esto significa que las secuencias de escape (como \n, \t, etc.) no serán interpretadas, y el string se tomará tal cual, incluyendo las barras invertidas. 
Ejemplo:
string ruta = @"C:\Usuarios\Nombre\Documentos";
Console.WriteLine(ruta);
Salida -> C:\Usuarios\Nombre\Documentos


$ (Interpolación de cadenas):
El carácter $ se usa para la interpolación de cadenas, lo que permite incluir variables o expresiones dentro de un string directamente, usando llaves {}.
Ejemplo:
string nombre = "Juan";
string saludo = $"Hola, {nombre}!";
Console.WriteLine(saludo);
Salida -> Hola, Juan!



PREGUNTAS EJERCICIO 5
¿Qué son las expresiones regulares?

Las expresiones regulares son patrones usados para buscar, validar, extraer o manipular texto basándose en reglas definidas por esos patrones. Son como un lenguaje pequeño y específico para describir conjuntos de cadenas.

Por ejemplo, una expresión regular puede servir para:

    Verificar si un texto es un correo electrónico válido.

    Extraer todos los números de un texto.

    Reemplazar todas las apariciones de una palabra en un texto.

¿Funcionan únicamente en C#?

No, las expresiones regulares no son exclusivas de C#.

    Son una herramienta muy común en la mayoría de los lenguajes de programación modernos.

    Por ejemplo: Python, JavaScript, Java, PHP, Ruby, Perl, C++, etc., tienen soporte para expresiones regulares, aunque la sintaxis puede variar ligeramente entre lenguajes.

    En C#, las expresiones regulares se usan a través de la clase Regex que está en el espacio de nombres System.Text.RegularExpressions.

¿En qué casos le parecen útiles? (3 ejemplos)

    Validación de datos:
    Verificar si un número telefónico, email, código postal o DNI ingresado tiene el formato correcto.

    Búsqueda y extracción de información:
    Extraer todas las direcciones de correo, URLs o números de teléfono de un texto largo o documento.

    Transformación y limpieza de texto:
    Reemplazar formatos incorrectos, eliminar caracteres no deseados, formatear fechas o extraer partes específicas de un texto.