using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Threading.Tasks;
using DynamicData;
using ReactiveUI;
using ScrollBarTest.Models;

namespace ScrollBarTest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<ExampleModel> Models { get; } = new();
    public ObservableCollection<Employee> Employees { get; } = new();

    protected override async Task LoadInitialData()
    {
        Models.Clear();

        await Task.Delay(2000);

        Employees.AddRange(new List<Employee>()
        {
            new() { Name = "bob" },
            new() { Name = "george" }
        });

        DateTime date = DateTime.Now.AddDays(-17);

        Random r = new Random();

        for (int i = 0; i < r.Next(15, 30); i++)
        {
            List<DetailModel> details = new();
            foreach (var e in Employees)
            {
                details.Add(new()
                {
                    Title = e.Name,
                    Hours = 0,
                    Minutes = 0,
                });
            }


            Models.Add(new($"Item {i}", details));
        }
    }
}