module Binders

let (>>=) x f = Result.bind f x

let (>=>) s1 s2 = s1 >> Result.bind s2

let Plus addSuccess addFailure switch1 switch2 x =
    match (switch1 x), (switch2 x) with
    | Ok s1, Ok s2 -> Ok(addSuccess s1 s2)
    | Error f1, Ok _ -> Error f1
    | Ok _, Error f2 -> Error f2
    | Error f1, Error f2 -> Error(addFailure f1 f2)

let (&&&) v1 v2 =
    let addSuccess r1 r2 = r1
    let addFailure s1 s2 = s1 + "; " + s2
    Plus addSuccess addFailure v1 v2

let Map oneTrackFunction twoTrackInput =
    match twoTrackInput with
    | Ok s -> Ok(oneTrackFunction s)
    | Error f -> Error f

let DoubleMap successFunc failureFunc twoTrackInput =
    match twoTrackInput with
    | Ok s -> Ok(successFunc s)
    | Error f -> Error(failureFunc f)
