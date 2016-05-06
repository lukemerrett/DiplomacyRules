module GameLogic

open Domain
open Seasons
open System
open GameLogicTypes
open Validators

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

// Responsible for checking whether a move is valid. 
type MoveValidator() =
    let validator = ValidatorMap()

    member this.ValidateMove(move, turnDetails) = 
        let validationResults = validator.RunValidators(move, turnDetails)
        let failedRows = (validationResults |> List.filter (fun x -> x.result = Failed)).Length
        {
            MoveResponse.requestedMove=move; 
            result=if failedRows = 0 then Valid else Invalid; 
            validations=validationResults
        }

// Responsible for executing moves for players.
type MoveExecutor(validator:MoveValidator) =
    let validator = validator

    let executeValidatedMove moveResponse = 
        raise(NotImplementedException())
        moveResponse
     
    member this.ExecuteMove(move, turnDetails) = 
        let response = validator.ValidateMove(move, turnDetails)
        match response.result with  
            | Valid -> executeValidatedMove response
            | Invalid -> response

// Responsible for collecting and executing moves for a player.
type MoveTracker(yearTracker:YearTracker, executor:MoveExecutor) =
    let yearTracker = yearTracker
    let executor = executor     
    let mutable moveList = []

    member this.GatherMove move =
        moveList <- move :: moveList  

    member this.ExecuteGatheredMoves(turnDetails) =
        let turnDetails = yearTracker.GetCurrentTurnDetails()
        let results = moveList |> List.map (fun x -> executor.ExecuteMove(x, turnDetails))
        moveList <- []
        yearTracker.EndTurn()
        results