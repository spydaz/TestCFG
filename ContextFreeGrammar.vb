

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
    Private Shared CFG_Rules As List(Of Rule) = AddRules()
    ''' <summary>
    ''' Adds Nouns to toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddNouns() As List(Of Rule)
        Dim NewRule As New Rule
        AddNouns = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$N$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" CAT")
        NewRule.SentenceStr.Add(" DOG")
        NewRule.SentenceStr.Add(" HORSE")
        NewRule.SentenceStr.Add(" LION")
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
        NewRule.SentenceStr.Add(" IN")
        NewRule.SentenceStr.Add(" ON")
        NewRule.SentenceStr.Add(" AGAINST")
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
        '"Adj": ["bald", "smug", "important", "tame", "overstaffed", "luxurious", "blue"],
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(" BALD")
        NewRule.SentenceStr.Add(" SMUG")
        NewRule.SentenceStr.Add(" TAME")
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
        NewRule.SentenceStr.Add(" The")
        NewRule.SentenceStr.Add(" This")
        NewRule.SentenceStr.Add(" That")

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
        NewRule.SentenceStr.Add(" BARK")
        NewRule.SentenceStr.Add(" PURR")
        NewRule.SentenceStr.Add(" ROARS")
        NewRule.SentenceStr.Add(" CRYS")
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

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((Item.Count * Rnd())))
        Return Item(value)
    End Function
    ''' <summary>
    ''' Expands grammar to Words
    ''' </summary>
    ''' <param name="StartStr">Sentence containing gramar to be expanded</param>
    ''' <param name="Expansion">Expanded Sentence Grammar</param>
    ''' <returns>Expanded Sentence</returns>
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
        Return Expand(CFG, "$S$", "")

    End Function
    ''' <summary>
    ''' generates sentence with toy grammar
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GenerateRandomSentence() As String
        Return Expand("$S$", "")
    End Function
End Class
