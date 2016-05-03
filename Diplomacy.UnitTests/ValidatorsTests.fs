module ValidatorsTests

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
        Assert.IsTrue(result)

    [<Test>]
    member this.``When in order phase, hold move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Hold unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.IsTrue(result)

    [<Test>]
    member this.``When in order phase, support moving unit move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=SupportMovingUnit(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.IsTrue(result)

    [<Test>]
    member this.``When in order phase, support holding unit move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=SupportHoldingUnit(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.IsTrue(result)

    [<Test>]
    member this.``When in order phase, convoy unit move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Convoy(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.IsTrue(result)

    [<Test>]
    member this.``When in order phase, create unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Create unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in order phase, disband unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Disband unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Order)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in retreat phase, move or attack move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=MoveOrAttack(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.IsTrue(result)

    [<Test>]
    member this.``When in retreat phase, hold move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Hold unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in retreat phase, support moving unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=SupportMovingUnit(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in retreat phase, support holding unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=SupportHoldingUnit(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in retreat phase, convoy unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Convoy(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in retreat phase, create unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Create unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in retreat phase, disband unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Disband unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Retreat)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in build phase, move or attack move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=MoveOrAttack(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in build phase, hold move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Hold unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in build phase, support moving unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=SupportMovingUnit(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in build phase, support holding unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=SupportHoldingUnit(unit, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in build phase, convoy unit move is invalid``() =
        let requestedMove = {RequestedMove.power=england; move=Convoy(unit, zone, zone)}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When in build phase, create unit move is valid``() =
        let requestedMove = {RequestedMove.power=england; move=Create unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.IsTrue(result)

    [<Test>]
    member this.``When in build phase, disband unit move is allowed``() =
        let requestedMove = {RequestedMove.power=england; move=Disband unit}
        let result = moveIsValidForPhase(requestedMove, turnDetails Build)
        Assert.IsTrue(result)

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
        Assert.IsTrue(result)

    [<Test>]
    member this.``When an army attempts to move to a sea, move is invalid``() =
        let zone = englishChannel
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When a fleet attempts to move to a coastal region, move is allowed``() =
        let zone = london
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.IsTrue(result)

    [<Test>]
    member this.``When a fleet attempts to move to a landlocked region, move is invalid``() =
        let zone = paris
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.IsFalse(result)

    [<Test>]
    member this.``When a fleet attempts to move to a sea, move is allowed``() =
        let zone = englishChannel
        let unit = Fleet(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitCanMoveIntoRegionOfThisType(requestedMove, turnDetails)
        Assert.IsTrue(result)

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
        Assert.IsTrue(result)
    
    [<Test>]
    member this.``When an army attempts to convoy, move is invalid``() =
        let unit = Army(zone, england)
        let requestedMove = requestedMove(unit, zone)
        let result = unitIsAllowedToConvoy(requestedMove, turnDetails)
        Assert.IsFalse(result)
