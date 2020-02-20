using System;
using System.Collections.Generic;

namespace ErrorMockUp
{
    class Program
    {
        static void Main(string[] args)
        {

            Error re = new StopError();
            Error se = new SpeedError();
            Error ce = new CriticalError();

            ErrorLog el = new ErrorLog();

            el.add(re);
            el.add(se);
            el.add(ce);

            List<Error> ruleError = el.getRuleErrors();
            List<Error> allErrors = el.getErrorList();
            Error criticalError = el.getCriticalError();

            Console.WriteLine("Showing Rule errors\n");

            foreach (Error value in ruleError)
                Console.WriteLine(value.Text);


            Console.WriteLine("\nShowing All Errors\n");
            foreach (Error value in allErrors)
                Console.WriteLine(value.toString());


            Console.ReadLine();
        }
    }
}
