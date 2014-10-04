module RabbitProblem

type Position =
    struct 
       val X : int
       val Y : int
       new(x, y) = { X = x; Y = y}
    end 

let moveLeft (positions: Position List) =
    List.map (fun (n:Position) -> new Position(n.X, 2)) positions
