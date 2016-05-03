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
    match move.move with 
        | MoveOrAttack (unit, toZone) 
            -> match unit with
                | Army _ -> match toZone with
                                | Region region -> true
                                | Sea _ -> false
                | Fleet _ -> match toZone with
                                | Region region -> region.isCoastal
                                | Sea _ -> true
        | _ -> false

let unitIsAllowedToConvoy (move:RequestedMove, turn:CurrentTurnDetails) =
    match move.move with
        | Convoy (unit, _, _) -> match unit with 
                                    | Fleet _ -> true
                                    | Army _ -> false
        | _ -> true

let moveFromToDestinationIsValid (move:RequestedMove, turn:CurrentTurnDetails) = 
    // Todo: Map which regions border one another to allow this validation to occur
    // How would we best model this?
    raise(NotImplementedException())

let buildIsAllowedAtDestination (move:RequestedMove, turn:CurrentTurnDetails) =
    let isBuildAllowed(zone:Zone, executingPower:Power) =
        match zone with
            | Region region 
                ->  region.isSupplyCenter
                    && executingPower.name = region.owner.name
                    && executingPower.name = region.startingPower.name
            | Sea _ -> false

    match move.move with
        | Create unit -> match unit with
                            | Army (zone, _) -> isBuildAllowed(zone, move.power)
                            | Fleet (zone, _) -> isBuildAllowed(zone, move.power)
        | _ -> true

let disbandIsAllowed (move:RequestedMove, turn:CurrentTurnDetails) =
    match move.move with
        | Disband unit -> match unit with
                            | Army (zone, power) -> move.power.name = power.name
                            | Fleet (zone, power) -> move.power.name = power.name
        | _ -> true