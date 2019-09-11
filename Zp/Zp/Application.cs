using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zp
{
    public abstract class Application
    {
        private bool _isDone = false;

        protected abstract void Init();
        protected abstract void Idle();
        protected abstract void Cleanup();

        protected void SetDone()
        {
            _isDone = true;
        }

        protected bool Done()
        {
            return _isDone;
        }

        public void Run()
        {
            Init();
            while (!Done())
            {
                Idle();
            }
            Cleanup();
        }
    }
}
