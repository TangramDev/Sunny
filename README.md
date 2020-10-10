# Sunny: You are the girl just I want most
In the spring of 2018, a girl broke into my world, perhaps by accident, perhaps by a certain destiny, this girl attracted me deeply from all angles, and made me fascinated and excited about her all day long. From that moment on, my work was deeply imprinted on her... After more than two years, she finally became a beautiful girl. Can she attract the elite of this world with her unique charm? Will it be a flash in the pan? With these excitement and uneasiness, I opened the curtain that belongs to her... 

## What is Sunny?

I have been engaged in software development for almost 30 years, and I have been looking forward to forming a software architecture that I am satisfied with, especially during the prevalence of the Internet. I shoulder the expectations of my family and many friends from all walks of life. These years, I have been happy to create something that I am satisfied with. Sunny is a flash of light: If your thoughts are so beautiful and excite you, what kind of fantastic ideas should it be? If this idea is worth looking forward to, is it a good idea to carve it into an extraordinary and slim girl? Sunny is a girl full of inspiration, shoulders a set of missions that make **Desktop Software** a **disruptor in the Internet age.**

# Sunny，你是我最想要的丫头
2018年春天，一个女孩闯入了我的世界，或许是一种偶然，或许是一种冥冥之中的注定，这个姑娘，从各个角度都深深的吸引着我，让我为之着迷、为她兴奋，从那个时刻起，我的工作深深的刻上了她的烙印……，两年多的时间过去了，这个姑娘终于出落成一个漂亮的少女，她能以她独特的魅力吸引这个世界的精英吗？ 会不会昙花一现？ 带着这些兴奋与忐忑不安，我拉开了属于她的帷幕……

## Sunny是什么？

从事软件开发快30年了，一直期待着形成一款自己满意的软件架构，特别是互联网盛行的阶段，肩负着家人、诸多各界朋友的期望，这些年一直乐此不疲的打造自己满意的东西。Sunny是灵光一现的想法：如果自己的想法非常之美，是那么令自己为之激动，应该是一种什么样的奇思妙想呢？如果这个构想值得期待，那么就将其雕琢成一个超凡脱俗、亭亭玉立的姑娘，是不是一个好主意？Sunny是一个充满灵光的女孩，肩负着一组使命，这个使命使得桌面软件成为互联网时代的颠覆者。

## In order to clearly state our basic vision, we need 3 basic concepts: 
- the first is VLE, 
- the second is VBE, 
- the third is VEE.

## Virtual Layout Engine(VLE) 
The Virtual Layout Runtime is a multi-level, gridded, nestable and easy to describe UI layout description engine. The so-called gridding refers to a window matrix with m rows and n columns(a grid with 1 row and n columns can be interpreted as a tabbed window with n tabs), while nestable refers to that each lattice in the matrix can dynamically nest multiple grid layers, and only one layer is visible at runtime. Here, "virtual" means that a certain layout may be uncertain at design time and can be generated dynamically at runtime, different dynamic matching may be made due to different scenarios, permissions and other factors. In fact, a flexible layout is the result of dynamic change of multi-layer grid. 
## Virtual Web Browser Runtime(VBE or Virtual Web Browser Runtime for Application).
Virtual Web Browser Runtime is a dynamic link library version of Google Chromium Project that contains all of the Chromium Project Code, with the goal of allowing Windows desktop applications to implement the built-in modern browser model in a unified manner, making the host desktop software a natural Web browser. The difference with browsers in the conventional sense is that applications that integrate VBR (Virtual Web Browser Runtime) have their own application object models, and because of the built-in Chromium, application developers can develop new application contents for host applications based on Web technology, making the host application a Web technology-based Software Ecosystem.
VBR is different from Chromium Embedded Framework. Compared with CEF, VBR provides all the functions of Chromium. This ensures that the smallest structural unit of desktop applications integrated with VBR is a web browser. The most obvious difference from conventional browsers is that VBR supports Application-oriented windows, and browsers usually only support browser windows. VBR is also different from Electron, and the positioning between the two is completely different. VBR is for desktop software, while Electron is committed to developing desktop software using Web technology. Electron weakens the huge resources of desktop software, which is almost two extremes of VBR's positioning. Every application that supports VBR is a modern browser. Strictly speaking, it is an application-oriented browser, which is different from standard browsers. the fundamental difference is that VBR supports extended DOM, allowing developers to customize their own DOM model, The fundamental difference is that VBR supports extending DOM, allowing developers to customize their own DOM model, which endows host applications with great content ecological support.
###### Key features of VBE
1.	Supports all of Chromium features.
2.	With the Complete Chromium Sandbox Mechanism, this is the most direct difference from CEF.
3.	Custom DOM, in particular, we allow Binary Programmable Object UI Elements (WinForm, Usercontrol, WPF, ActiveX Control, etc.) to participate in web page development as extended DOM elements.
4.	Binary programmable object Web binding: 1, allows the Renderer Process to listen for events of the Browser process object(COM Object, .Net Object, Java Object and C++ Object etc.) in the Javascript session; 2, Binary Programmable Objects(COM Object, .Net Object, Java Object and C++ Object etc.) can send IPC messages to the Renderer process. Through the above two aspects, VBR realizes the web page expansion development ability
5.	A Multi-Layered, Gridded UI layout Description Engine based on DOM enables developers to implement a flexible, powerful, dynamic Web-Desktop hybrid layout based on Web technology.
## Virtual Eclipse Runtime(Eclipse for Application). VEE
Virtual Eclipse Runtime is a dynamic link library version of Eclipse Project. We know that eclipse's basic structure consists of two parts, the first being an executable called Eclipse Laucher and the second being a Java-based component integration system. Eclipse Runtime essentially implements Eclipse Laucher as a set of dynamic link libraries, allowing a typically meaningful Windows desktop application to become Eclipse Laucher in a standard way, and integrating Eclipse Runtime applications with its own non-Java-based application model allows application developers to take full advantage of Java technology. Based on this model, Java technology is used to develop new application content for host applications, making the application system a Software Ecosystem based on Java technology.


