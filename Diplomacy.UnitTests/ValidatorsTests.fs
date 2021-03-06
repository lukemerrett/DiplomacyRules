﻿module ValidatorsTests

open System
open Domain
open GameLogicTypes
open Powers
open Regions
open Seasons
open Validators
open NUnit.Framework

[<TestFixture>]
type moveIsValidForPhaseTests() =
    let zone = london
    let unit = Army(zone, england)
    let turnDetails (phase:Phase) = {year=1901; season=spring; phase=phase}

    [<Test>]
    member this.``When in order phase, move or attack move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=MoveOrAttack(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When in order phase, hold move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Hold unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When in order phase, support moving unit move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=SupportMovingUnit(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When in order phase, support holding unit move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=SupportHoldingUnit(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When in order phase, convoy unit move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Convoy(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When in order phase, create unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Create unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in order phase, disband unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Disband unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in retreat phase, move or attack move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=MoveOrAttack(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When in retreat phase, hold move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Hold unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in retreat phase, support moving unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=SupportMovingUnit(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in retreat phase, support holding unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=SupportHoldingUnit(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in retreat phase, convoy unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Convoy(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in retreat phase, create unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Create unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in retreat phase, disband unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Disband unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in build phase, move or attack move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=MoveOrAttack(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in build phase, hold move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Hold unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in build phase, support moving unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=SupportMovingUnit(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in build phase, support holding unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=SupportHoldingUnit(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in build phase, convoy unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Convoy(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When in build phase, create unit move is valid``() =
        let requestedMove = {RequestedMove.power=england; move=Create unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When in build phase, disband unit move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Disband unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.AreEqual(Passed, result)

[<TestFixture>]
type unitCanMoveIntoRegionOfThisTypeTests() = 
    let turnDetails = {year=1901; season=spring; phase=Order}
    let requestedMove(unit, zone) = {RequestedMove.power=england; move=MoveOrAttack(unit, zone)}

    [<Test>]
    member this.``When an army attempts to move to a region, move is allowed``() =
        let zone = london
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When an army attempts to move to a sea, move is invalid``() =
        let zone = englishChannel
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When a fleet attempts to move to a coastal region, move is allowed``() =
        let zone = london
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When a fleet attempts to move to a landlocked region, move is invalid``() =
        let zone = paris
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When a fleet attempts to move to a sea, move is allowed``() =
        let zone = englishChannel
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When order is not a move, not applicable is returned``() =
        let zone = englishChannel
        let unit = Fleet(zone, england)
        let requestedMove = {RequestedMove.power=england; move=Create(unit)}
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.AreEqual(NotApplicable, result)

[<TestFixture>]
type unitIsAllowedToConvoyTests() = 
    let zone = englishChannel
    let turnDetails = {year=1901; season=spring; phase=Order}
    let requestedMove(unit, zone) = {RequestedMove.power=england; move=Convoy(unit, zone, zone)}

    [<Test>]
    member this.``When a fleet attempts to convoy, move is allowed``() =
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitIsAllowedToConvoy(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)
    
    [<Test>]
    member this.``When an army attempts to convoy, move is invalid``() =
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitIsAllowedToConvoy(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When order is not a convoy, not applicable is returned``() =
        let zone = englishChannel
        let unit = Fleet(zone, england)
        let requestedMove = {RequestedMove.power=england; move=Create(unit)}
        let result = unitIsAllowedToConvoy(requestedMove, turnDetails)
        Assert.AreEqual(NotApplicable, result)

[<TestFixture>]
type moveFromToDestinationIsValidTests() =
    [<Test>]
    member this.``Check move is from a correct border destination to another``() =
        Assert.Fail("Not Implemented")

[<TestFixture>]
type buildIsAllowedAtDestinationTests() =
    let turnDetails = {year=1901; season=spring; phase=Order}
    let requestedMove(unit, zone) = {RequestedMove.power=england; move=Create unit}
    let mutable zone = london

    let setOwnerTo(newOwner) = 
        match zone with
            | Region region -> region.owner <- newOwner
            | _ -> ()

    [<Test>]
    member this.``When power requests to build army in owned starting control center, move is allowed``() =
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = buildIsAllowedAtDestination(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When power requests to build fleet in owned starting control center, move is allowed``() =
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = buildIsAllowedAtDestination(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When power requests to build army in lost control center, move is invalid``() =
        setOwnerTo france
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = buildIsAllowedAtDestination(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When power requests to build fleet in lost control center, move is invalid``() =
        setOwnerTo france
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = buildIsAllowedAtDestination(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When power requests to build army in non starting control center, move is invalid``() =
        zone <- paris
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = buildIsAllowedAtDestination(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When power requests to build fleet in non starting control center, move is invalid``() =
        zone <- paris
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = buildIsAllowedAtDestination(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When order is not a build, not applicable is returned``() =
        let zone = englishChannel
        let unit = Fleet(zone, england)
        let requestedMove = {RequestedMove.power=england; move=Disband(unit)}
        let result = unitIsAllowedToConvoy(requestedMove, turnDetails)
        Assert.AreEqual(NotApplicable, result)

    [<TearDown>]
    member this.tearDown() =
        zone <- london 
        setOwnerTo england

[<TestFixture>]
type disbandIsAllowedTests() = 
    let zone = englishChannel
    let turnDetails = {year=1901; season=spring; phase=Order}
    let requestedMove(unit) = {RequestedMove.power=england; move=Disband unit}
    
    [<Test>]
    member this.``When power requests disband of army it owns, move is allowed``() =
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit)
        let result = disbandIsAllowed(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When power requests disband of fleet it owns, move is allowed``() =
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit)
        let result = disbandIsAllowed(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When power requests disband of army it does not own, move is invalid``() =
        let unit = Army(zone, france)
        let requestedMove = requestedMove(unit)
        let result = disbandIsAllowed(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When power requests disband of fleet it does not own, move is invalid``() =
        let unit = Fleet(zone, france)
        let requestedMove = requestedMove(unit)
        let result = disbandIsAllowed(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When order is not a disband, not applicable is returned``() =
        let zone = englishChannel
        let unit = Fleet(zone, england)
        let requestedMove = {RequestedMove.power=england; move=Create(unit)}
        let result = unitIsAllowedToConvoy(requestedMove, turnDetails)
        Assert.AreEqual(NotApplicable, result)

[<TestFixture>]
type unitIsOwnedByPowerTests() = 
    let zone = englishChannel
    let turnDetails = {year=1901; season=spring; phase=Order}
    let unit = Army(zone, england)
    
    [<Test>]
    member this.``When move requested by power owning unit, move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=MoveOrAttack(unit, zone)}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When hold requested by power owning unit, move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Hold unit}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When support moving unit requested by power owning unit, move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=SupportMovingUnit(unit, zone, zone)}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When support holding unit requested by power owning unit, move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=SupportHoldingUnit(unit, zone)}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When disband requested by power owning unit, move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Disband unit}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When convoy requested by power owning unit, move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Convoy(unit, zone, zone)}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)

    [<Test>]
    member this.``When create requested by power owning unit, move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Create unit}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Passed, result)
    
    [<Test>]
    member this.``When move requested by power that doesn't own unit, move is invalid``() =
        let requestedMove = {RequestedMove.power=france; move=MoveOrAttack(unit, zone)}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When hold requested by power that doesn't own unit, move is invalid``() =
        let requestedMove = {RequestedMove.power=france; move=Hold unit}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When support moving unit requested by power that doesn't own unit, move is invalid``() =
        let requestedMove = {RequestedMove.power=france; move=SupportMovingUnit(unit, zone, zone)}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When support holding unit requested by power that doesn't own unit, move is invalid``() =
        let requestedMove = {RequestedMove.power=france; move=SupportHoldingUnit(unit, zone)}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When disband requested by power that doesn't own unit, move is invalid``() =
        let requestedMove = {RequestedMove.power=france; move=Disband unit}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When convoy requested by power that doesn't own unit, move is invalid``() =
        let requestedMove = {RequestedMove.power=france; move=Convoy(unit, zone, zone)}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

    [<Test>]
    member this.``When create requested by power that doesn't own unit, move is invalid``() =
        let requestedMove = {RequestedMove.power=france; move=Create unit}
        let result = unitIsOwnedByPower(requestedMove, turnDetails)
        Assert.AreEqual(Failed, result)

[<TestFixture>]
type ValidatorMapTests() =  
    let checkResult (r:ValidationResult, expected:ResultType) =
        let errorMessage = (
            sprintf 
                "Incorrect response from validator: '%s'. Expected: '%A'. Actual: '%A'" 
                r.validationName 
                expected 
                r.result
            )
        Assert.AreEqual(expected, r.result, errorMessage)

    [<Test>]
    member this.``When given a move to validate, returns a list of results for validators run``() =
        let zone = wales
        let turnDetails = {year=1901; season=spring; phase=Order}
        let unit = Army(zone, england)
        let requestedMove = {RequestedMove.power=england; move=MoveOrAttack(unit, zone)}
        
        let map = ValidatorMap()
        let results = map.RunValidators(requestedMove, turnDetails)
            
        for r in results do
            match r.validationName with
                | "Move is valid for phase" -> checkResult(r, Passed)
                | "Unit can move into region of this type" -> checkResult(r, Passed)
                | "Unit is allowed to convoy" -> checkResult(r, NotApplicable)
                | "Can move to destination" -> checkResult(r, Passed)
                | "Build is allowed at destination" -> checkResult(r, NotApplicable)
                | "Disband is allowed" -> checkResult(r, NotApplicable)
                | "Unit is owned by power" -> checkResult(r, Passed)
                | _ -> Assert.Fail("No tests written for validator:" + r.validationName)