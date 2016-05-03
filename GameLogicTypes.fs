module GameLogicTypes

open Domain
open Seasons

type CurrentTurnDetails = {year:int; season:Season; phase:Phase}

type MoveResult = 
    | Invalid
    | Valid

type RequestedMove = {power:Power; move:Move}
type MoveResponse = {requestedMove:RequestedMove; result:MoveResult}