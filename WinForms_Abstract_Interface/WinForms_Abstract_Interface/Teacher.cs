using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Abstract_Interface
{
    internal class Teacher : Member, Keynote
    {
        public bool approceCourse()
        {
            return true;
        }

        public override bool register()
        {
            return true;
        }

        public bool train()
        {
            return false;
        }
    }
}
