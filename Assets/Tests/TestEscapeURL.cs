using System;
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
        string originalString = "*아래는 단말기 정보입니다.삭제하지 말고 전송해주세요" + System.Environment.NewLine
            + "- OS : {0}" + System.Environment.NewLine
            + "- DeviceModel : {1}" + System.Environment.NewLine
            + "- SystemLanguage : {2}" + System.Environment.NewLine
            + "- Version : {3}" + System.Environment.NewLine
            + "- Nickname : {4}" + System.Environment.NewLine
            + "- UserCode : {5}";

        // https://www.urlencoder.org/
        // 원문은 하래와 같습니다.
        // *아래는 단말기 정보입니다.삭제하지 말고 전송해주세요
        // - OS : {0}
        // - DeviceModel : {1}
        // - SystemLanguage : {2}
        // - Version : {3}
        // - Nickname : {4}
        // - UserCode : {5}
        string expectedString = "%2A%EC%95%84%EB%9E%98%EB%8A%94%20%EB%8B%A8%EB%A7%90%EA%B8%B0%20%EC%A0%95%EB%B3%B4%EC%9E%85%EB%8B%88%EB%8B%A4.%EC%82%AD%EC%A0%9C%ED%95%98%EC%A7%80%20%EB%A7%90%EA%B3%A0%20%EC%A0%84%EC%86%A1%ED%95%B4%EC%A3%BC%EC%84%B8%EC%9A%94%0A-%20OS%20%3A%20%7B0%7D%0A-%20DeviceModel%20%3A%20%7B1%7D%0A-%20SystemLanguage%20%3A%20%7B2%7D%0A-%20Version%20%3A%20%7B3%7D%0A-%20Nickname%20%3A%20%7B4%7D%0A-%20UserCode%20%3A%20%7B5%7D";

        // Act
        string escapedURL = Uri.EscapeDataString(originalString);

        // Assert
        Assert.AreEqual(expectedString, escapedURL);
    }
}
