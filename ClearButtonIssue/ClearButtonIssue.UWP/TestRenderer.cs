using ClearButtonIssue.UWP;
using Syncfusion.SfNumericTextBox.XForms;
using Syncfusion.SfNumericTextBox.XForms.UWP;
using Syncfusion.XForms.Editors;
using System;
using Windows.UI;
using Windows.UI.Xaml.Media;
using ClearButtonIssue;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(SfNumericTextBox), typeof(ActualClassRenderer))]
[assembly: ExportRenderer(typeof(SfNumericTextBoxSubClass), typeof(SubClassRenderer))]
[assembly: ExportRenderer(typeof(Entry), typeof(EntryTestRenderer))]
namespace ClearButtonIssue.UWP
{
	public class EntryTestRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			Control.Text = "I was set in a custom renderer";
		}
		//protected override void UpdateBackground()
		//{
		//	base.UpdateBackground();
		//	Control.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
		//}

		//protected override void UpdateBackgroundColor()
		//{
		//	base.UpdateBackgroundColor();
		//	Control.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Colors.Red);
		//}
	}

	public class ActualClassRenderer : SfNumericTextBoxRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<SfNumericTextBox> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				switch (Element.ClearButtonVisibility)
				{
					case ClearButtonVisibilityMode.Never:
						Control.ShowClearButton = false;
						break;
					case ClearButtonVisibilityMode.WhileEditing:
						Control.ShowClearButton = true;
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}

	public class SubClassRenderer : SfNumericTextBoxRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<SfNumericTextBox> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				switch (Element.ClearButtonVisibility)
				{
					case ClearButtonVisibilityMode.Never:
						Control.ShowClearButton = false;
						break;
					case ClearButtonVisibilityMode.WhileEditing:
						Control.ShowClearButton = true;
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
