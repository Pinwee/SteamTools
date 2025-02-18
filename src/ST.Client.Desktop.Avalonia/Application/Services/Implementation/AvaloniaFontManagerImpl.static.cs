using Avalonia.Media;
using System.Application.UI.Resx;

namespace System.Application.Services.Implementation
{
    partial class AvaloniaFontManagerImpl
    {
        static readonly Lazy<FontFamily> mDefault = new(() =>
        {
            var @this = DI.Get<AvaloniaFontManagerImpl>();
            var name = @this.platformService.GetDefaultFontFamily();
            if (string.IsNullOrEmpty(name)) return @this._defaultTypeface.FontFamily;
            return new FontFamily(name);
        });

        public static FontFamily Default => mDefault.Value;

        //static readonly Lazy<FontFamily> mDefaultConsole = new(() =>
        //{
        //    var fontName = R.DefaultConsoleFont;
        //    if (fontName == IFontManager.KEY_Default) return mDefault.Value;
        //    return new(fontName);
        //});
        //public static FontFamily DefaultConsole => mDefaultConsole.Value;
    }
}
