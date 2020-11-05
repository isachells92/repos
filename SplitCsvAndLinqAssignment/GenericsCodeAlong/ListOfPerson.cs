using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsCodeAlong
{
    class ListOfPerson : IEnumerable,
    {
        Person[] people = new Person[2]; 
    }
}
