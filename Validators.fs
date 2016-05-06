module Validators

open System
open Domain
open GameLogicTypes

type ResultType =
    | Passed
    | Failed
    | NotApplicable

type ValidationResult = {validationName:string; result:ResultType}

let moveIsValidForPhase (move:RequestedMove, turn:CurrentTurnDetails) = 
    match turn.phase with
        | Order -> match move.move with
                        | MoveOrAttack _ -> Passed
                        | Hold _ -> Passed
                        | SupportMovingUnit _ -> Passed
                        | SupportHoldingUnit _ -> Passed
                        | Convoy _ -> Passed
                        | _ -> Failed
        | Retreat -> match move.move with
                        | MoveOrAttack _ -> Passed
                        | _ -> Failed
        | Build -> match move.move with
                        | Create _ -> Passed
                        | Disband _ -> Passed
                        | _ -> Failed

let unitCanMoveIntoRegionOfThisType (move:RequestedMove, turn:CurrentTurnDetails) =
    match move.move with 
        | MoveOrAttack (unit, toZone) 
            -> match unit with
                | Army _ -> match toZone with
                                | Region region -> Passed
                                | Sea _ -> Failed
                | Fleet _ -> match toZone with
                                | Region region -> if region.isCoastal then Passed else Failed
                                | Sea _ -> Passed
        | _ -> NotApplicable

let unitIsAllowedToConvoy (move:RequestedMove, turn:CurrentTurnDetails) =
    match move.move with
        | Convoy (unit, _, _) -> match unit with 
                                    | Fleet _ -> Passed
                                    | Army _ -> Failed
        | _ -> NotApplicable

let moveFromToDestinationIsValid (move:RequestedMove, turn:CurrentTurnDetails) = 
    Passed

let buildIsAllowedAtDestination (move:RequestedMove, turn:CurrentTurnDetails) =
    let isBuildAllowed(zone:Zone, executingPower:Power) =
        match zone with
            | Region region 
                ->  if region.isSupplyCenter
                        && executingPower.name = region.owner.name
                        && executingPower.name = region.startingPower.name
                    then Passed
                    else Failed
            | Sea _ -> Failed

    match move.move with
        | Create unit -> match unit with
                            | Army (zone, _) -> isBuildAllowed(zone, move.power)
                            | Fleet (zone, _) -> isBuildAllowed(zone, move.power)
        | _ -> NotApplicable

let disbandIsAllowed (move:RequestedMove, turn:CurrentTurnDetails) =
    match move.move with
        | Disband unit -> match unit with
                            | Army (zone, power) -> if move.power.name = power.name then Passed else Failed
                            | Fleet (zone, power) -> if move.power.name = power.name then Passed else Failed
        | _ -> NotApplicable

let unitIsOwnedByPower (move:RequestedMove, turn:CurrentTurnDetails) =
    let isOwned(unit) = 
        match unit with
            | Army(_, power) | Fleet(_, power) 
                -> if power.name = move.power.name then Passed else Failed

    match move.move with 
        | MoveOrAttack(unit, _)
        | Hold(unit)
        | SupportMovingUnit(unit, _, _)
        | SupportHoldingUnit(unit, _)
        | Disband(unit) 
            -> isOwned(unit)
        | _ -> NotApplicable

type ValidatorMap() = 
    let validations = [
        ("Move is valid for phase", moveIsValidForPhase);
        ("Unit can move into region of this type", unitCanMoveIntoRegionOfThisType);
        ("Unit is allowed to convoy", unitIsAllowedToConvoy);
        ("Can move to destination", moveFromToDestinationIsValid);
        ("Build is allowed at destination", buildIsAllowedAtDestination);
        ("Disband is allowed", disbandIsAllowed);
        ("Unit is owned by power", unitIsOwnedByPower)
    ]

    member this.RunValidators(move:RequestedMove, turn:CurrentTurnDetails) =
        let runValidation validationTuple =
            let (name, validation) = validationTuple // Unwrap tuple
            let result = validation(move, turn)
            {validationName=name; result=result}

        validations |> List.map runValidation 