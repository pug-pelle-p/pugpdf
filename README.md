# pugpdf
A WkHtmlToPdf .net core wrapper.

It includes all binaries to run wkhtmltopdf, no external dependencies.

## NuGet

To get started you can download the prebuilt [NuGet package](https://www.nuget.org/packages/PugPDF.Core/).

## Usage

```
var pdfByteArray = await WkHtmlToPdfDriver.ConvertAsync("<h1>Hello world</h1>");
```
