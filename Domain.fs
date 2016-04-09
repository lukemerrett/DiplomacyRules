﻿module Domain

type Power = string

type country = {name:string; owner:Power; isSupplyCenter:bool; isCoastal: bool;}

type Zone = 
    | Country of country
    | Sea

type Phase = 
    | Order
    | Retreat
    | Build

type Season = 
    | Sprint
    | Fall
    | Winter

type Unit =
    | Army of Zone * Power
    | Fleet of Zone * Power

type Move =
    | MoveOrAttack of Unit * Zone * Zone                // Army moves from Zone to Zone
    | Hold of Unit * Zone                               // Army holds in Zone
    | SupportMovingUnit of Unit * Zone * Zone * Zone    // Army in Zone supports a unit moving from Zone to Zone
    | SupportHoldingUnit of Unit * Zone * Zone          // Army in Zone supports a unit holding in Zone
    | Convoy of Unit * Zone * Zone                      // Fleet in Zone convoys a unit to Zone

type BuildAction = 
    | Create of Unit
    | Disband of Unit