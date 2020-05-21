# EastAsianWidth

Unicodeの文字の全角・半角を判定して、幅を取得するためのライブラリです。

```cs
using  EastAsianWidthDotNet;

...
var width = "全角.".GetWidth();
Console.WriteLine($"Width is {width}.");
```

![](images/sample.png)

全角・半角の判定は、Unicodeの[EAST ASIAN WIDTH](http://www.unicode.org/reports/tr11/)に則って判定します。

EAST ASIAN WIDTHには全角・半角が文脈によって変化する「Ambiguous」という種別が存在します。

Ambiguousは、東アジアの場合は全角として、東アジア以外の場合は半角として扱う必要があります。

EastAsianWidthDotNetではCultureInfoによって判断しています。EastAsianWidthDotNetでは[こちらのロケール](https://github.com/nuitsjp/EastAsianWidthDotNet/blob/master/src/EastAsianWidthDotNet/EastAsia.cs#L20)を東アジアとして判断します。

CultureInfoを明示的に指定することもできますが、未指定の場合、CultureInfo.CurrentUICultureが適用されます。

また明示的に東アジアか否か指定することも可能です。

## API Reference

以下を参照ください。

- [https://nuitsjp.github.io/EastAsianWidthDotNet/](https://nuitsjp.github.io/EastAsianWidthDotNet/)
  - [StringExtensions](https://nuitsjp.github.io/EastAsianWidthDotNet/class_east_asian_width_dot_net_1_1_string_extensions.html)

多くの場合、stringの拡張メソッド（StringExtensions）を利用することで解決できます。

## 絵文字の扱いについて

一部の絵文字について適切に判断することができません。たとえば多くのフォントで「⏳」は全角と半角の中間の幅として表示されます。絵文字の幅はフォントに依存するところが多く、フォント別に網羅することが現実的ではありません。

EastAsianWidthDotNetでは、「現時点で」絵文字に対する個別の対応は行っていません。文字幅を気にする箇所では、絵文字を利用することは避けてください。

ただし一部の絵文字（☀など）は、多くの場合扱いが同一ですが、EAST ASIAN WIDTHとの定義と差があります。このような絵文字について、要望が多ければ個別に対応することを検討したいと思います。

その際は[Issue](https://github.com/nuitsjp/EastAsianWidthDotNet/issues)へ連絡ください。
