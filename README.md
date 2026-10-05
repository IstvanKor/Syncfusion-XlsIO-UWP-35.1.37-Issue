# Syncfusion.XlsIO.UWP 35.1.37 – PlatformNotSupportedException

Minimal UWP project reproducing a `System.PlatformNotSupportedException` with **Syncfusion.XlsIO.UWP 35.1.37** when running with the **.NET Native toolchain** in Release mode.

## Issue

With Syncfusion.XlsIO.UWP **35.1.37**, the following code throws:

```csharp
try
{
    ExcelEngine excelEngine = new ExcelEngine();
    excelEngine.Dispose();
}
catch (Exception ex)
{
    // System.PlatformNotSupportedException
    // Operation is not supported on this platform.
}
