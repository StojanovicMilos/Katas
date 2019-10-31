using System;

namespace PillReminderUI
{
    public class PillModel
    {
        private readonly string _pillName;
        private DateTime _lastTaken;

        public PillModel(string pillName, DateTime timeToTake, DateTime lastTaken)
        {
            _pillName = pillName;
            TimeToTake = timeToTake;
            _lastTaken = lastTaken;
        }

        public DateTime TimeToTake { get; }

        public string PillInfo => $"{_pillName} at {TimeToTake:h:mm tt}";

        public void TakePillAt(DateTime time) => _lastTaken = time;

        public bool PillShouldBeTakenBy(DateTime dateTime) => PillShouldBeTakenByDay(dateTime) && PillShouldBeTakenByTime(dateTime);

        private bool PillShouldBeTakenByDay(DateTime dateTime) => _lastTaken.Day < dateTime.Day && _lastTaken < dateTime;

        private bool PillShouldBeTakenByTime(DateTime dateTime) => TimeToTake.TimeOfDay < dateTime.TimeOfDay;
    }
}
