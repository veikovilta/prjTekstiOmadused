<TestClass()> Public Class CtekstiOmadusedTest

    <DataRow("aas", 2)>
    <DataRow("aasa", 3)>
    <DataTestMethod()> Public Sub LoeTaishaalikuteArv_TestideKomplekt(sisend, oodatavVastus)
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused(sisend)
        Dim vastus = testija.intTaishaalikuteArv

        Assert.AreEqual(oodatavVastus, vastus)
    End Sub

    <TestMethod()> Public Sub KontrolliJärjestust()
        Dim test As String = "a1"
        Dim testija As New PrjTekstiOmadused.CTekstiOmadused(test)
        Dim vastus = testija.JarjestaTahemargidNumbrid("1aaa1")

        Assert.AreEqual("aaa11", vastus)
    End Sub

End Class
