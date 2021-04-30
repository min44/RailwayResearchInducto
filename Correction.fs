module Correction

open Types

let CanonicalizeEmail input =
    { input with
          email = input.email.Trim().ToLower() }
