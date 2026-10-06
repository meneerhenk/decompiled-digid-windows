using DigiD.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls.Behaviors;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
public class LabelLiveTextBehavior : PlatformBehavior<Label>
{
	protected readonly IA11YService A11YService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IA11YService>();
}
