module Main

open Validation
open Correction
open Propagation
open Binders
open Logger
open Config

[<EntryPoint>]
let main _ =
    let input0 = Candidate.Default
    let input1 = Candidate.Create "" 0 "as"

    let usecase config =
        CombinedValidation
        >> Map CanonicalizeEmail
        >> InjectableLogger config

    let releaseConfig = { debug = true }

    input1 |> usecase releaseConfig |> ignore

    0
