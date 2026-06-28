open System

let toInt = function

    | "i" -> 1    | "ii" -> 2   | "iii" -> 3
    | "iv" -> 4   | "v" -> 5    | "vi" -> 6
    | "vii" -> 7  | "viii" -> 8 | "ix" -> 9
    | _ -> 0

[<EntryPoint>]
let main _ =
    printf "Введите числа: "
    
    Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries)

    |> Seq.fold (fun acc x -> acc + toInt x) 0
    |> printfn "Сумма: %d"

    0
