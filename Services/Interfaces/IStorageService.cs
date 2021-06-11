namespace Player.Services.Interfaces
{
    using System.Collections.Generic;

    using Player.Models;

    public interface IStorageService
    {
        List<TrackFolder> TrackFolders { get; }

        void SaveData();
    }
}