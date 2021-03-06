﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StepsTracker.Properties;

namespace StepsTracker.Models
{
    public class ReadingByDate: INotifyPropertyChanged
    {
        private bool _isHighest;
        public DateTime DateTime { get; set; }

        public uint WalkingStepsCount { get; set; }

        public uint RunningStepsCount { get; set; }

        public uint TotalStepsCount { get; set; }

        public string FormattedDate
        {
            get { return DateTime.ToString("dd MM yy - HH:mm tt"); }
        }

        public bool IsHighest
        {
            get { return _isHighest; }
            set
            {
                if (value == _isHighest) return;
                _isHighest = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}