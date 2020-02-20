using System;


namespace ErrorMockUp
{
    class StopError : Error
    {
        private String message;
        public StopError()
        {
            message = "Failed to stop";
        }

        public StopError(String message)
        {
            this.message = message;
        }

        public override string Text
        {
            get { return message; }
            set { message = value; }
        }

        public override string toString() { return "StopError"; }
    }
}
