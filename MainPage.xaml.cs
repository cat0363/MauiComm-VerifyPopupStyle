using CommunityToolkit.Maui.Views;

namespace MauiComm_VerifyPopupStyle;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	void btnPopup1_Clicked(object sender, EventArgs e)
	{
		var popup1 = new Popup1();
		Shell.Current.ShowPopup(popup1);
	}

	void btnPopup2_Clicked(object sender, EventArgs e)
	{
		var popup2 = new Popup2();
		Shell.Current.ShowPopup(popup2);
	}

	void btnPopup3_Clicked(object sender, EventArgs e)
	{
		var popup3 = new Popup3();
		Shell.Current.ShowPopup(popup3);
	}

	void btnPopup4_Clicked(object sender, EventArgs e)
	{
		var popup4 = new Popup4();
		Shell.Current.ShowPopup(popup4);
	}

	void btnPopup5_Clicked(object sender, EventArgs e)
	{
		var popup5 = new Popup5();
		Shell.Current.ShowPopup(popup5);
	}
}

