namespace Player.Services.Interfaces
{
    public interface IFileSystemBrowserService
    {
        bool BrowseDirectory(out string directory);
    }
}