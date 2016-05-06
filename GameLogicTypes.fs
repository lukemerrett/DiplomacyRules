module GameLogicTypes

open Domain
open Seasons

type CurrentTurnDetails = {year:int; season:Season; phase:Phase}

type ResultType =
    | Passed
    | Failed
    | NotApplicable

type ValidationResult = {validationName:string; result:ResultType}

type MoveResult = 
    | Invalid
    | Valid

type RequestedMove = {power:Power; move:Move}
type MoveResponse = {requestedMove:RequestedMove; result:MoveResult; validations:list<ValidationResult>}