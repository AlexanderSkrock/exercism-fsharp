module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int =
    let isDivisable number divisor = number % divisor = 0
    let isDivisableByAnyOf number =
        numbers
            |> List.filter ((<) 0)
            |> List.exists (isDivisable number)
    
    [1 .. upperBound - 1]
        |> List.filter isDivisableByAnyOf
        |> List.sum