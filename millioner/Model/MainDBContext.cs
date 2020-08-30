using System;
using System.Collections.Generic;
using System.Text;

namespace millioner.Model
{
    class MainDBContext
    {

        static MillionerDBContext MillionerDBContext = new MillionerDBContext();

        private MainDBContext()
        {

        }

        public static MillionerDBContext GetMainContext()
        {
            if (MillionerDBContext == null) { MillionerDBContext = new MillionerDBContext(); }
            return MillionerDBContext;
        }


    }
}
