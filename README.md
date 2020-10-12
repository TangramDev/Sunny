# Sunny: You are the girl just I want most
In the spring of 2018, a girl broke into my world, perhaps by accident, perhaps by a certain destiny, this girl attracted me deeply from all angles, and made me fascinated and excited about her all day long. From that moment on, my work was deeply imprinted on her... After more than two years, she finally became a beautiful girl. Can she attract the elite of this world with her unique charm? Will it be a flash in the pan? With these excitement and uneasiness, I opened the curtain that belongs to her... 

## Why develop Sunny?

I have been engaged in software development for almost 30 years, and I have been looking forward to forming a software architecture that I am satisfied with, especially during the prevalence of the Internet. I shoulder the expectations of my family and many friends from all walks of life. These years, I have been happy to create something that I am satisfied with. Sunny is a flash of light: If your thoughts are so beautiful and excite you, what kind of fantastic ideas should it be? If this idea is worth looking forward to, is it a good idea to carve it into an extraordinary and slim girl? Sunny is a girl full of inspiration, shoulders a set of missions that make **Desktop Software** a **disruptor in the Internet age.**

# 艳阳，你是我最想要的丫头
2018年春天，一个女孩闯入了我的世界，或许是一种偶然，或许是一种冥冥之中的注定，这个姑娘，从各个角度都深深的吸引着我，让我为之着迷、为她兴奋，从那个时刻起，我的工作深深的刻上了她的烙印……，两年多的时间过去了，这个姑娘终于出落成一个漂亮的少女，她能以她独特的魅力吸引这个世界的精英吗？ 会不会昙花一现？ 带着这些兴奋与忐忑不安，我拉开了属于她的帷幕……

## 为什么开发"艳阳"（Sunny）？

从事软件开发快30年了，一直期待着形成一款自己满意的软件架构，特别是互联网盛行的阶段，肩负着家人、诸多各界朋友的期望，这些年一直乐此不疲的打造自己满意的东西。Sunny是灵光一现的想法：如果自己的想法非常之美，是那么令自己为之激动，应该是一种什么样的奇思妙想呢？如果这个构想值得期待，那么就将其雕琢成一个超凡脱俗、亭亭玉立的姑娘，是不是一个好主意？Sunny是一个充满灵光的女孩，肩负着一组使命，这个使命使得桌面软件成为互联网时代的颠覆者。

Sunny是一创新度极高的产品线，其关键特征之一就是直接让一款基于.NET的产品具备软件生态，这一点确保了相关产品做为互联网服务的可行性。
Sunny is a highly innovative product line. One of its key features is to directly enable a product based on .NET to have a software ecosystem, which ensures the feasibility of related products as Internet services.


## In order to clearly state our basic vision, we need 3 basic concepts: 
- The first is **Virtual Layout Engine** (VLE), 
- The second is **Virtual Web Browser Engine** (VBE), 
- The third is **Virtual Eclipse Engine** (VEE).

## Virtual Layout Engine(VLE) 
The Virtual Layout Engine is a multi-level, gridded, nestable and easy to describe UI layout description engine. The so-called gridding refers to a window matrix with m rows and n columns(a grid with 1 row and n columns can be interpreted as a tabbed window with n tabs), while nestable refers to that each lattice in the matrix can dynamically nest multiple grid layers, and only one layer is visible at runtime. Here, "virtual" means that a certain layout may be uncertain at design time and can be generated dynamically at runtime, different dynamic matching may be made due to different scenarios, permissions and other factors. In fact, a flexible layout is the result of dynamic change of multi-layer grid. 
## Virtual Web Browser Engine(VBE or Virtual Web Browser Engine for Application).
The Virtual Web Browser Engine is a **dynamic link library version** of the Google Chromium Project. It contains all the code of the Chromium project. The goal is to make **windows desktop applications** implement the **Built-in Modern Browser Model** according to a consistent scheme and make the host desktop software naturally become a modern web browser. Different from the traditional browser, the application integrated with VBE (Virtual Web Browser Engine) has its own **application object model**, since all functions of the browser part are provided based on dll mode, VBE does not know in advance what the host application is and what object model the host application contains, VBE solves the connection problem between the host model and the browser standard model, so "virtual" here means that the real browser model can only be determined after a specific host application is defined. At the same time, the DOM model of the host application will be larger than the DOM model of a standard browser. In other words, the host application system will provide a key part of the real model that is not available in standard browsers. The actual DOM model of the host application may include members that are not part of the standard browser DOM model, which means that the host application supports both standard web pages and application-based web pages, and there is no application-based web page in the standard browser mode. Because the host application has all the functions of the Chromium project built-in, application developers can develop new application content for the host application based on Web technology, so that the host application becomes a **Software Ecosystem based on Web Technology**.
#### Key features of VBE
1.	Supports all of Chromium features.
2.	With the Complete Chromium Sandbox Mechanism, this is the most direct difference from CEF.
3.	Custom DOM, in particular, we allow Binary Programmable Object UI Elements (WinForm, Usercontrol, WPF, ActiveX Control, etc.) to participate in web page development as extended DOM elements.
4.	Binary programmable object Web binding: 1, allows the Renderer Process to listen for events of the Browser process object(COM Object, .Net Object, Java Object and C++ Object etc.) in the Javascript session; 2, Binary Programmable Objects(COM Object, .Net Object, Java Object and C++ Object etc.) can send IPC messages to the Renderer process. Through the above two aspects, VBE realizes the web page expansion development ability
5.	A Multi-Layered, Gridded UI layout Description Engine based on DOM enables developers to implement a flexible, powerful, dynamic Web-Desktop hybrid layout based on Web technology.
## Virtual Eclipse Engine(VEE, Eclipse for Application)
The Virtual Eclipse Engine is a **dynamic link library version** of the Eclipse Project. It contains all the code of the Eclipse Project. The goal is to make windows desktop applications implement the Built-in Eclipse Model according to a consistent scheme and make the host desktop software naturally become a **Eclipse Launcher**. Different from the traditional eclipse, the application integrated with VEE (Virtual Eclipse Engine) has its own application object model, since all functions of the eclipse part are provided based on dll mode, VEE does not know in advance what the host application is and what object model the host application contains, VEE solves the connection problem between the host model and the eclipse standard model, so "virtual" here means that the real eclipse model can only be determined after a specific host application is defined. At the same time, the OSGi model of the host application will be larger than the OSGi model of a standard eclipse. In other words, the host application system will provide a key part of the real model that is not available in standard eclipse. The actual OSGi model of the host application may include members that are not part of the standard eclipse OSGi model, which means that the host application supports both standard eclipse components and application-based eclipse components, and there is no application-based eclipse components in the standard browser mode. Because the host application has all the functions of the Eclipse project built-in, application developers can develop new application content for the host application based on Eclipse technology, so that the host application becomes a Software Ecosystem based on Java Technology.

## What is Sunny?
1.	A **New Disruptive .NET Dynamic Integration Technology** enables .NET desktop applications to optimally integrate VLE. Through VLE and Sunny, the .NET application system can maximize support for WinForm, Usercontrol and WPF components and other .NET components at runtime 
2.	A **Unique VBE Integration Pattern** that enables the host .NET application directly become a **Modern Web Browser**, and then have an **Application Content Ecological Chain** based on **Web-Desktop Hybrid Technology**;
3.	A **Unique VEE Integration Mode** makes the host application system directly become a **Eclipse Launcher**, and then has a **Java Content Ecological Chain** based on **Eclipse Technology**;

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

## Sunny从以下几个方面重新调整开发者对.NET桌面应用的认知：
1. 每个.NET桌面应用应该有任意多个运行时状态；
2. 每个.NET桌面应用都有一个无限大的对象模型；
3. 每个.NET桌面应用都是互联网内容的访问入口
4. 每个.NET桌面应用，都有其自己的Office文档生态链
5. 每个.NET桌面应用都有其私有模型以及共享一组公共模型

## Sunny readjusts developers' understanding of .Net desktop applications from the following aspects:
1. Every.Net desktop application should have any number of runtime states;
2. Every.Net desktop application has an infinite object model;
3. Every.Net desktop application is the entrance to Internet content;
4. Every.Net desktop application has its own office document ecological chain;
5. Every.Net desktop application has its own private model and shares a common set of models

Sunny与VBA的对比

