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
