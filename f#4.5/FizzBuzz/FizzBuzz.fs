﻿namespace FizzBuzz

type FizzBuzz =
    static member Generate (?n, ?m) = 
        let n = defaultArg n 1
        let m = defaultArg m 100
        let say x =
            match x with
            | f when f % 15 = 0 -> "FizzBuzz"
            | f when f % 3 = 0 -> "Fizz"
            | f when f % 5 = 0 -> "Buzz"
            | _ -> x.ToString()
        [ for x in n..m -> say x ]