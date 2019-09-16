Public Class TestScreen
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayText(CFG.GenerateRandomSentence() & vbNewLine)
    End Sub

    Public Sub DisplayText(ByVal nText As String)
        TextBoxDisplay.Text = nText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewStart As String = " S "



        Dim Expansion As String = ""

        DisplayText(CFG.GenerateRandomSentence() & vbNewLine)
    End Sub
End Class
