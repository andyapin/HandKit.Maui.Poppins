
# HandKit.Maui.Poppins

![icon](https://handityo.my.id/icon_nuget.png)

[![NuGet](https://img.shields.io/nuget/v/HandKit.Maui.Poppins)](https://www.nuget.org/packages/HandKit.Maui.Poppins)
[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-512BD4?style=flat&logo=dotnet&label=.NET%20MAUI)](https://dotnet.microsoft.com/en-us/apps/maui)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Platform](https://img.shields.io/badge/Platform-Android-green)](https://www.android.com/)
[![Platform](https://img.shields.io/badge/Platform-iOS-blue)](https://www.apple.com/ios/ios-16/)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D7)](https://www.microsoft.com/en-us/windows)
[![Platform](https://img.shields.io/badge/Platform-macOS-00203a)](https://www.apple.com/macos/)

**Effortlessly integrate the Poppins font family into your .NET MAUI applications.** 

Poppins, a popular geometric sans-serif typeface, offers a clean and modern aesthetic, supporting a wide range of languages.

This plugin simplifies the process of including the Poppins font family in your .NET MAUI apps, eliminating the need for manual font embedding and registration. It provides pre-configured font resources that can be easily accessed and applied to your UI elements.

## Key Features

*   **Easy Integration**: Simple setup with a single line of code in `MauiProgram.cs`.
*   **Comprehensive Collection**: Includes 8 weights and styles of the Poppins font.
*   **Optimized**: Designed for performance in mobile and desktop environments.
*   **Cross-Platform**: Fully compatible with Android, iOS, Windows, and macOS.

## Included Fonts

The following font styles are included and registered by default:

*   `Regular` (PoppinsRegular.ttf)
*   `Italic` (PoppinsItalic.ttf)
*   `Medium` (PoppinsMedium.ttf)
*   `MediumItalic` (PoppinsMediumItalic.ttf)
*   `SemiBold` (PoppinsSemiBold.ttf)
*   `SemiBoldItalic` (PoppinsSemiBoldItalic.ttf)
*   `Bold` (PoppinsBold.ttf)
*   `BoldItalic` (PoppinsBoldItalic.ttf)

## Installation

You can install the plugin via NuGet Package Manager or the .NET CLI:

```bash
Install-Package HandKit.Maui.Poppins
```

## Setup

1.  Open your `MauiProgram.cs` file.
2.  Add the `using HandKit.Maui.Poppins;` namespace.
3.  Call `.UsePoppinsFonts()` on the `MauiAppBuilder`.

```csharp
using HandKit.Maui.Poppins;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UsePoppinsFonts() // <-- Registers the fonts
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        return builder.Build();
    }
}
```

## Usage

### Basic Usage

By default, the fonts are registered with their style names as aliases (e.g., `Regular`, `Bold`). You can use them directly in XAML or C#.

**XAML:**

```xml
<Label Text="This is Poppins Regular" FontFamily="Regular" />
<Label Text="This is Poppins Bold" FontFamily="Bold" FontAttributes="Bold" />
<Label Text="This is Poppins Italic" FontFamily="Italic" FontAttributes="Italic" />
```

**C#:**

```csharp
label.FontFamily = "SemiBold";
```

### Advanced Usage (Custom Alias / Conflict Resolution)

If you have other fonts that might conflict with names like "Regular" or "Bold", you can provide a custom prefix when registering the fonts.

**MauiProgram.cs:**

```csharp
// Registers fonts as "PoppinsRegular", "PoppinsBold", etc.
builder.UsePoppinsFonts("Poppins"); 
```

**XAML:**

```xml
<Label Text="Using Custom Alias" FontFamily="PoppinsRegular" />
<Label Text="Using Custom Alias (Bold)" FontFamily="PoppinsBold" />
```

## Example Project
The repository includes a sample MAUI project demonstrating the usage of the plugin. You can find it in the `samples` directory.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request.

## Contact
If you have any questions or suggestions, please feel free to contact me at andyapin@gmail.com
