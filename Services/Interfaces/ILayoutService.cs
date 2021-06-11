namespace Player.Services.Interfaces
{
    using Player.Models;

    internal interface ILayoutService
    {
        AppLayout AppLayout { get; }

        void SaveLayout();
    }
}