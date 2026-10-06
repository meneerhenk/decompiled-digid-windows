using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility.Compatibility_XamlTypeInfo;
using Microsoft.Maui.Controls.Controls_Core_XamlTypeInfo;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Core_XamlTypeInfo;
using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.XamlTypeInfo;
using Syncfusion.Maui.Core.Syncfusion_Maui_Core_XamlTypeInfo;

namespace DigiD.Mobile.DigiD_Mobile_XamlTypeInfo;

[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2605")]
[DebuggerNonUserCode]
internal class XamlTypeInfoProvider
{
	private Dictionary<string, IXamlType> _xamlTypeCacheByName = new Dictionary<string, IXamlType>();

	private Dictionary<Type, IXamlType> _xamlTypeCacheByType = new Dictionary<Type, IXamlType>();

	private Dictionary<string, IXamlMember> _xamlMembers = new Dictionary<string, IXamlMember>();

	private string[] _typeNameTable = null;

	private Type[] _typeTable = null;

	private List<IXamlMetadataProvider> _otherProviders;

	private List<IXamlMetadataProvider> OtherProviders
	{
		get
		{
			if (_otherProviders == null)
			{
				List<IXamlMetadataProvider> list = new List<IXamlMetadataProvider>();
				IXamlMetadataProvider item = new XamlControlsXamlMetaDataProvider();
				list.Add(item);
				item = new Microsoft.Maui.Controls.Compatibility.Compatibility_XamlTypeInfo.XamlMetaDataProvider();
				list.Add(item);
				item = new Microsoft.Maui.Controls.Controls_Core_XamlTypeInfo.XamlMetaDataProvider();
				list.Add(item);
				item = new Microsoft.Maui.Core_XamlTypeInfo.XamlMetaDataProvider();
				list.Add(item);
				item = new Syncfusion.Maui.Core.Syncfusion_Maui_Core_XamlTypeInfo.XamlMetaDataProvider();
				list.Add(item);
				_otherProviders = list;
			}
			return _otherProviders;
		}
	}

	public IXamlType GetXamlTypeByType(Type type)
	{
		IXamlType value;
		lock (_xamlTypeCacheByType)
		{
			if (_xamlTypeCacheByType.TryGetValue(type, out value))
			{
				return value;
			}
			int num = LookupTypeIndexByType(type);
			if (num != -1)
			{
				value = CreateXamlType(num);
			}
			XamlUserType xamlUserType = value as XamlUserType;
			if (value == null || (xamlUserType != null && xamlUserType.IsReturnTypeStub && !xamlUserType.IsLocalType))
			{
				IXamlType xamlType = CheckOtherMetadataProvidersForType(type);
				if (xamlType != null && (xamlType.IsConstructible || value == null))
				{
					value = xamlType;
				}
			}
			if (value != null)
			{
				_xamlTypeCacheByName.Add(value.FullName, value);
				_xamlTypeCacheByType.Add(value.UnderlyingType, value);
			}
		}
		return value;
	}

	public IXamlType GetXamlTypeByName(string typeName)
	{
		if (string.IsNullOrEmpty(typeName))
		{
			return null;
		}
		IXamlType value;
		lock (_xamlTypeCacheByType)
		{
			if (_xamlTypeCacheByName.TryGetValue(typeName, out value))
			{
				return value;
			}
			int num = LookupTypeIndexByName(typeName);
			if (num != -1)
			{
				value = CreateXamlType(num);
			}
			XamlUserType xamlUserType = value as XamlUserType;
			if (value == null || (xamlUserType != null && xamlUserType.IsReturnTypeStub && !xamlUserType.IsLocalType))
			{
				IXamlType xamlType = CheckOtherMetadataProvidersForName(typeName);
				if (xamlType != null && (xamlType.IsConstructible || value == null))
				{
					value = xamlType;
				}
			}
			if (value != null)
			{
				_xamlTypeCacheByName.Add(value.FullName, value);
				_xamlTypeCacheByType.Add(value.UnderlyingType, value);
			}
		}
		return value;
	}

	public IXamlMember GetMemberByLongName(string longMemberName)
	{
		if (string.IsNullOrEmpty(longMemberName))
		{
			return null;
		}
		IXamlMember value;
		lock (_xamlMembers)
		{
			if (_xamlMembers.TryGetValue(longMemberName, out value))
			{
				return value;
			}
			value = CreateXamlMember(longMemberName);
			if (value != null)
			{
				_xamlMembers.Add(longMemberName, value);
			}
		}
		return value;
	}

	private void InitTypeTables()
	{
		_typeNameTable = new string[35];
		_typeNameTable[0] = "Microsoft.Maui.MauiWinUIApplication";
		_typeNameTable[1] = "Microsoft.UI.Xaml.Application";
		_typeNameTable[2] = "Microsoft.UI.Xaml.LaunchActivatedEventArgs";
		_typeNameTable[3] = "System.IServiceProvider";
		_typeNameTable[4] = "Microsoft.Maui.IApplication";
		_typeNameTable[5] = "Microsoft.Maui.Controls.Platform.ShellView";
		_typeNameTable[6] = "Microsoft.Maui.Platform.RootNavigationView";
		_typeNameTable[7] = "Microsoft.Maui.Platform.MauiNavigationView";
		_typeNameTable[8] = "Microsoft.UI.Xaml.Controls.NavigationView";
		_typeNameTable[9] = "Microsoft.UI.Xaml.Controls.ContentControl";
		_typeNameTable[10] = "Microsoft.UI.Xaml.Thickness";
		_typeNameTable[11] = "System.ValueType";
		_typeNameTable[12] = "Object";
		_typeNameTable[13] = "Boolean";
		_typeNameTable[14] = "Microsoft.UI.Xaml.Controls.AutoSuggestBox";
		_typeNameTable[15] = "Double";
		_typeNameTable[16] = "Microsoft.UI.Xaml.UIElement";
		_typeNameTable[17] = "Microsoft.UI.Xaml.Controls.NavigationViewDisplayMode";
		_typeNameTable[18] = "System.Enum";
		_typeNameTable[19] = "System.Collections.Generic.IList`1<Object>";
		_typeNameTable[20] = "Microsoft.UI.Xaml.DataTemplate";
		_typeNameTable[21] = "Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible";
		_typeNameTable[22] = "Microsoft.UI.Xaml.Style";
		_typeNameTable[23] = "Microsoft.UI.Xaml.Controls.StyleSelector";
		_typeNameTable[24] = "Microsoft.UI.Xaml.Controls.DataTemplateSelector";
		_typeNameTable[25] = "Microsoft.UI.Xaml.Controls.NavigationViewOverflowLabelMode";
		_typeNameTable[26] = "Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode";
		_typeNameTable[27] = "String";
		_typeNameTable[28] = "Microsoft.UI.Xaml.Controls.NavigationViewSelectionFollowsFocus";
		_typeNameTable[29] = "Microsoft.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled";
		_typeNameTable[30] = "Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings";
		_typeNameTable[31] = "Microsoft.UI.Xaml.DependencyObject";
		_typeNameTable[32] = "Microsoft.UI.Xaml.Controls.TreeViewNode";
		_typeNameTable[33] = "System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.TreeViewNode>";
		_typeNameTable[34] = "Int32";
		_typeTable = new Type[35];
		_typeTable[0] = typeof(MauiWinUIApplication);
		_typeTable[1] = typeof(Application);
		_typeTable[2] = typeof(LaunchActivatedEventArgs);
		_typeTable[3] = typeof(IServiceProvider);
		_typeTable[4] = typeof(IApplication);
		_typeTable[5] = typeof(ShellView);
		_typeTable[6] = typeof(RootNavigationView);
		_typeTable[7] = typeof(MauiNavigationView);
		_typeTable[8] = typeof(NavigationView);
		_typeTable[9] = typeof(ContentControl);
		_typeTable[10] = typeof(Microsoft.UI.Xaml.Thickness);
		_typeTable[11] = typeof(ValueType);
		_typeTable[12] = typeof(object);
		_typeTable[13] = typeof(bool);
		_typeTable[14] = typeof(AutoSuggestBox);
		_typeTable[15] = typeof(double);
		_typeTable[16] = typeof(UIElement);
		_typeTable[17] = typeof(NavigationViewDisplayMode);
		_typeTable[18] = typeof(Enum);
		_typeTable[19] = typeof(IList<object>);
		_typeTable[20] = typeof(DataTemplate);
		_typeTable[21] = typeof(NavigationViewBackButtonVisible);
		_typeTable[22] = typeof(Style);
		_typeTable[23] = typeof(StyleSelector);
		_typeTable[24] = typeof(DataTemplateSelector);
		_typeTable[25] = typeof(NavigationViewOverflowLabelMode);
		_typeTable[26] = typeof(NavigationViewPaneDisplayMode);
		_typeTable[27] = typeof(string);
		_typeTable[28] = typeof(NavigationViewSelectionFollowsFocus);
		_typeTable[29] = typeof(NavigationViewShoulderNavigationEnabled);
		_typeTable[30] = typeof(NavigationViewTemplateSettings);
		_typeTable[31] = typeof(DependencyObject);
		_typeTable[32] = typeof(TreeViewNode);
		_typeTable[33] = typeof(IList<TreeViewNode>);
		_typeTable[34] = typeof(int);
	}

	private int LookupTypeIndexByName(string typeName)
	{
		if (_typeNameTable == null)
		{
			InitTypeTables();
		}
		for (int i = 0; i < _typeNameTable.Length; i++)
		{
			if (string.CompareOrdinal(_typeNameTable[i], typeName) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	private int LookupTypeIndexByType(Type type)
	{
		if (_typeTable == null)
		{
			InitTypeTables();
		}
		for (int i = 0; i < _typeTable.Length; i++)
		{
			if (type == _typeTable[i])
			{
				return i;
			}
		}
		return -1;
	}

	private object Activate_5_ShellView()
	{
		return new ShellView();
	}

	private object Activate_6_RootNavigationView()
	{
		return new RootNavigationView();
	}

	private object Activate_7_MauiNavigationView()
	{
		return new MauiNavigationView();
	}

	private object Activate_8_NavigationView()
	{
		return new NavigationView();
	}

	private object Activate_30_NavigationViewTemplateSettings()
	{
		return new NavigationViewTemplateSettings();
	}

	private object Activate_32_TreeViewNode()
	{
		return new TreeViewNode();
	}

	private void StaticInitializer_0_MauiWinUIApplication()
	{
		RuntimeHelpers.RunClassConstructor(typeof(MauiWinUIApplication).TypeHandle);
	}

	private void StaticInitializer_3_IServiceProvider()
	{
		RuntimeHelpers.RunClassConstructor(typeof(IServiceProvider).TypeHandle);
	}

	private void StaticInitializer_4_IApplication()
	{
		RuntimeHelpers.RunClassConstructor(typeof(IApplication).TypeHandle);
	}

	private void StaticInitializer_5_ShellView()
	{
		RuntimeHelpers.RunClassConstructor(typeof(ShellView).TypeHandle);
	}

	private void StaticInitializer_6_RootNavigationView()
	{
		RuntimeHelpers.RunClassConstructor(typeof(RootNavigationView).TypeHandle);
	}

	private void StaticInitializer_7_MauiNavigationView()
	{
		RuntimeHelpers.RunClassConstructor(typeof(MauiNavigationView).TypeHandle);
	}

	private void StaticInitializer_8_NavigationView()
	{
		RuntimeHelpers.RunClassConstructor(typeof(NavigationView).TypeHandle);
	}

	private void StaticInitializer_10_Thickness()
	{
		RuntimeHelpers.RunClassConstructor(typeof(Microsoft.UI.Xaml.Thickness).TypeHandle);
	}

	private void StaticInitializer_11_ValueType()
	{
		RuntimeHelpers.RunClassConstructor(typeof(ValueType).TypeHandle);
	}

	private void StaticInitializer_17_NavigationViewDisplayMode()
	{
		RuntimeHelpers.RunClassConstructor(typeof(NavigationViewDisplayMode).TypeHandle);
	}

	private void StaticInitializer_18_Enum()
	{
		RuntimeHelpers.RunClassConstructor(typeof(Enum).TypeHandle);
	}

	private void StaticInitializer_19_IList()
	{
		RuntimeHelpers.RunClassConstructor(typeof(IList<object>).TypeHandle);
	}

	private void StaticInitializer_21_NavigationViewBackButtonVisible()
	{
		RuntimeHelpers.RunClassConstructor(typeof(NavigationViewBackButtonVisible).TypeHandle);
	}

	private void StaticInitializer_25_NavigationViewOverflowLabelMode()
	{
		RuntimeHelpers.RunClassConstructor(typeof(NavigationViewOverflowLabelMode).TypeHandle);
	}

	private void StaticInitializer_26_NavigationViewPaneDisplayMode()
	{
		RuntimeHelpers.RunClassConstructor(typeof(NavigationViewPaneDisplayMode).TypeHandle);
	}

	private void StaticInitializer_28_NavigationViewSelectionFollowsFocus()
	{
		RuntimeHelpers.RunClassConstructor(typeof(NavigationViewSelectionFollowsFocus).TypeHandle);
	}

	private void StaticInitializer_29_NavigationViewShoulderNavigationEnabled()
	{
		RuntimeHelpers.RunClassConstructor(typeof(NavigationViewShoulderNavigationEnabled).TypeHandle);
	}

	private void StaticInitializer_30_NavigationViewTemplateSettings()
	{
		RuntimeHelpers.RunClassConstructor(typeof(NavigationViewTemplateSettings).TypeHandle);
	}

	private void StaticInitializer_32_TreeViewNode()
	{
		RuntimeHelpers.RunClassConstructor(typeof(TreeViewNode).TypeHandle);
	}

	private void StaticInitializer_33_IList()
	{
		RuntimeHelpers.RunClassConstructor(typeof(IList<TreeViewNode>).TypeHandle);
	}

	private void VectorAdd_19_IList(object instance, object item)
	{
		ICollection<object> collection = (ICollection<object>)instance;
		collection.Add(item);
	}

	private void VectorAdd_33_IList(object instance, object item)
	{
		ICollection<TreeViewNode> collection = (ICollection<TreeViewNode>)instance;
		TreeViewNode item2 = (TreeViewNode)item;
		collection.Add(item2);
	}

	private IXamlType CreateXamlType(int typeIndex)
	{
		XamlSystemBaseType result = null;
		string fullName = _typeNameTable[typeIndex];
		Type type = _typeTable[typeIndex];
		switch (typeIndex)
		{
		case 0:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Application"));
			xamlUserType.StaticInitializer = StaticInitializer_0_MauiWinUIApplication;
			xamlUserType.AddMemberName("LaunchActivatedEventArgs");
			xamlUserType.AddMemberName("Services");
			xamlUserType.AddMemberName("Application");
			result = xamlUserType;
			break;
		}
		case 1:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 2:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 3:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, null);
			xamlUserType.StaticInitializer = StaticInitializer_3_IServiceProvider;
			xamlUserType.SetIsReturnTypeStub();
			result = xamlUserType;
			break;
		}
		case 4:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, null);
			xamlUserType.StaticInitializer = StaticInitializer_4_IApplication;
			xamlUserType.SetIsReturnTypeStub();
			result = xamlUserType;
			break;
		}
		case 5:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.Maui.Platform.RootNavigationView"));
			xamlUserType.Activator = Activate_5_ShellView;
			xamlUserType.StaticInitializer = StaticInitializer_5_ShellView;
			xamlUserType.SetIsBindable();
			result = xamlUserType;
			break;
		}
		case 6:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.Maui.Platform.MauiNavigationView"));
			xamlUserType.Activator = Activate_6_RootNavigationView;
			xamlUserType.StaticInitializer = StaticInitializer_6_RootNavigationView;
			xamlUserType.SetIsBindable();
			result = xamlUserType;
			break;
		}
		case 7:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView"));
			xamlUserType.Activator = Activate_7_MauiNavigationView;
			xamlUserType.StaticInitializer = StaticInitializer_7_MauiNavigationView;
			xamlUserType.AddMemberName("NavigationViewBackButtonMargin");
			xamlUserType.SetIsBindable();
			result = xamlUserType;
			break;
		}
		case 8:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.Controls.ContentControl"));
			xamlUserType.Activator = Activate_8_NavigationView;
			xamlUserType.StaticInitializer = StaticInitializer_8_NavigationView;
			xamlUserType.AddMemberName("AlwaysShowHeader");
			xamlUserType.AddMemberName("AutoSuggestBox");
			xamlUserType.AddMemberName("CompactModeThresholdWidth");
			xamlUserType.AddMemberName("CompactPaneLength");
			xamlUserType.AddMemberName("ContentOverlay");
			xamlUserType.AddMemberName("DisplayMode");
			xamlUserType.AddMemberName("ExpandedModeThresholdWidth");
			xamlUserType.AddMemberName("FooterMenuItems");
			xamlUserType.AddMemberName("FooterMenuItemsSource");
			xamlUserType.AddMemberName("Header");
			xamlUserType.AddMemberName("HeaderTemplate");
			xamlUserType.AddMemberName("IsBackButtonVisible");
			xamlUserType.AddMemberName("IsBackEnabled");
			xamlUserType.AddMemberName("IsPaneOpen");
			xamlUserType.AddMemberName("IsPaneToggleButtonVisible");
			xamlUserType.AddMemberName("IsPaneVisible");
			xamlUserType.AddMemberName("IsSettingsVisible");
			xamlUserType.AddMemberName("IsTitleBarAutoPaddingEnabled");
			xamlUserType.AddMemberName("MenuItemContainerStyle");
			xamlUserType.AddMemberName("MenuItemContainerStyleSelector");
			xamlUserType.AddMemberName("MenuItemTemplate");
			xamlUserType.AddMemberName("MenuItemTemplateSelector");
			xamlUserType.AddMemberName("MenuItems");
			xamlUserType.AddMemberName("MenuItemsSource");
			xamlUserType.AddMemberName("OpenPaneLength");
			xamlUserType.AddMemberName("OverflowLabelMode");
			xamlUserType.AddMemberName("PaneCustomContent");
			xamlUserType.AddMemberName("PaneDisplayMode");
			xamlUserType.AddMemberName("PaneFooter");
			xamlUserType.AddMemberName("PaneHeader");
			xamlUserType.AddMemberName("PaneTitle");
			xamlUserType.AddMemberName("PaneToggleButtonStyle");
			xamlUserType.AddMemberName("SelectedItem");
			xamlUserType.AddMemberName("SelectionFollowsFocus");
			xamlUserType.AddMemberName("SettingsItem");
			xamlUserType.AddMemberName("ShoulderNavigationEnabled");
			xamlUserType.AddMemberName("TemplateSettings");
			result = xamlUserType;
			break;
		}
		case 9:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 10:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			xamlUserType.StaticInitializer = StaticInitializer_10_Thickness;
			xamlUserType.SetIsReturnTypeStub();
			result = xamlUserType;
			break;
		}
		case 11:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("Object"));
			xamlUserType.StaticInitializer = StaticInitializer_11_ValueType;
			result = xamlUserType;
			break;
		}
		case 12:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 13:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 14:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 15:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 16:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 17:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			xamlUserType.StaticInitializer = StaticInitializer_17_NavigationViewDisplayMode;
			xamlUserType.AddEnumValue("Minimal", NavigationViewDisplayMode.Minimal);
			xamlUserType.AddEnumValue("Compact", NavigationViewDisplayMode.Compact);
			xamlUserType.AddEnumValue("Expanded", NavigationViewDisplayMode.Expanded);
			result = xamlUserType;
			break;
		}
		case 18:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("System.ValueType"));
			xamlUserType.StaticInitializer = StaticInitializer_18_Enum;
			result = xamlUserType;
			break;
		}
		case 19:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, null);
			xamlUserType.StaticInitializer = StaticInitializer_19_IList;
			xamlUserType.CollectionAdd = VectorAdd_19_IList;
			xamlUserType.SetIsReturnTypeStub();
			result = xamlUserType;
			break;
		}
		case 20:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 21:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			xamlUserType.StaticInitializer = StaticInitializer_21_NavigationViewBackButtonVisible;
			xamlUserType.AddEnumValue("Collapsed", NavigationViewBackButtonVisible.Collapsed);
			xamlUserType.AddEnumValue("Visible", NavigationViewBackButtonVisible.Visible);
			xamlUserType.AddEnumValue("Auto", NavigationViewBackButtonVisible.Auto);
			result = xamlUserType;
			break;
		}
		case 22:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 23:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 24:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 25:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			xamlUserType.StaticInitializer = StaticInitializer_25_NavigationViewOverflowLabelMode;
			xamlUserType.AddEnumValue("MoreLabel", NavigationViewOverflowLabelMode.MoreLabel);
			xamlUserType.AddEnumValue("NoLabel", NavigationViewOverflowLabelMode.NoLabel);
			result = xamlUserType;
			break;
		}
		case 26:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			xamlUserType.StaticInitializer = StaticInitializer_26_NavigationViewPaneDisplayMode;
			xamlUserType.AddEnumValue("Auto", NavigationViewPaneDisplayMode.Auto);
			xamlUserType.AddEnumValue("Left", NavigationViewPaneDisplayMode.Left);
			xamlUserType.AddEnumValue("Top", NavigationViewPaneDisplayMode.Top);
			xamlUserType.AddEnumValue("LeftCompact", NavigationViewPaneDisplayMode.LeftCompact);
			xamlUserType.AddEnumValue("LeftMinimal", NavigationViewPaneDisplayMode.LeftMinimal);
			result = xamlUserType;
			break;
		}
		case 27:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 28:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			xamlUserType.StaticInitializer = StaticInitializer_28_NavigationViewSelectionFollowsFocus;
			xamlUserType.AddEnumValue("Disabled", NavigationViewSelectionFollowsFocus.Disabled);
			xamlUserType.AddEnumValue("Enabled", NavigationViewSelectionFollowsFocus.Enabled);
			result = xamlUserType;
			break;
		}
		case 29:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("System.Enum"));
			xamlUserType.StaticInitializer = StaticInitializer_29_NavigationViewShoulderNavigationEnabled;
			xamlUserType.AddEnumValue("WhenSelectionFollowsFocus", NavigationViewShoulderNavigationEnabled.WhenSelectionFollowsFocus);
			xamlUserType.AddEnumValue("Always", NavigationViewShoulderNavigationEnabled.Always);
			xamlUserType.AddEnumValue("Never", NavigationViewShoulderNavigationEnabled.Never);
			result = xamlUserType;
			break;
		}
		case 30:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			xamlUserType.StaticInitializer = StaticInitializer_30_NavigationViewTemplateSettings;
			xamlUserType.SetIsReturnTypeStub();
			result = xamlUserType;
			break;
		}
		case 31:
			result = new XamlSystemBaseType(fullName, type);
			break;
		case 32:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, GetXamlTypeByName("Microsoft.UI.Xaml.DependencyObject"));
			xamlUserType.Activator = Activate_32_TreeViewNode;
			xamlUserType.StaticInitializer = StaticInitializer_32_TreeViewNode;
			xamlUserType.AddMemberName("Children");
			xamlUserType.AddMemberName("Content");
			xamlUserType.AddMemberName("Depth");
			xamlUserType.AddMemberName("HasChildren");
			xamlUserType.AddMemberName("HasUnrealizedChildren");
			xamlUserType.AddMemberName("IsExpanded");
			xamlUserType.AddMemberName("Parent");
			xamlUserType.SetIsBindable();
			result = xamlUserType;
			break;
		}
		case 33:
		{
			XamlUserType xamlUserType = new XamlUserType(this, fullName, type, null);
			xamlUserType.StaticInitializer = StaticInitializer_33_IList;
			xamlUserType.CollectionAdd = VectorAdd_33_IList;
			xamlUserType.SetIsReturnTypeStub();
			result = xamlUserType;
			break;
		}
		case 34:
			result = new XamlSystemBaseType(fullName, type);
			break;
		}
		return result;
	}

	private IXamlType CheckOtherMetadataProvidersForName(string typeName)
	{
		IXamlType xamlType = null;
		IXamlType result = null;
		foreach (IXamlMetadataProvider otherProvider in OtherProviders)
		{
			xamlType = otherProvider.GetXamlType(typeName);
			if (xamlType != null)
			{
				if (xamlType.IsConstructible)
				{
					return xamlType;
				}
				result = xamlType;
			}
		}
		return result;
	}

	private IXamlType CheckOtherMetadataProvidersForType(Type type)
	{
		IXamlType xamlType = null;
		IXamlType result = null;
		foreach (IXamlMetadataProvider otherProvider in OtherProviders)
		{
			xamlType = otherProvider.GetXamlType(type);
			if (xamlType != null)
			{
				if (xamlType.IsConstructible)
				{
					return xamlType;
				}
				result = xamlType;
			}
		}
		return result;
	}

	private object get_0_MauiWinUIApplication_LaunchActivatedEventArgs(object instance)
	{
		MauiWinUIApplication mauiWinUIApplication = (MauiWinUIApplication)instance;
		return mauiWinUIApplication.LaunchActivatedEventArgs;
	}

	private object get_1_MauiWinUIApplication_Services(object instance)
	{
		MauiWinUIApplication mauiWinUIApplication = (MauiWinUIApplication)instance;
		return mauiWinUIApplication.Services;
	}

	private object get_2_MauiWinUIApplication_Application(object instance)
	{
		MauiWinUIApplication mauiWinUIApplication = (MauiWinUIApplication)instance;
		return mauiWinUIApplication.Application;
	}

	private object get_3_MauiNavigationView_NavigationViewBackButtonMargin(object instance)
	{
		MauiNavigationView mauiNavigationView = (MauiNavigationView)instance;
		return mauiNavigationView.NavigationViewBackButtonMargin;
	}

	private void set_3_MauiNavigationView_NavigationViewBackButtonMargin(object instance, object Value)
	{
		MauiNavigationView mauiNavigationView = (MauiNavigationView)instance;
		mauiNavigationView.NavigationViewBackButtonMargin = (Microsoft.UI.Xaml.Thickness)Value;
	}

	private object get_4_NavigationView_AlwaysShowHeader(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.AlwaysShowHeader;
	}

	private void set_4_NavigationView_AlwaysShowHeader(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.AlwaysShowHeader = (bool)Value;
	}

	private object get_5_NavigationView_AutoSuggestBox(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.AutoSuggestBox;
	}

	private void set_5_NavigationView_AutoSuggestBox(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.AutoSuggestBox = (AutoSuggestBox)Value;
	}

	private object get_6_NavigationView_CompactModeThresholdWidth(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.CompactModeThresholdWidth;
	}

	private void set_6_NavigationView_CompactModeThresholdWidth(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.CompactModeThresholdWidth = (double)Value;
	}

	private object get_7_NavigationView_CompactPaneLength(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.CompactPaneLength;
	}

	private void set_7_NavigationView_CompactPaneLength(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.CompactPaneLength = (double)Value;
	}

	private object get_8_NavigationView_ContentOverlay(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.ContentOverlay;
	}

	private void set_8_NavigationView_ContentOverlay(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.ContentOverlay = (UIElement)Value;
	}

	private object get_9_NavigationView_DisplayMode(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.DisplayMode;
	}

	private object get_10_NavigationView_ExpandedModeThresholdWidth(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.ExpandedModeThresholdWidth;
	}

	private void set_10_NavigationView_ExpandedModeThresholdWidth(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.ExpandedModeThresholdWidth = (double)Value;
	}

	private object get_11_NavigationView_FooterMenuItems(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.FooterMenuItems;
	}

	private object get_12_NavigationView_FooterMenuItemsSource(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.FooterMenuItemsSource;
	}

	private void set_12_NavigationView_FooterMenuItemsSource(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.FooterMenuItemsSource = Value;
	}

	private object get_13_NavigationView_Header(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.Header;
	}

	private void set_13_NavigationView_Header(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.Header = Value;
	}

	private object get_14_NavigationView_HeaderTemplate(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.HeaderTemplate;
	}

	private void set_14_NavigationView_HeaderTemplate(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.HeaderTemplate = (DataTemplate)Value;
	}

	private object get_15_NavigationView_IsBackButtonVisible(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.IsBackButtonVisible;
	}

	private void set_15_NavigationView_IsBackButtonVisible(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.IsBackButtonVisible = (NavigationViewBackButtonVisible)Value;
	}

	private object get_16_NavigationView_IsBackEnabled(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.IsBackEnabled;
	}

	private void set_16_NavigationView_IsBackEnabled(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.IsBackEnabled = (bool)Value;
	}

	private object get_17_NavigationView_IsPaneOpen(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.IsPaneOpen;
	}

	private void set_17_NavigationView_IsPaneOpen(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.IsPaneOpen = (bool)Value;
	}

	private object get_18_NavigationView_IsPaneToggleButtonVisible(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.IsPaneToggleButtonVisible;
	}

	private void set_18_NavigationView_IsPaneToggleButtonVisible(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.IsPaneToggleButtonVisible = (bool)Value;
	}

	private object get_19_NavigationView_IsPaneVisible(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.IsPaneVisible;
	}

	private void set_19_NavigationView_IsPaneVisible(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.IsPaneVisible = (bool)Value;
	}

	private object get_20_NavigationView_IsSettingsVisible(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.IsSettingsVisible;
	}

	private void set_20_NavigationView_IsSettingsVisible(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.IsSettingsVisible = (bool)Value;
	}

	private object get_21_NavigationView_IsTitleBarAutoPaddingEnabled(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.IsTitleBarAutoPaddingEnabled;
	}

	private void set_21_NavigationView_IsTitleBarAutoPaddingEnabled(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.IsTitleBarAutoPaddingEnabled = (bool)Value;
	}

	private object get_22_NavigationView_MenuItemContainerStyle(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.MenuItemContainerStyle;
	}

	private void set_22_NavigationView_MenuItemContainerStyle(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.MenuItemContainerStyle = (Style)Value;
	}

	private object get_23_NavigationView_MenuItemContainerStyleSelector(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.MenuItemContainerStyleSelector;
	}

	private void set_23_NavigationView_MenuItemContainerStyleSelector(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.MenuItemContainerStyleSelector = (StyleSelector)Value;
	}

	private object get_24_NavigationView_MenuItemTemplate(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.MenuItemTemplate;
	}

	private void set_24_NavigationView_MenuItemTemplate(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.MenuItemTemplate = (DataTemplate)Value;
	}

	private object get_25_NavigationView_MenuItemTemplateSelector(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.MenuItemTemplateSelector;
	}

	private void set_25_NavigationView_MenuItemTemplateSelector(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.MenuItemTemplateSelector = (DataTemplateSelector)Value;
	}

	private object get_26_NavigationView_MenuItems(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.MenuItems;
	}

	private object get_27_NavigationView_MenuItemsSource(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.MenuItemsSource;
	}

	private void set_27_NavigationView_MenuItemsSource(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.MenuItemsSource = Value;
	}

	private object get_28_NavigationView_OpenPaneLength(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.OpenPaneLength;
	}

	private void set_28_NavigationView_OpenPaneLength(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.OpenPaneLength = (double)Value;
	}

	private object get_29_NavigationView_OverflowLabelMode(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.OverflowLabelMode;
	}

	private void set_29_NavigationView_OverflowLabelMode(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.OverflowLabelMode = (NavigationViewOverflowLabelMode)Value;
	}

	private object get_30_NavigationView_PaneCustomContent(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.PaneCustomContent;
	}

	private void set_30_NavigationView_PaneCustomContent(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.PaneCustomContent = (UIElement)Value;
	}

	private object get_31_NavigationView_PaneDisplayMode(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.PaneDisplayMode;
	}

	private void set_31_NavigationView_PaneDisplayMode(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.PaneDisplayMode = (NavigationViewPaneDisplayMode)Value;
	}

	private object get_32_NavigationView_PaneFooter(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.PaneFooter;
	}

	private void set_32_NavigationView_PaneFooter(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.PaneFooter = (UIElement)Value;
	}

	private object get_33_NavigationView_PaneHeader(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.PaneHeader;
	}

	private void set_33_NavigationView_PaneHeader(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.PaneHeader = (UIElement)Value;
	}

	private object get_34_NavigationView_PaneTitle(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.PaneTitle;
	}

	private void set_34_NavigationView_PaneTitle(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.PaneTitle = (string)Value;
	}

	private object get_35_NavigationView_PaneToggleButtonStyle(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.PaneToggleButtonStyle;
	}

	private void set_35_NavigationView_PaneToggleButtonStyle(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.PaneToggleButtonStyle = (Style)Value;
	}

	private object get_36_NavigationView_SelectedItem(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.SelectedItem;
	}

	private void set_36_NavigationView_SelectedItem(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.SelectedItem = Value;
	}

	private object get_37_NavigationView_SelectionFollowsFocus(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.SelectionFollowsFocus;
	}

	private void set_37_NavigationView_SelectionFollowsFocus(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.SelectionFollowsFocus = (NavigationViewSelectionFollowsFocus)Value;
	}

	private object get_38_NavigationView_SettingsItem(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.SettingsItem;
	}

	private object get_39_NavigationView_ShoulderNavigationEnabled(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.ShoulderNavigationEnabled;
	}

	private void set_39_NavigationView_ShoulderNavigationEnabled(object instance, object Value)
	{
		NavigationView navigationView = (NavigationView)instance;
		navigationView.ShoulderNavigationEnabled = (NavigationViewShoulderNavigationEnabled)Value;
	}

	private object get_40_NavigationView_TemplateSettings(object instance)
	{
		NavigationView navigationView = (NavigationView)instance;
		return navigationView.TemplateSettings;
	}

	private object get_41_TreeViewNode_Children(object instance)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		return treeViewNode.Children;
	}

	private object get_42_TreeViewNode_Content(object instance)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		return treeViewNode.Content;
	}

	private void set_42_TreeViewNode_Content(object instance, object Value)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		treeViewNode.Content = Value;
	}

	private object get_43_TreeViewNode_Depth(object instance)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		return treeViewNode.Depth;
	}

	private object get_44_TreeViewNode_HasChildren(object instance)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		return treeViewNode.HasChildren;
	}

	private object get_45_TreeViewNode_HasUnrealizedChildren(object instance)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		return treeViewNode.HasUnrealizedChildren;
	}

	private void set_45_TreeViewNode_HasUnrealizedChildren(object instance, object Value)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		treeViewNode.HasUnrealizedChildren = (bool)Value;
	}

	private object get_46_TreeViewNode_IsExpanded(object instance)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		return treeViewNode.IsExpanded;
	}

	private void set_46_TreeViewNode_IsExpanded(object instance, object Value)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		treeViewNode.IsExpanded = (bool)Value;
	}

	private object get_47_TreeViewNode_Parent(object instance)
	{
		TreeViewNode treeViewNode = (TreeViewNode)instance;
		return treeViewNode.Parent;
	}

	private IXamlMember CreateXamlMember(string longMemberName)
	{
		XamlMember xamlMember = null;
		switch (longMemberName)
		{
		case "Microsoft.Maui.MauiWinUIApplication.LaunchActivatedEventArgs":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.Maui.MauiWinUIApplication");
			xamlMember = new XamlMember(this, "LaunchActivatedEventArgs", "Microsoft.UI.Xaml.LaunchActivatedEventArgs");
			xamlMember.Getter = get_0_MauiWinUIApplication_LaunchActivatedEventArgs;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.Maui.MauiWinUIApplication.Services":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.Maui.MauiWinUIApplication");
			xamlMember = new XamlMember(this, "Services", "System.IServiceProvider");
			xamlMember.Getter = get_1_MauiWinUIApplication_Services;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.Maui.MauiWinUIApplication.Application":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.Maui.MauiWinUIApplication");
			xamlMember = new XamlMember(this, "Application", "Microsoft.Maui.IApplication");
			xamlMember.Getter = get_2_MauiWinUIApplication_Application;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.Maui.Platform.MauiNavigationView.NavigationViewBackButtonMargin":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.Maui.Platform.MauiNavigationView");
			xamlMember = new XamlMember(this, "NavigationViewBackButtonMargin", "Microsoft.UI.Xaml.Thickness");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_3_MauiNavigationView_NavigationViewBackButtonMargin;
			xamlMember.Setter = set_3_MauiNavigationView_NavigationViewBackButtonMargin;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.AlwaysShowHeader":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "AlwaysShowHeader", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_4_NavigationView_AlwaysShowHeader;
			xamlMember.Setter = set_4_NavigationView_AlwaysShowHeader;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.AutoSuggestBox":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "AutoSuggestBox", "Microsoft.UI.Xaml.Controls.AutoSuggestBox");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_5_NavigationView_AutoSuggestBox;
			xamlMember.Setter = set_5_NavigationView_AutoSuggestBox;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.CompactModeThresholdWidth":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "CompactModeThresholdWidth", "Double");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_6_NavigationView_CompactModeThresholdWidth;
			xamlMember.Setter = set_6_NavigationView_CompactModeThresholdWidth;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.CompactPaneLength":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "CompactPaneLength", "Double");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_7_NavigationView_CompactPaneLength;
			xamlMember.Setter = set_7_NavigationView_CompactPaneLength;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.ContentOverlay":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "ContentOverlay", "Microsoft.UI.Xaml.UIElement");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_8_NavigationView_ContentOverlay;
			xamlMember.Setter = set_8_NavigationView_ContentOverlay;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.DisplayMode":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "DisplayMode", "Microsoft.UI.Xaml.Controls.NavigationViewDisplayMode");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_9_NavigationView_DisplayMode;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.ExpandedModeThresholdWidth":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "ExpandedModeThresholdWidth", "Double");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_10_NavigationView_ExpandedModeThresholdWidth;
			xamlMember.Setter = set_10_NavigationView_ExpandedModeThresholdWidth;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.FooterMenuItems":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "FooterMenuItems", "System.Collections.Generic.IList`1<Object>");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_11_NavigationView_FooterMenuItems;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.FooterMenuItemsSource":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "FooterMenuItemsSource", "Object");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_12_NavigationView_FooterMenuItemsSource;
			xamlMember.Setter = set_12_NavigationView_FooterMenuItemsSource;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.Header":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "Header", "Object");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_13_NavigationView_Header;
			xamlMember.Setter = set_13_NavigationView_Header;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.HeaderTemplate":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "HeaderTemplate", "Microsoft.UI.Xaml.DataTemplate");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_14_NavigationView_HeaderTemplate;
			xamlMember.Setter = set_14_NavigationView_HeaderTemplate;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.IsBackButtonVisible":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "IsBackButtonVisible", "Microsoft.UI.Xaml.Controls.NavigationViewBackButtonVisible");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_15_NavigationView_IsBackButtonVisible;
			xamlMember.Setter = set_15_NavigationView_IsBackButtonVisible;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.IsBackEnabled":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "IsBackEnabled", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_16_NavigationView_IsBackEnabled;
			xamlMember.Setter = set_16_NavigationView_IsBackEnabled;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.IsPaneOpen":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "IsPaneOpen", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_17_NavigationView_IsPaneOpen;
			xamlMember.Setter = set_17_NavigationView_IsPaneOpen;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.IsPaneToggleButtonVisible":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "IsPaneToggleButtonVisible", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_18_NavigationView_IsPaneToggleButtonVisible;
			xamlMember.Setter = set_18_NavigationView_IsPaneToggleButtonVisible;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.IsPaneVisible":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "IsPaneVisible", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_19_NavigationView_IsPaneVisible;
			xamlMember.Setter = set_19_NavigationView_IsPaneVisible;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.IsSettingsVisible":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "IsSettingsVisible", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_20_NavigationView_IsSettingsVisible;
			xamlMember.Setter = set_20_NavigationView_IsSettingsVisible;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.IsTitleBarAutoPaddingEnabled":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "IsTitleBarAutoPaddingEnabled", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_21_NavigationView_IsTitleBarAutoPaddingEnabled;
			xamlMember.Setter = set_21_NavigationView_IsTitleBarAutoPaddingEnabled;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemContainerStyle":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "MenuItemContainerStyle", "Microsoft.UI.Xaml.Style");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_22_NavigationView_MenuItemContainerStyle;
			xamlMember.Setter = set_22_NavigationView_MenuItemContainerStyle;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemContainerStyleSelector":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "MenuItemContainerStyleSelector", "Microsoft.UI.Xaml.Controls.StyleSelector");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_23_NavigationView_MenuItemContainerStyleSelector;
			xamlMember.Setter = set_23_NavigationView_MenuItemContainerStyleSelector;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemTemplate":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "MenuItemTemplate", "Microsoft.UI.Xaml.DataTemplate");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_24_NavigationView_MenuItemTemplate;
			xamlMember.Setter = set_24_NavigationView_MenuItemTemplate;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemTemplateSelector":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "MenuItemTemplateSelector", "Microsoft.UI.Xaml.Controls.DataTemplateSelector");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_25_NavigationView_MenuItemTemplateSelector;
			xamlMember.Setter = set_25_NavigationView_MenuItemTemplateSelector;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.MenuItems":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "MenuItems", "System.Collections.Generic.IList`1<Object>");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_26_NavigationView_MenuItems;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.MenuItemsSource":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "MenuItemsSource", "Object");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_27_NavigationView_MenuItemsSource;
			xamlMember.Setter = set_27_NavigationView_MenuItemsSource;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.OpenPaneLength":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "OpenPaneLength", "Double");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_28_NavigationView_OpenPaneLength;
			xamlMember.Setter = set_28_NavigationView_OpenPaneLength;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.OverflowLabelMode":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "OverflowLabelMode", "Microsoft.UI.Xaml.Controls.NavigationViewOverflowLabelMode");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_29_NavigationView_OverflowLabelMode;
			xamlMember.Setter = set_29_NavigationView_OverflowLabelMode;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.PaneCustomContent":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "PaneCustomContent", "Microsoft.UI.Xaml.UIElement");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_30_NavigationView_PaneCustomContent;
			xamlMember.Setter = set_30_NavigationView_PaneCustomContent;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.PaneDisplayMode":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "PaneDisplayMode", "Microsoft.UI.Xaml.Controls.NavigationViewPaneDisplayMode");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_31_NavigationView_PaneDisplayMode;
			xamlMember.Setter = set_31_NavigationView_PaneDisplayMode;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.PaneFooter":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "PaneFooter", "Microsoft.UI.Xaml.UIElement");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_32_NavigationView_PaneFooter;
			xamlMember.Setter = set_32_NavigationView_PaneFooter;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.PaneHeader":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "PaneHeader", "Microsoft.UI.Xaml.UIElement");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_33_NavigationView_PaneHeader;
			xamlMember.Setter = set_33_NavigationView_PaneHeader;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.PaneTitle":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "PaneTitle", "String");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_34_NavigationView_PaneTitle;
			xamlMember.Setter = set_34_NavigationView_PaneTitle;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.PaneToggleButtonStyle":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "PaneToggleButtonStyle", "Microsoft.UI.Xaml.Style");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_35_NavigationView_PaneToggleButtonStyle;
			xamlMember.Setter = set_35_NavigationView_PaneToggleButtonStyle;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.SelectedItem":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "SelectedItem", "Object");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_36_NavigationView_SelectedItem;
			xamlMember.Setter = set_36_NavigationView_SelectedItem;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.SelectionFollowsFocus":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "SelectionFollowsFocus", "Microsoft.UI.Xaml.Controls.NavigationViewSelectionFollowsFocus");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_37_NavigationView_SelectionFollowsFocus;
			xamlMember.Setter = set_37_NavigationView_SelectionFollowsFocus;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.SettingsItem":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "SettingsItem", "Object");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_38_NavigationView_SettingsItem;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.ShoulderNavigationEnabled":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "ShoulderNavigationEnabled", "Microsoft.UI.Xaml.Controls.NavigationViewShoulderNavigationEnabled");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_39_NavigationView_ShoulderNavigationEnabled;
			xamlMember.Setter = set_39_NavigationView_ShoulderNavigationEnabled;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.NavigationView.TemplateSettings":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.NavigationView");
			xamlMember = new XamlMember(this, "TemplateSettings", "Microsoft.UI.Xaml.Controls.NavigationViewTemplateSettings");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_40_NavigationView_TemplateSettings;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.UI.Xaml.Controls.TreeViewNode.Children":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
			xamlMember = new XamlMember(this, "Children", "System.Collections.Generic.IList`1<Microsoft.UI.Xaml.Controls.TreeViewNode>");
			xamlMember.Getter = get_41_TreeViewNode_Children;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.UI.Xaml.Controls.TreeViewNode.Content":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
			xamlMember = new XamlMember(this, "Content", "Object");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_42_TreeViewNode_Content;
			xamlMember.Setter = set_42_TreeViewNode_Content;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.TreeViewNode.Depth":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
			xamlMember = new XamlMember(this, "Depth", "Int32");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_43_TreeViewNode_Depth;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.UI.Xaml.Controls.TreeViewNode.HasChildren":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
			xamlMember = new XamlMember(this, "HasChildren", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_44_TreeViewNode_HasChildren;
			xamlMember.SetIsReadOnly();
			break;
		}
		case "Microsoft.UI.Xaml.Controls.TreeViewNode.HasUnrealizedChildren":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
			xamlMember = new XamlMember(this, "HasUnrealizedChildren", "Boolean");
			xamlMember.Getter = get_45_TreeViewNode_HasUnrealizedChildren;
			xamlMember.Setter = set_45_TreeViewNode_HasUnrealizedChildren;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.TreeViewNode.IsExpanded":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
			xamlMember = new XamlMember(this, "IsExpanded", "Boolean");
			xamlMember.SetIsDependencyProperty();
			xamlMember.Getter = get_46_TreeViewNode_IsExpanded;
			xamlMember.Setter = set_46_TreeViewNode_IsExpanded;
			break;
		}
		case "Microsoft.UI.Xaml.Controls.TreeViewNode.Parent":
		{
			XamlUserType xamlUserType = (XamlUserType)GetXamlTypeByName("Microsoft.UI.Xaml.Controls.TreeViewNode");
			xamlMember = new XamlMember(this, "Parent", "Microsoft.UI.Xaml.Controls.TreeViewNode");
			xamlMember.Getter = get_47_TreeViewNode_Parent;
			xamlMember.SetIsReadOnly();
			break;
		}
		}
		return xamlMember;
	}
}
