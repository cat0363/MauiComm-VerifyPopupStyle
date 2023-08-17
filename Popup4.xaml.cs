using CommunityToolkit.Maui.Views;

namespace MauiComm_VerifyPopupStyle;

public partial class Popup4 : Popup
{
	public Popup4()
	{
		InitializeComponent();
	}

	void gd_Tapped(object sender, TappedEventArgs e)
	{
		this.Close();
	}
}