using System.Collections.Generic;

namespace BindingFailure.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        Sections = new List<Section>()
        {
            new Section()
            {
                Name = "Sample 1",
                Content = new NestedViewModel(),
            },
            new Section()
            {
                Name = "Sample 2",
                Content = "This is a sample 2"
            },
            new Section()
            {
                Name = "Sample 3",
                Content = "This is a sample 3"
            },
        };
    }

    public IEnumerable<Section> Sections { get; }
}
