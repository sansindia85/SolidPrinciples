using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleUI
{
    internal class PersonValidator
    {
        internal static bool Validate(Person person)
        {
            //Checks to be sure the first and last name are valid
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
