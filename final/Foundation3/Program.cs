using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("001 Oluseyi St", "Eleyele", "Oyo State", "Nigeria");
        Address address2 = new Address("25", "Coker Alhaja St", "Lagos State", "Nigeria");
        Address address3 = new Address("227 Shelter Afrique", "Uyo City", "Akwa Ibom State", "Nigeria");

        Event lecture = new Lecture("Tech Talk", "A talk on the latest in tech.", new DateTime(2024, 7, 10), new TimeSpan(14, 0, 0), address1, "Jane Doe", 100);
        Event reception = new Reception("Wedding Reception", "Celebrating the union of Hickley and Faith .", new DateTime(2024, 8, 5), new TimeSpan(18, 0, 0), address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Company Picnic", "Annual company picnic with fun activities.", new DateTime(2024, 9, 15), new TimeSpan(11, 0, 0), address3, "Sunny with a chance of rain");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var evt in events)
        {
            Console.WriteLine(evt.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(evt.FullDetails());
            Console.WriteLine();
            Console.WriteLine(evt.ShortDescription());
            Console.WriteLine();
        }
    }
}