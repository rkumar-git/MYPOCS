# MYPOCS
POCs Developed for TFG - Rameshkumar Madhavakurup
================================================================================
01: Context Injection feature implementation with SpecFlow.
Solution Name: RapidApp-CT-Solution
IDE: Visual Studio
BDD Tool: SpecFlow
Language: C#
GitPath:https://github.com/rkumar-git/MYPOCS/
		https://github.com/rkumar-git/MYPOCS/tree/master/BDDTestautomation/sample
================================================================================
Automated Acceptance testing is important milestone in Acceptance Test Driven Development. The automation tools like SpecFlow and Selenium playing an active role in automated acceptance driven test scenarios in the Agile projects.

Problem Statement:
In the Acceptance Test Driven Development with SpecFlow and WebDriver, throwing exception during the test run, which indicates the non-availability of WebDriver to perform the Test. Since, once the instance of WebDriver shared across the step definitions for execution, WebDriver  availability is getting nullified and getting "WebDriver" not available exception.

Solution:
SpecFlow have the luxury of "Context Injection" feature, which support to share the WebDriver instance across the step definition. 

Context Injection:
The Context Injection feature will instantiate and inject class instance for the scenarios. It groups the shared state to Context-classes, and inject them into every binding class that is interested in that shared state. The context injection designed to share data between two step definitions. The two most important rule for Context Injection are
•	The life time of an injected object is limited to the scenarios execution. If the injected object is implemented IDisposible, they will be disposed after the scenario execution.
•	Within one scenario execution, same instance of the object will be shared across the step definitions.

=========================================================================================
#Project #2: 
AutoTestMate - POC on PageObjectModel Design Pattern to develop Test Automation Framework
Solution developed to send a client as part of project request.
=========================================================================================
About the Implementation:
Page Object Model Design Patten with Visual Studio C# & Selenium WebDriver
=========================================================================================
Implementation details
=========================================================================================
01. POM Design pattern
02. PageFatory Implementation to Optimize page elements
03. Generic Web Driver class (ManageWebDriver)
04. Generic Library class for WebDriver Interaction (SelenseSync)
05. Page Object Classes (LoginPage, AccountOverviewPage, CartPage)
05. Test Cases - LoginTest, CartTest
06. App.config
More details can find in a Technical presentation named 
POM-DesignPattern-ImplementationWithC#-V1, uploaded in MYPOCS\AutoTestMate\Docs