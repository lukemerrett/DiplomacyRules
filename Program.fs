open GameLogic

let printDetails (tracker:YearTracker) = 
    let details = tracker.GetCurrentTurnDetails()
    printf "%i: %s - %A \n" details.year details.season.name details.phase
    
[<EntryPoint>]
let main argv = 
    let tracker = YearTracker()

    printDetails tracker

    for i in [0..10] do
       tracker.EndTurn()
       printDetails tracker

    0
