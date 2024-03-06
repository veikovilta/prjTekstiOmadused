Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CtekstiPoorajaTest

    <TestMethod()> Public Sub CtesktiPooraja_YksSone_VastusPooratudSone()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("meow")
        Assert.AreEqual("woem", vastus)
    End Sub

    <TestMethod()> Public Sub CtesktiPooraja_TuhiString_VastusTuhiString()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("")
        Assert.AreEqual("", vastus)
    End Sub

End Class