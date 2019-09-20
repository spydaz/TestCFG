Public Class QuestionGenerator
    Inherits ContextFreeGrammar
    Private Questions As New List(Of Rule)
    Private Shared Function AddWhat() As List(Of Rule)
        Dim NewRule As New Rule
        AddWhat = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$WHAT$"

        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("What")

        AddWhat.Add(NewRule)
    End Function
    Private Shared Function AddWhy() As List(Of Rule)
        Dim NewRule As New Rule
        AddWhy = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$WHY$"

        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" Why")

        AddWhy.Add(NewRule)
    End Function
    Private Shared Function AddWhen() As List(Of Rule)
        Dim NewRule As New Rule
        AddWhen = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$WHEN$"

        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("When")

        AddWhy.Add(NewRule)
    End Function
    Private Shared Function AddWho() As List(Of Rule)
        Dim NewRule As New Rule
        AddWho = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$WHO$"

        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("Who")

        AddWho.Add(NewRule)
    End Function
    Private Shared Function AddWhere() As List(Of Rule)
        Dim NewRule As New Rule
        AddWhere = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$WHERE$"

        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("Where")

        AddWhere.Add(NewRule)
    End Function
    Private Shared Function AddHow() As List(Of Rule)
        Dim NewRule As New Rule
        AddHow = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$HOW$"

        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("How")

        AddHow.Add(NewRule)
    End Function
    'S → Wh-NP VP
End Class

'where (place), when (time), why (reason), who (person). 
'auxiliary verb	+	subject	+	main verb
