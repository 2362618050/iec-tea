namespace Player.Services.Interfaces
{
    using Player.Models.Settings;

    internal interface ISettingsService
    {
        Settings Settings { get; }

        void Save();
    }
}