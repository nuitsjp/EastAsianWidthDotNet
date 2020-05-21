# EastAsianWidth

[Japanese](README-ja.md)

A library to determine the width of a Unicode character by determining its full-width or half-width and other.

```cs
using  EastAsianWidthDotNet;

...
var width = "全角.".GetWidth();
Console.WriteLine($"Width is {width}.");
```

![](images/sample.png)

EastAsianWidthDotNet conforms to Unicode's [EAST ASIAN WIDTH](http://www.unicode.org/reports/tr11/).

In EAST ASIAN WIDTH, there is a kind called "Ambiguous", whose width varies depending on the context.

Ambiguous should be a full-width character in East Asia. But outside of East Asia, it is a narrow.

EastAsianWidthDotNet uses CultureInfo to determine this. [This local](https://github.com/nuitsjp/EastAsianWidthDotNet/blob/master/src/EastAsianWidthDotNet/EastAsia.cs#L20) is a East Asian.

You can specify whether it is explicitly East Asian or not, or you can specify CultureInfo. If not specified, CultureInfo.CurrentUICulture will be applied.

## API Reference

See below.

- [https://nuitsjp.github.io/EastAsianWidthDotNet/](https://nuitsjp.github.io/EastAsianWidthDotNet/)
  - [StringExtensions](https://nuitsjp.github.io/EastAsianWidthDotNet/class_east_asian_width_dot_net_1_1_string_extensions.html)

In many cases, this can be solved by using StringExtensions.

## About Emojis

The width is not correct for some emojis.

For example, in many fonts, "⏳" is displayed as a width between full and half-widths. The width of the emoji often depends on the font, and it is not practical to encompass them by font.

EastAsianWidthDotNet does not provide individual support for Emoji. Emojis are deprecated in areas where character width is a concern.

However, for example, "☀" is full-width in many fonts, but "Neutral" in EAST ASIAN WIDTH.There are several similar Emoji's. If there are many requests, we will consider addressing them.

In this case, please contact [Issue](https://github.com/nuitsjp/EastAsianWidthDotNet/issues).
