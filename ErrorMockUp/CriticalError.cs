
namespace ErrorMockUp
{
    class CriticalError : Error
    {
        string message;
        public CriticalError()
        {
            message = "You have violated a rule of the road";
        }
        public CriticalError(string message)
        {
            this.message = message;
        }

        public override string Text
        {
            get { return message; }
            set { message = value; }
        }

        public override string toString() { return "CriticalError"; }
    }
}
