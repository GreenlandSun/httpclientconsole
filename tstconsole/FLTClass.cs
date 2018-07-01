using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tstconsole
{
    public class Rootobject
    {
        public string InfoType { get; set; }
        public string Carrier { get; set; }
        public int Flight { get; set; }
        public DateTime OpDate { get; set; }
        public string REG { get; set; }
        public string DEP { get; set; }
        public string ARR { get; set; }
        public DateTime STD { get; set; }
        public DateTime STA { get; set; }
        public int BlockedSeats { get; set; }
        public Carryin[] CarryIn { get; set; }
        public Stbid[] StbID { get; set; }
        public Stbfullprice[] StbFullPrice { get; set; }
        public Bookedpax[] BookedPAX { get; set; }
        public Acceptedpax[] AcceptedPAX { get; set; }
        public Boardedpax[] BoardedPAX { get; set; }
        public Bookedssr[] BookedSSRs { get; set; }
        public Acceptedssr[] AcceptedSSRs { get; set; }
        public Forecastbag[] ForecastBags { get; set; }
        public Acceptedbag[] AcceptedBags { get; set; }
        public Bookedspecialbag[] BookedSpecialBags { get; set; }
        public Acceptedspecialbag[] AcceptedSpecialBags { get; set; }
        public AC_Config[] AC_Config { get; set; }
        public Leg_Config[] Leg_Config { get; set; }
    }

    public class Carryin
    {
        public string Carrier { get; set; }
        public int Flight { get; set; }
        public Carryinbag[] CarryInBags { get; set; }
    }

    public class Carryinbag
    {
        public string Destination { get; set; }
        public string BagType { get; set; }
        public int BagCount { get; set; }
        public int BagWeight { get; set; }
    }

    public class Stbid
    {
        public string Destination { get; set; }
        public string Cabin { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; }
    }

    public class Stbfullprice
    {
        public string Destination { get; set; }
        public string Cabin { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; }
    }

    public class Bookedpax
    {
        public string Destination { get; set; }
        public string Cabin { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; }
    }

    public class Acceptedpax
    {
        public string Destination { get; set; }
        public string Cabin { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; }
    }

    public class Boardedpax
    {
        public string Destination { get; set; }
        public string Cabin { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
        public int Infant { get; set; }
    }

    public class Bookedssr
    {
        public string Destination { get; set; }
        public string SSR { get; set; }
        public int Count { get; set; }
    }

    public class Acceptedssr
    {
        public string Destination { get; set; }
        public string SSR { get; set; }
        public int Count { get; set; }
    }

    public class Forecastbag
    {
        public string Destination { get; set; }
        public string BagType { get; set; }
        public int BagCount { get; set; }
        public int BagWeight { get; set; }
    }

    public class Acceptedbag
    {
        public string Destination { get; set; }
        public string BagType { get; set; }
        public int BagCount { get; set; }
        public int BagWeight { get; set; }
    }

    public class Bookedspecialbag
    {
        public string Destination { get; set; }
        public string BagType { get; set; }
        public int BagCount { get; set; }
        public int BagWeight { get; set; }
    }

    public class Acceptedspecialbag
    {
        public string Destination { get; set; }
        public string BagType { get; set; }
        public int BagCount { get; set; }
        public int BagWeight { get; set; }
    }

    public class AC_Config
    {
        public string CabinClass { get; set; }
        public int Seats { get; set; }
    }

    public class Leg_Config
    {
        public string CabinClass { get; set; }
        public int Seats { get; set; }
    }
}
