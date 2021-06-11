namespace Player.Services.Interfaces
{
    using Player.Models.Dialogs;
    using Player.ViewModels.Interfaces.Dialogs;

    internal interface IDialogService
    {
        TModel ShowDialog<TModel, TViewModel>(WindowSettings windowSettings = default)
                where TModel : new()
                where TViewModel : IDialogViewModel<TModel>;

        TModel ShowDialog<TModel, TViewModel>(TModel model, WindowSettings windowSettings = default)
                where TViewModel : IDialogViewModel<TModel>;
    }
}