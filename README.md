# UBL Larsen
This is a C# class library for streaming [Universal Business Language](https://en.wikipedia.org/wiki/Universal_Business_Language) V 2.1 xml documents. No xml parsing or DOM traversal is needed. All that tedious work is taken care of by [XmlSerializer](https://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlserializer.aspx). 

An older version (UBL 2.0) of this project was previously hosted on [CodePlex](http://ubllarsen.codeplex.com/).

# Using the library
All ubl types are contained in library project UblLarsen.Ubl2. Compile it. Use the "Add reference ..." option in your own project and locate UblLarsen.Ubl2.dll produced in the bin output folder during compile.

# Status
I have not looked into Extensions and xml document signatures. Don't know what to do yet. That is why three of the integration test exit with Assert.Inconclusive. Hopefully I will be able to recreate all of the xml sample files provided by [oasis](http://docs.oasis-open.org/ubl/os-UBL-2.1/UBL-2.1.html) by using C# code. 

Open an [Issue](https://github.com/Gammern/ubllarsen/issues) if you have any questions. Do try out the included samples first.
