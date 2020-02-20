using System.Collections.Generic;

namespace ErrorMockUp
{


    class ErrorLog
    {
        private List<Error> ruleList;
        private List<Error> navList;
        private List<Error> specialList;
        private List<Error> errorList;
        Error critical;


        //Constructor
        public ErrorLog()
        {
            ruleList = new List<Error>();
            navList = new List<Error>();
            specialList = new List<Error>();
            errorList = new List<Error>();
            critical = null;
        }

        //Adds Error to specified list depending on error trait
        public void add(Error e)
        {

            if (e.toString() == "StopError" || e.toString() == "SpeedError") ruleList.Add(e);
            else if (false) navList.Add(e);
            else if (false) specialList.Add(e);
            else if (e.toString() == "CriticalError") critical = new CriticalError();
            else return;

            errorList.Add(e);


        }

        //returns list of rule errors
        public List<Error> getRuleErrors() { return ruleList; }

        //returns list of nav errors
        public List<Error> getNavErrors() { return navList; }

        //returns list of special errors
        public List<Error> getSpecialErrors() { return specialList; }

        //returns critical error
        public Error getCriticalError() { return critical; }

        //returns list with all errors
        public List<Error> getErrorList() {return errorList; }

    }
}
