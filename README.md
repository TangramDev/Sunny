# Sunny: You Are the Girl just I Want Most
In the spring of 2018, a girl broke into my world, perhaps by accident, perhaps by a certain destiny, she attracted me deeply from all angles, and made me fascinated and excited about her every day. From that moment on, she became a brand, deeply engraved in my work. More than two years later, she finally became a beautiful and elegant girl. Can she attract the elite of this world with her unique charm? Will it be a flash in the pan? With these excitement and uneasiness, I opened the curtain that belongs to her...

## Why Develop Sunny?

I have been engaged in software development for almost 30 years, and I have been looking forward to forming a software architecture that I am satisfied with, especially during the prevalence of the Internet. I shoulder the expectations of my family and many friends from all walks of life. These years, I have been happy to create something that I am satisfied with. Sunny is a flash of light: If your thoughts are so beautiful and excite you, what kind of fantastic ideas should it be? If this idea is worth looking forward to, is it a good idea to carve it into an extraordinary and slim girl? Sunny is a girl full of inspiration, shoulders a set of missions that make **Desktop Software** a **Disruptor in the Internet Age.**

## In order to express our vision clearly, we need three basic concepts.: 
- The first is **Virtual Layout Engine** (VLE), 
- The second is **Virtual Web Browser Engine** (VBE), 
- The third is **Virtual Eclipse Engine** (VEE).

## Virtual Layout Engine (VLE) 
The Virtual Layout Engine is a **Multi-Level, Gridded, Nestable and Easy to Describe UI Layout Description Engine**. The so-called gridding refers to a **window matrix** with m rows and n columns(a grid with 1 row and n columns can be interpreted as a tabbed window with n tabs), while nestable refers to that each lattice in the matrix can dynamically nest multiple grid layers, and only one layer is visible at runtime. Here, "virtual" means that a certain layout may be uncertain at design time and can be generated dynamically at runtime, different dynamic matching may be made due to different scenarios, permissions and other factors. In fact, a flexible layout is the result of dynamic change of multi-layer grid. 
## Virtual Web Browser Engine (VBE).
The Virtual Web Browser Engine is a **dynamic link library version** of the Google Chromium Project. It contains all the code of the Chromium Project. The goal is to make **Windows Desktop Applications** implement the **Built-in Modern Browser Model** according to a consistent scheme and make the host desktop software naturally become a modern web browser. Different from the traditional browser, the application integrated with VBE (Virtual Web Browser Engine) has its own **application object model**, since all functions of the browser part are provided based on dll mode, VBE does not know in advance what the host application is and what object model the host application contains, VBE solves the connection problem between the host model and the browser standard model, so "virtual" here means that the real browser model can only be determined after a specific host application is defined. At the same time, the DOM model of the host application will be larger than the DOM model of a standard browser. In other words, the host application system will provide a key part of the real model that is not available in standard browsers. The actual DOM model of the host application may include members that are not part of the standard browser DOM model, which means that the host application supports both standard web pages and application-based web pages, and there is no application-based web page in the standard browser mode. Because the host application has all the functions of the Chromium project built-in, application developers can develop new application content for the host application based on Web technology, so that the host application becomes a **Software Ecosystem based on Web Technology**.
#### Key features of VBE
1.	Supports all of Chromium features.
2.	With the Complete Chromium Sandbox Mechanism, this is the most direct difference from CEF.
3.	Custom DOM, in particular, we allow Binary Programmable Object UI Elements (WinForms, User controls, WPF, ActiveX Control, etc.) to participate in web page development as extended DOM elements.
4.	Binary programmable object Web binding: 1, allows the Renderer Process to listen for events of the Browser process object(COM Object, .Net Object, Java Object and C++ Object etc.) in the Javascript session; 2, Binary Programmable Objects(COM Object, .Net Object, Java Object and C++ Object etc.) can send IPC messages to the Renderer process. Through the above two aspects, VBE realizes the web page expansion development ability
5.	A Multi-Layered, Gridded UI layout Description Engine based on DOM enables developers to implement a flexible, powerful, dynamic Web-Desktop hybrid layout based on Web technology.
## Virtual Eclipse Engine (VEE, Eclipse for Application)
The Virtual Eclipse Engine is a **dynamic link library version** of the Eclipse Project. It contains all the code of the Eclipse Project. The goal is to make windows desktop applications implement the Built-in Eclipse Model according to a consistent scheme and make the host desktop software naturally become a **Eclipse Launcher**. Different from the traditional eclipse, the application integrated with VEE (Virtual Eclipse Engine) has its own application object model, since all functions of the eclipse part are provided based on dll mode, VEE does not know in advance what the host application is and what object model the host application contains, VEE solves the connection problem between the host model and the eclipse standard model, so "virtual" here means that the real eclipse model can only be determined after a specific host application is defined. At the same time, the OSGi model of the host application will be larger than the OSGi model of a standard eclipse. In other words, the host application system will provide a key part of the real model that is not available in standard eclipse. The actual OSGi model of the host application may include members that are not part of the standard eclipse OSGi model, which means that the host application supports both standard eclipse components and application-based eclipse components, and there is no application-based eclipse components in the standard browser mode. Because the host application has all the functions of the Eclipse project built-in, application developers can develop new application content for the host application based on Eclipse technology, so that the host application becomes a Software Ecosystem based on Java Technology.

## What is Sunny?
Sunny is a **productivity-oriented** and highly innovative **software runtime support environment**. Its purpose is to enable .NET-based Desktop Software Products to have an **Internet Software Ecosystem**, which is embodied in the following aspects:
1.	A **New Disruptive .NET Dynamic Integration Technology** enables .NET desktop applications to optimally integrate VLE. Through VLE and Sunny, the .NET application system can maximize support for WinForms, User Controls, WPF components and other .NET components at runtime;
2.	A **Unique VBE Integration Pattern** that enables the host .NET application directly to become a **Modern Web Browser**, and then have an **Application Content Ecological Chain** based on **Web-Desktop Hybrid Technology**;
3.	A **Unique VEE Integration Mode** makes the host application system directly to become an **Eclipse Launcher**, and then has a **Java Content Ecological Chain** based on **Eclipse Technology**;

## What is the Core Issue of Sunny?
- In the Internet era, desktop software will inevitably be affected by Web software. Whether it is expressiveness or full use of Internet network services, Internet browsers dwarf desktop software. Change is imperative. Sunny's core vision is to make full use of web technology to control the core backbone of desktop software and the software ecosystem of the software itself, this idea is the key to connecting desktop software and Internet services. In terms of .NET desktop development, Sunny’s strategy is to make full use of open source technology instead of competing with browsers, and build the desktop software ecosystem directly on the basis of the browser framework while **retaining the advantages of desktop software.** This idea is the original vision of **VBR** (Virtual Web Browser Engine), and it is also Sunny's core issue.
- Another key issue for Sunny is to provide **a complete software ecosystem construction solution** for .Net desktop applications. Considering that .NET, Java and Web Technology almost cover the mainstream developer community, through the integration of **VEE (Virtual Eclipse Engine)**, Sunny provides a solution for the Java ecological chain construction mechanism of .Net desktop software, thereby making the ecological construction technology of .Net desktop software more complete.

> In fact, although the above code is "the ***smallest*** Sunny application", at the same time, it is almost equivalent to the most complete Sunny application.
## Create your first Sunny Application
### Open Visual Studio 2019, creating a C# WinForm Application
This is one of the most common C# WinForm applications, and the starting point of the Sunny project starts here.
#### Step 1: Add reference to "Cosmos.dll"
Sunny only supports 64 bit applications, which needs to be made clear.
#### Step 2: Add "app.mainfest" to this project
![markdown](https://blog.tangram.dev/assets/AddManifestFile.png "markdown")
As shown in the figure above, ***we need to use this Wizard to add a manifest file to the created project***. This step is an indispensable step.
Sunny needs to add an application manifest file to the current project. Please refer to the standard .NET document for the specific steps of adding the manifest file. ***The "compatibility" node of the manifest file needs to be modified as follows***:
```xml
  <compatibility xmlns="urn:schemas-microsoft-com:compatibility.v1">
    <application>
      <!-- A list of the Windows versions that this application has been tested on
           and is designed to work with. Uncomment the appropriate elements
           and Windows will automatically select the most compatible environment. -->

      <!-- Windows Vista -->
      <supportedOS Id="{e2011457-1546-43c5-a5fe-008deee3d3f0}" />

      <!-- Windows 7 -->
      <supportedOS Id="{35138b9a-5d96-4fbd-8e2d-a2440225f93a}" />

      <!-- Windows 8 -->
      <supportedOS Id="{4a2f28e3-53b9-4441-ba9c-d69d4a4a6e38}" />

      <!-- Windows 8.1 -->
      <supportedOS Id="{1f676c76-80e1-4239-95bb-83d0f6d0da78}" />

      <!-- Windows 10 -->
      <supportedOS Id="{8e0f7a12-bfb3-4fe8-b9a5-48fd50a15a9a}" />

    </application>
  </compatibility>
```
#### Step 3: modify the program.cs file
```csharp
using System;
using System.Windows.Forms;
using Cosmos;

namespace Sunny
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Hubble.Run();//Modified by Sunny
        }
    }
}
```
#### Step 4: Compile and Run
## Sunny has the following four missions:
1. Enable every .NET desktop application is a dynamic content service portal;
2. Enable every .NET desktop application is an **Internet Browser**. Sunny has created a ubiquitous browser trend. At the same time, it also dilutes the exclusive mode of browser applications, making the characteristics of the browser change from individuality to commonality, and then gradually disappear. When more and more applications are browsers, the unique status of the browser will be shaken;
3. Enable every .NET desktop application is a **fully functional customized version of Eclipse**, similar to Sunny's attitude towards browsers, Sunny will reduce the unique position of Eclipse and turn it into a public service.
4. Enable each .NET desktop application has its own **Application Ecology**. Developers can use various mature technologies to produce ecological content including the following aspects:
-   a. Ecosystem based on Web pages;
-   b. Based on the ecology of .NET itself;
-   c. Java-based ecology;
-   d. Ecology based on COM/C++;
-   e. Office-based ecology

## Sunny will reshape developers' perception of .NET desktop applications from the following aspects:
1. Every.Net desktop application should have any number of runtime states;
2. Every.Net desktop application has an infinite object model;
3. Every.Net desktop application is the entrance to Internet content;
4. Every.Net desktop application has its own office document ecological chain;
5. Every.Net desktop application has its own private model and shares a common set of models
