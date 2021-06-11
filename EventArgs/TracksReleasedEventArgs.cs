namespace Player.EventArgs
{
    using System.Collections.Generic;

    using Player.ViewModels.Interfaces;

    internal class TracksReleasedEventArgs
    {
        public TracksReleasedEventArgs(IEnumerable<ITrackViewModel> tracks)
        {
            Tracks = tracks;
        }

        public IEnumerable<ITrackViewModel> Tracks { get; }
    }
}
