using CommunityToolkit.Maui.Views;

namespace MauiComm_VerifyPopupStyle;

public partial class Popup2 : Popup
{
	public Popup2()
	{
		InitializeComponent();
	}

	void gd_Tapped(object sender, TappedEventArgs e)
	{
		this.Close();
	}
}