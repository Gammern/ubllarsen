# UBL Larsen
This is a C# class library for streaming [Universal Business Language](https://en.wikipedia.org/wiki/Universal_Business_Language) V 2.1 xml documents. No xml parsing or DOM traversal is needed. All that tedious fiddling is taken care of by [XmlSerializer](https://msdn.microsoft.com/en-us/library/system.xml.serialization.xmlserializer.aspx). 

An older version (UBL 2.0) of this project was previously hosted at [CodePlex](http://ubllarsen.codeplex.com/).

# Using the library
All ubl types are contained in library project UblLarsen.Ubl2. Compile it. To use it in you own project, use the "Add reference ..." option and locate UblLarsen.Ubl2.dll produced in the bin output folder during compile.

# Status
Extensions and document signatures support are missing. 3 of the integration tests do not work properly.

Open an [Issue](https://github.com/Gammern/ubllarsen/issues) if you have any questions.
