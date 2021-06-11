namespace Player.Services.Interfaces
{
    using System;

    using Player.EventArgs;

    internal interface IHotKeyService
    {
        event EventHandler<HotKeyActuatedEventArgs> HotKeyActuated;
    }
}