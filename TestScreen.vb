Public Class TestScreen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rules As List(Of ContextFreeGrammar.Rule) = ContextFreeGrammar.CFG_Rules

        Console.WriteLine(rules)
        DisplayText(ContextFreeGrammar.GenerateRandomSentencefromGramar(rules))
    End Sub

    Public Sub DisplayText(ByVal nText As String)
        TextBoxDisplay.Text = nText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewStart As String = " $S$ "



        Dim Expansion As String = ""

        DisplayText(ContextFreeGrammar.GenerateRandomSentence() & vbNewLine)
    End Sub
End Class
