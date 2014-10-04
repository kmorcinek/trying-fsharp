namespace Types

type Position =
    struct 
       val X : int
       val Y : int
       new(x, y) = { X = x; Y = y}
    end 

type Rabbit =
    struct 
       val Position : Position
       val Food : double
       new(position, food) = { Position = position; Food = food}
    end