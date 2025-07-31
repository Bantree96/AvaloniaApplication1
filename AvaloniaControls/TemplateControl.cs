using Avalonia;
using Avalonia.Controls.Primitives;

namespace AvaloniaControls
{
    public class TemplateControl : TemplatedControl
    {
        public static readonly StyledProperty<string?> TitleProperty =
            AvaloniaProperty.Register<TemplateControl, string?>(nameof(Title));

        public string? Title
        {
            get => GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
    }
}
