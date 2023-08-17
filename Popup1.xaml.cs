using CommunityToolkit.Maui.Views;

namespace MauiComm_VerifyPopupStyle;

public partial class Popup1 : Popup
{
	public Popup1()
	{
		InitializeComponent();
	}

	void gd_Tapped(object sender, TappedEventArgs e)
	{
		this.Close();
	}
}