using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Helpers.Entity;

namespace Helpers.Enum
{
    public  class Statuses : IEnumerable<IDName>
    {
        private static List<IDName> statuses = new List<IDName>
        {
            new IDName() {ID = 1, Name = "Pending"},
            new IDName() {ID = 2, Name = "Approved"}
        };

        public static IDName FindItem(int i)
        {
            return statuses.FirstOrDefault(Statuses => Statuses.ID == i);
        }

        public IEnumerator<IDName> GetEnumerator()
        {
            return statuses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return statuses.GetEnumerator();
        }
    }
}
