module Leap

let leapYear (year: int): bool = 
    let isDivisableBy number divisor = number % divisor = 0
    isDivisableBy year 4 && (not (isDivisableBy year 100) || isDivisableBy year 400)