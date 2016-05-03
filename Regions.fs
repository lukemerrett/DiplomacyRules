module Regions

open Domain
open Powers

// England
let clyde =     {Region.name="Clyde"; owner=england; isSupplyCenter=false; isCoastal=true}
let edinburgh = {Region.name="Edinburgh"; owner=england; isSupplyCenter=true; isCoastal=true}
let liverpool = {Region.name="Liverpool"; owner=england; isSupplyCenter=true; isCoastal=true}
let yorkshire = {Region.name="Yorkshire"; owner=england; isSupplyCenter=false; isCoastal=true}
let wales =     {Region.name="Wales"; owner=england; isSupplyCenter=false; isCoastal=true}
let london =    {Region.name="London"; owner=england; isSupplyCenter=true; isCoastal=true}

// France
let brest =         {Region.name="Brest"; owner=france; isSupplyCenter=true; isCoastal=true}
let picardy =       {Region.name="Picardy"; owner=france; isSupplyCenter=false; isCoastal=true}
let paris =         {Region.name="Paris"; owner=france; isSupplyCenter=true; isCoastal=false}
let gascony =       {Region.name="Gascony"; owner=france; isSupplyCenter=false; isCoastal=true}
let burgundy =      {Region.name="Burgundy"; owner=france; isSupplyCenter=false; isCoastal=false}
let marseilles =    {Region.name="Marseilles"; owner=france; isSupplyCenter=true; isCoastal=true}

// Italy
let piedmont =  {Region.name="Piedmont"; owner=italy; isSupplyCenter=false; isCoastal=true}
let tuscany =   {Region.name="Tuscany"; owner=italy; isSupplyCenter=false; isCoastal=true}
let venice =    {Region.name="Venice"; owner=italy; isSupplyCenter=true; isCoastal=true}
let rome =      {Region.name="Rome"; owner=italy; isSupplyCenter=true; isCoastal=true}
let apulia =    {Region.name="Apulia"; owner=italy; isSupplyCenter=false; isCoastal=true}
let naples =    {Region.name="Naples"; owner=italy; isSupplyCenter=true; isCoastal=true}

// Germany
let ruhr =      {Region.name="Ruhr"; owner=germany; isSupplyCenter=false; isCoastal=false}
let munich =    {Region.name="Munich"; owner=germany; isSupplyCenter=true; isCoastal=false}
let silesia =   {Region.name="Silesia"; owner=germany; isSupplyCenter=false; isCoastal=false}
let prussia =   {Region.name="Prussia"; owner=germany; isSupplyCenter=false; isCoastal=true}
let berlin =    {Region.name="Berlin"; owner=germany; isSupplyCenter=true; isCoastal=true}
let kiel =      {Region.name="Kiel"; owner=germany; isSupplyCenter=true; isCoastal=true}

// Austria
let tyrolia =   {Region.name="Tyrolia"; owner=austria; isSupplyCenter=false; isCoastal=false}
let bohemia =   {Region.name="Bohemia"; owner=austria; isSupplyCenter=false; isCoastal=false}
let trieste =   {Region.name="Trieste"; owner=austria; isSupplyCenter=true; isCoastal=true}
let vienna =    {Region.name="Vienna"; owner=austria; isSupplyCenter=true; isCoastal=false}
let budapest =  {Region.name="Budapest"; owner=austria; isSupplyCenter=true; isCoastal=false}
let galicia =   {Region.name="Galicia"; owner=austria; isSupplyCenter=false; isCoastal=false}

// Turkey
let constantinople =    {Region.name="Constantinople"; owner=turkey; isSupplyCenter=true; isCoastal=true}
let ankara =            {Region.name="Ankara"; owner=turkey; isSupplyCenter=true; isCoastal=true}
let smyma =             {Region.name="Smyma"; owner=turkey; isSupplyCenter=true; isCoastal=true}
let armenia =           {Region.name="Armenia"; owner=turkey; isSupplyCenter=false; isCoastal=true}
let syria =             {Region.name="Syria"; owner=turkey; isSupplyCenter=false; isCoastal=true}

// Russia
let sevastopol =    {Region.name="Sevastopol"; owner=russia; isSupplyCenter=true; isCoastal=true}
let ukraine =       {Region.name="Ukraine"; owner=russia; isSupplyCenter=false; isCoastal=false}
let warsaw =        {Region.name="Warsaw"; owner=russia; isSupplyCenter=true; isCoastal=false}
let livonia =       {Region.name="Livonia"; owner=russia; isSupplyCenter=false; isCoastal=true}
let moscow =        {Region.name="Moscow"; owner=russia; isSupplyCenter=true; isCoastal=false}
let stpetersburg =  {Region.name="St. Petersburg"; owner=russia; isSupplyCenter=true; isCoastal=true}
let finland =       {Region.name="Finland"; owner=russia; isSupplyCenter=false; isCoastal=true}

// Neutral
let portugal =      {Region.name="Portugal"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let spain =         {Region.name="Spain"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let northafrica =   {Region.name="North Africa"; owner=neutral; isSupplyCenter=false; isCoastal=true}
let tunisia =       {Region.name="Tunisia"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let belgium =       {Region.name="Beligum"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let holland =       {Region.name="Holland"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let denmark =       {Region.name="Denmark"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let norway =        {Region.name="Norway"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let sweden =        {Region.name="Sweden"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let albania =       {Region.name="Albania"; owner=neutral; isSupplyCenter=false; isCoastal=true}
let greece =        {Region.name="Greece"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let serbia =        {Region.name="Serbia"; owner=neutral; isSupplyCenter=true; isCoastal=false}
let bulgaria =      {Region.name="Bulgaria"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let rumania =       {Region.name="Rumania"; owner=neutral; isSupplyCenter=true; isCoastal=true}

// Todo: Map the seas as well