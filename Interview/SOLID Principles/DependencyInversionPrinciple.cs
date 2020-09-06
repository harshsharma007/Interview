using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interview.SOLID_Principles
{
    class DependencyInversionPrinciple
    {
        /*
            The Dependency Inversion Principle (DIP) states that high-level modules/classes should not depend on low-level modules/classes. Both should depend upon
            abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions.

            High-level module/classes implement business rule or logic in a system(application). Low-level modules/classes deal with more detailed operations;
            in other words they may deal with writing information to databases or passing messages to the operating system or services.

            A high-level module/class that has dependency on low-level modules/classes or some other class and knows a lot about the other classes it interacts with
            is said to be tightly coupled. When a class knows explicity about the design and implementation of another class, it raises the risk that changes to one
            class will break the other class. So we must keep these high-level modules/classes loosely coupled as much as we can. To do that, we need to make both
            of them dependent on abstractions instead of knowing each other.
        */
    }

    //Suppose we need to work on an error logging module that logs exception stack trace into a file.
    public class FileLogger
    {
        public void LogMessage(string StackTrace)
        {

        }
    }

    public class ExceptionLogger
    {
        public void LogIntoFile(Exception exception)
        {
            FileLogger objFileLogger = new FileLogger();
            objFileLogger.LogMessage(exception.ToString());
        }
    }

    //A client class exports data from many files into database.
    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {

            }
            catch(Exception ex)
            {
                new ExceptionLogger().LogIntoFile(ex);
            }
        }
    }

    /*
        We have sent our application to the client. But our client wants to store this stack trace in a database if an IO exception occurs. Here we need to add
        one more class that provides the functionality to log the stack trace into the database and an extra method in ExceptionLogger to interact with our new class.
    */

    public class DbLogger
    {
        public void LogMessage(string Message)
        {
            //Code to write message in database.
        }
    }

    public class FileLoggerNew
    {
        public void LogMessage(string StackTrace)
        {

        }
    }

    public class ExceptionLoggerNew
    {
        public void LogIntoFile(Exception exception)
        {
            FileLoggerNew fileLoggerNew = new FileLoggerNew();
            fileLoggerNew.LogMessage(exception.ToString());
        }

        public void LogIntoDatabase(Exception exception)
        {
            DbLogger dbLogger = new DbLogger();
            dbLogger.LogMessage(exception.ToString());
        }
    }

    public class DataExporterNew
    {
        public void ExportDataFromFile()
        {
            try
            {

            }
            catch(IOException ex)
            {
                new ExceptionLoggerNew().LogIntoDatabase(ex);
            }
            catch(Exception ex)
            {
                new ExceptionLoggerNew().LogIntoFile(ex);
            }
        }
    }

    /*
        Looks fine for now. But whenever the client wants to introduce a new logger, we need to alter ExceptionLogger by adding a new method. If we continue doing
        this, after sometime we will see a fat ExceptionLogger class with a large set of methods that provide the functionality to log a message into various targets.
        Why does this occur? Because ExceptionLogger direclty contacts the low-level classes FileLogger and DbLogger to log the exception. We need to alter the
        design so that this ExceptionLogger class can be loosely coupled with those class. To do that we need to introduce an abstraction between them, so that
        ExceptionLogger can contact the abstraction to log the exception instead of depending on the low-level classes directly.
    */

    public interface ILogger
    {
        void LogMessage(string Message);
    }

    //Now our low-level classes need to implement this interface
    public class DbLoggers : ILogger
    {
        public void LogMessage(string Message)
        {

        }
    }

    public class FileLoggers : ILogger
    {
        public void LogMessage(string Message)
        {

        }
    }

    /*
        Now, we move to the low-level class initiation from the ExceptionLogger class to the DataExporter class to make ExceptionLogger loosely coupled with the
        low-level classes FileLogger and EventLogger. By doing this, we are giving provision to DataExporter class to decide what kind of Logger should be called based
        on the exception that occurs.
    */

    public class ExceptionLoggers
    {
        private ILogger _logger;

        public ExceptionLoggers(ILogger logger)
        {
            this._logger = logger;
        }

        public void LogException(Exception exception)
        {
            this._logger.LogMessage(exception.ToString());
        }
    }

    public class DataExporters
    {
        public void ExportDataFromFile()
        {
            ExceptionLoggers exceptionLogger;
            try
            {

            }
            catch(IOException ex)
            {
                exceptionLogger = new ExceptionLoggers(new DbLoggers());
                exceptionLogger.LogException(ex);
            }
            catch(Exception ex)
            {
                exceptionLogger = new ExceptionLoggers(new FileLoggers());
                exceptionLogger.LogException(ex);
            }
        }
    }
}
