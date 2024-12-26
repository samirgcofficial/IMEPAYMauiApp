
# IMEPay Native Plugin for .NET MAUI

![IMEPay](https://raw.githubusercontent.com/samirgcofficial/IMEPAYMauiApp/main/Images/ImePay.png)

Welcome to the **IMEPay** Plugin for .NET MAUI repository! Our Plugin provides seamless integration with **IMEPay's** payment gateway, enabling developers to quickly and securely accept payments in their .NET MAUI applications.

## Features

- **Easy Integration**: Integrate IMEPay's payment gateway into your .NET MAUI apps with just a few lines of code.
- **Secure Transactions**: Ensure secure and encrypted payment transactions for your users.

## Getting Started

To start using the IMEPay Plugin in your .NET MAUI project, follow these simple steps:

**Installation**: Install the IMEPay Plugin NuGet package in your .NET MAUI project. 

   ```sh
   dotnet add package Plugin.Maui.IMEPay --version 0.0.1
   ```

## .NET MAUI Android Implementation (MainActivity.cs)



## .NET MAUI Implementation (MainPage.xaml.cs)

```csharp
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnPayButtonClicked(object sender, EventArgs e)
    {
        var result = await IMEPayService.StartPaymentAsync(
            userName: "your_username", 
            password: "your_password",
            merchantCode: "merchant_code",
            merchantName: "Merchant Name",
            merchantUrl: "https://merchanturl.com",
            amount: "1000",
            referenceId: "order12345",
            module: "paymentModule",
            environment: APIEnvironment.Production);

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
```

## .csproj Implementation for iOS Platform (IMEPayMauiApp.csproj)

```xml
<PropertyGroup Condition="$(TargetFramework.Contains('-ios')) and '$(Configuration)' == 'Debug'">
    <ForceSimulatorX64ArchitectureInIDE>true</ForceSimulatorX64ArchitectureInIDE>
</PropertyGroup>
<PropertyGroup Condition="$(TargetFramework.Contains('-ios'))">
	<BaseOutputPath>..\..\..\..\..\temp\</BaseOutputPath>
</PropertyGroup>
```

# Unlock the Full Version
Gain access to the entire plugin, free from the evaluation popup limit, by supporting our project with a small contribution. Your support acknowledges our hard work and dedication 🥰. We suggest trying the evaluation copy before making a purchase. Plus, we've made it affordable for all customers.

Upon completing your payment of RS 2,500 NRS for our IME Payment Gateway Plugin, please provide your GitHub email address and bank receipt at 8ringsoft@gmail.com. Thank you.

