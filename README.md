# Junior Software Engineer in Platform home test

This code is an example of a very simple supermarket checkout. The supermarket sells on 4 items (A, B, C & D). The unit prices of these are below, including specials which also need to be considered.

|Item |  Unit Price | Special |
| ------------- |:-------------:| -----:|
|    A |     50 |      3 for 130 |
|    B |     30 |     2 for 45 |
|    C |     20 | max 6 items allowed|
|    D |     15 | |

We have already implented a Till (the Point of sale machine) class and have added some code that allows you to scan a number items as a string of characters and returns the total price to you, when you call the Total() function.

To test the code have added some unit tests.

We have not been able to implent all the features, and have decided to ship the more limited version of the product as soon as possible.

## Challenge

How would you improve the code, so that we can ship it to our first customers without implementing all the missing features? Though you can take as much time as you like, we don't really expect you to spend more than one hour at the most.

**We would like you give us the code, in a github repository, that you would be happy to ship.**

Feel to make any changes you like. This exercise is much more about what you think needs improving.

## Requirements

- This test needs .net core 3.1+ to run which you can download from [here](https://dotnet.microsoft.com/download).

### To build the code use the command `dotnet build`

e.g.

```
> dotnet build

Microsoft (R) Build Engine version 16.6.0+5ff7b0c9e for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  Checkout -> C:\dev\checkout\Checkout\bin\Debug\netcoreapp3.1\Checkout.dll
  Checkout.Tests -> C:\dev\checkout\Checkout.Tests\bin\Debug\netcoreapp3.1\Checkout.Tests.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.05
```

### To run the tests use the command `dotnet test`  

e.g.

```
>  dotnet test
Test run for C:\dev\checkout\Checkout.Tests\bin\Debug\netcoreapp3.1\Checkout.Tests.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.6.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.
  X Given_AB_TotalPrice_ShouldBe_80 [37ms]
  Error Message:
     Expected: 80.0d
  But was:  0.0d

  Stack Trace:
     at Checkout.Tests.ExampleTests.Given_AB_TotalPrice_ShouldBe_80() in C:\dev\checkout\Checkout.Tests\CheckoutTests.cs:line 45

  X Given_CDBA_TotalPrice_ShouldBe_115 [4ms]
  Error Message:
   System.Collections.Generic.KeyNotFoundException : The given key 'D' was not present in the dictionary.
  Stack Trace:
     at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at Checkout.Till.Scan(String items) in c:\dev\checkout\Checkout\Till.cs:line 77
   at Checkout.Tests.ExampleTests.Given_CDBA_TotalPrice_ShouldBe_115() in C:\dev\checkout\Checkout.Tests\CheckoutTests.cs:line 52
  X Given_TwoAAItems_TotalPrice_ShouldBe_110 [< 1ms]
  Error Message:
   System.Collections.Generic.KeyNotFoundException : The given key 'a' was not present in the dictionary.
  Stack Trace:
     at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at Checkout.Till.Scan(String items) in c:\dev\checkout\Checkout\Till.cs:line 77
   at Checkout.Tests.ExampleTests.Given_TwoAAItems_TotalPrice_ShouldBe_110() in C:\dev\checkout\Checkout.Tests\CheckoutTests.cs:line 100
  X Given_TwoItemsOfTypeA_TotalPrice_ShouldBe_100 [1ms]
  Error Message:
     Expected: 100
  But was:  150.0d

  Stack Trace:
     at Checkout.Tests.ExampleTests.Given_TwoItemsOfTypeA_TotalPrice_ShouldBe_100() in C:\dev\checkout\Checkout.Tests\CheckoutTests.cs:line 65


Test Run Failed.
Total tests: 7
     Passed: 3
     Failed: 4
 Total time: 1.0073 Seconds
 ```
