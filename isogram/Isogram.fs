module Isogram

let isIsogram (str: string) = 
    let withoutSpecialCharacters = Seq.map System.Char.ToUpper >> Seq.filter System.Char.IsLetter
    str |> withoutSpecialCharacters |> Seq.length = (str |> withoutSpecialCharacters |> Set.ofSeq |> Set.count)