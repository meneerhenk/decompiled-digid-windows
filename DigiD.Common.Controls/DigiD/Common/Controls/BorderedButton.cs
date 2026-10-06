using System.Linq;
using System.Runtime.CompilerServices;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
public class BorderedButton : Button, IA11YControl, IView, IElement, ITransform
{
	public static readonly BindableProperty ButtonTypeProperty = BindableProperty.Create("ButtonType", typeof(ButtonType), typeof(BorderedButton), ButtonType.NotSet);

	public static readonly BindableProperty IsExternProperty = BindableProperty.Create("IsExtern", typeof(bool), typeof(BorderedButton), false, BindingMode.OneWay, null, IsExternPropertyChanged);

	public ButtonType ButtonType
	{
		get
		{
			return (ButtonType)GetValue(ButtonTypeProperty);
		}
		set
		{
			SetValue(ButtonTypeProperty, value);
		}
	}

	public bool IsExtern
	{
		get
		{
			return (bool)GetValue(IsExternProperty);
		}
		set
		{
			SetValue(IsExternProperty, value);
		}
	}

	private static void IsExternPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is BorderedButton borderedButton)
		{
			if ((bool)newValue)
			{
				borderedButton.ContentLayout = new ButtonContentLayout(ButtonContentLayout.ImagePosition.Right, 10.0);
				borderedButton.ImageSource = (FileImageSource)Application.Current.Resources["iconButtonExternalLink"];
			}
			else
			{
				borderedButton.ContentLayout = null;
				borderedButton.ImageSource = null;
			}
			borderedButton.ChangeBehavior();
		}
	}

	protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		if (!(propertyName == "ButtonType"))
		{
			if (propertyName == "Text")
			{
				if (IsExtern)
				{
					ChangeBehavior();
				}
				else
				{
					SemanticProperties.SetDescription(this, base.Text);
				}
			}
		}
		else
		{
			SetStyle();
		}
	}

	private void ChangeBehavior()
	{
		A11YBehavior a11YBehavior = base.Behaviors.OfType<A11YBehavior>().FirstOrDefault();
		if (a11YBehavior == null)
		{
			a11YBehavior = new A11YBehavior();
			base.Behaviors.Add(a11YBehavior);
		}
		a11YBehavior.Role = A11YRole.Link;
		a11YBehavior.Description = base.Text;
		ILocalizationResourceManager requiredService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<ILocalizationResourceManager>();
		a11YBehavior.StateDescription = requiredService["Alg_External"];
	}

	private void SetStyle()
	{
		base.Style = (Style)Application.Current.Resources[$"Button{ButtonType}"];
	}
}
