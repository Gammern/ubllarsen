UBL Larsen
-----------
UBL Larsen is a library of classes that can be streamed to/from "UBL 2.1" compliant 
xml files by System.Xml.XmlSerializer. Knowledge of XmlSerialiser is preffered in order to 
understand how class instances can be converted from/to xml without fiddly parsing.
http://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlserializer.aspx

A similar library like UBL Larsen can be made by using Microsoft tool "xsd.exe" and xsd files 
from http://docs.oasis-open.org/ubl/. However, everything gets piled up in one sourcefile 
and documentation comments from the xsd files are lost.

Requirements: Visual Studio #2015, C# .NET4.5++

UBL Version: 2.1


Compiling the library
----------------------
Project UblLarsen.Ubl contains all the sourcefiles required to compile the library. 
The following files are generated in bin\Debug or bin\Release when you compile.

UblLarsen.Ubl2.dll                The library
UblLarsen.Ubl2.xml                Documentation file for Visual Studio popup intellisence.

The post build event contain a rem'ed out command for generating the precompiled version 
of the library by using sgen.exe. The library should work without it but you may notice 
a small delay first time a type is serialized. 

UBL Generator
--------------
Project ublxsd generates the sourcefiles for the libary above.

Unit test
----------
select testsettings file named "Local.testsettings" before running tests. 
Most of the unit tests deserialize xml documents made by Oasis to an UBL Larsen class instance. 
This instance is then serialized back to xml and compared with the original using XmlDiffPatch.
http://msdn.microsoft.com/en-us/library/aa302294.aspx
Adding you own test for other documents types is simple. Have a look at UblDocLoadTest.cs.

"xs:time" is treated as a string and can handle all datetimekinds. 
Have a look at common/UBL-UnqualifiedDataTypes-2.1.partial.cs
Set your own dateformat if you are unhappy with the ones supplied.


Using the library
------------------
In your project "Add Reference..." to UblLarsen.Ubl2.dll. Browse to the location where it got built.
in your source file add "using UblLarsen.Ubl2;".
Add references to the other namespaces as required. VS2015 IDE will make helpfull suggestions.

The file UblDoc.cs in UblLarsen.Test project contain some helpfull C# code for reading/writing 
xml files using XmlSerializer. Requirement if you want to control namspace prefixes.


IT IS FREE!
------------
The library is free because I do not have time nor resources to give any product support. 
I don't even sell support. It is not part of my business model. 

Hvalstad, Norway 2016'ish
