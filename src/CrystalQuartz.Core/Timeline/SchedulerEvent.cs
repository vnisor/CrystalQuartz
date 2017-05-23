﻿namespace CrystalQuartz.Core.Timeline
{
    public class SchedulerEvent
    {
        private readonly string _typeCode;
        private readonly string _group;
        private readonly string _trigger;
        private readonly string _job;
        private readonly string _fireInstanceId;

        public SchedulerEvent(string typeCode, string @group, string trigger, string job, string fireInstanceId)
        {
            _typeCode = typeCode;
            _group = @group;
            _trigger = trigger;
            _job = job;
            _fireInstanceId = fireInstanceId;
        }

        public string TypeCode
        {
            get { return _typeCode; }
        }

        public string Group
        {
            get { return _group; }
        }

        public string Trigger
        {
            get { return _trigger; }
        }

        public string Job
        {
            get { return _job; }
        }

        public string FireInstanceId
        {
            get { return _fireInstanceId; }
        }
    }
}