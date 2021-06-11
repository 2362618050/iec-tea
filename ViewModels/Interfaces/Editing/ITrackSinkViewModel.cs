namespace Player.ViewModels.Interfaces.Editing
{
    using System;
    using System.Collections.Generic;

    using Player.EventArgs;
    using Player.Models.Player;

    internal interface ITrackSinkViewModel : IViewModelBase
    {
        event EventHandler<TracksReleasedEventArgs> TracksReleased;

        IEnumerable<Track> ReleasedTracks { get; }

        int ReleasedTracksCount { get; }

        void AddTracks(IEnumerable<ITrackViewModel> tracks);

        void Reset();
    }
}