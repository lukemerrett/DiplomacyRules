module Countries

open Domain
open Powers

// England
let clyde =     {region.name="Clyde"; owner=england; isSupplyCenter=false; isCoastal=true}
let edinburgh = {region.name="Edinburgh"; owner=england; isSupplyCenter=true; isCoastal=true}
let liverpool = {region.name="Liverpool"; owner=england; isSupplyCenter=true; isCoastal=true}
let yorkshire = {region.name="Yorkshire"; owner=england; isSupplyCenter=false; isCoastal=true}
let wales =     {region.name="Wales"; owner=england; isSupplyCenter=false; isCoastal=true}
let london =    {region.name="London"; owner=england; isSupplyCenter=true; isCoastal=true}

// France
let brest =         {region.name="Brest"; owner=france; isSupplyCenter=true; isCoastal=true}
let picardy =       {region.name="Picardy"; owner=france; isSupplyCenter=false; isCoastal=true}
let paris =         {region.name="Paris"; owner=france; isSupplyCenter=true; isCoastal=false}
let gascony =       {region.name="Gascony"; owner=france; isSupplyCenter=false; isCoastal=true}
let burgundy =      {region.name="Burgundy"; owner=france; isSupplyCenter=false; isCoastal=false}
let marseilles =    {region.name="Marseilles"; owner=france; isSupplyCenter=true; isCoastal=true}

// Italy
let piedmont =  {region.name="Piedmont"; owner=italy; isSupplyCenter=false; isCoastal=true}
let tuscany =   {region.name="Tuscany"; owner=italy; isSupplyCenter=false; isCoastal=true}
let venice =    {region.name="Venice"; owner=italy; isSupplyCenter=true; isCoastal=true}
let rome =      {region.name="Rome"; owner=italy; isSupplyCenter=true; isCoastal=true}
let apulia =    {region.name="Apulia"; owner=italy; isSupplyCenter=false; isCoastal=true}
let naples =    {region.name="Naples"; owner=italy; isSupplyCenter=true; isCoastal=true}

// Germany
let ruhr =      {region.name="Ruhr"; owner=germany; isSupplyCenter=false; isCoastal=false}
let munich =    {region.name="Munich"; owner=germany; isSupplyCenter=true; isCoastal=false}
let silesia =   {region.name="Silesia"; owner=germany; isSupplyCenter=false; isCoastal=false}
let prussia =   {region.name="Prussia"; owner=germany; isSupplyCenter=false; isCoastal=true}
let berlin =    {region.name="Berlin"; owner=germany; isSupplyCenter=true; isCoastal=true}
let kiel =      {region.name="Kiel"; owner=germany; isSupplyCenter=true; isCoastal=true}

// Austria
let tyrolia =   {region.name="Tyrolia"; owner=austria; isSupplyCenter=false; isCoastal=false}
let bohemia =   {region.name="Bohemia"; owner=austria; isSupplyCenter=false; isCoastal=false}
let trieste =   {region.name="Trieste"; owner=austria; isSupplyCenter=true; isCoastal=true}
let vienna =    {region.name="Vienna"; owner=austria; isSupplyCenter=true; isCoastal=false}
let budapest =  {region.name="Budapest"; owner=austria; isSupplyCenter=true; isCoastal=false}
let galicia =   {region.name="Galicia"; owner=austria; isSupplyCenter=false; isCoastal=false}

// Turkey
let constantinople =    {region.name="Constantinople"; owner=turkey; isSupplyCenter=true; isCoastal=true}
let ankara =            {region.name="Ankara"; owner=turkey; isSupplyCenter=true; isCoastal=true}
let smyma =             {region.name="Smyma"; owner=turkey; isSupplyCenter=true; isCoastal=true}
let armenia =           {region.name="Armenia"; owner=turkey; isSupplyCenter=false; isCoastal=true}
let syria =             {region.name="Syria"; owner=turkey; isSupplyCenter=false; isCoastal=true}

// Russia
let sevastopol =    {region.name="Sevastopol"; owner=russia; isSupplyCenter=true; isCoastal=true}
let ukraine =       {region.name="Ukraine"; owner=russia; isSupplyCenter=false; isCoastal=false}
let warsaw =        {region.name="Warsaw"; owner=russia; isSupplyCenter=true; isCoastal=false}
let livonia =       {region.name="Livonia"; owner=russia; isSupplyCenter=false; isCoastal=true}
let moscow =        {region.name="Moscow"; owner=russia; isSupplyCenter=true; isCoastal=false}
let stpetersburg =  {region.name="St. Petersburg"; owner=russia; isSupplyCenter=true; isCoastal=true}
let finland =       {region.name="Finland"; owner=russia; isSupplyCenter=false; isCoastal=true}

// Neutral
let portugal =      {region.name="Portugal"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let spain =         {region.name="Spain"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let northafrica =   {region.name="North Africa"; owner=neutral; isSupplyCenter=false; isCoastal=true}
let tunisia =       {region.name="Tunisia"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let belgium =       {region.name="Beligum"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let holland =       {region.name="Holland"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let denmark =       {region.name="Denmark"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let norway =        {region.name="Norway"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let sweden =        {region.name="Sweden"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let albania =       {region.name="Albania"; owner=neutral; isSupplyCenter=false; isCoastal=true}
let greece =        {region.name="Greece"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let serbia =        {region.name="Serbia"; owner=neutral; isSupplyCenter=true; isCoastal=false}
let bulgaria =      {region.name="Bulgaria"; owner=neutral; isSupplyCenter=true; isCoastal=true}
let rumania =       {region.name="Rumania"; owner=neutral; isSupplyCenter=true; isCoastal=true}