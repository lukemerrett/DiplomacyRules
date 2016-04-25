module Domain

type power = {name:string}

type country = {name:string; owner:Power; isSupplyCenter:bool; isCoastal: bool;}

type Zone = 
    | Country of country
    | Sea of string

type Phase = 
    | Order
    | Retreat
    | Build

type Unit =
    | Army of Zone * power
    | Fleet of Zone * power

type Move =
    | MoveOrAttack of Unit * Zone * Zone                // Army moves from Zone to Zone
    | Hold of Unit * Zone                               // Army holds in Zone
    | SupportMovingUnit of Unit * Zone * Zone * Zone    // Army in Zone supports a unit moving from Zone to Zone
    | SupportHoldingUnit of Unit * Zone * Zone          // Army in Zone supports a unit holding in Zone
    | Convoy of Unit * Zone * Zone                      // Fleet in Zone convoys a unit to Zone

type BuildAction = 
    | Create of Unit
    | Disband of Unit

type Season = {name:string; phases:Phase list}

let spring = {name="Spring"; phases=[Order; Retreat]}
let fall = {name="Fall"; phases=[Order; Retreat; Build]}