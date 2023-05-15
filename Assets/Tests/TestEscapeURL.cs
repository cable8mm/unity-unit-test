using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestEscapeURL
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestEscapeURLSimplePasses()
    {
        // Arrange
        string originalString = "https://one.com/escape?this=that&and=theother thing";

        // Act
        string expectedString = UnityEngine.Networking.UnityWebRequest.EscapeURL(originalString);

        // Assert
        Assert.AreEqual(expectedString, originalString);

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestEscapeURLWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
