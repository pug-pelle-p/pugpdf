# PugPDF
A WkHtmlToPdf .net core wrapper.

It includes all binaries to run wkhtmltopdf, no external dependencies.

## NuGet

To get started you can download the prebuilt [NuGet package](https://www.nuget.org/packages/PugPDF.Core/).

## Usage

```
var renderer = new HtmlToPdf();

renderer.PrintOptions.Title = "My title";

var pdf = await renderer.RenderHtmlAsPdfAsync("<h1>Hello world</h1>");

pdf.SaveAs("c:\\my.pdf");
```
