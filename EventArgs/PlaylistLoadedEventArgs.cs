namespace Player.EventArgs
{
    using System;

    using Player.Models.Player;

    internal class PlaylistLoadedEventArgs : EventArgs
    {
        public PlaylistLoadedEventArgs(Track[] tracks)
        {
            Tracks = tracks;
        }

        public Track[] Tracks { get; }
    }
}
