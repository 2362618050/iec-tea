namespace Player.EventArgs
{
    using System;

    using Player.Models.Player;

    internal class TrackChangedEventArgs : EventArgs
    {
        public TrackChangedEventArgs(Track track, TimeSpan duration)
        {
            Track = track;
            Duration = duration;
        }

        public Track Track { get; }

        public TimeSpan Duration { get; }
    }
}
