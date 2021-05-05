using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.AsyncAwaitThread
{
    class MultithreadingQuestion
    {
        /*
            I am working on Apple push notifications services. My application demands to send notifications to 30K users when a new deal is added to the website.
            Can I split the 30K users into lists, each list containing 1000 users and start multiple threads or can use task? Is the following way efficient?
            
            if (lstDevice.Count > 0)
            {
                for (int i = 0; i < lstDevice.Count; i += 2)
                {
                    splitList.Add(lstDevice.Skip(i).Take(2).ToList<DeviceHelper>());
                }

                var tasks = new Task[splitList.Count];
                int count=0;
                foreach (List<DeviceHelper> lst in splitList)
                {
                    tasks[count] = Task.Factory.StartNew(() =>
                    {
                        QueueNotifications(lst, pMessage, pSubject, pNotificationType, push);
                    }, TaskCreationOptions.None);
                    count++;
                }
            }
            
            QueueNotification method will just loop through each list item and creates a payload like
            
            foreach (DeviceHelper device in splitList)
            {
                if (device.PlatformType.ToLower() == "ios")
                {
                    push.QueueNotification(new AppleNotification()
                                                .ForDeviceToken(device.DeviceToken)
                                                .WithAlert(pMessage)
                                                .WithBadge(device.Badge)
                                                 );
                    Console.Write("Waiting for Queue to Finish...");
                }
            }
            push.StopAllServices(true);
        */

        /*
            Technically, it is sure possible to split a list and then start threads that runs your List in parallel. You can also implement everything youself, as you
            already have done, but this isn't good approach. At first splitting List into chunks that gets processed in parallel is already what Parallel.For or
            Parallel.ForEach does. There is no need to re-implement everthing yourself.
            
            Now, you constantly ask if something can run 300 or 500 notifications in parallel. But actually this is not a good question because you completely miss
            the point of running something in parallel.
            
            So, let me explain you why that question is not good. At first, you should ask yourself why do you want to run something in parallel? The answer to that is,
            you want that something runs faster by using multiple CPU-cores.
            
            Now your simple idea is probably that spawning 300 or 500 threads is faster, because you have more threads and it runs more things "in parallel". But that
            is not exactly the case.
            
            At first, creating a thread is not "free". Every thread you create has some overhead, it takes some CPU-time to create a thread, and also it needs some
            memory. On top of that, if you create 300 threads it doesn't mean 300 threads can run in parallel. If you have for example an 8 core CPU only 8 threads
            really can run in parallel. Creating more threads can ever hurt your performance. Because now your program needs to switch constantly between threads that
            also cost CPU-performance.
            
            The result of all that is, if you have something lightweight some small code that don't do a lot of computation it ends that creating a lot of threads will
            slow down your application instead of running faster, because the managing of your threads creates more overhead than running it on (for example) 8 CPU-cores.
            
            That means, if you have a list of 30,000 of somewhat. It usually end that it is faster to just split your list in 8 chunks and work through your list in
            8 threads as creating 300 Threads.
            
            Your goal should never be: Can it run xxx things in parallel? The question should be like: How many threads do I need, and how much items should every thread
            process to get my work as fastest done.
            
            That is an important difference between just spawning more threads doesn't mean something ends up being fast.
            
            So how many threads do you need, and how many items should every thread process? Well, you can write a lot of code to test it. But the amount changes from
            hardware to hardware. A PC with just 4 cores have another optimum that a system with 8 cores. If what you are doing is IO bound (for example read/write to
            disk/network) you also don't get more speed by increasing your threads.
            
            So what you now can do is test everything, try to get the correct thread number and do a lot of benchmarking to find the best numbers.
            
            But actually, that is the whole purpose of the TPL library with the Task<T> class. The Task<T> class already looks at your computer how many CPU-cores it
            have. And when you are running your Task it automatically tries to create as much threads needed to get the maximum out of your system.
            
            So my suggestion is that you should use the TPL library with the Task<T> class. In my opinion you should never create Threads directly yourself or doing
            partition yourself, because all of that is already done in TPL.
        */
    }
}
