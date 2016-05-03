module Regions

open Domain
open Powers

// England
let clyde =     {Region.name="Clyde"; owner=england; startingPower=england; isSupplyCenter=false; isCoastal=true}
let edinburgh = {Region.name="Edinburgh"; owner=england; startingPower=england; isSupplyCenter=true; isCoastal=true}
let liverpool = {Region.name="Liverpool"; owner=england; startingPower=england; isSupplyCenter=true; isCoastal=true}
let yorkshire = {Region.name="Yorkshire"; owner=england; startingPower=england; isSupplyCenter=false; isCoastal=true}
let wales =     {Region.name="Wales"; owner=england; startingPower=england; isSupplyCenter=false; isCoastal=true}
let london =    {Region.name="London"; owner=england; startingPower=england; isSupplyCenter=true; isCoastal=true}

// France
let brest =         {Region.name="Brest"; owner=france; startingPower=france; isSupplyCenter=true; isCoastal=true}
let picardy =       {Region.name="Picardy"; owner=france; startingPower=france; isSupplyCenter=false; isCoastal=true}
let paris =         {Region.name="Paris"; owner=france; startingPower=france; isSupplyCenter=true; isCoastal=false}
let gascony =       {Region.name="Gascony"; owner=france; startingPower=france; isSupplyCenter=false; isCoastal=true}
let burgundy =      {Region.name="Burgundy"; owner=france; startingPower=france; isSupplyCenter=false; isCoastal=false}
let marseilles =    {Region.name="Marseilles"; owner=france; startingPower=france; isSupplyCenter=true; isCoastal=true}

// Italy
let piedmont =  {Region.name="Piedmont"; owner=italy; startingPower=italy; isSupplyCenter=false; isCoastal=true}
let tuscany =   {Region.name="Tuscany"; owner=italy; startingPower=italy; isSupplyCenter=false; isCoastal=true}
let venice =    {Region.name="Venice"; owner=italy; startingPower=italy; isSupplyCenter=true; isCoastal=true}
let rome =      {Region.name="Rome"; owner=italy; startingPower=italy; isSupplyCenter=true; isCoastal=true}
let apulia =    {Region.name="Apulia"; owner=italy; startingPower=italy; isSupplyCenter=false; isCoastal=true}
let naples =    {Region.name="Naples"; owner=italy; startingPower=italy; isSupplyCenter=true; isCoastal=true}

// Germany
let ruhr =      {Region.name="Ruhr"; owner=germany; startingPower=germany; isSupplyCenter=false; isCoastal=false}
let munich =    {Region.name="Munich"; owner=germany; startingPower=germany; isSupplyCenter=true; isCoastal=false}
let silesia =   {Region.name="Silesia"; owner=germany; startingPower=germany; isSupplyCenter=false; isCoastal=false}
let prussia =   {Region.name="Prussia"; owner=germany; startingPower=germany; isSupplyCenter=false; isCoastal=true}
let berlin =    {Region.name="Berlin"; owner=germany; startingPower=germany; isSupplyCenter=true; isCoastal=true}
let kiel =      {Region.name="Kiel"; owner=germany; startingPower=germany; isSupplyCenter=true; isCoastal=true}

// Austria
let tyrolia =   {Region.name="Tyrolia"; owner=austria; startingPower=austria; isSupplyCenter=false; isCoastal=false}
let bohemia =   {Region.name="Bohemia"; owner=austria; startingPower=austria; isSupplyCenter=false; isCoastal=false}
let trieste =   {Region.name="Trieste"; owner=austria; startingPower=austria; isSupplyCenter=true; isCoastal=true}
let vienna =    {Region.name="Vienna"; owner=austria; startingPower=austria; isSupplyCenter=true; isCoastal=false}
let budapest =  {Region.name="Budapest"; owner=austria; startingPower=austria; isSupplyCenter=true; isCoastal=false}
let galicia =   {Region.name="Galicia"; owner=austria; startingPower=austria; isSupplyCenter=false; isCoastal=false}

// Turkey
let constantinople =    {Region.name="Constantinople"; owner=turkey; startingPower=turkey; isSupplyCenter=true; isCoastal=true}
let ankara =            {Region.name="Ankara"; owner=turkey; startingPower=turkey; isSupplyCenter=true; isCoastal=true}
let smyma =             {Region.name="Smyma"; owner=turkey; startingPower=turkey; isSupplyCenter=true; isCoastal=true}
let armenia =           {Region.name="Armenia"; owner=turkey; startingPower=turkey; isSupplyCenter=false; isCoastal=true}
let syria =             {Region.name="Syria"; owner=turkey; startingPower=turkey; isSupplyCenter=false; isCoastal=true}

// Russia
let sevastopol =    {Region.name="Sevastopol"; owner=russia; startingPower=russia; isSupplyCenter=true; isCoastal=true}
let ukraine =       {Region.name="Ukraine"; owner=russia; startingPower=russia; isSupplyCenter=false; isCoastal=false}
let warsaw =        {Region.name="Warsaw"; owner=russia; startingPower=russia; isSupplyCenter=true; isCoastal=false}
let livonia =       {Region.name="Livonia"; owner=russia; startingPower=russia; isSupplyCenter=false; isCoastal=true}
let moscow =        {Region.name="Moscow"; owner=russia; startingPower=russia; isSupplyCenter=true; isCoastal=false}
let stpetersburg =  {Region.name="St. Petersburg"; owner=russia; startingPower=russia; isSupplyCenter=true; isCoastal=true}
let finland =       {Region.name="Finland"; owner=russia; startingPower=russia; isSupplyCenter=false; isCoastal=true}

// Neutral
let portugal =      {Region.name="Portugal"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let spain =         {Region.name="Spain"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let northafrica =   {Region.name="North Africa"; owner=neutral; startingPower=neutral; isSupplyCenter=false; isCoastal=true}
let tunisia =       {Region.name="Tunisia"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let belgium =       {Region.name="Beligum"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let holland =       {Region.name="Holland"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let denmark =       {Region.name="Denmark"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let norway =        {Region.name="Norway"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let sweden =        {Region.name="Sweden"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let albania =       {Region.name="Albania"; owner=neutral; startingPower=neutral; isSupplyCenter=false; isCoastal=true}
let greece =        {Region.name="Greece"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let serbia =        {Region.name="Serbia"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=false}
let bulgaria =      {Region.name="Bulgaria"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}
let rumania =       {Region.name="Rumania"; owner=neutral; startingPower=neutral; isSupplyCenter=true; isCoastal=true}

// Todo: Map the seas as well