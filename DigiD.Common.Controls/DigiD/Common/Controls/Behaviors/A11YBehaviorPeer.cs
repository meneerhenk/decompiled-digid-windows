using System.Collections.Generic;
using System.Windows.Input;
using DigiD.Common.Controls.Enums;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Automation.Provider;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;
using Windows.Foundation;

namespace DigiD.Common.Controls.Behaviors;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Automation.Peers.IAutomationPeerOverrides")]
[WinRTExposedType(typeof(DigiD_Common_Controls_Behaviors_A11YBehaviorPeerWinRTTypeDetails))]
public class A11YBehaviorPeer : FrameworkElementAutomationPeer, IInvokeProvider
{
	private const string WindowsButtonRoleDescription = "button";

	private const string WindowsHyperlinkRoleDescription = "hyperlink";

	private const string WindowsTextRoleDescription = "text";

	private const string WindowsImageRoleDescription = "image";

	private const string WindowsCustomRoleDescription = "custom";

	public string? AutomationId { get; internal set; }

	public string? Description { get; internal set; }

	public string? HelpText { get; internal set; }

	public AccessibilityView? AccessibilityView { get; internal set; }

	public string? State { get; internal set; }

	public A11YRole Role { get; internal set; }

	public ICommand? Command { get; internal set; }

	public object? CommandParameter { get; internal set; }

	public A11YBehaviorPeer(FrameworkElement frameworkElement)
		: base(frameworkElement)
	{
	}

	protected override object? GetPatternCore(PatternInterface patternInterface)
	{
		object result = base.GetPatternCore(patternInterface);
		if (patternInterface == PatternInterface.Invoke)
		{
			result = this;
		}
		return result;
	}

	protected override IReadOnlyList<AutomationPeer> GetControlledPeersCore()
	{
		IReadOnlyList<AutomationPeer> readOnlyList = base.GetControlledPeersCore();
		if (readOnlyList == null)
		{
			readOnlyList = new List<A11YBehaviorPeer> { this }.AsReadOnly();
		}
		return readOnlyList;
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		A11YRole role = Role;
		if (1 == 0)
		{
		}
		AutomationControlType result = role switch
		{
			A11YRole.Button => AutomationControlType.Button, 
			A11YRole.Link => AutomationControlType.Hyperlink, 
			A11YRole.Text => AutomationControlType.Text, 
			A11YRole.Image => AutomationControlType.Image, 
			_ => AutomationControlType.Custom, 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	protected override bool HasKeyboardFocusCore()
	{
		return true;
	}

	protected override AutomationHeadingLevel GetHeadingLevelCore()
	{
		return base.GetHeadingLevelCore();
	}

	protected override string GetAutomationIdCore()
	{
		string automationIdCore = base.GetAutomationIdCore();
		return AutomationId ?? automationIdCore;
	}

	protected override string GetFullDescriptionCore()
	{
		string fullDescriptionCore = base.GetFullDescriptionCore();
		return Description ?? fullDescriptionCore;
	}

	protected override string GetHelpTextCore()
	{
		string helpTextCore = base.GetHelpTextCore();
		return HelpText ?? helpTextCore;
	}

	protected override string GetNameCore()
	{
		string nameCore = base.GetNameCore();
		return Description ?? nameCore;
	}

	protected override bool IsContentElementCore()
	{
		return true;
	}

	protected override bool IsControlElementCore()
	{
		return true;
	}

	protected override bool IsEnabledCore()
	{
		return true;
	}

	void IInvokeProvider.Invoke()
	{
		RaiseAutomationEvent(AutomationEvents.InvokePatternOnInvoked);
		ICommand? command = Command;
		if (command != null && command.CanExecute(CommandParameter))
		{
			Command.Execute(CommandParameter);
		}
	}

	protected override Rect GetBoundingRectangleCore()
	{
		return base.GetBoundingRectangleCore();
	}

	protected override string GetLocalizedControlTypeCore()
	{
		A11YRole role = Role;
		if (1 == 0)
		{
		}
		string result = role switch
		{
			A11YRole.Button => "button", 
			A11YRole.Link => "hyperlink", 
			A11YRole.Text => "text", 
			A11YRole.Image => "image", 
			_ => "custom", 
		};
		if (1 == 0)
		{
		}
		return result;
	}
}
