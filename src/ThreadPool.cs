using System;
using System.Threading;
using System.Threading.Tasks;

/**
 * Created by SimplyRin on 2018/10/04.
 */
public class ThreadPool {

    public static void runAsync(ThreadStart threadStart) {
        new Thread(threadStart).Start();
    }

}
