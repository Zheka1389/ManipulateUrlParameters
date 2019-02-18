using System;
using NUnit.Framework;

namespace ManipulateUrlParameters
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase("www.example.com", "key=value", ExpectedResult = "www.example.com?key=value")]
        [TestCase("www.example.com?key=value", "key2=value2", ExpectedResult = "www.example.com?key=value&key2=value2")]
        [TestCase("www.example.com?key=oldValue`", "key=newValue", ExpectedResult = "www.example.com?key=newValue")]
        [TestCase("http://example.com/", "ID=1234", ExpectedResult = "http://example.com/?ID=1234")]
        [TestCase("http://example.com?ID=666", "ID=1234", ExpectedResult = "http://example.com?ID=1234")]
        [TestCase("http://example.com?Name=Allan", "ID=1234", ExpectedResult = "http://example.com?Name=Allan&ID=1234")]
        public static string AllCharactersAreUniqueTests(string url, string param) => ManipulateUrlParameters.AddOrChangeUrlParameter(url, param);
   
    }
}
