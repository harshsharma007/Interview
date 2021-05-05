using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.OnlineTestQuestions
{
    class WhatHappensToThreadInThreadPool
    {
        /*
            Q. When using a thread pool, what happens to a given thread after it finishes its task?
            A. Thread pool threads are background threads. Each thread uses the default stack size, runs at the default priority, and is in the multithreaded apartment.
               Once a thread in the thread pool completes its task, it's returned to a queue of waiting threads. From this moment it can be reused. This reuse enables
               applications to avoid the cost of creating a new thread for each task. There is only one thread pool per process.
        */
    }
}
