using System;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveUI;

namespace ScrollBarTest.ViewModels;

public abstract class ViewModelBase : ReactiveObject, IActivatableViewModel
{
    public ReactiveCommand<Unit, Unit> LoadTabDataCommand { get; set; }


    public ViewModelActivator Activator { get; }

    public ViewModelBase()
    {
        Activator = new();

        LoadTabDataCommand = ReactiveCommand.CreateFromTask(LoadInitialData);

        this.WhenActivated((CompositeDisposable disposables) =>
        {
            LoadTabDataCommand.Execute().ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe().DisposeWith(disposables);
        });
    }

    protected virtual Task LoadInitialData()
    {
        return Task.CompletedTask;
    }
}