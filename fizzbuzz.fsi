let printFizzBuzz = function
   | n when n % 3 = 0 && n % 5 = 0 -> printfn "FizzBuzz"
   | n when n % 3 = 0 -> printfn "Fizz"
   | n when n % 5 = 0 -> printfn "Buzz"
   | n -> printfn "%d" n
