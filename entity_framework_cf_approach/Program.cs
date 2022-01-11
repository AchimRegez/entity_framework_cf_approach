using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;

namespace entity_framework_cf_approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var stud = new Student() { FirstName = "Bill", LastName = "Harw", Age = 18, MajorSubject = "Anthropology", City = "Belgrade" };
                var pers = new Person() { FirstName = "Clara", LastName = "Sclak", Age = 21, City = "Munich" };

                var foundPersons = context.Persons.Where(p => p.City == "Munich");

                context.Students.Add(stud);
                context.Persons.Add(pers);
                context.SaveChanges();
            }
        }
    }
}
