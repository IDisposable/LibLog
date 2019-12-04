![Image](docs/liblog_icon.png)

# LibLog [![Build status](https://ci.appveyor.com/api/projects/status/4v136j3od783udpa?svg=true)](https://ci.appveyor.com/project/damianh/liblog) [![NuGet Badge](https://buildstats.info/nuget/LibLog)](https://www.nuget.org/packages/LibLog/)

:warning: LibLog is now deprecated (see [#270](https://github.com/damianh/LibLog/issues/270)). 

My recommend course of action for library developers is to use [`Microsoft.Extensions.Logging.Abstractions`](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions) as it is now the defacto standard logging interface in the .NET ecosystem. For library developers that wish to continue to use LibLog or need to make adjustments for their needs should copy the code into their project (after all, that's just what LibLog did).

Thanks to all contributors and users for the support over the years.

Damian

---

Designed specifically for **library** developers, `LibLog` is a source code package that you [install via nuget][0] into your library/framework/application to provide a logging abstraction. It also contains transparent built-in support for [NLog][3], [Log4Net][4], [Serilog][9] and [Loupe][10], and allows your users to define a custom provider if necessary.

Please see [Wiki](https://github.com/damianh/LibLog/wiki) for more information.

## Availability for old csproj format

LibLog uses `.pp` file to do a namespace transform (aka [source
transform](https://docs.microsoft.com/en-us/nuget/create-packages/source-and-config-file-transformations))
so it fits into your project's namespace. This is handled transparently by the
new dotnet sdk as of LibLog version 5.0.0. If you change your project's root
namespace then LibLog will automatically change also. For older project
formats, please continue to use LibLog 4.x versions.

### License

LibLog is licensed under [MIT Licence][2].

Feedback, compliments or criticism: [@randompunter][6] 

[0]: https://www.nuget.org/packages/LibLog
[1]: https://github.com/damianh/LibLog/blob/master/src/LibLog/LibLog.cs
[2]: http://www.opensource.org/licenses/MIT
[3]: http://nlog-project.org/
[4]: https://logging.apache.org/log4net/
[6]: https://twitter.com/randompunter
[9]: http://serilog.net/
[10]: http://www.gibraltarsoftware.com/Loupe
