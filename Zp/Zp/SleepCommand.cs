using System;

namespace Zp
{
    public class SleepCommand : Command
    {
        private Command _wakeUpCommand = null;
        private ActiveObjectEngine _e = null;
        private long _sleepTime = 0;
        private DateTime _startTime;
        private bool _started = false;



        public SleepCommand(long mililsecond, ActiveObjectEngine e, Command wakeUp)
        {
            _sleepTime = mililsecond;
            _e = e;
            _wakeUpCommand = wakeUp;
        }

        public void Execute()
        {
            DateTime currentTime = DateTime.Now;
            if (!_started)
            {
                _started = true;
                _startTime = currentTime;
                _e.AddCommand(this);
            }
            else
            {
                TimeSpan elapsedTime = currentTime - _startTime;
                if (elapsedTime.TotalMilliseconds < _sleepTime)
                {
                    _e.AddCommand(this);
                }
                else
                {
                    _e.AddCommand(_wakeUpCommand);
                }
            }
        }
    }
}