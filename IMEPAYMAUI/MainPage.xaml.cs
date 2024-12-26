
using IMEPayMAUILib;
namespace IMEPAYMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void CounterBtn_Clicked(object sender, EventArgs e)
    {

        var result = await IMEPayService.StartPaymentAsync(
            userName: "TEST",
            password: "TEST",
            merchantCode: "TEST",
            merchantName: "TEST",
            merchantUrl: "https://merchanturl.com",
            amount: "1000",
            referenceId: "order12345",
            module: "paymentModule",
            environment: APIEnvironment.Test);

        if (result.IsSuccess)
        {
            await DisplayAlert("Success", "Payment Successful!", "OK");
        }
        else
        {
            await DisplayAlert("Error", result.Message, "OK");
        }

    }
}
