## 什么是CefSharp

> https://cefsharp.github.io

> CefSharp is a simple .Net wrapper around the Chromium Embedded Framework (CEF). CEF is an open source project based on the Google Chromium project. Unlike the Chromium project itself, which focuses mainly on Google Chrome application development, CEF focuses on facilitating embedded browser use cases in third-party applications. CEF is based on the multi-process Chromium Content API and as a result only a subset of the features that exist in Chromium are currently available. For example, support for extensions is limited, only a subset of the Extension API is implemented.

`CefSharp`是**嵌入式Chromium框架**(`Chromium Embedded Framework`)的C#实现版本，让基于.Net的Windows客户端能方便的把Chromium核心嵌入其中，满足Hybrid混合架构的业务场景需求，终端技术目前支持：`WinFroms`、`WPF`、`OffScreen`，.Net框架不仅支持`.Net Framework`，还支持最新的`.Net Core 3.1` / `Net 5`。

> CefSharp provides three different flavors, WinForms, WPF and OffScreen. The WPF and OffScreen versions use the OffScreen Rendering(OSR) rendering mode. In OSR mode each frame is rendered to a buffer and then either drawn on the screen as in the case of WPF or available as a Bitmap in the OffScreen. All versions use the CefSharp and CefSharp.Core libraries, as a result much of the API is used exactly the same within all three flavors. This limits code duplication and reduces the maintenance burden of adding a new feature, the only downside is the WPF version is not quite as WPF friendly as it could be (you can subclass the ChromiumWebBrowser class and implement any missing parts in your application that are required). Also you can host the WinForms version within WPF using the WindowsFormsHost, this may be required to get around some limitations of the WPF version (CEF has yet to implement full touch screen support in the OSR mode, there is an open issue on the CEF Issue Tracker, if this is something you require, get involved there).

> Off-Screen Rendering 离屏渲染，指的是GPU在当前屏幕缓冲区以外新开辟一个缓冲区进行渲染操作

`CefSharp`的WPF和OffScreen版本使用了离屏渲染机制(`OffScreen Rendering`, OSR)，但是在OSR模式下，Cef暂时没有全触屏的接口支持，所以WPF版本还是存在一些限制，如果有必要你可以在WPF中可通过WindowsFormsHost技术来嵌入WinForms版，所有的版本都将使用`CefSharp`、`CefSharp.Core`这两个库。

## 相关文档

* [温故知新，遇见CefSharp，适用于WPF/WinFroms的Chromium嵌入框架的C#版本，让客户端插上Web的翅膀](https://www.cnblogs.com/taylorshi/p/15192119.html)

## 相关截图

