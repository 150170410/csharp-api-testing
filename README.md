# REST API testing framework example in C#

As an example REST API I am using the [Google Books API](https://developers.google.com/books/docs/v1/reference/), so to eventually also add authorization related test cases. At the moment this is **work in progress**

Packages used:
* [NUnit](https://nunit.org/)<sup>1</sup>
* [FluentAssertions](https://fluentassertions.com/)
* [RestSharp](http://restsharp.org/)<sup>2</sup>

----

# Some future tasks #

[ ] <sup>1</sup>Add examples with [xUnit](https://xunit.net/) to see how much truth is in this article [NET Core 2: Why xUnit and not NUnit or MSTest](https://dev.to/hatsrumandcode/net-core-2-why-xunit-and-not-nunit-or-mstest--aei)

[ ] <sup>2</sup> Add examples and compare the native HTTP Client and also Flurl since it seems to offer certain interesting capabilities when compared to RestSharp as described in [this article](https://jeremylindsayni.wordpress.com/2018/12/27/comparing-restsharp-and-flurl-http-while-consuming-a-web-service-in-net-core/)
