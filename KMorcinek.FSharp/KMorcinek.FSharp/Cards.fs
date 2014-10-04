module Cards

type Suit = 
    | Club 
    | Diamond 
    | Heart 
    | Spade

type Rank = 
    | Ace | Deuce | Trey | Four | Five  
    | Six | Seven | Eight | Nine | Ten 
    | Jack | Queen | King 
     
type Card =  
    | Card of Suit * Rank

let bullet = Card(Spade,Ace) 
printfn "%A" bullet
