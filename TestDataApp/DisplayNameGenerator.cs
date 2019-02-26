using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataApp
{
    public class DisplayNameGenerator
    {
        private readonly PersonData personData;

        public DisplayNameGenerator(PersonData personData)
        {
            this.personData = personData ?? throw new ArgumentNullException(nameof(personData));
        }

        public string GetDisplayName()
        {
            string r = String.Format("{0} {1} ({2})", personData.FirstName, personData.LastName, personData.Age);
            return r;
        }
    }
}
