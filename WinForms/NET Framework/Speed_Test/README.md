# TeeChart .NET Framework 4.7.2 and 4.8 Speed Test

To run these benchmarks, build the solution in Release mode, set one of the Benchmark projects as the start-up project, and then run.

These speed tests are the equivalent of the .NET 6.0 speed tests which are [also located in this repo](https://github.com/Steema/TeeChart-NET-Pro-Samples/tree/main/WinForms/NET%206/Speed_Test).

### N.B.
These two speed tests use slightly different versions of TeeChart:

- _.NET Framework 4.7.2_ uses TeeChart.dll, a stand-alone assembly built against .NET Framework 4.0
- _.NET Framework 4.8_ uses TeeChart.WinForm.dll, an assembly built against .NET Framework 4.8 which exposes the API in TeeChart.dll, an assembly built against .NET Standard 2.0. This latter assembly is the same assembly we use to build the .NET 6.0 version of TeeChart.WinForm.dll. 