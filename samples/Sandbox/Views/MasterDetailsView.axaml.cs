using System.Collections;
using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;

#nullable enable
namespace Sandbox.Views;

public class MasterDetailsView : TemplatedControl
{
    public static readonly StyledProperty<IEnumerable?> ItemsSourceProperty = AvaloniaProperty.Register<MasterDetailsView, IEnumerable?>(nameof(ItemsSource));

    public static readonly StyledProperty<object> SelectedItemProperty = AvaloniaProperty.Register<MasterDetailsView, object>(nameof(SelectedItem));

    public static readonly StyledProperty<IDataTemplate?> ItemTemplateProperty = AvaloniaProperty.Register<MasterDetailsView, IDataTemplate?>(nameof(ItemTemplate));

    public static readonly StyledProperty<IDataTemplate?> DetailsTemplateProperty = AvaloniaProperty.Register<MasterDetailsView, IDataTemplate?>(nameof(DetailsTemplate));
    public IDataTemplate? DetailsTemplate
    {
        get => GetValue(DetailsTemplateProperty);
        set => SetValue(DetailsTemplateProperty, value);
    }


    public IEnumerable? ItemsSource
    {
        get => GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    public object SelectedItem
    {
        get => GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }

    public IDataTemplate? ItemTemplate
    {
        get => GetValue(ItemTemplateProperty);
        set => SetValue(ItemTemplateProperty, value);
    }
}

public class RegisterNavigation
{
    public MasterDetailsView MasterDetailsView { get; }

    public RegisterNavigation(MasterDetailsView masterDetailsView)
    {
        MasterDetailsView = masterDetailsView;
    }
}
