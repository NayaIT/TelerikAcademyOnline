#XML

* __XML__ (e**X**tensible **M**arkup **L**anguage)
    * Universal language (notation) for describing structured data using text with tags
    * The data is stored together with the meta-data about it
    * Used to describe other languages (formats) for data representation

* __XML__ looks like __HTML__
    * Text based language, uses **tags** and **attributes**

* Worldwide standard
   * supported by the W3C - www.w3c.org
   
#Namespaces in the XML documents

* __Name Conflicts__
   * In __XML__, element names are defined by the developer. This often results in a conflict when trying to mix XML documents from different XML applications.

* __XML Namespaces__ provide a method to avoid element name conflicts
    * Name conflicts in __XML__ can easily be avoided using a name prefix
    * When using prefixes in __XML__, a namespace for the prefix must be defined

* The __namespace__ can be defined by an xmlns attribute in the start tag of an element
    * The namespace declaration has the following syntax. xmlns:prefix="URI".
    * The purpose of using an URI is to give the namespace a unique name.
