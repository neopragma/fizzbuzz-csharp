namespace FizzBuzzPBT
 
// Based on this gist by Mike Harris: https://gist.github.com/MikeMKH/783ef9b82d2987795be6
 
open Xunit
open FsCheck
open FsCheck.Xunit
open FizzBuzz
 
module ``FizzBuzz Property tests`` =

    [<Property>]
    let ``A number not divisible by 3 or 5 will return self as string`` (x:int) =
        let fb = Bubbler ()
        (x % 3 <> 0 && x % 5 <> 0)
        ==> (x.ToString() = fb.Percolate x)

    [<Property>]
    let ``A number not be divisible by 5 and multiplied by 3 will return Fizz`` (x:int) =
        let fb = Bubbler ()
        (x % 5 <> 0)
        ==> ("Fizz" = fb.Percolate (x * 3))
        
    [<Property>]
    let ``A number not be divisible by 3 and multiplied by 5 will return Buzz`` (x:int) =
        let fb = Bubbler ()
        (x % 3 <> 0)
        ==> ("Buzz" = fb.Percolate (x * 5))
    
    [<Property>]
    let ``A number multiplied 15 will return FizzBuzz`` (x:int) =
        let fb = Bubbler ()
        "FizzBuzz" = fb.Percolate (x * 15)
    
    //  more restrictive tests
    
    [<Property>]
    let ``A number not divisible by 5 but divisible by 3 will return Fizz`` (x:int) =
        let fb = Bubbler ()
        (x % 5 <> 0 && x % 3 = 0)
        ==> ("Fizz" = fb.Percolate x)
        
    [<Property>]
    let ``A number not divisible by 3 but divisible by 5 will return Buzz`` (x:int) =
        let fb = Bubbler ()
        (x % 3 <> 0 && x % 5 = 0)
        ==> ("Buzz" = fb.Percolate x)
    
    // will fail with "Arguments exhausted" if not limited to around 50
    [<Property(MaxTest=50)>]
    let ``A number divisible by 15 will return FizzBuzz`` (x:int) =
        let fb = Bubbler ()
        (x % 15 = 0)
        ==> ("FizzBuzz" = fb.Percolate x)