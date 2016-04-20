using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_WinForm_Filters
{
    public class FilterApplier : IFilterSpecification
    {
        public string SearchPerson(string person)
        {
            return IsSatisfiedBy(person);
        }

        public string IsSatisfiedBy(string person)
        {
            return new WhiteListFilter().IsSatisfiedBy(new BlackListFilter().IsSatisfiedBy(person));
        }
    }
}
