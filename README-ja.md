# EastAsianWidth

Unicodeの文字の全角・半角を判定して、幅を取得するためのライブラリです。

```cs
using  EastAsianWidthDotNet;

...

var width = "".GetWidth();
```

全角・半角の判定は、Unicodeの[EAST ASIAN WIDTH](http://www.unicode.org/reports/tr11/)に則って判定します。

EAST ASIAN WIDTHには全角・半角が文脈によって変化する「Ambiguous」という種別が存在します。

Ambiguousは、東アジアの場合は全角として、東アジア以外の場合は半角として扱う必要があります。

EastAsianWidthDotNetではCultureInfoによって判断しています。EastAsianWidthDotNetでは[こちらのロケール](https://github.com/nuitsjp/EastAsianWidthDotNet/blob/master/src/EastAsianWidthDotNet/EastAsia.cs#L20)を東アジア以外として判断しており、それ以外のロケールを東アジアとして判断します。

明示的に東アジアか否か、もしくはCultureInfoを指定できます。未指定の場合、CultureInfo.CurrentUICultureが適用されます。

## API Reference

以下を参照ください。

- [https://nuitsjp.github.io/EastAsianWidthDotNet/](https://nuitsjp.github.io/EastAsianWidthDotNet/)

多くの場合、拡張メソッドを利用することで解決できます。

- [](https://nuitsjp.github.io/EastAsianWidthDotNet/class_east_asian_width_dot_net_1_1_east_asian_width_extensions.html)




## 絵文字の扱いについて

絵文字の実際の扱いは

EastAsianWidthを考慮して全角・半角を判定
