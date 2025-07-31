using Avalonia;
using Avalonia.Controls.Primitives;

namespace AvaloniaControls
{
	public class MyCustomControl : TemplatedControl
	{
		public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<MyCustomControl, string>(nameof(Title));

		public string Title
		{
			get => GetValue(TitleProperty);
			set => SetValue(TitleProperty, value);
		}
	}
}
