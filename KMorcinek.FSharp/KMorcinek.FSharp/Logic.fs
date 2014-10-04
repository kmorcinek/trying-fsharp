module Logic

open Types

let pos1 = new Position(1, 1)
let rabbit1 = new Rabbit(pos1, 1.0)
let rabbit2 = new Rabbit(pos1, 11.0)

let rabbits = [rabbit1;rabbit2]

let sumRabbits list =
   let rec loop list acc =
       match list with
       | (head:Rabbit) :: tail -> loop tail (acc + head.Food)
       | [] -> acc
   loop list 0.0

let lista = [ 1.1; 2.1; 3.2 ]

let isRabbitAlive (rabbit:Rabbit) =
    rabbit.Food >= 5.0

let getAliveAnimals (rabbits: Rabbit List) =
    List.filter isRabbitAlive rabbits

List.iter (fun (elem:Rabbit) -> printf "%f " elem.Food) rabbits

let isParrent (rabbit:Rabbit) =
    rabbit.Food > 50.0

let getParrents (rabbits: Rabbit List) =
    List.filter isParrent rabbits

let getChildren (rabbits: Rabbit List) =
    rabbits
    |> List.map (fun (n:Rabbit) -> new Rabbit(n.Position, 2.0)) 
    


