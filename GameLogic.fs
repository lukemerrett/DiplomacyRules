module GameLogic

open Seasons

type YearTracker() =
    let mutable currentYear = {Year.year=1901; seasons=[spring; fall]}
    let mutable currentSeason = 0
    let mutable currentPhase = 0

    let seasonsAvailable = 
        currentYear.seasons.Length

    let phasesAvailable = 
        currentYear.seasons.Item(currentSeason).phases.Length

    let incrementYear = 
        currentYear.year <- currentYear.year + 1
        currentSeason <- 0
        currentPhase <- 0

    let incrementSeason = 
        if currentSeason >= seasonsAvailable then incrementYear
        else (
            currentSeason <- currentSeason + 1
            currentPhase <- 0
        )

    let incrementPhase =
        currentPhase <- currentPhase + 1

    member this.EndTurn = 
        if currentPhase + 1 >= phasesAvailable then incrementSeason
        else incrementPhase

    member this.GetCurrentYear = 
        currentYear.year

    member this.GetCurrentSeason =
        currentYear.seasons.Item(currentSeason)

    member this.GetCurrentPhase = 
        this.GetCurrentSeason.phases.Item(currentPhase)