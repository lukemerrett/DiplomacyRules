module GameLogicTests

open Domain
open GameLogic
open Seasons
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