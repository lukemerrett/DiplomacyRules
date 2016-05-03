module Validators

open System
open Domain
open GameLogicTypes

// List of validators to execute per move
// Common interface (or F# alternative) so they can be executed
// Alternatively, a list of functions to run all taking move and phase

let moveIsValidForPhase (move:RequestedMove, turn:CurrentTurnDetails) = 
    match turn.phase with
        | Order -> match move.move with
                        | MoveOrAttack _ -> true
                        | Hold _ -> true
                        | SupportMovingUnit _ -> true
                        | SupportHoldingUnit _ -> true
                        | Convoy _ -> true
                        | _ -> false
        | Retreat -> match move.move with
                        | MoveOrAttack _ -> true
                        | _ -> false
        | Build -> match move.move with
                        | Create _ -> true
                        | Disband _ -> true
                        | _ -> false

let unitCanMoveIntoRegionOfThisType (move:RequestedMove, turn:CurrentTurnDetails) =
    raise(NotImplementedException())
    match move.move with 
        | MoveOrAttack (unit, fromZone, toZone) 
            -> match unit with
                | Army _ -> match toZone with
                                | Region region -> true
                                | Sea _ -> false
                | Fleet _ -> match toZone with
                                | Region region -> region.isCoastal
                                | Sea _ -> true
        | _ -> false
