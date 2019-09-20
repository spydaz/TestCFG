Imports TestCFG.ContextFreeGrammar.Rule

Public Class TestScreen
    Dim CFG As New TestCFG.ContextFreeGrammar
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim rules As List(Of ContextFreeGrammar.Rule) = CFG_Rules

        Console.WriteLine(rules.ToString)
        DisplayText(CFG.GenerateRandomSentencefromGramar(rules))
    End Sub

    Public Sub DisplayText(ByVal nText As String)
        TextBoxDisplay.Text = nText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Expansion As String = ""

        DisplayText(CFG.GenerateRandomSentence() & vbNewLine)
    End Sub
#Region "TOY GRAMMAR"
    ''' <summary>
    ''' Toy grammar for testing purposes
    ''' </summary>
    Public CFG_Rules As List(Of ContextFreeGrammar.Rule) = Add_TOY_GRAMMAR(CFG.StandardGrammar)
    ''' <summary>
    ''' Returns a Toy grammar to populate a ruleset, With basic grammar-set 
    ''' </summary>
    ''' <returns>Additions for standard grammarset (toy grmmar)</returns>
    Public Function Add_TOY_GRAMMAR(ByVal Grammar As List(Of ContextFreeGrammar.Rule)) As List(Of ContextFreeGrammar.Rule)
        Dim Toy_Grammar As List(Of ContextFreeGrammar.Rule) = Grammar


        Dim NewRule As New Rule


        'STANDARD
        Toy_Grammar = ContextFreeGrammar.Rule.AddRuleStr(Toy_Grammar, "DO", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "DID", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "DOES", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "BE", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "AM", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "IS", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "WERE", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "HAVE", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "HAS", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "HAD", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "COULD", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "SHOULD", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "MUST", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "MAY", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "MIGHT", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "WILL", "$VAV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "WOULD", "$VAV$")

        'STANDARD

        'STANDARD

        'STANDARD
        Toy_Grammar = AddRuleStr(Toy_Grammar, "!", "$PUNCT$")



        Toy_Grammar = AddRuleStr(Toy_Grammar, "THATS GREAT!", "$INTERJ$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "WOW AMAZING!", "$INTERJ$")

        Toy_Grammar = AddRuleStr(Toy_Grammar, "HOUSE", "$N$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "BED", "$PNP$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "LION", "$PN$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "DOG", "$PN$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "BOB", "$PNN$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "MAT", "$PNP$")



        Toy_Grammar = AddRuleStr(Toy_Grammar, "RIDE", "$V$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "CREEP", "$V$")

        Toy_Grammar = AddRuleStr(Toy_Grammar, "RED", "$ADJ$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "GREEN", "$ADJ$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "LARGE", "$ADJ$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "SMALL", "$ADJ$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "RAGING", "$ADJ$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "HUNTING", "$ADJ$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "FANTASTIC", "$ADJ$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "WONDERFUL", "$ADJ$")

        Toy_Grammar = AddRuleStr(Toy_Grammar, "BEFORE", "$PREP$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "AFTER", "$PREP$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "ABOVE", "$PREP$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "BELOW", "$PREP$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "IN", "$PREP$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "ON", "$PREP$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "OVER", "$PREP$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "OF", "$PREP$")


        Toy_Grammar = AddRuleStr(Toy_Grammar, "SLEEPS", "$VITV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "WALKS", "$VITV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "LAUGHS", "$VINTRA$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "SEES", "$VTV$")


        Toy_Grammar = AddRuleStr(Toy_Grammar, "SOFTLY", "$ADV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "BOLDLY", "$ADV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "HAPPILY", "$ADV$")
        Toy_Grammar = AddRuleStr(Toy_Grammar, "LOUDLY!", "$ADV$")
        Return Toy_Grammar
    End Function
#End Region
End Class
