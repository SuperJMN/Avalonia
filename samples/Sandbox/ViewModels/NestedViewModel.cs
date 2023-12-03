using System.Collections.Generic;

namespace BindingFailure.ViewModels;

public class NestedViewModel
{
    public NestedViewModel()
    {
        Sections = new List<Section>()
        {
            new Section()
            {
                Name = "Child 1",
                Content = "1",
            },
            new Section()
            {
                Name = "Child 2",
                Content = "2"
            },
            new Section()
            {
                Name = "Child 3",
                Content = "3"
            },
        };
    }

    public IEnumerable<Section> Sections { get; }
}