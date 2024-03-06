Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports PrjTekstiOmadused

<TestClass()> Public Class EkraaniVormTest
    <TestMethod()> Public Sub EkraaniVorm_BoolFalse_VastusStringEi()
        Dim palindroom As New PrjTekstiOmadused.EkraaniVorm
        Dim test = palindroom.PalindroomVastus(False)

        Assert.AreEqual("Ei", test)

    End Sub
    <TestMethod()> Public Sub EkraaniVorm_BoolTrue_VastusStringJah()
        Dim palindroom As New PrjTekstiOmadused.EkraaniVorm
        Dim test = palindroom.PalindroomVastus(True)

        Assert.AreEqual("Jah", test)

    End Sub

End Class