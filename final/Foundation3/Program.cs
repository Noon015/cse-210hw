using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("237 Coconut Ave.","Atlanta","Georgia","USA");
        Address address2 = new Address("999 Green Blvd.", "Flagstaff","Arizona","USA");
        Address address3 = new Address("1230 Bread St.","New York","New York","USA");

        DateTime date1 = new DateTime(2025,12,31);
        DateTime date2 = new DateTime(2026,3,14);
        DateTime date3 = new DateTime(2027,9,23);

        TimeSpan time1 = new TimeSpan(10,30,00);
        TimeSpan time2 = new TimeSpan(13,45,00);
        TimeSpan time3 = new TimeSpan(19,00,00);

        Lecture myLecture = new Lecture("Lecture on Nuclear Physics","A lecture on the basics of nucelar physics and how it pertains to real world applications",date1,time1,address1,"Max Planck",100);
        Reception myReception = new Reception("Wedding Reception of Laura and Mike Bailey","A wedding reception to celevrate the Marraiage of Mike Bailey and Laura Figglestein",date2,time2,address2,"fleshmuncher420@yahoo.com");
        Outdoor myOutdoor = new Outdoor("Boy Scout Jamboree","A jamboree and competition for the 23 troop of Boy Scouts and the 34 troop of Cub Scouts",date3,time3,address3,"Partly cloudy with chance for meatballs");

        string fullLecture = myLecture.FullDetails();
        string fullReception = myReception.FullDetails();
        string fullOutdoor = myOutdoor.FullDetails();
        
        Console.WriteLine("***********************************************");
        Console.WriteLine(fullLecture);
        Console.WriteLine("***********************************************");
        Console.WriteLine(fullReception);
        Console.WriteLine("***********************************************");
        Console.WriteLine(fullOutdoor);
         Console.WriteLine("***********************************************");

    }
}