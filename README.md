# Visual Studio Live! Orlando (part of Live!360) - November 2022  

## Description  
This repository contains slides and code samples for sessions presented at Visual Studio Live! Orlando (part of Live! 360) November 13-28, 2022.  

## Sessions  

**VSHOL03 - Hands-On Lab: Asynchronous and Parallel Programming in C#**  
Level: Intermediate  

Asynchronous programming is a critical skill to take full advantage of today's multi-core systems. But async programming brings its own set of issues. In this workshop, we'll work through some of those issues and get comfortable using parts of the .NET Task Parallel Library (TPL).  

We'll start by calling asynchronous methods using the Task Asynchronous Pattern (TAP), including how to handle exceptions and cancellation. With this in hand, we'll look at creating our own asynchronous methods and methods that use asynchronous libraries. Along the way, we'll see how to avoid deadlocks, how to isolate our code for easier async, and why it's important to stay away from "async void".  

In addition, we'll look at some patterns for running code in parallel, including using Parallel.ForEachAsync, channels, and other techniques. We'll see pros and cons so that we can use the right pattern for a particular problem.  

Throughout the day, we'll go hands-on with lab exercises to put these skills into practice.  

Objectives:  

* Use asynchronous methods with Task and await  
* Create asynchronous methods and libraries  
* How to avoid deadlocks and other pitfalls  
* Understand different parallel programming techniques  

Pre-Requisites:  

Basic understanding of C# and object-oriented programming (classes, inheritance, methods, and properties). No prior experience with asynchronous programming is necessary; we'll take care of that as we go.  

Attendee Requirements:  

* You must provide your own laptop computer (Windows or Mac) for this hands-on lab.  

* You need to have the .NET 6 SDK installed as well as the code editor of your choice (Visual Studio 2022 Community Edition or Visual Studio Code are both good (free) choices).  

* Interactive labs, web application samples, and console samples will work with Windows, macOS, and Linux (anywhere .NET 6 will run).  

* WPF desktop samples will only work on Windows machines. There are equivalent web and console examples for these projects.

Links:

* .NET 6.0 SDK  
[https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)  
* Visual Studio 2022 (Community)  
[https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/)  
Note: Install the "*ASP.NET and web development*" workload for the labs and samples. Include "*.NET desktop development*" for "digit-display" sample and WPF-based samples.  
* Visual Studio Code  
[https://code.visualstudio.com/download](https://code.visualstudio.com/download)    

Resources:  
* Slides: [/VSHOL03-async-programming/SLIDES-asynchronous-programming.pdf](./VSHOL03-async-programming/SLIDES-asynchronous-programming.pdf)
* Sample Code: [/VSHOL03-async-programming/](./VSHOL03-async-programming/)

---  

**VSW06 - Design Patterns: Not Just for Architects**  
Level: Introductory / Intermediate  

Design patterns are not just for architects. In fact, you already use Design Patterns but probably don't know it. Observer, Facade, Iterator, Proxy - these are all patterns that allow us to better communicate our ideas with other developers. And once we understand the patterns, we can use solutions that people way smarter than us have already implemented. In this session, we'll take a look at several Gang of Four patterns that we regularly use without realizing it. Don't know who the Gang of Four is? Join us to find out.  

You will learn:

* What design patterns are  
* How you are already using design patterns (even if you don't realize it)  
* How intentional use of patterns can lead to better software  

Resources:  
* Slides: [/VSW06-design-patterns/SLIDES-design-patterns.pdf](./VSW06-design-patterns/SLIDES-design-patterns.pdf)
* Sample Code: [/VSW06-design-patterns/](./VSW06-design-patterns/)

---

**VSTH11 - A Tour of Go for the C# Developer**  
Level: Introductory

Learning other programming languages enhances our work in our primary language. From the perspective of a C# developer, the Go language (golang) has many interesting ideas. Go is opinionated on some things (such as where curly braces go and what items are capitalized). Declaring an unused variable causes a compile failure; the use of "blank identifiers" (or "discards" in C#) are common. Concurrency is baked right in to the language through goroutines and channels. Programming by exception is discouraged; it's actually called a "panic" in Go. Instead, errors are treated as states to be handled like any other data state. We'll explore these features (and others) by building an application that uses concurrent operations to get data from a service. These ideas make us think about the way we program and how we can improve our day-to-day work (in C# or elsewhere).

You will learn:

* Why you want to look at other languages such as Go  
* How Go concurrency compares to C#  
* How to approach error handling with a different mindset  

Resources:  
* Slides: [/VSTH11-go-for-the-csharp-developer/SLIDES-go-for-the-csharp-developer.pdf](./VSTH11-go-for-the-csharp-developer/SLIDES-go-for-the-csharp-developer.pdf)
* Sample Code: [/VSTH11-go-for-the-csharp-developer/](./VSTH11-go-for-the-csharp-developer/)

---