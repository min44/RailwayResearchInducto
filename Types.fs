module Types

open System

type Candidate =
    { id: Guid
      name: string
      age: int
      email: string
      isValid: bool }