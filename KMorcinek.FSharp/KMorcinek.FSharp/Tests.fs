module Tests
open Xunit
open Xunit.Should
open Types
open Logic

type TestClass() = 

    [<Fact>]
    let ``When 2 is added to 2 expect 4``() = 
        let pos1 = new Position(1, 1)
        let rabbit1 = new Rabbit(pos1, 1.0)
        let rabbit2 = new Rabbit(pos1, 11.0)
        let animals = [rabbit1; rabbit2]

        Assert.Equal(1, getAliveAnimals(animals).Length)
        Assert.Equal(11.0, getAliveAnimals(animals).Head.Food)

