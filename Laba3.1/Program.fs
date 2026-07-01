open System

let isEven x = x % 2 = 0

[<EntryPoint>]
let main _ =
    printf "Введите количество чисел: "
    let n = int (Console.ReadLine())

    let numbers =
        Seq.init n (fun i ->
            printf "Введите число %d: " (i + 1)
            int (Console.ReadLine()))

    let res = 
        numbers 
        |> Seq.map isEven 
        |> Seq.toList

    printfn "Результат: %A" res
    0
