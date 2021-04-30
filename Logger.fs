module Logger

open Binders
open Config

let DebugLogger twoTrackInput =
    let success x =
        printfn "DEBUG. Success so far:\n%A" x
        x

    let failure x =
        printfn "ERROR.\n%A" x
        x

    DoubleMap success failure twoTrackInput

let InjectableLogger config =
    if config.debug then DebugLogger else id
