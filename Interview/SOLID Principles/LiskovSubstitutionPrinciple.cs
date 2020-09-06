using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interview
{
    class LiskovSubstitutionPrinciple
    {
        /*
            The Liskov Substitution Principle (LSP) states that "you should be able to use any derived class instead of a parent class and have it behave in the"
            "same manner without modification". It ensures that a derived class does not affect the behavior of the parent class, in other words that a derived
            class must be substitutable for its base class.

            This principle is just an extension of the Open Close Principle and it means that we must ensure that new derived classes extend the base classes
            without changing the behavior. Below is the example that violates LSP.

            Suppose we need to build an app to manage data using a group of SQL file text. Here we need to write functionality to load and save the text of a
            group of SQL files in the application directory. So we need a class that manages the load and saves the text of group of SQL files along with SQLFile
            class.
        */
    }

    public class SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText()
        {
            return "Code to read text from SQL file";
        }

        public void SaveText()
        {
            //Code to save text into SQL file
        }
    }

    public class SqlFileManager
    {
        public List<SqlFile> lstSqlFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStringBuilder = new StringBuilder();
            foreach (var objFile in lstSqlFiles)
            {
                objStringBuilder.Append(objFile.LoadText());
            }
            return objStringBuilder.ToString();
        }

        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                objFile.SaveText();
            }
        }
    }

    /*
        The functionality looks good for now. After sometime our lead might tell us that we may have a few read-only files in the application folder, so we need to
        restrict the flow whenever it tries to do a save on them.
    */

    public class SqlFileChanged
    {
        public string LoadText()
        {
            return "Code to read text from sql file";
        }

        public void SaveText()
        {
            //Code to save text into sql file
        }
    }

    public class ReadOnlySqlFile : SqlFileChanged
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public new string LoadText()
        {
            return "Code to read text from sql file";
        }

        public new void SaveText()
        {
            throw new IOException("Can't save into readonly file.");
        }
    }

    //To avoid exception we need to modify "SqlFileManager" by adding one condition to the loop.

    public class SqlFileManagerChanged
    {
        public List<SqlFileChanged> lstSqlFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStringBuilder = new StringBuilder();
            foreach (var objFile in lstSqlFiles)
            {
                objStringBuilder.Append(objFile.LoadText());
            }
            return objStringBuilder.ToString();
        }

        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                //Check whether the current file object is readonly or not. If yes, skip calling it's SaveText() method to skip the exception.
                if (!(objFile is ReadOnlySqlFile))
                    objFile.SaveText();
            }
        }
    }

    /*
        Here we have altered the SaveTextIntoFiles() in the SqlFileManagerChanged class to determine whether or not the instance is of ReadOnlySqlFile to avoid the
        exception. We can't use the ReadOnlySqlFile class as a substitute of its parent without altering SqlFileManager code. So we can say that this design is not
        following LSP. Let's make this design follow the LSP.
    */

    public interface IReadableSqlFile
    {
        string LoadText();
    }

    public interface IWriteableSqlFile
    {
        void SaveText();
    }

    public class ReadOnlySqlFileNew : IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText()
        {
            return "Code to read text from sql file";
        }
    }

    public class SqlFileNew : IReadableSqlFile, IWriteableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText()
        {
            return "Code to read text from sql file";
        }

        public void SaveText()
        {
            //Code to save text into sql file
        }
    }

    public class SqlFileManagerNew
    {
        public string GetTextFromFiles(List<IReadableSqlFile> lstReadableSqlFiles)
        {
            StringBuilder objStringBuilder = new StringBuilder();
            foreach (var objFile in lstReadableSqlFiles)
            {
                objStringBuilder.Append(objFile.LoadText());
            }
            return objStringBuilder.ToString();
        }

        public void SaveTextIntoFiles(List<IWriteableSqlFile> lstWriteableSqlFile)
        {
            foreach (var objFile in lstWriteableSqlFile)
            {
                objFile.SaveText();
            }
        }
    }

    /*
        Here the GetTextFromFiles() method gets only the list of instances of classes that implement the IReadOnlySqlFile interface. That means the SqlFileNew and
        ReadOnlySqlFile class instances and the SaveTextIntoFiles() method gets only the list instances of the class that implements the IWritableSqlFiles interface.
        In other words, SqlFileNew instances in this case. Now we can say our design is following the LSP. And we have fixed the problem using the
        Interface Segregation Principle (ISP) by identifying the abstraction and the responsibility separation method.
    */
}
