module Seasons

open Domain

type Season = {name:string; phases:Phase list}

type Year = {mutable year:int; seasons:Season list}

let spring = {Season.name="Spring"; phases=[Order; Retreat]}
let fall = {Season.name="Fall"; phases=[Order; Retreat; Build]}