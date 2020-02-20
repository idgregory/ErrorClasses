using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorMockUp
{
    class SpeedError : Error
    {
        String message;
        public SpeedError()
        {
            message = "You are speeding";
        }

        public SpeedError(String message)
        {
            this.message = message;
        }

        public override string Text
        {
            get { return message; }
            set { message = value; }
        }

        public override string toString() { return "SpeedError"; }
    }
}
