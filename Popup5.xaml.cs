using CommunityToolkit.Maui.Views;

namespace MauiComm_VerifyPopupStyle;

public partial class Popup5 : Popup
{
	public Popup5()
	{
		InitializeComponent();
	}

	void gd_Tapped(object sender, TappedEventArgs e)
	{
		this.Close();
	}
}