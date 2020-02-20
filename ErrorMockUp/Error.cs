/*
    Name: Ian Gregory
    Function: base class that represent errors
*/

namespace ErrorMockUp
{
    class Error
    {
        string message;
        public Error()
        {
            message = "Error road violaion";
        }
        public Error(string message)
        {
            this.message = message;
        }
 
        public virtual string Text
        {
            get { return message; }
            set { message = value; }
        }

        public virtual string toString() { return "Error"; }

    }


}
