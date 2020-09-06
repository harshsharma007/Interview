using System;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Interview.Common
{
    class UnderstandingLock
    {
        //Exclusive locking in threading ensures that one thread does not enter a critical section while another thread is in the critical section of code. If another
        //thread attempts to enter a locked code, it will wait (blocked) until the object is released. To achieve this functionality we have two lock constructs:

        //1. Mutex
        //2. Lock

        //The lock construct is faster and more convenient. The lock statement takes the following form:
        //lock(expression) statement_block
        //Where:
        //expression: Specifies the object that you want to lock on. Expression must be a reference type.
        //statement_block: The statements of the critical section. A critical section is a piece of code that accesses a shared resource (data structure or device) but
        //the condition is that only one thread can enter in this section at a time.

        //The lock keyword calls Enter at the start of the block and Exit at the end of the block. Lock keyword actually handles Monitor class at back end.
    }

    class Department
    {
        private object thisLock = new object();
        int salary;
        Random random = new Random();

        public Department(int initial)
        {
            salary = initial;
        }

        int Withdraw(int amount)
        {
            //This condition is never true, unless the lock statement is commented out.
            if (salary < 0)
                throw new Exception("Negative Balance");

            //Comment out the next line to see the effect of leaving out the lock keyword.
            lock (thisLock)
            {
                if (salary >= amount)
                {
                    Console.WriteLine("Salary before withdrawal : " + salary);
                    Console.WriteLine("Amount to withdraw : " + amount);
                    salary = salary - amount;
                    Console.WriteLine("Salary after withdrawal : " + salary);
                    return amount;
                }
                else
                    return 0;
            }
        }

        public void DoTransactions()
        {
            for (int i = 0; i < 10; i++)
            {
                Withdraw(random.Next(1, 100));
            }
        }

        public void Main()
        {
            Thread[] threads = new Thread[10];
            Department department = new Department(1000);
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(new ThreadStart(department.DoTransactions));
                threads[i] = thread;
            }
            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
            Console.Read();
        }
    }

    //Nested locking: A thread can repeatedly lock the same object in a nested manner:
    //lock(object)
    //lock(object)
    //lock(object)

    //In a nested locking, the object is unlocked only when the outermost lock statement has exited. It is useful when one method calls another within a lock
    class NewProgram
    {
        static object x = new object();
        public void Method()
        {
            lock (x)
            {
                Console.WriteLine("In method");
            }
        }

        public void Main()
        {
            lock (x)
            {
                Method();
                //We still have the lock, because locks are reentrant.
            }
            Console.Read();
        }

        //Lock-based resource protection and thread/process synchronization have many disadvantages:
        //1. They cause blocking, which means some threads/processes have to wait until a lock (or a whole set of locks) is released.
        //2. Lock handling adds overhead for each access to a resource, even when the chances for collision are very rare. (However, any chance for collisions is a race
        //condition).
        //3. Lock contention limits scalability and adds complexity.
        //4. Priority Inversion High priority threads/processes cannot proceed, if a low priority thread/process is holding the common lock.
        //5. Convoying: All other threads have to wait, if a thread holding a lock is descheduled due to a time-slice interrupt or page fault.
        //6. Hard to debug: Bugs associated with locks are time dependent. They are extremely hard to replicate.
    }
}
