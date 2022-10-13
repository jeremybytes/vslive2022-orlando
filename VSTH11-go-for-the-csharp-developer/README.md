A Tour of Go for the C# Developer
=======================
Level: Introductory

Learning other programming languages enhances our work in our primary language. From the perspective of a C# developer, the Go language (golang) has many interesting ideas. Go is opinionated on some things (such as where curly braces go and what items are capitalized). Declaring an unused variable causes a compile failure; the use of "blank identifiers" (or "discards" in C#) are common. Concurrency is baked right in to the language through goroutines and channels. Programming by exception is discouraged; it's actually called a "panic" in Go. Instead, errors are treated as states to be handled like any other data state. We'll explore these features (and others) by building an application that uses concurrent operations to get data from a service. These ideas make us think about the way we program and how we can improve our day-to-day work (in C# or elsewhere).

You will learn:

* Why you want to look at other languages such as Go  
* How Go concurrency compares to C#  
* How to approach error handling with a different mindset  

*Video Walkthrough: If you prefer a video walkthrough of the code, take a look at this video on YouTube: [A Tour of Go (golang) for the C# Developer](https://www.youtube.com/watch?v=NW-8WpnGQtE).*

Pre-requisites
--------------
If you want to build and run the code, you will need to have both Go 1.19 installed on your machine.

* Go: [https://golang.org/doc/install](https://golang.org/doc/install)
* "Go" extension for Visual Studio Code: [https://marketplace.visualstudio.com/items?itemName=golang.go](https://marketplace.visualstudio.com/items?itemName=golang.go).

Samples should work on all platforms supported by the runtimes (Windows, macOS, and Linux).

Project Layout
--------------
**/tour-of-go** contains the Go program  
**/people-service-go** contains a Go service (used by the "tour-of-go" program)  

The Go program is a console application that calls a service and displays the output. In order to show concurrency, the application gets each record individually.

Running the Service
-------------------  
The **Go service** can be started from the command line by navigating to the ".../people-service-go" directory and typing `go build` to build the services, then "./people-service-go.exe" to start the service. This provides endpoints at the following locations:

* http://localhost:9874/people/1  
Provides an individual "Person" record based on the "id" value. This service will delay for 1 second before responding. Sample record:

```json
{"id":1,"givenName":"John","familyName":"Koenig","startDate":"1975-10-17T00:00:00-07:00","rating":6,"formatString":null}
```

The Go Sample Program
---------------------
The **/tour-of-go** folder contains the "main.go" file which is the completed project.  

*Note: 
If you would like a step-by-step walkthrough, you can start with an empty folder and follow the instruction in [Walkthrough.md](Walkthrough.md).*

Other Topics
------------
This is by no means an exhaustive look at Go. Additional topics and topics to look into further include packages, exports, project structure, types, interfaces, and pointers.  

Here are a few articles (written by me):  
* [Go (golang) Loops - A Unified "for"](https://jeremybytes.blogspot.com/2021/01/go-golang-loops-unified-for.html)  
* [Go (golang) defer - A Better "finally"](https://jeremybytes.blogspot.com/2021/01/go-golang-defer-making-sure-something.html)  
* [Go (golang) Error Handling - A Different Philosophy](https://jeremybytes.blogspot.com/2021/01/go-golang-error-handling-different.html)  
* [Go (golang) Multiple Return Values - Different from C# Tuples](https://jeremybytes.blogspot.com/2021/01/go-golang-multiple-return-values.html)  
* [Go (golang) Goroutines - Running Functions Asynchronously](https://jeremybytes.blogspot.com/2021/01/go-golang-goroutines-running-functions.html)  
* [Go (golang) Channels - Moving Data Between Concurrent Processes](https://jeremybytes.blogspot.com/2021/01/go-golang-channels-moving-data-between.html)  
* [Go (golang) WaitGroup - Signal that a Concurrent Operation is Complete](https://jeremybytes.blogspot.com/2021/02/go-golang-waitgroup-signal-that.html)  
* [Go (golang) Anonymous Functions - Inlining Code for Goroutines](https://jeremybytes.blogspot.com/2021/02/go-golang-anonymous-functions-inlining.html)  
* [Go and Interfaces](https://jeremybytes.blogspot.com/2020/07/go-and-interfaces.html)  

Other Resources:
* Learn Go interactively: [A Tour Of Go](https://tour.golang.org/)  
* The official site: [golang.org](https://golang.org/)  
* Installation: [Getting Started](https://golang.org/doc/install)  
* Visual Studio Code extension: [Go Language Extension](https://code.visualstudio.com/docs/languages/go)  