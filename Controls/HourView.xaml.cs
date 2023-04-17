namespace LiturgiaDasHoras;

public partial class HourView : Frame
{
	public HourView()
	{
		InitializeComponent();
	}
    public static readonly BindableProperty HoraProperty = BindableProperty.Create(
        propertyName: nameof(Hora),
        returnType: typeof(string),
        declaringType: typeof(HourView),
        defaultValue: string.Empty,
        defaultBindingMode: BindingMode.TwoWay);
    public string Hora
    {
        get => (string)GetValue(HoraProperty);
        set => SetValue(HoraProperty, value);
    }

    public static readonly BindableProperty HourProperty = BindableProperty.Create(
        propertyName: nameof(Hour),
        returnType: typeof(string),
        declaringType: typeof(HourView),
        defaultValue: string.Empty,
        defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: (bindable, oldValue, newValue) => {
            if (bindable is HourView hourView && newValue is string value)
            {
                hourView.Initial = value[0].ToString();
                hourView.Complement = value.Substring(1);
            }
        });
    public string Hour
    {
        get => (string)GetValue(HourProperty);
        set => SetValue(HourProperty, value);
    }

    public static readonly BindableProperty InitialProperty = BindableProperty.Create(
        propertyName: nameof(Initial),
        returnType: typeof(string),
        declaringType: typeof(HourView),
        defaultValue: string.Empty,
        defaultBindingMode: BindingMode.TwoWay);

    public string Initial
    {
        get => (string)GetValue(InitialProperty);
        set => SetValue(InitialProperty, value);
    }

    public static readonly BindableProperty ComplementProperty = BindableProperty.Create(
        propertyName: nameof(Complement),
        returnType: typeof(string),
        declaringType: typeof(HourView),
        defaultValue: string.Empty,
        defaultBindingMode: BindingMode.TwoWay);

    public string Complement
    {
        get => (string)GetValue(ComplementProperty);
        set => SetValue(ComplementProperty, value);
    }

    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
        propertyName: nameof(Command),
        returnType: typeof(ICommand),
        declaringType: typeof(HourView),
        defaultValue: null,
        defaultBindingMode: BindingMode.TwoWay);
    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create(
        propertyName: nameof(CommandParameter),
        returnType: typeof(object),
        declaringType: typeof(HourView),
        defaultValue: null,
        defaultBindingMode: BindingMode.TwoWay);
    public object CommandParameter
    {
        get => GetValue(CommandParameterProperty);
        set => SetValue(CommandParameterProperty, value);
    }
}