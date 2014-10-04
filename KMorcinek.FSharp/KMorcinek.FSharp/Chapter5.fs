module Chapter5

open System

type Schedule =
  | Never
  | Once of DateTime
  | Repeatedly of DateTime * TimeSpan

let sch1 : Schedule = Never

let tomorrow = DateTime.Now.AddDays(1.0)

let sch2 = Once(tomorrow)

let occursNextWeek (schedule) =
    let isNextWeekDate dt =
        dt > DateTime.Now && dt < DateTime.Now.AddDays(7.0)

    match schedule with
    | Never -> false
    | Once(dt) -> isNextWeekDate(dt)
    | Repeatedly(dt, ts) ->
        let q = (DateTime.Now - dt).TotalSeconds /ts.TotalSeconds
        let q = max q 0.0
        let next = dt.AddSeconds(ts.TotalSeconds * (Math.Floor(q) + 1.0))

        isNextWeekDate(next)

let readInput() =
    let s = Console.ReadLine()
    let (succ, num) = Int32.TryParse(s)
    if (succ) then
        Some(num)
    else
        None

let testInput() =
    let inp = readInput()
    match inp with
    | None -> 
        printfn "missing"
    | Some(num) ->
        printfn "You entered %d" num

type IntOption = 
    | SomeInt of int
    | NoneInt

let readValue (opt) =
    match opt with
    | Some(v) -> v
    | None -> failwith "no value"
