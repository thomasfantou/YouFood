using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using Local.Services;

namespace Local.Daemon
{
    public class DatabaseSync
    {
        static Thread thread;

        public static bool IsActive;
        public static void StartSync()
        {
            if (!IsActive)
            {
                thread = new Thread(Sync);
                thread.Start();
                IsActive = true;
            }
        }

        private static void Sync()
        {
            while (true)
            {
                TimeSpan now = DateTime.Now.TimeOfDay;
                //To 6AM, client will sync to server
                if (now >= new TimeSpan(6, 0, 0) && now < new TimeSpan(6, 0, 1))
                {
                    Service service = new Service();
                    service.SendDataToDatabase();
                    service.TryRefreshDatabase();
                }

                //Sleep 1 min
                Thread.Sleep(60000);
            }

        }
    }
}