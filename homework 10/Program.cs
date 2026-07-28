using homework_10.enums;

namespace homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {






            Employ emp1 = new Employ(
           "Giorgi",
           "Giorgadze",
           new DateTime(1998, 5, 10),
           Country.Georgia,
           Gender.Male,
           new Contact()
       );

            Employ emp2 = new Employ(
                "Nino",
                "Ninoshvili",
                new DateTime(1999, 8, 15),
                Country.Georgia,
                Gender.Female,
                new Contact()
            );

            Employ emp3 = new Employ(
                "John",
                "Smith",
                new DateTime(1995, 3, 20),
                Country.Germany,
                Gender.Male,
                new Contact()
            );

            Employ emp4 = new Employ(
                "Emma",
                "Brown",
                new DateTime(1997, 11, 5),
                Country.Germany,
                Gender.Female,
                new Contact()
            );

            Employ emp5 = new Employ(
                "Hans",
                "Muller",
                new DateTime(1993, 7, 18),
                Country.Spain,
                Gender.Male,
                new Contact()
            );

            Employ emp6 = new Employ(
                "Anna",
                "Schmidt",
                new DateTime(1996, 9, 25),
                Country.Spain,
                Gender.Female,
                new Contact()
            );

            Employ emp7 = new Employ(
                "Pierre",
                "Martin",
                new DateTime(1994, 2, 12),
                Country.China,
                Gender.Male,
                new Contact()
            );

            Employ emp8 = new Employ(
                "Sophie",
                "Dubois",
                new DateTime(1998, 12, 30),
                Country.China,
                Gender.Female,
                new Contact()
            );




            Employ[] employs = new Employ[8];

            employs[0] = emp1;
            employs[1] = emp2;
            employs[2] = emp3;
            employs[3] = emp4;
            employs[4] = emp5;
            employs[5] = emp6;
            employs[6] = emp7;
            employs[7] = emp8;









            GetCountry.GetCntry(employs, Country.Germany);




        }
    }
}
