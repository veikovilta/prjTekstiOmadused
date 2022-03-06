Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CTekstiPoorajaTestid

    <TestMethod()> Public Sub PooraFunktsiooniga_YksSona_VastusPooratudSona()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("abcxyz")
        Assert.AreEqual(vastus, "zyxcba")
    End Sub

    <TestMethod()> Public Sub PooraFunktsiooniga_TyhiString_VastusTyhiString()
        Dim pooraja As New PrjTekstiOmadused.CTekstiPooraja
        Dim vastus = pooraja.PooraFunktsiooniga("")
        Assert.AreEqual(vastus, "")
    End Sub


End Class