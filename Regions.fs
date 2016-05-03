module Regions

open Domain
open Powers

// England
let clyde =     Region {Region.name="Clyde"; owner=england; startingPower=england; isSupplyCenter=false; isCoastal=true}
let edinburgh = Region {Region.name="Edinburgh"; owner=england; startingPower=england; isSupplyCenter=true; isCoastal=true}
let liverpool = Region {Region.name="Liverpool"; owner=england; startingPower=england; isSupplyCenter=true; isCoastal=true}
let yorkshire = Region {Region.name="Yorkshire"; owner=england; startingPower=england; isSupplyCenter=false; isCoastal=true}
let wales =     Region {Region.name="Wales"; owner=england; startingPower=england; isSupplyCenter=false; isCoastal=true}
let london =    Region {Region.name="London"; owner=england; startingPower=england; isSupplyCenter=true; isCoastal=true}

// France
let brest =         Region {Region.name="Brest"; owner=france; startingPower=france; isSupplyCenter=true; isCoastal=true}
let picardy =       Region {Region.name="Picardy"; owner=france; startingPower=france; isSupplyCenter=false; isCoastal=true}
let paris =         Region {Region.name="Paris"; owner=france; startingPower=france; isSupplyCenter=true; isCoastal=false}
let gascony =       Region {Region.name="Gascony"; owner=france; startingPower=france; isSupplyCenter=false; isCoastal=true}
let burgundy =      Region {Region.name="Burgundy"; owner=france; startingPower=france; isSupplyCenter=false; isCoastal=false}
let marseilles =    Region {Region.name="Marseilles"; owner=france; startingPower=france; isSupplyCenter=true; isCoastal=true}

// Italy
let piedmont =  Region {Region.name="Piedmont"; owner=italy; startingPower=italy; isSupplyCenter=false; isCoastal=true}
let tuscany =   Region {Region.name="Tuscany"; owner=italy; startingPower=italy; isSupplyCenter=false; isCoastal=true}
let venice =    Region {Region.name="Venice"; owner=italy; startingPower=italy; isSupplyCenter=true; isCoastal=true}
let rome =      Region {Region.name="Rome"; owner=italy; startingPower=italy; isSupplyCenter=true; isCoastal=true}
let apulia =    Region {Region.name="Apulia"; owner=italy; startingPower=italy; isSupplyCenter=false; isCoastal=true}
let naples =    Region {Region.name="Naples"; owner=italy; startingPower=italy; isSupplyCenter=true; isCoastal=true}

// Germany
let ruhr =      Region {Region.name="Ruhr"; owner=germany; startingPower=germany; isSupplyCenter=false; isCoastal=false}
let munich =    Region {Region.name="Munich"; owner=germany; startingPower=germany; isSupplyCenter=true; isCoastal=false}
let silesia =   Region {Region.name="Silesia"; owner=germany; startingPower=germany; isSupplyCenter=false; isCoastal=false}
let prussia =   Region {Region.name="Prussia"; owner=germany; startingPower=germany; isSupplyCenter=false; isCoastal=true}
let berlin =    Region {Region.name="Berlin"; owner=germany; startingPower=germany; isSupplyCenter=true; isCoastal=true}
let kiel =      Region {Region.name="Kiel"; owner=germany; startingPower=germany; isSupplyCenter=true; isCoastal=true}

// Austria
let tyrolia =   Region {Region.name="Tyrolia"; owner=austria; startingPower=austria; isSupplyCenter=false; isCoastal=false}
let bohemia =   Region {Region.name="Bohemia"; owner=austria; startingPower=austria; isSupplyCenter=false; isCoastal=false}
let trieste =   Region {Region.name="Trieste"; owner=austria; startingPower=austria; isSupplyCenter=true; isCoastal=true}
let vienna =    Region {Region.name="Vienna"; owner=austria; startingPower=austria; isSupplyCenter=true; isCoastal=false}
let budapest =  Region {Region.name="Budapest"; owner=austria; startingPower=austria; isSupplyCenter=true; isCoastal=false}
let galicia =   Region {Region.name="Galicia"; owner=austria; startingPower=austria; isSupplyCenter=false; isCoastal=false}

// Turkey
let constantinople =    Region {Region.name="Constantinople"; owner=turkey; startingPower=turkey; isSupplyCenter=true; isCoastal=true}
let ankara =            Region {Region.name="Ankara"; owner=turkey; startingPower=turkey; isSupplyCenter=true; isCoastal=true}
let smyma =             Region {Region.name="Smyma"; owner=turkey; startingPower=turkey; isSupplyCenter=true; isCoastal=true}
let armenia =           Region {Region.name="Armenia"; owner=turkey; startingPower=turkey; isSupplyCenter=false; isCoastal=true}
let syria =             Region {Region.name="Syria"; owner=turkey; startingPower=turkey; isSupplyCenter=false; isCoastal=true}

// Russia
let sevastopol =    Region {Region.name="Sevastopol"; owner=russia; startingPower=russia; isSupplyCenter=true; isCoastal=true}
let ukraine =       Region {Region.name="Ukraine"; owner=russia; startingPower=russia; isSupplyCenter=false; isCoastal=false}
let warsaw =        Region {Region.name="Warsaw"; owner=russia; startingPower=russia; isSupplyCenter=true; isCoastal=false}
let livonia =       Region {Region.name="Livonia"; owner=russia; startingPower=russia; isSupplyCenter=false; isCoastal=true}
let moscow =        Region {Region.name="Moscow"; owner=russia; startingPower=russia; isSupplyCenter=true; isCoastal=false}
let stpetersburg =  Region {Region.name="St. Petersburg"; owner=russia; startingPower=russia; isSupplyCenter=true; isCoastal=true}
let finland =       Region {Region.name="Finland"; owner=russia; startingPower=russia; isSupplyCenter=false; isCoastal=true}

// Neutral
let portugal =      Region {Region.name="Portugal"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let spain =         Region {Region.name="Spain"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let northafrica =   Region {Region.name="North Africa"; owner=neutral; startingPower=neutral; isSupplyCenter=false; isCoastal=true}
let tunisia =       Region {Region.name="Tunisia"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let belgium =       Region {Region.name="Beligum"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let holland =       Region {Region.name="Holland"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let denmark =       Region {Region.name="Denmark"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let norway =        Region {Region.name="Norway"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let sweden =        Region {Region.name="Sweden"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let albania =       Region {Region.name="Albania"; owner=neutral; startingPower=neutral; isSupplyCenter=false; isCoastal=true}
let greece =        Region {Region.name="Greece"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let serbia =        Region {Region.name="Serbia"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=false}
let bulgaria =      Region {Region.name="Bulgaria"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let rumania =       Region {Region.name="Rumania"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}

// Seas
let englishChannel =    Sea "English Channel"