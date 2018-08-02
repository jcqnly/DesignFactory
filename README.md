# Design Patterns
Design a document making process.  Create an abstract class, derive a concrete 
class.  Create an abstract class for the creation of previous class and then 
derive a concrete class from it.

---
#### Type of Document
The type of document used is Reports.

#### Concrete object of the Document
The 2 concrete objects of Reports are News and Science.

#### Type of Creator
The type of creator is ReportStore.

#### Concrete object of the Creator
The ReportFactory is the concrete object.  It calls ReportStand in order 
to create and order a report.

## Dependencies
This exercise runs on .NET Core 2.1, which can be downloaded [here](https://www.microsoft.com/net/download/macos).

---
## Build
After installing the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/macos), clone this repo onto your machine. From a terminal interface, go to where this was cloned and type the following commands:

```
cd DesignFactory
dotnet restore
dotnet run
```

---

## Screenshots
![Console Messages](/assets/DesignPatterns.png)