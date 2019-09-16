
Public Class CFG
    Private Shared CFG_Rules As List(Of Rule) = AddRules()
    Private Shared Function AddNouns() As List(Of Rule)
        Dim NewRule As New Rule
        AddNouns = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = " N"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" CAT")
        NewRule.SentenceStr.Add(" DOG")
        NewRule.SentenceStr.Add(" HORSE")
        NewRule.SentenceStr.Add(" LION")
        AddNouns.Add(NewRule)
    End Function
    Private Shared Function AddSentences() As List(Of Rule)
        Dim NewRule As New Rule
        AddSentences = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = " S "

        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("THE N V")
        AddSentences.Add(NewRule)
    End Function
    Private Shared Function AddVerbs() As List(Of Rule)
        Dim NewRule As New Rule
        AddVerbs = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = " V"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" BARK")
        NewRule.SentenceStr.Add(" PURR")
        NewRule.SentenceStr.Add(" ROARS")
        NewRule.SentenceStr.Add(" CRYS")
        AddVerbs.Add(NewRule)
    End Function
    Private Shared Function AddRules() As List(Of Rule)
        AddRules = New List(Of Rule)
        AddRules.AddRange(AddVerbs)
        AddRules.AddRange(AddNouns)
        AddRules.AddRange(AddSentences)
    End Function
    Public Structure Rule
        Public Structure SentenceComponent
            Public PartOfSpeech As String
        End Structure
        Public SentenceType As SentenceComponent
        Public SentenceStr As List(Of String)
    End Structure
    Public Shared Function AddRule(ByRef Rules As List(Of Rule), ByRef PartOfSpeech As String, ByRef Word As String) As List(Of Rule)
        Dim NewRule As New Rule
        NewRule.SentenceType.PartOfSpeech = PartOfSpeech
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" " & Word)


        Rules.Add(NewRule)
        Return Rules
    End Function
    Public Shared Function GetRandomfromListStr(ByVal Item As List(Of String)) As String

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((Item.Count * Rnd())))
        Return Item(value)
    End Function
    Private Shared Function Expand(ByRef StartStr As String, ByRef Expansion As String) As String
        For Each iRule In CFG_Rules
            If StartStr.Contains(iRule.SentenceType.PartOfSpeech) = True Then
                'If StartStr = iRule.SentenceType.PartOfSpeech = True Then
                Randomize()
                Dim PickStr As String = GetRandomfromListStr(iRule.SentenceStr)
                StartStr = StartStr.Replace(iRule.SentenceType.PartOfSpeech, PickStr)

                For Each item In StartStr.Split(" ")
                    Expand(StartStr, Expansion)
                Next

                Console.WriteLine(Expansion)
            Else
                Expansion = " " & StartStr
            End If
        Next
        Return Expansion
    End Function
    Private Shared Function Expand(ByRef CustomRules As List(Of Rule), ByRef StartStr As String, ByRef Expansion As String) As String


        For Each iRule In CustomRules
            If StartStr.Contains(iRule.SentenceType.PartOfSpeech) = True Then
                'If StartStr = iRule.SentenceType.PartOfSpeech = True Then
                Randomize()
                Dim PickStr As String = GetRandomfromListStr(iRule.SentenceStr)
                StartStr = StartStr.Replace(iRule.SentenceType.PartOfSpeech, PickStr)

                For Each item In StartStr.Split(" ")
                    Expand(StartStr, Expansion)
                Next

                Console.WriteLine(Expansion)
            Else
                Expansion = " " & StartStr
            End If
        Next
        Return Expansion
    End Function
    Public Shared Function GenerateRandomSentencefromGramar(ByRef CFG As List(Of Rule)) As String
        Return Expand(CFG, " S ", "")

    End Function
    Public Shared Function GenerateRandomSentence() As String
        Return Expand(" S ", "")

    End Function
End Class
