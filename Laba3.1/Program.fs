open System

let checkEven numbers =
    numbers |> Seq.map (fun x -> x % 2 = 0)

printf "Введите числа через пробел: "
let input = Console.ReadLine()

let result = 
    input.Split ' ' // Простое разделение по пробелу

    |> Seq.map int
    |> checkEven

printfn "%A" result

