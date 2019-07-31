using System;

namespace AspNetCoreApp.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CI { get; set; }
        public int Cellphone { get; set; }
        public DateTime Birth { get; set; }

        public int Age
        {
            get
            {
                int Age = DateTime.Now.Year - Birth.Year;
                return (Birth.AddYears(Age) > DateTime.Now) ? Age -= 1 : Age;
            }
        }
    }
}