using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ScrollBarTest.Models;

public class ExampleModel
{
    public ExampleModel(string title, List<DetailModel> details)
    {
        Title = title;
        Details = details;
    }

    public string Title { get; set; }
    public List<DetailModel> Details { get; } = new();
}