module Propagation

open Types
open System

module Candidate =
    let Default =
        { id = Guid.Empty
          name = "Igor Stepanov"
          age = 22
          email = "igor@mail.com"
          isValid = false }

    let Create name age email =
        { id = Guid.NewGuid()
          name = name
          age = age
          email = email
          isValid = false }
