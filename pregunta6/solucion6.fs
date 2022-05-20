// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System
let suma a b = a+b
let multi a b = a*b
let resta a b = a-b
let div a b = a/b
[<EntryPoint>]

let main argumentos = 
    
    Console.WriteLine("introdusca dos numeros para sumar")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    let valor3 = suma valor1 valor2
    Console.WriteLine("la suma de los numeros es: " + valor3.ToString())
    Console.WriteLine("introdusca dos numeros para restar")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    let valor3 = resta valor1 valor2
    Console.WriteLine("la resta de los numeros es: " + valor3.ToString())
    Console.WriteLine("introdusca dos numeros para multiplicar")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    let valor3 = multi valor1 valor2
    Console.WriteLine("la multiplicacion de los numeros es: " + valor3.ToString())
    Console.WriteLine("introdusca dos numeros para dividir")
    let num1 = float (Console.ReadLine())
    let num2 = float (Console.ReadLine())
    let valor1 = (num1)
    let valor2 = (num2)
    let valor3 = div valor1 valor2
    Console.WriteLine("la division de los numeros es: " + valor3.ToString())
    
    let tecla = Console.ReadKey()
    


    0 // devolver un código de salida entero