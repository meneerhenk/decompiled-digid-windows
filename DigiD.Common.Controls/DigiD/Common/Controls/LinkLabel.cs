using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Models.Messages;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Input;
using Windows.System;

namespace DigiD.Common.Controls;

[XamlFilePath("LinkLabel.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class LinkLabel : Border
{
	public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(LinkLabel));

	public static readonly BindableProperty CommandArgumentsProperty = BindableProperty.Create("CommandArguments", typeof(object), typeof(LinkLabel));

	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(LinkLabel), null, BindingMode.TwoWay, null, TextPropertyChanged);

	public static readonly BindableProperty IsButtonStyleProperty = BindableProperty.Create("IsButtonStyle", typeof(bool), typeof(LinkLabel), null, BindingMode.OneWay, null, IsButtonStylePropertyChanged);

	public static readonly BindableProperty IsExternalLinkProperty = BindableProperty.Create("IsExternalLink", typeof(bool), typeof(LinkLabel), null, BindingMode.OneWay, null, IsExternalLinkPropertyChanged);

	public static readonly BindableProperty SemanticsProperty = BindableProperty.Create("Semantics", typeof(string), typeof(LinkLabel), string.Empty, BindingMode.TwoWay, null, SemanticsPropertyChanged);

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border Border;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label linkLabel;

	public ICommand? Command
	{
		get
		{
			return (ICommand)GetValue(CommandProperty);
		}
		set
		{
			SetValue(CommandProperty, value);
		}
	}

	public object CommandArguments
	{
		get
		{
			return GetValue(CommandArgumentsProperty);
		}
		set
		{
			SetValue(CommandArgumentsProperty, value);
		}
	}

	public string Text
	{
		get
		{
			return (string)GetValue(TextProperty);
		}
		set
		{
			SetValue(TextProperty, value);
		}
	}

	public string Semantics
	{
		get
		{
			return (string)GetValue(SemanticsProperty);
		}
		set
		{
			SetValue(SemanticsProperty, value);
		}
	}

	public bool IsButtonStyle
	{
		get
		{
			return (bool)GetValue(IsButtonStyleProperty);
		}
		set
		{
			SetValue(IsButtonStyleProperty, value);
		}
	}

	public bool IsExternalLink
	{
		get
		{
			return (bool)GetValue(IsExternalLinkProperty);
		}
		set
		{
			SetValue(IsExternalLinkProperty, value);
		}
	}

	private A11YBehavior LinkLabelBehavior { get; }

	private static void IsButtonStylePropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		((LinkLabel)bindable).linkLabel.TextColor = (Color)Microsoft.Maui.Controls.Application.Current.Resources["FontTextColor"];
		((LinkLabel)bindable).linkLabel.FontFamily = Microsoft.Maui.Controls.Application.Current.Resources["FontBold"].ToString();
		((LinkLabel)bindable).linkLabel.FontAttributes = FontAttributes.Bold;
	}

	private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is LinkLabel linkLabel)
		{
			linkLabel.linkLabel.Text = (string)newValue;
			if ((AutomationProperties.GetIsInAccessibleTree(linkLabel) ?? true) && !string.IsNullOrWhiteSpace(linkLabel.linkLabel.Text) && !linkLabel.Behaviors.Contains(linkLabel.LinkLabelBehavior))
			{
				linkLabel.Behaviors.Add(linkLabel.LinkLabelBehavior);
			}
		}
	}

	private static void SemanticsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is LinkLabel linkLabel)
		{
			if (newValue is string text && !string.IsNullOrWhiteSpace(text))
			{
				linkLabel.LinkLabelBehavior.RemoveBinding(A11YBehavior.DescriptionProperty);
				linkLabel.LinkLabelBehavior.Description = (linkLabel.IsExternalLink ? (text + ", " + CommonResources.Alg_External) : text);
			}
			else
			{
				linkLabel.LinkLabelBehavior.SetBinding(A11YBehavior.DescriptionProperty, new Binding("Text", BindingMode.Default, null, null, null, linkLabel));
				linkLabel.LinkLabelBehavior.Description = (linkLabel.IsExternalLink ? (linkLabel.Text + ", " + CommonResources.Alg_External) : linkLabel.Text);
			}
			if (!linkLabel.Behaviors.Contains(linkLabel.LinkLabelBehavior))
			{
				linkLabel.Behaviors.Add(linkLabel.LinkLabelBehavior);
			}
		}
	}

	private static void IsExternalLinkPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is LinkLabel linkLabel && newValue is bool flag)
		{
			string text = linkLabel.LinkLabelBehavior?.Description ?? string.Empty;
			if (!string.IsNullOrEmpty(text) && !text.Contains(CommonResources.Alg_External))
			{
				linkLabel.LinkLabelBehavior.Description = (flag ? (text + ", " + CommonResources.Alg_External) : linkLabel.Text);
			}
		}
	}

	public LinkLabel()
	{
		LinkLabelBehavior = new A11YBehavior
		{
			Role = A11YRole.Link
		};
		LinkLabelBehavior.SetBinding(A11YBehavior.CommandProperty, new Binding("Command", BindingMode.Default, null, null, null, this));
		LinkLabelBehavior.SetBinding(A11YBehavior.CommandParameterProperty, new Binding("CommandArguments", BindingMode.Default, null, null, null, this));
		LinkLabelBehavior.SetBinding(A11YBehavior.DescriptionProperty, new Binding("Text", BindingMode.Default, null, null, null, this));
		InitializeComponent();
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, delegate
		{
			SetLinkColor();
		});
		SetLinkColor();
	}

	private void SetLinkColor()
	{
		linkLabel.TextColor = (Color)Microsoft.Maui.Controls.Application.Current.Resources["LinkColor"];
	}

	private void LinkLabel_OnFocused(object? sender, FocusEventArgs e)
	{
		Microsoft.Maui.Controls.VisualStateManager.GoToState(Border, e.IsFocused ? "Focused" : "Normal");
	}

	protected override void OnHandlerChanged()
	{
		base.OnHandlerChanged();
		SetKeyDownOnContentPanel(base.Handler != null);
	}

	private void SetKeyDownOnContentPanel(bool? activate = true)
	{
		if (base.Handler?.PlatformView is ContentPanel contentPanel)
		{
			contentPanel.KeyDown -= OnKeyDown;
			if (activate ?? false)
			{
				contentPanel.KeyDown += OnKeyDown;
			}
		}
	}

	private void OnKeyDown(object sender, KeyRoutedEventArgs e)
	{
		bool flag = sender is ContentPanel contentPanel && contentPanel.FocusState == FocusState.Keyboard;
		bool flag2 = flag;
		if (flag2)
		{
			VirtualKey key = e.Key;
			bool flag3 = ((key == VirtualKey.Enter || key == VirtualKey.Space) ? true : false);
			flag2 = flag3;
		}
		if (flag2 && Command != null && Command.CanExecute(CommandArguments))
		{
			Command?.Execute(CommandArguments);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Border")]
	[MemberNotNull("linkLabel")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(LinkLabel).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(LinkLabel)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		DynamicResource dynamicResource = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("LinkLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 9);
		DynamicResource dynamicResource2 = new DynamicResource("FontLineHeight");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("LinkLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 9);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("LinkLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("LinkLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("Border", this);
		if (StyleId == null)
		{
			string text = (StyleId = "Border");
		}
		label.transientNamescope = nameScope;
		nameScope.RegisterName("linkLabel", label);
		Label label2 = label;
		if (label2.StyleId == null)
		{
			string text = (label2.StyleId = "linkLabel");
		}
		Border = this;
		linkLabel = label;
		SetValue(View.MarginProperty, new Microsoft.Maui.Thickness(2.0, 0.0, 0.0, 0.0));
		SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		label.SetValue(Label.PaddingProperty, new Microsoft.Maui.Thickness(0.0, 1.0));
		((IDynamicResourceHandler)label).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		label.Focused += LinkLabel_OnFocused;
		((IDynamicResourceHandler)label).SetDynamicResource(Label.LineHeightProperty, dynamicResource2.Key);
		label.SetValue(Label.TextDecorationsProperty, TextDecorations.Underline);
		label.Unfocused += LinkLabel_OnFocused;
		label.SetValue(Label.VerticalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Center);
		SetValue(Border.ContentProperty, label);
		static string? getPathForType(Type type)
		{
			Assembly assembly = type.Assembly;
			foreach (XamlResourceIdAttribute customAttribute in assembly.GetCustomAttributes<XamlResourceIdAttribute>())
			{
				if (customAttribute.Type == type)
				{
					return customAttribute.Path;
				}
			}
			return null;
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Border")]
	[MemberNotNull("linkLabel")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(LinkLabel));
		Border = this.FindByName<Border>("Border");
		linkLabel = this.FindByName<Label>("linkLabel");
	}
}
