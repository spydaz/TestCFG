

'"S" ["NP VP", "Interj NP VP"],
'"NP": ["Det N", "Det N that VP", "Det Adj N", "Det N PP"],
'"PP": ["Prep NP"],
'"Prep": ["in", "on", "over", "against"],
'"VP": ["Vtrans NP", "Vintr"],
'"Interj": ["oh,", "my,", "wow,", "damn,"],
'"Det": ["this", "that", "the"],
'"N": ["amoeba", "dichotomy", "seagull", "trombone", "corsage", "restaurant", "suburb"],
'"Adj": ["bald", "smug", "important", "tame", "overstaffed", "luxurious", "blue"],
'"Vtrans": ["computes", "examines", "foregrounds", "prefers", "interprets", "spins"],
'"Vintr": ["coughs", "daydreams", "whines", "slobbers", "vocalizes", "sneezes"]

Public Class ContextFreeGrammar
    ''' <summary>
    ''' Toy grammar
    ''' </summary>
    Public Shared CFG_Rules As List(Of Rule) = Add_TOY_GRAMMAR()
    ''' <summary>
    ''' Standard grammar
    ''' </summary>
    Public Shared BASIC_GRAMMAR As List(Of Rule) = AddRules()



    Public Shared Function Add_TOY_GRAMMAR() As List(Of Rule)
        Dim TOY_GRAMMAR = New List(Of Rule)
        TOY_GRAMMAR.AddRange(AddPrepositionalPhrases)
        TOY_GRAMMAR.AddRange(AddNounPhrases)
        TOY_GRAMMAR.AddRange(AddSentences)
        Dim NewRule As New Rule

        NewRule.SentenceType.PartOfSpeech = "$N$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("HORSE")
        NewRule.SentenceStr.Add("LION")
        NewRule.SentenceStr.Add("MAN")
        NewRule.SentenceStr.Add("BOY")
        NewRule.SentenceStr.Add("Girl")
        NewRule.SentenceStr.Add("WOMAN")
        TOY_GRAMMAR.Add(NewRule)


        NewRule.SentenceType.PartOfSpeech = "$V$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("KICK")
        NewRule.SentenceStr.Add("KISS")
        NewRule.SentenceStr.Add("Purrs")
        NewRule.SentenceStr.Add("Barks")
        NewRule.SentenceStr.Add("Sleeps")
        NewRule.SentenceStr.Add("Runs")
        TOY_GRAMMAR.Add(NewRule)

        NewRule.SentenceType.PartOfSpeech = "$VP$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("MIGHT EAT")
        NewRule.SentenceStr.Add("MUST GO")
        TOY_GRAMMAR.Add(NewRule)

        NewRule.SentenceType.PartOfSpeech = "$DET$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("THE")
        NewRule.SentenceStr.Add("A")
        TOY_GRAMMAR.Add(NewRule)


        NewRule.SentenceType.PartOfSpeech = "$ADJ$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("Astonishing")
        NewRule.SentenceStr.Add("Fabulous")
        NewRule.SentenceStr.Add("Fantastic")
        NewRule.SentenceStr.Add("Wonderful")
        NewRule.SentenceStr.Add("Bald")
        NewRule.SentenceStr.Add("Smug")
        NewRule.SentenceStr.Add("Tame")
        NewRule.SentenceStr.Add("Raging")
        TOY_GRAMMAR.Add(NewRule)

        NewRule.SentenceType.PartOfSpeech = "$PREP$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("About")
        NewRule.SentenceStr.Add("Against")
        NewRule.SentenceStr.Add("For")
        NewRule.SentenceStr.Add("From")
        NewRule.SentenceStr.Add("Except")
        NewRule.SentenceStr.Add("Outside")
        TOY_GRAMMAR.Add(NewRule)

        NewRule.SentenceType.PartOfSpeech = "$PUNCT$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("!")
        NewRule.SentenceStr.Add(".")
        TOY_GRAMMAR.Add(NewRule)

        Return TOY_GRAMMAR
    End Function



    ''' <summary>
    ''' Adds Nouns to toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddNouns() As List(Of Rule)
        Dim NewRule As New Rule
        AddNouns = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$N$"
        NewRule.SentenceStr = New List(Of String)
        AddNouns.Add(NewRule)
    End Function
    ''' <summary>
    ''' Adds Toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddSentences() As List(Of Rule)
        Dim NewRule As New Rule
        AddSentences = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$S$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$DET$ $N$ $V$ $PUNCT$")
        NewRule.SentenceStr.Add("$NP$ $V$ $PUNCT$")
        AddSentences.Add(NewRule)
    End Function
    ''' <summary>
    ''' Prepositional phrases to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddPrepositionalPhrases() As List(Of Rule)
        Dim NewRule As New Rule
        AddPrepositionalPhrases = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$PP$"
        '"Prep": ["in", "on", "over", "against"],
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" $PREP$ $NP$")
        AddPrepositionalPhrases.Add(NewRule)
    End Function
    ''' <summary>
    ''' Prepositions to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddPrepositions() As List(Of Rule)
        Dim NewRule As New Rule
        AddPrepositions = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$PREP$"
        '"Prep": ["in", "on", "over", "against"],
        NewRule.SentenceStr = New List(Of String)
        AddPrepositions.Add(NewRule)
    End Function
    ''' <summary>
    ''' Adjectives to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddAdjectives() As List(Of Rule)
        Dim NewRule As New Rule
        AddAdjectives = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$ADJ$"
        NewRule.SentenceStr = New List(Of String)
        AddAdjectives.Add(NewRule)
    End Function
    ''' <summary>
    ''' Determiners to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddDeterminers() As List(Of Rule)
        Dim NewRule As New Rule
        AddDeterminers = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$DET$"
        NewRule.SentenceStr = New List(Of String)
        AddDeterminers.Add(NewRule)
    End Function
    ''' <summary>
    ''' NounPhrase to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddNounPhrases() As List(Of Rule)
        Dim NewRule As New Rule
        AddNounPhrases = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$NP$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" $DET$ $N$")
        NewRule.SentenceStr.Add(" $DET$ $N$ $PP$")
        NewRule.SentenceStr.Add(" $DET$ $ADJ$ $N$")
        AddNounPhrases.Add(NewRule)
    End Function
    ''' <summary>
    ''' Verbs to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddVerbs() As List(Of Rule)
        Dim NewRule As New Rule
        AddVerbs = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$V$"
        NewRule.SentenceStr = New List(Of String)
        AddVerbs.Add(NewRule)
    End Function
    ''' <summary>
    ''' verb phrases to be added (Toy) grammar
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddVerbPhrases() As List(Of Rule)
        Dim NewRule As New Rule
        AddVerbPhrases = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$VP$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" $V$ $NP$")
        NewRule.SentenceStr.Add(" $V$ $ADJ$")
        NewRule.SentenceStr.Add(" $V$ $NP$ %PP$")
        AddVerbPhrases.Add(NewRule)
    End Function
    ''' <summary>
    ''' Punctuation to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddPunctuation() As List(Of Rule)
        Dim NewRule As New Rule
        AddPunctuation = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$PUNCT$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(".")
        AddPunctuation.Add(NewRule)
    End Function
    ''' <summary>
    ''' Adds Toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddRules() As List(Of Rule)
        AddRules = New List(Of Rule)
        AddRules.AddRange(AddVerbs)
        AddRules.AddRange(AddNouns)
        AddRules.AddRange(AddSentences)
        AddRules.AddRange(AddPunctuation)
        AddRules.AddRange(AddAdjectives)
        AddRules.AddRange(AddDeterminers)
        AddRules.AddRange(AddNounPhrases)
        AddRules.AddRange(AddPrepositionalPhrases)
        AddRules.AddRange(AddPrepositions)
        AddRules.AddRange(AddVerbPhrases)
    End Function
    ''' <summary>
    ''' Rule set / Grammar
    ''' </summary>
    Public Structure Rule
        ''' <summary>
        ''' Gramar parameter
        ''' </summary>
        Public Structure SentenceComponent
            ''' <summary>
            ''' Grammar rule 
            ''' </summary>
            Public PartOfSpeech As String
        End Structure
        ''' <summary>
        ''' Grammar Rule parameter
        ''' </summary>
        Public SentenceType As SentenceComponent
        ''' <summary>
        ''' List of associated Words
        ''' </summary>
        Public SentenceStr As List(Of String)
    End Structure
    ''' <summary>
    ''' Adds Rule to Rule-set
    ''' </summary>
    ''' <param name="Rules">Grammar </param>
    ''' <param name="PartOfSpeech">Rule</param>
    ''' <param name="Word">WordList</param>
    ''' <returns></returns>
    Public Shared Function AddRule(ByRef Rules As List(Of Rule), ByRef PartOfSpeech As String, ByRef Word As String) As List(Of Rule)
        Dim NewRule As New Rule
        NewRule.SentenceType.PartOfSpeech = PartOfSpeech
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" " & Word)


        Rules.Add(NewRule)
        Return Rules
    End Function
    ''' <summary>
    ''' Gets Random item from list
    ''' </summary>
    ''' <param name="Item"></param>
    ''' <returns></returns>
    Public Shared Function GetRandomfromListStr(ByVal Item As List(Of String)) As String
        Dim value As Integer = 0
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        If Item.Count > 0 Then
            value = CInt(Int((Item.Count * Rnd())))
            Return Item(value)
        Else
            Return ""
        End If


    End Function
    ''' <summary>
    ''' Expands grammar to Words
    ''' </summary>
    ''' <param name="StartStr">Sentence containing gramar to be expanded</param>
    ''' <param name="Expansion">Expanded Sentence Grammar</param>
    ''' <returns>Expanded Sentence</returns>
    Private Shared Function Expand(ByRef StartStr As String, ByRef Expansion As String) As String
        Dim PickStr As String = ""
        For Each iRule In CFG_Rules
            If StartStr.Contains(iRule.SentenceType.PartOfSpeech) = True Then
                'If StartStr = iRule.SentenceType.PartOfSpeech = True Then
                Randomize()
                PickStr = GetRandomfromListStr(iRule.SentenceStr)
                StartStr = StartStr.Replace(iRule.SentenceType.PartOfSpeech, PickStr)

                For Each item In StartStr.Split(" ")
                    Expand(StartStr, Expansion)
                Next

                Console.WriteLine(Expansion)
            Else
                Expansion = StartStr
            End If
        Next
        Return Expansion
    End Function
    ''' <summary>
    ''' Uses Custom Grammar
    ''' </summary>
    ''' <param name="CustomRules">Custome Ruleset</param>
    ''' <param name="StartStr">Sentence Indicator Rule</param>
    ''' <param name="Expansion">Final String</param>
    ''' <returns></returns>
    Private Shared Function Expand(ByRef CustomRules As List(Of Rule), ByRef StartStr As String, ByRef Expansion As String) As String

        Dim PickStr As String = ""
        For Each iRule In CustomRules
            If StartStr.Contains(iRule.SentenceType.PartOfSpeech) = True Then
                'If StartStr = iRule.SentenceType.PartOfSpeech = True Then
                Randomize()
                PickStr = GetRandomfromListStr(iRule.SentenceStr)
                StartStr = StartStr.Replace(iRule.SentenceType.PartOfSpeech, PickStr)

                For Each item In StartStr.Split(" ")
                    Expand(StartStr, Expansion)
                Next

                Console.WriteLine(Expansion)
            Else
                Expansion = StartStr
            End If
        Next
        Return Expansion
    End Function
    ''' <summary>
    ''' Generates Output from Sentence Grammar String with custome grammar
    ''' </summary>
    ''' <param name="CFG">Grammar / Ruleset</param>
    ''' <returns>Expanded Sentence</returns>
    Public Shared Function GenerateRandomSentencefromGramar(ByRef CFG As List(Of Rule)) As String
        Return Expand(CFG, " $S$ ", "")

    End Function
    ''' <summary>
    ''' generates sentence with toy grammar
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GenerateRandomSentence() As String

        Return Expand(" $S$ ", "")
    End Function

End Class
