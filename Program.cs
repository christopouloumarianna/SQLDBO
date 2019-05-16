using System;

namespace SQLDBO
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Msql();

            //db.M1sql(); // save to json data from server localhost

            db.InsertDB(); 

            Console.ReadLine();
        }
    }
}
