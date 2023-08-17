using CommunityToolkit.Maui.Views;

namespace MauiComm_VerifyPopupStyle;

public partial class Popup3 : Popup
{
	public Popup3()
	{
		InitializeComponent();
	}

	void gd_Tapped(object sender, TappedEventArgs e)
	{
		this.Close();
	}
}