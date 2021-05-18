using System.Collections.Generic;
using gregslist_cs.Models;

namespace gregslist_cs.DB
{
    public static class FakeDB
    {
        public static List<Car> Cars {get; set;} = new List<Car>(){
            new Car("Subaru","Crosstrek", 2015, 25000,"Suzi the Subi", "https://cdn.dealerdna.com/modelimages/640x480/2021_33_9662_82887_000.jpg")
        };
    }
}