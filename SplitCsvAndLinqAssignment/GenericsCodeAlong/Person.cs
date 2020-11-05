using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsCodeAlong
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        //public int Age                                    // old syntax  !
        //{
        //    get
        //    {
        //        return DateTime.Now.Year - BirthYear;
        //    }
        //}
        public int Age => DateTime.Now.Year - BirthYear;    // New Syntax  !

    }
}
