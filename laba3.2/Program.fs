open System

let romanToDecimal roman =
    match roman with
    | "I" -> 1
    | "II" -> 2
    | "III" -> 3
    | "IV" -> 4
    | "V" -> 5
    | "VI" -> 6
    | "VII" -> 7
    | "VIII" -> 8
    | "IX" -> 9
    | _ -> 0

let calculateSum sequence =
    let totalSum =
        sequence
        |> Seq.fold (fun acc roman -> acc + romanToDecimal roman) 0
    printfn "Сумма = %d" totalSum

[<EntryPoint>]
let main _ =
    printf "Введите количество элементов n: "
    let n = int (Console.ReadLine())

    let romanSequence =
        seq {
            for i in 1 .. n do
                printf "Введите элемент %d (I-IX): " i
                yield Console.ReadLine().Trim().ToUpper()
        }

    calculateSum romanSequence
    0
