namespace HandKit.Maui.Poppins
{
    /// <summary>
    /// Provides extension methods to easily integrate Poppins fonts into .NET MAUI applications.
    /// </summary>
    public static class FontExtensions
    {
        /// <summary>
        /// Registers the Poppins fonts in the MAUI application.
        /// <code>
        /// Font Family: Regular, Italic, Medium, SemiBold, Bold, MediumItalic, SemiBoldItalic, BoldItalic
        /// </code>
        /// </summary>
        /// <param name="builder">The <see cref="MauiAppBuilder"/> to configure.</param>
        /// <param name="name">Optional alias prefix. If provided (e.g., "Poppins"), use FontFamily="PoppinsRegular". If empty, use FontFamily="Regular".</param>
        /// <returns><see cref="MauiAppBuilder"/></returns>
        public static MauiAppBuilder UsePoppinsFonts(this MauiAppBuilder builder, string name = "")
        {
            builder.ConfigureFonts(fonts =>
            {
                fonts.AddFont("PoppinsRegular.ttf", $"{name}Regular");
                fonts.AddFont("PoppinsItalic.ttf", $"{name}Italic");
                fonts.AddFont("PoppinsMedium.ttf", $"{name}Medium");
                fonts.AddFont("PoppinsMediumItalic.ttf", $"{name}MediumItalic");
                fonts.AddFont("PoppinsSemiBold.ttf", $"{name}SemiBold");
                fonts.AddFont("PoppinsSemiBoldItalic.ttf", $"{name}SemiBoldItalic");
                fonts.AddFont("PoppinsBold.ttf", $"{name}Bold");
                fonts.AddFont("PoppinsBoldItalic.ttf", $"{name}BoldItalic");
            });
            return builder;
        }
    }
}
