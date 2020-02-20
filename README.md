# ErrorClasses

This project has 3 types of classes.
  *ErrorLog
  *Error(base class)
  *Error Types(Child Classes)
  
  ***Function of ErrorLog
    -Keeps a log of all the errors added to it.
    -returns list of each error sub category
    
    ***Function of Error
      -Is the base class for an error.  It holds an error message and the type of error
      ***Function of Error Types
        -Classes that inherits from error
        -Allows for generic errors
