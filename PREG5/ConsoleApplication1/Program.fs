// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System

module calculadora = 
  let sumar x y = x+y
  let restar x y = x-y
  let multiplicar x y = x*y
  let dividir x y = x/y


[<EntryPoint>]
let main argv = 
    Console.WriteLine("CALCULADORA")
    Console.WriteLine("-------------------")
    Console.WriteLine("INGRESE NRO 1:")
    let x = Convert.ToInt32(Console.ReadLine())
    Console.WriteLine("INGRESE NRO 2:")
    let y = Convert.ToInt32(Console.ReadLine())
    let suma = calculadora.sumar x y
    Console.WriteLine("LA SUMA ES: " + suma.ToString())
    let resta = calculadora.restar x y
    Console.WriteLine("LA RESTA ES: " + resta.ToString())
    let multi = calculadora.multiplicar x y
    Console.WriteLine("LA MULTIPLICACION ES: " + multi.ToString())
    let divi = calculadora.dividir x y 
    Console.WriteLine("LA DIVISION ES: " + divi.ToString())
    let tecla = Console.ReadKey()
    
