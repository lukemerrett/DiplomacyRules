module GameLogic

open Domain
open Seasons
open System

// Todo: As a player I can see if my move is valid
// Todo: As a player I can see my move has been executed

type CurrentTurnDetails = {year:int; season:Season; phase:Phase}

// Responsible for tracking the year, season and phase currently in play.
type YearTracker() =
    let mutable currentYear = {Year.year=1901; seasons=[spring; fall]}
    let mutable currentSeason = 0
    let mutable currentPhase = 0

    let seasonsAvailable = 
        currentYear.seasons.Length

    let phasesAvailable() = 
        currentYear.seasons.Item(currentSeason).phases.Length

    let incrementYear() = 
        currentYear.year <- currentYear.year + 1
        currentSeason <- 0
        currentPhase <- 0

    let incrementSeason() = 
        if currentSeason + 1 >= seasonsAvailable then incrementYear()
        else (
            currentSeason <- currentSeason + 1
            currentPhase <- 0
        )

    let incrementPhase() =
        currentPhase <- currentPhase + 1

    member this.EndTurn() = 
        if currentPhase + 1 >= phasesAvailable() then incrementSeason()
        else incrementPhase()

    member this.GetCurrentTurnDetails() =
        let seasonToReturn = currentYear.seasons.Item(currentSeason)
        let phaseToReturn = seasonToReturn.phases.Item(currentPhase)
        {
            CurrentTurnDetails.year=currentYear.year;
            season=seasonToReturn;
            phase=phaseToReturn
        }

type RequestedMove = {power:Power; move:Move}

// Responsible for gathering, validating and executing moves for players.
type MoveTracker() = 
    let mutable moveList = []

    let executeMove move = 
        raise(NotImplementedException())

    member this.GatherMove move =
        moveList <- move :: moveList  

    member this.ValidateMove move = 
        raise(NotImplementedException())

    member this.ValidateMoves move =
        let results = moveList |> List.map this.ValidateMove
        results

    member this.ExecuteGatheredMoves() =
        let results = moveList |> List.map executeMove
        moveList <- []
        results