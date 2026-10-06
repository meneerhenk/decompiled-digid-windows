using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Nfc;
using DigiD.Common.Resources;
using DigiD.Mobile.Controls;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DM002.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DM002 : BasePage<DM002ViewModel>
{
	public DM002(DM002ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DM002).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DM002)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		DynamicResource dynamicResource = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 19);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 21);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 21);
		CustomTabButton customTabButton = new CustomTabButton();
		VisualDiagnostics.RegisterSourceInfo(customTabButton, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 18);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 21);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		CustomTabButton customTabButton2 = new CustomTabButton();
		VisualDiagnostics.RegisterSourceInfo(customTabButton2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 18);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 24);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 18);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 22);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 25);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 51);
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 30);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 22);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 18);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 22);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 25);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 51);
		TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 30);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 22);
		Grid grid3 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid3, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 18);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 22);
		BindingExtension bindingExtension10 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 25);
		Switch obj = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 22);
		Grid grid4 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid4, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 18);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 80, 22);
		BindingExtension bindingExtension11 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 84, 25);
		Switch obj2 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 81, 22);
		Grid grid5 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid5, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 79, 18);
		Label label8 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label8, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 88, 22);
		BindingExtension bindingExtension12 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension12, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 92, 25);
		Switch obj3 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 89, 22);
		Grid grid6 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid6, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 87, 18);
		Label label9 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label9, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 22);
		BindingExtension bindingExtension13 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension13, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 100, 25);
		Switch obj4 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 22);
		Grid grid7 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid7, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 95, 18);
		Label label10 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label10, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 104, 22);
		BindingExtension bindingExtension14 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension14, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 25);
		Switch obj5 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 105, 22);
		Grid grid8 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid8, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 103, 18);
		Label label11 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label11, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 22);
		BindingExtension bindingExtension15 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension15, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 117, 25);
		Switch obj6 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 113, 22);
		Grid grid9 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid9, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 111, 18);
		Label label12 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label12, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 22);
		BindingExtension bindingExtension16 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension16, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 125, 25);
		Switch obj7 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 122, 22);
		Grid grid10 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid10, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 120, 18);
		Label label13 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label13, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 129, 22);
		BindingExtension bindingExtension17 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension17, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 133, 25);
		Switch obj8 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj8, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 130, 22);
		Grid grid11 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid11, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 128, 18);
		Label label14 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label14, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 137, 22);
		BindingExtension bindingExtension18 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension18, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 141, 25);
		Switch obj9 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj9, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 138, 22);
		Grid grid12 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid12, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 136, 18);
		Label label15 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label15, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 145, 22);
		BindingExtension bindingExtension19 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension19, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 149, 25);
		Switch obj10 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj10, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 146, 22);
		Grid grid13 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid13, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 144, 18);
		Label label16 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label16, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 153, 22);
		BindingExtension bindingExtension20 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension20, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 157, 25);
		Switch obj11 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj11, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 154, 22);
		Grid grid14 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid14, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 152, 18);
		Label label17 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label17, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 161, 22);
		BindingExtension bindingExtension21 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension21, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 165, 25);
		Switch obj12 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj12, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 162, 22);
		Grid grid15 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid15, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 160, 18);
		Label label18 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label18, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 169, 22);
		BindingExtension bindingExtension22 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension22, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 173, 25);
		Switch obj13 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj13, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 170, 22);
		Grid grid16 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid16, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 168, 18);
		BindingExtension bindingExtension23 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension23, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 176, 51);
		Label label19 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label19, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 177, 22);
		BindingExtension bindingExtension24 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension24, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 182, 25);
		Switch obj14 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj14, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 179, 22);
		Grid grid17 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid17, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 176, 18);
		Label label20 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label20, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 186, 22);
		BindingExtension bindingExtension25 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension25, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 190, 25);
		Switch obj15 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj15, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 187, 22);
		Grid grid18 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid18, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 185, 18);
		Label label21 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label21, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 194, 22);
		BindingExtension bindingExtension26 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension26, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 198, 25);
		Switch obj16 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj16, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 195, 22);
		Grid grid19 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid19, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 193, 18);
		Label label22 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label22, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 202, 22);
		BindingExtension bindingExtension27 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension27, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 206, 25);
		Switch obj17 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj17, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 203, 22);
		Grid grid20 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid20, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 201, 18);
		Label label23 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label23, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 210, 22);
		BindingExtension bindingExtension28 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension28, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 214, 25);
		BindingExtension bindingExtension29 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension29, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 216, 51);
		TapGestureRecognizer tapGestureRecognizer3 = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer3, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 216, 30);
		Label label24 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label24, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 211, 22);
		Grid grid21 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid21, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 209, 18);
		Label label25 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label25, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 222, 22);
		BindingExtension bindingExtension30 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension30, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 226, 25);
		Switch obj18 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj18, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 223, 22);
		Grid grid22 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid22, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 221, 18);
		Label label26 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label26, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 230, 22);
		BindingExtension bindingExtension31 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension31, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 234, 25);
		Switch obj19 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj19, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 231, 22);
		Grid grid23 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid23, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 229, 18);
		Label label27 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label27, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 238, 22);
		BindingExtension bindingExtension32 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension32, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 243, 21);
		Switch obj20 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj20, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 240, 22);
		Grid grid24 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid24, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 237, 18);
		Label label28 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label28, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 247, 22);
		BindingExtension bindingExtension33 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension33, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 250, 25);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 248, 22);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 257, 25);
		BindingExtension bindingExtension34 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension34, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 257, 25);
		BindingExtension bindingExtension35 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension35, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 261, 51);
		TapGestureRecognizer tapGestureRecognizer4 = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer4, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 261, 30);
		Label label29 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label29, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 254, 22);
		BindingExtension bindingExtension36 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension36, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 268, 25);
		BindingExtension bindingExtension37 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension37, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 270, 25);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 271, 25);
		BindingExtension bindingExtension38 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension38, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 271, 25);
		DatePicker datePicker = new DatePicker();
		VisualDiagnostics.RegisterSourceInfo(datePicker, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 265, 22);
		Grid grid25 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid25, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 246, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 14);
		BindingExtension bindingExtension39 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension39, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 279, 17);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 282, 24);
		Label label30 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label30, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 282, 18);
		Label label31 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label31, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 284, 18);
		BindingExtension bindingExtension40 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension40, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 293, 21);
		Label label32 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label32, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 289, 18);
		Label label33 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label33, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 296, 18);
		BindingExtension bindingExtension41 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension41, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 305, 21);
		Label label34 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label34, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 301, 18);
		Label label35 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label35, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 308, 18);
		BindingExtension bindingExtension42 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension42, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 318, 21);
		Switch obj21 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj21, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 313, 18);
		Label label36 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label36, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 320, 18);
		BindingExtension bindingExtension43 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension43, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 331, 21);
		Switch obj22 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj22, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 326, 18);
		Label label37 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label37, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 333, 18);
		BindingExtension bindingExtension44 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension44, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 344, 21);
		Switch obj23 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj23, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 339, 18);
		Label label38 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label38, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 346, 18);
		BindingExtension bindingExtension45 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension45, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 357, 21);
		Switch obj24 = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj24, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 352, 18);
		BindingExtension bindingExtension46 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension46, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 366, 21);
		string demo_ResetCard = DigiDAppResources.Demo_ResetCard;
		VisualDiagnostics.RegisterSourceInfo(demo_ResetCard, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 367, 21);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 359, 18);
		Grid grid26 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid26, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 275, 14);
		BindingExtension bindingExtension47 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension47, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 376, 17);
		string demo_Close = DigiDAppResources.Demo_Close;
		VisualDiagnostics.RegisterSourceInfo(demo_Close, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 377, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 371, 14);
		Grid grid27 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid27, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid27.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		customTabButton.transientNamescope = nameScope;
		customTabButton2.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		tapGestureRecognizer.transientNamescope = nameScope;
		grid3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		tapGestureRecognizer2.transientNamescope = nameScope;
		grid4.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		obj.transientNamescope = nameScope;
		grid5.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		obj2.transientNamescope = nameScope;
		grid6.transientNamescope = nameScope;
		label8.transientNamescope = nameScope;
		obj3.transientNamescope = nameScope;
		grid7.transientNamescope = nameScope;
		label9.transientNamescope = nameScope;
		obj4.transientNamescope = nameScope;
		grid8.transientNamescope = nameScope;
		label10.transientNamescope = nameScope;
		obj5.transientNamescope = nameScope;
		grid9.transientNamescope = nameScope;
		label11.transientNamescope = nameScope;
		obj6.transientNamescope = nameScope;
		grid10.transientNamescope = nameScope;
		label12.transientNamescope = nameScope;
		obj7.transientNamescope = nameScope;
		grid11.transientNamescope = nameScope;
		label13.transientNamescope = nameScope;
		obj8.transientNamescope = nameScope;
		grid12.transientNamescope = nameScope;
		label14.transientNamescope = nameScope;
		obj9.transientNamescope = nameScope;
		grid13.transientNamescope = nameScope;
		label15.transientNamescope = nameScope;
		obj10.transientNamescope = nameScope;
		grid14.transientNamescope = nameScope;
		label16.transientNamescope = nameScope;
		obj11.transientNamescope = nameScope;
		grid15.transientNamescope = nameScope;
		label17.transientNamescope = nameScope;
		obj12.transientNamescope = nameScope;
		grid16.transientNamescope = nameScope;
		label18.transientNamescope = nameScope;
		obj13.transientNamescope = nameScope;
		grid17.transientNamescope = nameScope;
		label19.transientNamescope = nameScope;
		obj14.transientNamescope = nameScope;
		grid18.transientNamescope = nameScope;
		label20.transientNamescope = nameScope;
		obj15.transientNamescope = nameScope;
		grid19.transientNamescope = nameScope;
		label21.transientNamescope = nameScope;
		obj16.transientNamescope = nameScope;
		grid20.transientNamescope = nameScope;
		label22.transientNamescope = nameScope;
		obj17.transientNamescope = nameScope;
		grid21.transientNamescope = nameScope;
		label23.transientNamescope = nameScope;
		label24.transientNamescope = nameScope;
		tapGestureRecognizer3.transientNamescope = nameScope;
		grid22.transientNamescope = nameScope;
		label25.transientNamescope = nameScope;
		obj18.transientNamescope = nameScope;
		grid23.transientNamescope = nameScope;
		label26.transientNamescope = nameScope;
		obj19.transientNamescope = nameScope;
		grid24.transientNamescope = nameScope;
		label27.transientNamescope = nameScope;
		obj20.transientNamescope = nameScope;
		grid25.transientNamescope = nameScope;
		label28.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		label29.transientNamescope = nameScope;
		tapGestureRecognizer4.transientNamescope = nameScope;
		datePicker.transientNamescope = nameScope;
		grid26.transientNamescope = nameScope;
		label30.transientNamescope = nameScope;
		label31.transientNamescope = nameScope;
		label32.transientNamescope = nameScope;
		label33.transientNamescope = nameScope;
		label34.transientNamescope = nameScope;
		label35.transientNamescope = nameScope;
		obj21.transientNamescope = nameScope;
		label36.transientNamescope = nameScope;
		obj22.transientNamescope = nameScope;
		label37.transientNamescope = nameScope;
		obj23.transientNamescope = nameScope;
		label38.transientNamescope = nameScope;
		obj24.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid27.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid27.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
		((IDynamicResourceHandler)grid).SetDynamicResource(VisualElement.BackgroundProperty, dynamicResource.Key);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Star)));
		customTabButton.SetValue(Grid.ColumnProperty, 0);
		customTabButton.SetValue(Element.AutomationIdProperty, "TabAccount");
		bindingExtension.Path = "TabAccountButtonType";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 21);
		}
		customTabButton.SetBinding(BorderedButton.ButtonTypeProperty, bindingBase);
		bindingExtension2.Path = "TabSelectedCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 21);
		}
		customTabButton.SetBinding(Button.CommandProperty, bindingBase2);
		customTabButton.SetValue(Button.CommandParameterProperty, "account");
		customTabButton.NumberOfTabs = 2;
		customTabButton.TabIndex = 1;
		customTabButton.SetValue(Button.TextProperty, "Account");
		grid.Children.Add(customTabButton);
		customTabButton2.SetValue(Grid.ColumnProperty, 1);
		customTabButton2.SetValue(Element.AutomationIdProperty, "TabCard");
		bindingExtension3.Path = "TabCardButtonType";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 21);
		}
		customTabButton2.SetBinding(BorderedButton.ButtonTypeProperty, bindingBase3);
		bindingExtension4.Path = "TabSelectedCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		}
		customTabButton2.SetBinding(Button.CommandProperty, bindingBase4);
		customTabButton2.SetValue(Button.CommandParameterProperty, "card");
		customTabButton2.NumberOfTabs = 2;
		customTabButton2.TabIndex = 2;
		customTabButton2.SetValue(Button.TextProperty, "Kaart");
		grid.Children.Add(customTabButton2);
		grid27.Children.Add(grid);
		verticalStackLayout.SetValue(Grid.RowProperty, 1);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		bindingExtension5.Path = "TabAccountSelected";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		}
		verticalStackLayout.SetBinding(VisualElement.IsVisibleProperty, bindingBase5);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[5] { label, verticalStackLayout, grid27, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(43, 24)));
		object obj25 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj25) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj25, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 24);
		}
		label.SetValue(VisualElement.StyleProperty, obj25);
		label.SetValue(Label.TextProperty, "Voorkeuren");
		verticalStackLayout.Children.Add(label);
		grid2.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label2.SetValue(Label.TextProperty, "Verification method");
		grid2.Children.Add(label2);
		label3.SetValue(Grid.ColumnProperty, 1);
		label3.SetValue(Element.AutomationIdProperty, "ChangeVersionCheckResponseCommand");
		bindingExtension6.Path = "ActivationMethod";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 25);
		}
		label3.SetBinding(Label.TextProperty, bindingBase6);
		bindingExtension7.Path = "ChangeActivationMethodCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 51);
		}
		tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, bindingBase7);
		label3.GestureRecognizers.Add(tapGestureRecognizer);
		grid2.Children.Add(label3);
		verticalStackLayout.Children.Add(grid2);
		grid3.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label4.SetValue(Label.TextProperty, "Version check");
		grid3.Children.Add(label4);
		label5.SetValue(Grid.ColumnProperty, 1);
		label5.SetValue(Element.AutomationIdProperty, "ChangeActivationMethodCommand");
		bindingExtension8.Path = "VersionState";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 25);
		}
		label5.SetBinding(Label.TextProperty, bindingBase8);
		bindingExtension9.Path = "ChangeVersionCheckResponseCommand";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 51);
		}
		tapGestureRecognizer2.SetBinding(TapGestureRecognizer.CommandProperty, bindingBase9);
		label5.GestureRecognizers.Add(tapGestureRecognizer2);
		grid3.Children.Add(label5);
		verticalStackLayout.Children.Add(grid3);
		grid4.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label6.SetValue(Label.TextProperty, "Have messages");
		label6.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid4.Children.Add(label6);
		obj.SetValue(Grid.ColumnProperty, 1);
		obj.SetValue(Element.AutomationIdProperty, "HasMessagesSwitch");
		bindingExtension10.Path = "HasMessages";
		BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension10(bindingExtension10);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 25);
		}
		obj.SetBinding(Switch.IsToggledProperty, bindingBase10);
		grid4.Children.Add(obj);
		verticalStackLayout.Children.Add(grid4);
		grid5.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label7.SetValue(Label.TextProperty, "2FA active");
		label7.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid5.Children.Add(label7);
		obj2.SetValue(Grid.ColumnProperty, 1);
		obj2.SetValue(Element.AutomationIdProperty, "TwoFactorEnabledSwitch");
		bindingExtension11.Path = "TwoFactorEnabled";
		BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension11(bindingExtension11);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 84, 25);
		}
		obj2.SetBinding(Switch.IsToggledProperty, bindingBase11);
		grid5.Children.Add(obj2);
		verticalStackLayout.Children.Add(grid5);
		grid6.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label8.SetValue(Label.TextProperty, "EmailAdress known?");
		label8.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid6.Children.Add(label8);
		obj3.SetValue(Grid.ColumnProperty, 1);
		obj3.SetValue(Element.AutomationIdProperty, "HasEmailAddressSwitch");
		bindingExtension12.Path = "HasEmailAddress";
		BindingBase bindingBase12 = CreateTypedBindingFrom_bindingExtension12(bindingExtension12);
		if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 92, 25);
		}
		obj3.SetBinding(Switch.IsToggledProperty, bindingBase12);
		grid6.Children.Add(obj3);
		verticalStackLayout.Children.Add(grid6);
		grid7.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label9.SetValue(Label.TextProperty, "EmailAdress confirmed");
		label9.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid7.Children.Add(label9);
		obj4.SetValue(Grid.ColumnProperty, 1);
		obj4.SetValue(Element.AutomationIdProperty, "IsEmailAddressVerifiedSwitch");
		bindingExtension13.Path = "IsEmailAddressVerified";
		BindingBase bindingBase13 = CreateTypedBindingFrom_bindingExtension13(bindingExtension13);
		if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 100, 25);
		}
		obj4.SetBinding(Switch.IsToggledProperty, bindingBase13);
		grid7.Children.Add(obj4);
		verticalStackLayout.Children.Add(grid7);
		grid8.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label10.SetValue(Label.TextProperty, "Email verification needed");
		label10.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid8.Children.Add(label10);
		obj5.SetValue(Grid.ColumnProperty, 1);
		obj5.SetValue(Element.AutomationIdProperty, "UserActionNeededSwitch");
		bindingExtension14.Path = "UserActionNeeded";
		BindingBase bindingBase14 = CreateTypedBindingFrom_bindingExtension14(bindingExtension14);
		if (VisualDiagnostics.GetSourceInfo(bindingBase14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase14, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 25);
		}
		obj5.SetBinding(Switch.IsToggledProperty, bindingBase14);
		grid8.Children.Add(obj5);
		verticalStackLayout.Children.Add(grid8);
		grid9.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label11.SetValue(Label.TextProperty, "EIDAS User");
		label11.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid9.Children.Add(label11);
		obj6.SetValue(Grid.ColumnProperty, 1);
		obj6.SetValue(Element.AutomationIdProperty, "EIDASUserSwitch");
		obj6.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension15.Path = "EIDASUser";
		BindingBase bindingBase15 = CreateTypedBindingFrom_bindingExtension15(bindingExtension15);
		if (VisualDiagnostics.GetSourceInfo(bindingBase15) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase15, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 117, 25);
		}
		obj6.SetBinding(Switch.IsToggledProperty, bindingBase15);
		grid9.Children.Add(obj6);
		verticalStackLayout.Children.Add(grid9);
		grid10.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label12.SetValue(Label.TextProperty, "EIDAS Success");
		label12.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid10.Children.Add(label12);
		obj7.SetValue(Grid.ColumnProperty, 1);
		obj7.SetValue(Element.AutomationIdProperty, "EIDASSuccessSwitch");
		bindingExtension16.Path = "EIDASSuccess";
		BindingBase bindingBase16 = CreateTypedBindingFrom_bindingExtension16(bindingExtension16);
		if (VisualDiagnostics.GetSourceInfo(bindingBase16) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase16, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 125, 25);
		}
		obj7.SetBinding(Switch.IsToggledProperty, bindingBase16);
		grid10.Children.Add(obj7);
		verticalStackLayout.Children.Add(grid10);
		grid11.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label13.SetValue(Label.TextProperty, "RDA Failed");
		label13.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid11.Children.Add(label13);
		obj8.SetValue(Grid.ColumnProperty, 1);
		obj8.SetValue(Element.AutomationIdProperty, "RdaFailedSwitch");
		bindingExtension17.Path = "RdaFailed";
		BindingBase bindingBase17 = CreateTypedBindingFrom_bindingExtension17(bindingExtension17);
		if (VisualDiagnostics.GetSourceInfo(bindingBase17) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase17, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 133, 25);
		}
		obj8.SetBinding(Switch.IsToggledProperty, bindingBase17);
		grid11.Children.Add(obj8);
		verticalStackLayout.Children.Add(grid11);
		grid12.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label14.SetValue(Label.TextProperty, "Has No Documents");
		label14.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid12.Children.Add(label14);
		obj9.SetValue(Grid.ColumnProperty, 1);
		obj9.SetValue(Element.AutomationIdProperty, "NoDocumentsSwitch");
		bindingExtension18.Path = "HasNoDocuments";
		BindingBase bindingBase18 = CreateTypedBindingFrom_bindingExtension18(bindingExtension18);
		if (VisualDiagnostics.GetSourceInfo(bindingBase18) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase18, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 141, 25);
		}
		obj9.SetBinding(Switch.IsToggledProperty, bindingBase18);
		grid12.Children.Add(obj9);
		verticalStackLayout.Children.Add(grid12);
		grid13.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label15.SetValue(Label.TextProperty, "Is SMS Check Requested");
		label15.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid13.Children.Add(label15);
		obj10.SetValue(Grid.ColumnProperty, 1);
		obj10.SetValue(Element.AutomationIdProperty, "SmsCheckSwitch");
		bindingExtension19.Path = "IsSmsCheckRequested";
		BindingBase bindingBase19 = CreateTypedBindingFrom_bindingExtension19(bindingExtension19);
		if (VisualDiagnostics.GetSourceInfo(bindingBase19) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase19, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 149, 25);
		}
		obj10.SetBinding(Switch.IsToggledProperty, bindingBase19);
		grid13.Children.Add(obj10);
		verticalStackLayout.Children.Add(grid13);
		grid14.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label16.SetValue(Label.TextProperty, "EHA Enabled");
		label16.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid14.Children.Add(label16);
		obj11.SetValue(Grid.ColumnProperty, 1);
		obj11.SetValue(Element.AutomationIdProperty, "EHASwitch");
		bindingExtension20.Path = "IsEHAEnabled";
		BindingBase bindingBase20 = CreateTypedBindingFrom_bindingExtension20(bindingExtension20);
		if (VisualDiagnostics.GetSourceInfo(bindingBase20) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase20, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 157, 25);
		}
		obj11.SetBinding(Switch.IsToggledProperty, bindingBase20);
		grid14.Children.Add(obj11);
		verticalStackLayout.Children.Add(grid14);
		grid15.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label17.SetValue(Label.TextProperty, "Is Classified Deceased");
		label17.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid15.Children.Add(label17);
		obj12.SetValue(Grid.ColumnProperty, 1);
		obj12.SetValue(Element.AutomationIdProperty, "ClassifiedDeceasedSwitch");
		bindingExtension21.Path = "IsClassifiedDeceased";
		BindingBase bindingBase21 = CreateTypedBindingFrom_bindingExtension21(bindingExtension21);
		if (VisualDiagnostics.GetSourceInfo(bindingBase21) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase21, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 165, 25);
		}
		obj12.SetBinding(Switch.IsToggledProperty, bindingBase21);
		grid15.Children.Add(obj12);
		verticalStackLayout.Children.Add(grid15);
		grid16.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label18.SetValue(Label.TextProperty, "Has Pending Activations");
		label18.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid16.Children.Add(label18);
		obj13.SetValue(Grid.ColumnProperty, 1);
		obj13.SetValue(Element.AutomationIdProperty, "PendingActivationSwitch");
		bindingExtension22.Path = "HasPendingActivation";
		BindingBase bindingBase22 = CreateTypedBindingFrom_bindingExtension22(bindingExtension22);
		if (VisualDiagnostics.GetSourceInfo(bindingBase22) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase22, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 173, 25);
		}
		obj13.SetBinding(Switch.IsToggledProperty, bindingBase22);
		grid16.Children.Add(obj13);
		verticalStackLayout.Children.Add(grid16);
		grid17.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		bindingExtension23.Path = "HasNFCSupport";
		BindingBase bindingBase23 = CreateTypedBindingFrom_bindingExtension23(bindingExtension23);
		if (VisualDiagnostics.GetSourceInfo(bindingBase23) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase23, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 176, 51);
		}
		grid17.SetBinding(VisualElement.IsVisibleProperty, bindingBase23);
		label19.SetValue(Label.TextProperty, "Has NFC");
		label19.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid17.Children.Add(label19);
		obj14.SetValue(Grid.ColumnProperty, 1);
		obj14.SetValue(Element.AutomationIdProperty, "NfcSwitch");
		bindingExtension24.Path = "HasNfc";
		BindingBase bindingBase24 = CreateTypedBindingFrom_bindingExtension24(bindingExtension24);
		if (VisualDiagnostics.GetSourceInfo(bindingBase24) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase24, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 182, 25);
		}
		obj14.SetBinding(Switch.IsToggledProperty, bindingBase24);
		grid17.Children.Add(obj14);
		verticalStackLayout.Children.Add(grid17);
		grid18.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label20.SetValue(Label.TextProperty, "Metering enabled");
		label20.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid18.Children.Add(label20);
		obj15.SetValue(Grid.ColumnProperty, 1);
		obj15.SetValue(Element.AutomationIdProperty, "ToeritdoseringSwitch");
		bindingExtension25.Path = "IsTrafficMeteringEnabled";
		BindingBase bindingBase25 = CreateTypedBindingFrom_bindingExtension25(bindingExtension25);
		if (VisualDiagnostics.GetSourceInfo(bindingBase25) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase25, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 190, 25);
		}
		obj15.SetBinding(Switch.IsToggledProperty, bindingBase25);
		grid18.Children.Add(obj15);
		verticalStackLayout.Children.Add(grid18);
		grid19.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label21.SetValue(Label.TextProperty, "Has too many active devices");
		label21.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid19.Children.Add(label21);
		obj16.SetValue(Grid.ColumnProperty, 1);
		obj16.SetValue(Element.AutomationIdProperty, "HasTooManyActiveDevicesSwitch");
		bindingExtension26.Path = "HasTooManyActiveDevices";
		BindingBase bindingBase26 = CreateTypedBindingFrom_bindingExtension26(bindingExtension26);
		if (VisualDiagnostics.GetSourceInfo(bindingBase26) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase26, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 198, 25);
		}
		obj16.SetBinding(Switch.IsToggledProperty, bindingBase26);
		grid19.Children.Add(obj16);
		verticalStackLayout.Children.Add(grid19);
		grid20.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label22.SetValue(Label.TextProperty, "Maintenance Mode");
		label22.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid20.Children.Add(label22);
		obj17.SetValue(Grid.ColumnProperty, 1);
		obj17.SetValue(Element.AutomationIdProperty, "MaintenanceModeSwitch");
		bindingExtension27.Path = "IsMaintenanceModeEnabled";
		BindingBase bindingBase27 = CreateTypedBindingFrom_bindingExtension27(bindingExtension27);
		if (VisualDiagnostics.GetSourceInfo(bindingBase27) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase27, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 206, 25);
		}
		obj17.SetBinding(Switch.IsToggledProperty, bindingBase27);
		grid20.Children.Add(obj17);
		verticalStackLayout.Children.Add(grid20);
		grid21.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label23.SetValue(Label.TextProperty, "NFC Location");
		label23.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid21.Children.Add(label23);
		label24.SetValue(Grid.ColumnProperty, 1);
		label24.SetValue(Element.AutomationIdProperty, "ChangeNfcLocationCommandCommand");
		bindingExtension28.Path = "NfcPosition";
		BindingBase bindingBase28 = CreateTypedBindingFrom_bindingExtension28(bindingExtension28);
		if (VisualDiagnostics.GetSourceInfo(bindingBase28) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase28, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 214, 25);
		}
		label24.SetBinding(Label.TextProperty, bindingBase28);
		bindingExtension29.Path = "ChangeNfcLocationCommand";
		BindingBase bindingBase29 = CreateTypedBindingFrom_bindingExtension29(bindingExtension29);
		if (VisualDiagnostics.GetSourceInfo(bindingBase29) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase29, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 216, 51);
		}
		tapGestureRecognizer3.SetBinding(TapGestureRecognizer.CommandProperty, bindingBase29);
		label24.GestureRecognizers.Add(tapGestureRecognizer3);
		grid21.Children.Add(label24);
		verticalStackLayout.Children.Add(grid21);
		grid22.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label25.SetValue(Label.TextProperty, "KA Successful");
		label25.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid22.Children.Add(label25);
		obj18.SetValue(Grid.ColumnProperty, 1);
		obj18.SetValue(Element.AutomationIdProperty, "KASuccessfulSwitch");
		bindingExtension30.Path = "IsKeyAttestationSuccess";
		BindingBase bindingBase30 = CreateTypedBindingFrom_bindingExtension30(bindingExtension30);
		if (VisualDiagnostics.GetSourceInfo(bindingBase30) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase30, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 226, 25);
		}
		obj18.SetBinding(Switch.IsToggledProperty, bindingBase30);
		grid22.Children.Add(obj18);
		verticalStackLayout.Children.Add(grid22);
		grid23.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label26.SetValue(Label.TextProperty, "Webservice will require sub in future");
		label26.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid23.Children.Add(label26);
		obj19.SetValue(Grid.ColumnProperty, 1);
		obj19.SetValue(Element.AutomationIdProperty, "NeedSubInFutureSwitch");
		bindingExtension31.Path = "NeedSubInFuture";
		BindingBase bindingBase31 = CreateTypedBindingFrom_bindingExtension31(bindingExtension31);
		if (VisualDiagnostics.GetSourceInfo(bindingBase31) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase31, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 234, 25);
		}
		obj19.SetBinding(Switch.IsToggledProperty, bindingBase31);
		grid23.Children.Add(obj19);
		verticalStackLayout.Children.Add(grid23);
		grid24.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		label27.SetValue(Label.TextProperty, "EasterEgg Enabled");
		label27.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid24.Children.Add(label27);
		obj20.SetValue(Grid.ColumnProperty, 1);
		obj20.SetValue(Element.AutomationIdProperty, "EasterEggSwitch");
		bindingExtension32.Path = "IsEasterEggEnabled";
		BindingBase bindingBase32 = CreateTypedBindingFrom_bindingExtension32(bindingExtension32);
		if (VisualDiagnostics.GetSourceInfo(bindingBase32) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase32, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 243, 21);
		}
		obj20.SetBinding(Switch.IsToggledProperty, bindingBase32);
		grid24.Children.Add(obj20);
		verticalStackLayout.Children.Add(grid24);
		grid25.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star)));
		label28.SetValue(Label.TextProperty, "ID-Check expiry date");
		label28.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid25.Children.Add(label28);
		linkLabel.SetValue(Grid.ColumnProperty, 1);
		bindingExtension33.Path = "ClearSubExpiryDateCommand";
		BindingBase bindingBase33 = CreateTypedBindingFrom_bindingExtension33(bindingExtension33);
		if (VisualDiagnostics.GetSourceInfo(bindingBase33) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase33, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 250, 25);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase33);
		linkLabel.SetValue(LinkLabel.TextProperty, "Clear");
		linkLabel.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		grid25.Children.Add(linkLabel);
		label29.SetValue(Grid.ColumnProperty, 2);
		label29.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		staticResourceExtension2.Key = "IsNullConverter";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[7] { bindingExtension34, label29, grid25, verticalStackLayout, grid27, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(257, 25)));
		object obj26 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj26) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj26, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 257, 25);
		}
		bindingExtension34.Converter = (IValueConverter)obj26;
		bindingExtension34.Path = "SubExpiryDate";
		BindingBase bindingBase34 = CreateTypedBindingFrom_bindingExtension34(bindingExtension34);
		if (VisualDiagnostics.GetSourceInfo(bindingBase34) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase34, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 257, 25);
		}
		label29.SetBinding(VisualElement.IsVisibleProperty, bindingBase34);
		label29.SetValue(Label.TextProperty, "Select Date");
		label29.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		bindingExtension35.Path = "OpenDateSelectorCommand";
		BindingBase bindingBase35 = CreateTypedBindingFrom_bindingExtension35(bindingExtension35);
		if (VisualDiagnostics.GetSourceInfo(bindingBase35) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase35, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 261, 51);
		}
		tapGestureRecognizer4.SetBinding(TapGestureRecognizer.CommandProperty, bindingBase35);
		label29.GestureRecognizers.Add(tapGestureRecognizer4);
		grid25.Children.Add(label29);
		datePicker.SetValue(Grid.ColumnProperty, 2);
		datePicker.SetValue(Element.AutomationIdProperty, "SubExpiryDatePicker");
		bindingExtension36.Path = "SubExpiryDate";
		BindingBase bindingBase36 = CreateTypedBindingFrom_bindingExtension36(bindingExtension36);
		if (VisualDiagnostics.GetSourceInfo(bindingBase36) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase36, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 268, 25);
		}
		datePicker.SetBinding(DatePicker.DateProperty, bindingBase36);
		datePicker.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension37.Path = "IsDateSelectorOpen";
		BindingBase bindingBase37 = CreateTypedBindingFrom_bindingExtension37(bindingExtension37);
		if (VisualDiagnostics.GetSourceInfo(bindingBase37) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase37, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 270, 25);
		}
		datePicker.SetBinding(DatePicker.IsOpenProperty, bindingBase37);
		staticResourceExtension3.Key = "IsNotNullConverter";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[7] { bindingExtension38, datePicker, grid25, verticalStackLayout, grid27, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(271, 25)));
		object obj27 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj27) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj27, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 271, 25);
		}
		bindingExtension38.Converter = (IValueConverter)obj27;
		bindingExtension38.Path = "SubExpiryDate";
		BindingBase bindingBase38 = CreateTypedBindingFrom_bindingExtension38(bindingExtension38);
		if (VisualDiagnostics.GetSourceInfo(bindingBase38) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase38, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 271, 25);
		}
		datePicker.SetBinding(VisualElement.IsVisibleProperty, bindingBase38);
		grid25.Children.Add(datePicker);
		verticalStackLayout.Children.Add(grid25);
		grid27.Children.Add(verticalStackLayout);
		grid26.SetValue(Grid.RowProperty, 1);
		grid26.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid26.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star)));
		bindingExtension39.Path = "TabCardSelected";
		BindingBase bindingBase39 = CreateTypedBindingFrom_bindingExtension39(bindingExtension39);
		if (VisualDiagnostics.GetSourceInfo(bindingBase39) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase39, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 279, 17);
		}
		grid26.SetBinding(VisualElement.IsVisibleProperty, bindingBase39);
		grid26.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(new GridLength(20.0, GridUnitType.Absolute)), new RowDefinition(new GridLength(20.0, GridUnitType.Absolute)), new RowDefinition(new GridLength(20.0, GridUnitType.Absolute)), new RowDefinition(new GridLength(20.0, GridUnitType.Absolute)), new RowDefinition(GridLength.Star)));
		grid26.SetValue(Grid.RowSpacingProperty, 20.0);
		staticResourceExtension4.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[5] { label30, grid26, grid27, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(282, 24)));
		object obj28 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj28) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj28, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 282, 24);
		}
		label30.SetValue(VisualElement.StyleProperty, obj28);
		label30.SetValue(Label.TextProperty, "Voorkeuren");
		grid26.Children.Add(label30);
		label31.SetValue(Grid.RowProperty, 1);
		label31.SetValue(Grid.ColumnProperty, 0);
		label31.SetValue(Label.TextProperty, "Current PIN");
		label31.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid26.Children.Add(label31);
		label32.SetValue(Grid.RowProperty, 1);
		label32.SetValue(Grid.ColumnProperty, 2);
		label32.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension40.Path = "Pin";
		BindingBase bindingBase40 = CreateTypedBindingFrom_bindingExtension40(bindingExtension40);
		if (VisualDiagnostics.GetSourceInfo(bindingBase40) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase40, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 293, 21);
		}
		label32.SetBinding(Label.TextProperty, bindingBase40);
		label32.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid26.Children.Add(label32);
		label33.SetValue(Grid.RowProperty, 2);
		label33.SetValue(Grid.ColumnProperty, 0);
		label33.SetValue(Label.TextProperty, "Tries");
		label33.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid26.Children.Add(label33);
		label34.SetValue(Grid.RowProperty, 2);
		label34.SetValue(Grid.ColumnProperty, 1);
		label34.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension41.Path = "Tries";
		BindingBase bindingBase41 = CreateTypedBindingFrom_bindingExtension41(bindingExtension41);
		if (VisualDiagnostics.GetSourceInfo(bindingBase41) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase41, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 305, 21);
		}
		label34.SetBinding(Label.TextProperty, bindingBase41);
		label34.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid26.Children.Add(label34);
		label35.SetValue(Grid.RowProperty, 3);
		label35.SetValue(Grid.ColumnProperty, 0);
		label35.SetValue(Label.TextProperty, "Transportmode");
		label35.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid26.Children.Add(label35);
		obj21.SetValue(Grid.RowProperty, 3);
		obj21.SetValue(Grid.ColumnProperty, 1);
		obj21.SetValue(Element.AutomationIdProperty, "CardTransportSwitch");
		obj21.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension42.Path = "ChangePinRequired";
		BindingBase bindingBase42 = CreateTypedBindingFrom_bindingExtension42(bindingExtension42);
		if (VisualDiagnostics.GetSourceInfo(bindingBase42) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase42, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 318, 21);
		}
		obj21.SetBinding(Switch.IsToggledProperty, bindingBase42);
		grid26.Children.Add(obj21);
		label36.SetValue(Grid.RowProperty, 4);
		label36.SetValue(Grid.ColumnProperty, 0);
		label36.SetValue(Label.TextProperty, "Is blocked");
		label36.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid26.Children.Add(label36);
		obj22.SetValue(Grid.RowProperty, 4);
		obj22.SetValue(Grid.ColumnProperty, 1);
		obj22.SetValue(Element.AutomationIdProperty, "CardBlockedSwitch");
		obj22.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension43.Path = "IsBlocked";
		BindingBase bindingBase43 = CreateTypedBindingFrom_bindingExtension43(bindingExtension43);
		if (VisualDiagnostics.GetSourceInfo(bindingBase43) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase43, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 331, 21);
		}
		obj22.SetBinding(Switch.IsToggledProperty, bindingBase43);
		grid26.Children.Add(obj22);
		label37.SetValue(Grid.RowProperty, 5);
		label37.SetValue(Grid.ColumnProperty, 0);
		label37.SetValue(Label.TextProperty, "Is suspended");
		label37.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid26.Children.Add(label37);
		obj23.SetValue(Grid.RowProperty, 5);
		obj23.SetValue(Grid.ColumnProperty, 1);
		obj23.SetValue(Element.AutomationIdProperty, "CardSuspendedSwitch");
		obj23.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension44.Path = "IsSuspended";
		BindingBase bindingBase44 = CreateTypedBindingFrom_bindingExtension44(bindingExtension44);
		if (VisualDiagnostics.GetSourceInfo(bindingBase44) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase44, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 344, 21);
		}
		obj23.SetBinding(Switch.IsToggledProperty, bindingBase44);
		grid26.Children.Add(obj23);
		label38.SetValue(Grid.RowProperty, 6);
		label38.SetValue(Grid.ColumnProperty, 0);
		label38.SetValue(Label.TextProperty, "EasterEgg Enabled");
		label38.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid26.Children.Add(label38);
		obj24.SetValue(Grid.RowProperty, 6);
		obj24.SetValue(Grid.ColumnProperty, 1);
		obj24.SetValue(Element.AutomationIdProperty, "EasterEggSwitch");
		obj24.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		bindingExtension45.Path = "IsEasterEggEnabled";
		BindingBase bindingBase45 = CreateTypedBindingFrom_bindingExtension45(bindingExtension45);
		if (VisualDiagnostics.GetSourceInfo(bindingBase45) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase45, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 357, 21);
		}
		obj24.SetBinding(Switch.IsToggledProperty, bindingBase45);
		grid26.Children.Add(obj24);
		borderedButton.SetValue(Grid.RowProperty, 7);
		borderedButton.SetValue(Grid.ColumnProperty, 0);
		borderedButton.SetValue(Grid.ColumnSpanProperty, 2);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "ResetButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension46.Path = "ResetCommand";
		BindingBase bindingBase46 = CreateTypedBindingFrom_bindingExtension46(bindingExtension46);
		if (VisualDiagnostics.GetSourceInfo(bindingBase46) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase46, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 366, 21);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase46);
		borderedButton.SetValue(Button.TextProperty, demo_ResetCard);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid26.Children.Add(borderedButton);
		grid27.Children.Add(grid26);
		borderedButton2.SetValue(Grid.RowProperty, 2);
		borderedButton2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		borderedButton2.SetValue(Element.AutomationIdProperty, "CloseButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension47.Path = "CloseCommand";
		BindingBase bindingBase47 = CreateTypedBindingFrom_bindingExtension47(bindingExtension47);
		if (VisualDiagnostics.GetSourceInfo(bindingBase47) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase47, new Uri("Pages\\DM002.xaml;assembly=DigiD.Mobile", UriKind.Relative), 376, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase47);
		borderedButton2.SetValue(Button.TextProperty, demo_Close);
		borderedButton2.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid27.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid27);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DM002ViewModel, ButtonType> setter = delegate(DM002ViewModel source, ButtonType value)
			{
				source.TabAccountButtonType = value;
			};
			return new TypedBinding<DM002ViewModel, ButtonType>((DM002ViewModel source) => (value: source.TabAccountButtonType, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "TabAccountButtonType")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.HasMessages = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.HasMessages, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "HasMessages")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension11(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.TwoFactorEnabled = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.TwoFactorEnabled, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "TwoFactorEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension12(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.HasEmailAddress = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.HasEmailAddress, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "HasEmailAddress")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension13(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsEmailAddressVerified = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsEmailAddressVerified, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsEmailAddressVerified")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension14(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.UserActionNeeded = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.UserActionNeeded, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "UserActionNeeded")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension15(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.EIDASUser = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.EIDASUser, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "EIDASUser")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension16(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.EIDASSuccess = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.EIDASSuccess, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "EIDASSuccess")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension17(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.RdaFailed = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.RdaFailed, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "RdaFailed")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension18(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.HasNoDocuments = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.HasNoDocuments, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "HasNoDocuments")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension19(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsSmsCheckRequested = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsSmsCheckRequested, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsSmsCheckRequested")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.TabSelectedCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "TabSelectedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension20(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsEHAEnabled = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsEHAEnabled, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsEHAEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension21(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsClassifiedDeceased = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsClassifiedDeceased, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsClassifiedDeceased")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension22(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.HasPendingActivation = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.HasPendingActivation, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "HasPendingActivation")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension23(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.HasNFCSupport = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.HasNFCSupport, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "HasNFCSupport")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension24(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.HasNfc = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.HasNfc, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "HasNfc")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension25(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsTrafficMeteringEnabled = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsTrafficMeteringEnabled, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsTrafficMeteringEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension26(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.HasTooManyActiveDevices = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.HasTooManyActiveDevices, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "HasTooManyActiveDevices")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension27(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsMaintenanceModeEnabled = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsMaintenanceModeEnabled, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsMaintenanceModeEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension28(BindingExtension extension)
		{
			Action<DM002ViewModel, NfcPosition> setter = delegate(DM002ViewModel source, NfcPosition value)
			{
				source.NfcPosition = value;
			};
			return new TypedBinding<DM002ViewModel, NfcPosition>((DM002ViewModel source) => (value: source.NfcPosition, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "NfcPosition")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension29(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.ChangeNfcLocationCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "ChangeNfcLocationCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DM002ViewModel, ButtonType> setter = delegate(DM002ViewModel source, ButtonType value)
			{
				source.TabCardButtonType = value;
			};
			return new TypedBinding<DM002ViewModel, ButtonType>((DM002ViewModel source) => (value: source.TabCardButtonType, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "TabCardButtonType")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension30(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsKeyAttestationSuccess = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsKeyAttestationSuccess, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsKeyAttestationSuccess")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension31(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.NeedSubInFuture = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.NeedSubInFuture, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "NeedSubInFuture")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension32(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsEasterEggEnabled = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsEasterEggEnabled, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsEasterEggEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension33(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.ClearSubExpiryDateCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "ClearSubExpiryDateCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension34(BindingExtension extension)
		{
			Action<DM002ViewModel, DateTime?> setter = delegate(DM002ViewModel source, DateTime? value)
			{
				source.SubExpiryDate = value;
			};
			return new TypedBinding<DM002ViewModel, DateTime?>((DM002ViewModel source) => (value: source.SubExpiryDate, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "SubExpiryDate")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension35(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.OpenDateSelectorCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "OpenDateSelectorCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension36(BindingExtension extension)
		{
			Action<DM002ViewModel, DateTime?> setter = delegate(DM002ViewModel source, DateTime? value)
			{
				source.SubExpiryDate = value;
			};
			return new TypedBinding<DM002ViewModel, DateTime?>((DM002ViewModel source) => (value: source.SubExpiryDate, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "SubExpiryDate")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension37(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsDateSelectorOpen = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsDateSelectorOpen, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsDateSelectorOpen")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension38(BindingExtension extension)
		{
			Action<DM002ViewModel, DateTime?> setter = delegate(DM002ViewModel source, DateTime? value)
			{
				source.SubExpiryDate = value;
			};
			return new TypedBinding<DM002ViewModel, DateTime?>((DM002ViewModel source) => (value: source.SubExpiryDate, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "SubExpiryDate")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension39(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.TabCardSelected = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.TabCardSelected, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "TabCardSelected")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.TabSelectedCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "TabSelectedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension40(BindingExtension extension)
		{
			Action<DM002ViewModel, string> setter = delegate(DM002ViewModel source, string? value)
			{
				source.Pin = value;
			};
			return new TypedBinding<DM002ViewModel, string>((DM002ViewModel source) => (value: source.Pin, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "Pin")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension41(BindingExtension extension)
		{
			Action<DM002ViewModel, int> setter = delegate(DM002ViewModel source, int value)
			{
				source.Tries = value;
			};
			return new TypedBinding<DM002ViewModel, int>((DM002ViewModel source) => (value: source.Tries, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "Tries")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension42(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.ChangePinRequired = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.ChangePinRequired, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "ChangePinRequired")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension43(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsBlocked = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsBlocked, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsBlocked")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension44(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsSuspended = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsSuspended, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsSuspended")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension45(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.IsEasterEggEnabled = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.IsEasterEggEnabled, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "IsEasterEggEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension46(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.ResetCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "ResetCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension47(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.CloseCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "CloseCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DM002ViewModel, bool> setter = delegate(DM002ViewModel source, bool value)
			{
				source.TabAccountSelected = value;
			};
			return new TypedBinding<DM002ViewModel, bool>((DM002ViewModel source) => (value: source.TabAccountSelected, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "TabAccountSelected")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DM002ViewModel, string> setter = delegate(DM002ViewModel source, string? value)
			{
				source.ActivationMethod = value;
			};
			return new TypedBinding<DM002ViewModel, string>((DM002ViewModel source) => (value: source.ActivationMethod, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "ActivationMethod")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.ChangeActivationMethodCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "ChangeActivationMethodCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DM002ViewModel, VersionState> setter = delegate(DM002ViewModel source, VersionState value)
			{
				source.VersionState = value;
			};
			return new TypedBinding<DM002ViewModel, VersionState>((DM002ViewModel source) => (value: source.VersionState, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "VersionState")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<DM002ViewModel, ICommand> setter = null;
			return new TypedBinding<DM002ViewModel, ICommand>((DM002ViewModel source) => ((ICommand value, bool success))(value: source.ChangeVersionCheckResponseCommand, success: true), setter, new Tuple<Func<DM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<DM002ViewModel, object>, string>((DM002ViewModel source) => source, "ChangeVersionCheckResponseCommand")
			});
		}
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
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DM002));
	}
}
