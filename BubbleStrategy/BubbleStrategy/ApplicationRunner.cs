using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleStrategy
{
    public class ApplicationRunner
    {
        private Application itsApplication;

        public ApplicationRunner(Application app)
        {
            itsApplication = app;
        }

        public void Run()
        {
            itsApplication.Init();
            while (!itsApplication.Done())
            {
                itsApplication.Idle();
            }
            itsApplication.Cleanup();
        }
    }
}
