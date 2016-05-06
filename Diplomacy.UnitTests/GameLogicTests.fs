module GameLogicTests

open Domain
open GameLogicTypes
open GameLogic
open Seasons
open Regions
open Powers
open NUnit.Framework

let printDetails (tracker:YearTracker) = 
    let details = tracker.GetCurrentTurnDetails()
    printf "%i: %s - %A \n" details.year details.season.name details.phase

[<TestFixture>]
type YearTrackerTests() =
    [<Test>]
    member this.``When current turn is retrieved for the first time, year is 1901``() =
        let tracker = YearTracker()
        let details = tracker.GetCurrentTurnDetails()
        Assert.AreEqual(1901, details.year)

    [<Test>]
    member this.``When current turn is retrieved for the first time, season is spring``() =
        let tracker = YearTracker()
        let details = tracker.GetCurrentTurnDetails()
        Assert.AreEqual(spring, details.season)

    [<Test>]
    member this.``When current turn is retrieved for the first time, phase is order``() =
        let tracker = YearTracker()
        let details = tracker.GetCurrentTurnDetails()
        Assert.AreEqual(Order, details.phase)

    [<Test>]
    member this.``When end turn is called once, the phase increments to retreat``() =
        let tracker = YearTracker()
        tracker.EndTurn()
        let details = tracker.GetCurrentTurnDetails()
        Assert.AreEqual(Retreat, details.phase)

    [<Test>]
    member this.``When end turn is called twice, the season increments to fall and phase resets to order``() =
        let tracker = YearTracker()
        for i in [1..2] do tracker.EndTurn()
        let details = tracker.GetCurrentTurnDetails()
        Assert.AreEqual(fall, details.season)
        Assert.AreEqual(Order, details.phase)

    [<Test>]
    member this.``When end turn is called three times, the season increments to fall and phase moves to retreat``() =
        let tracker = YearTracker()
        for i in [1..3] do tracker.EndTurn()
        let details = tracker.GetCurrentTurnDetails()
        Assert.AreEqual(fall, details.season)
        Assert.AreEqual(Retreat, details.phase)

    [<Test>]
    member this.``When end turn is called four times, the season increments to fall and phase moves to build``() =
        let tracker = YearTracker()
        for i in [1..4] do tracker.EndTurn()
        let details = tracker.GetCurrentTurnDetails()
        Assert.AreEqual(fall, details.season)
        Assert.AreEqual(Build, details.phase)

    [<Test>]
    member this.``When end turn is called five times, the year increments to 1902 with season at spring and phase at order``() =
        let tracker = YearTracker()
        for i in [1..5] do tracker.EndTurn()
        let details = tracker.GetCurrentTurnDetails()
        Assert.AreEqual(1902, details.year)
        Assert.AreEqual(spring, details.season)
        Assert.AreEqual(Order, details.phase)

[<TestFixture>]
type MoveTrackerTests() = 
    let yearTracker = YearTracker()
    let validator = MoveValidator()
    let executor = MoveExecutor(validator)
    let moveTracker = MoveTracker(yearTracker, executor)
  
    [<Test>]
    member this.``When sample turn is performed, validates and executes the results as expected``() =
        let unit = Army(wales, england)

        let firstMove = {RequestedMove.power=england; move=MoveOrAttack(unit, wales)}
        moveTracker.GatherMove(firstMove)
        
        let secondMove = {RequestedMove.power=england; move=MoveOrAttack(unit, yorkshire)}
        moveTracker.GatherMove(secondMove)

        let results = moveTracker.ExecuteGatheredMoves()

        let turnDetails = yearTracker.GetCurrentTurnDetails()

        Assert.AreEqual(1901, turnDetails.year)
        Assert.AreEqual(spring, turnDetails.season)
        Assert.AreEqual(Retreat, turnDetails.phase)