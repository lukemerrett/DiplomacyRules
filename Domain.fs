module Domain

type Power = {name:string}

type Region = {name:string; owner:Power; isSupplyCenter:bool; isCoastal: bool;}

type Zone = 
    | Region of Region
    | Sea of string

type Phase = 
    | Order
    | Retreat
    | Build

type Unit =
    | Army of Zone * Power
    | Fleet of Zone * Power

type Move =
    | MoveOrAttack of Unit * Zone               // Army moves from Zone to Zone
    | Hold of Unit                              // Army holds in Zone
    | SupportMovingUnit of Unit * Zone * Zone   // Army in Zone supports a unit moving from Zone to Zone
    | SupportHoldingUnit of Unit * Zone         // Army in Zone supports a unit holding in Zone
    | Convoy of Unit * Zone * Zone              // Fleet in Zone convoys a unit to Zone
    | Create of Unit                            // Build a new unit
    | Disband of Unit                           // Remove an existing unit