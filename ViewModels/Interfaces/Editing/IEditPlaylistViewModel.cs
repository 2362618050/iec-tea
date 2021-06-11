namespace Player.ViewModels.Interfaces.Editing
{
    using Player.Models.Player;
    using Player.ViewModels.Interfaces.Playlist;

    internal interface IEditPlaylistViewModel : IViewModelBase
    {
        Playlist Playlist { get; }

        IPlaylistViewModel PlaylistViewModel { get; }
    }
}