module Validation

open Types
open Binders

let ValidateName candidate =
    match candidate.name with
    | "" -> Error "Name must be not empty"
    | _ -> Ok candidate

let ValidateEmail candidate =
    match candidate.email with
    | "" -> Error "Email must be not empty"
    | x when x.Length < 3 -> Error "Email is to short"
    | _ -> Ok candidate

let ValidateAge candidate =
    match candidate.age with
    | x when x < 12 || x > 99 -> Error $"Age valid range error. Age: {x}"
    | _ -> Ok candidate

let CombinedValidation =
    ValidateName &&& ValidateEmail &&& ValidateAge
