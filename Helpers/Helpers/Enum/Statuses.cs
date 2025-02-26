using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Helpers.Entity;
using Helpers.Utilities;


namespace Helpers.Enum
{
    public  class Statuses : Enumeration
    {
        public static readonly Statuses Pending = new Statuses(1, "Pending");
        public static readonly Statuses Completed = new Statuses(2, "Completed");

        private Statuses() { }
        private Statuses(int value, string displayName) : base(value, displayName) { }
    }
}
