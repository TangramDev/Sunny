# Sunny: You are the girl just I want most
In the spring of 2018, a girl broke into my world, perhaps by accident, perhaps by a certain destiny, this girl attracted me deeply from all angles, and made me fascinated and excited about her all day long. From that moment on, my work was deeply imprinted on her... After more than two years, she finally became a beautiful girl. Can she attract the elite of this world with her unique charm? Will it be a flash in the pan? With these excitement and uneasiness, I opened the curtain that belongs to her... 

## Why develop Sunny?

I have been engaged in software development for almost 30 years, and I have been looking forward to forming a software architecture that I am satisfied with, especially during the prevalence of the Internet. I shoulder the expectations of my family and many friends from all walks of life. These years, I have been happy to create something that I am satisfied with. Sunny is a flash of light: If your thoughts are so beautiful and excite you, what kind of fantastic ideas should it be? If this idea is worth looking forward to, is it a good idea to carve it into an extraordinary and slim girl? Sunny is a girl full of inspiration, shoulders a set of missions that make **Desktop Software** a **disruptor in the Internet age.**

# 艳阳，你是我最想要的丫头
2018年春天，一个女孩闯入了我的世界，或许是一种偶然，或许是一种冥冥之中的注定，这个姑娘，从各个角度都深深的吸引着我，让我为之着迷、为她兴奋，从那个时刻起，我的工作深深的刻上了她的烙印……，两年多的时间过去了，这个姑娘终于出落成一个漂亮的少女，她能以她独特的魅力吸引这个世界的精英吗？ 会不会昙花一现？ 带着这些兴奋与忐忑不安，我拉开了属于她的帷幕……

## Sunny是什么？

从事软件开发快30年了，一直期待着形成一款自己满意的软件架构，特别是互联网盛行的阶段，肩负着家人、诸多各界朋友的期望，这些年一直乐此不疲的打造自己满意的东西。Sunny是灵光一现的想法：如果自己的想法非常之美，是那么令自己为之激动，应该是一种什么样的奇思妙想呢？如果这个构想值得期待，那么就将其雕琢成一个超凡脱俗、亭亭玉立的姑娘，是不是一个好主意？Sunny是一个充满灵光的女孩，肩负着一组使命，这个使命使得桌面软件成为互联网时代的颠覆者。

## In order to clearly state our basic vision, we need 3 basic concepts: 
- the first is **VLE**(Virtual Layout Engine), 
- the second is **VBE**(Virtual Web Browser Engine), 
- the third is **VEE**(Virtual Eclipse Engine).

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

1.	A new subversive .NET dynamic integration technology enables .NET applications to integrate VLE in the best way. Through VLE and Sunny, the application software can support WinForm, Usercontrol, and WPF components to the maximum extent at runtime;
2.	A VBR integration mode that conforms to the habits of developers, enabling the host .NET application to have an application content ecological chain based on Web technology;
3.	Make the host program directly become the Eclipse Launcher, so that the host .NET application has a Java content ecological chain based on Eclipse technology;

## Sunny has the following mission:

1.	Each. Net desktop application is a dynamic content service portal;
2.	Every. Net desktop application is an Internet browser. Sunny creates a trend that browsers are ubiquitous. At the same time, it will weaken the exclusive mode of browser applications, making browser features change from individuality to generality, and then gradually disappear. When more and more applications are browsers, the unique position of browsers will be shaken.
3.	Each. Net desktop application is a customized version of full-featured eclipse, similar to a browser. Eventually, sunny will dilute eclipse's unique position and turn it into a public service.

## Sunny has three missions: 
1. Every .NET desktop application is a dynamic content service portal;
2. Every .NET desktop application is an Internet browser. Sunny has created a ubiquitous browser trend. At the same time, it also downplays the exclusive mode of browser applications, so that browser characteristics from personality to commonality, and then gradually disappear, when more and more applications are browsers, the unique position of the browser will be shaken;
3. Every .NET desktop application is a customized version of the fully functional Eclipse, similar to Sunny's attitude toward browsers, Sunny will reduce Eclipse's unique position and transform it into a public service. 

## Sunny has the following four missions:
1. Every .NET desktop application is a dynamic content service portal;
2. Every .NET desktop application is an Internet browser. Sunny has created a ubiquitous browser trend. At the same time, it also dilutes the exclusive mode of browser applications, making the characteristics of the browser change from individuality to commonality, and then gradually disappear. When more and more applications are browsers, the unique status of the browser will be shaken;
3. Every .NET desktop application is a fully functional customized version of Eclipse, similar to Sunny's attitude towards browsers, Sunny will reduce the unique position of Eclipse and turn it into a public service.
4. Each .NET desktop application has its own application ecology. Developers can use various mature technologies to produce ecological content including the following aspects:
4.1. Ecosystem based on Web pages;
4.2. Based on the ecology of .NET itself;
4.3. Java-based ecology;
4.4. Ecology based on COM/C++;
4.5. Office-based ecology


