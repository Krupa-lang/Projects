using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zp;

namespace ZpTest
{
    [TestClass]
    public class SleepTest
    {
        private class WakeUpCommand : Command
        {
            public bool executed = false;

            public void Execute()
            {
                executed = true;
            }
        }

        [TestMethod]
        public void TestSleep()
        {
            WakeUpCommand wakeUp = new WakeUpCommand();
            ActiveObjectEngine e = new ActiveObjectEngine();
            SleepCommand c = new SleepCommand(1000, e, wakeUp);
            e.AddCommand(c);
            DateTime start = DateTime.Now;
            e.Run();
            DateTime stop = DateTime.Now;
            double sleepTime = (stop - start).TotalMilliseconds;
            Assert.IsTrue(sleepTime >= 1000, 
                $"SleepTime {sleepTime} expected > 1000");
            Assert.IsTrue(sleepTime <= 1000,
                $"SleepTime {sleepTime} expected < 1000");
            Assert.IsTrue(wakeUp.executed, "Command executed");
        }
    }
}
