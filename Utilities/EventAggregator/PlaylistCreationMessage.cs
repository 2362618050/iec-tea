namespace Player.Utilities.EventAggregator
{
    using Player.ViewModels.Interfaces.Playlist;

    internal class PlaylistCreationMessage
    {
        public PlaylistCreationMessage(IPlaylistViewModel playlistViewModel)
        {
            PlaylistViewModel = playlistViewModel;
        }

        public IPlaylistViewModel PlaylistViewModel { get; }
    }
}