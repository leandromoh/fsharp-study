(*
https://www.geeksforgeeks.org/maximum-difference-between-two-elements/
Maximum difference between two elements such that larger element appears after the smaller number
Difficulty Level : Medium

Given an list of integers, find out the maximum difference between any two elements such that larger element appears after the smaller number.
*)

open System

let maxDiff ys = 
    let rec aux = function
      | max, [] -> max
      | max, [_] -> max  
      | max, x::xs -> xs 
                      |> List.map (fun y -> y - x)
                      |> List.maxBy id
                      |> (fun cMax -> Math.Max(int cMax, max), xs)
                      |> aux 
    aux (-1, ys)

let calc = maxDiff >> printfn "%d" >> ignore

List.empty     |> calc // -1
[8]            |> calc // -1
[7; 1; 5; 4 ]  |> calc //  4
[9; 4; 3; 2 ]  |> calc // -1
[1; 5 ; 2; 10] |> calc //  9
[7; 9; 3; 1]   |> calc //  2
