﻿

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

#Region "iNTERNAL GRAMMAR"
    ''' <summary>
    ''' Standard grammar
    ''' </summary>
    Private BASIC_GRAMMAR As List(Of Rule) = AddRules()
    ''' <summary>
    ''' USED AS A STANDARD TEMPLATE FOR CREATING GRAMAR-SET ;
    ''' THIS IS A UNPOPULATED SET, EACH TERM REQUIRES AT LEAST 2 WORD STRINGS
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property StandardGrammar As List(Of Rule)
        Get
            Return BASIC_GRAMMAR
        End Get
    End Property
#End Region

#Region "TOY GRAMMAR"
    ''' <summary>
    ''' Toy grammar for testing purposes
    ''' </summary>
    Public CFG_Rules As List(Of Rule) = Add_TOY_GRAMMAR()
    ''' <summary>
    ''' Returns a Toy grammar to populate a ruleset, With basic grammar-set 
    ''' </summary>
    ''' <returns>Additions for standard grammarset (toy grmmar)</returns>
    Public Function Add_TOY_GRAMMAR() As List(Of Rule)
        Dim TOY_GRAMMAR As List(Of Rule) = AddRules()

        Dim NewRule As New Rule


        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "HORSE", "$N$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "DOG", "$N$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "CAT", "$N$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "LION", "$N$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "TIGER", "$N$")

        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "KICKS", "$V$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "ROARS", "$V$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BARKS", "$V$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "PURRS", "$V$")

        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "MIGHT EAT", "$VP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "MIGHT BITE", "$VP$")

        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "THE", "$DET$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "A", "$DET$")


        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "RAGING", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "HUNTING", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "FANTASTIC", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "WONDERFUL", "$ADJ$")

        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BEFORE", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "AFTER", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "ABOVE", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BELOW", "$PREP$")

        NewRule.SentenceType.PartOfSpeech = "$PUNCT$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("!")
        NewRule.SentenceStr.Add(".")
        TOY_GRAMMAR.Add(NewRule)

        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, ".", "$PUNCT$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, ".", "$PUNCT$")
        Return TOY_GRAMMAR
    End Function
#End Region

#Region "Internal Grammar"
    ''' <summary>
    ''' Adds Nouns to toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Function AddNouns() As List(Of Rule)
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
    Private Function AddSentences() As List(Of Rule)
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
    Private Function AddPrepositionalPhrases() As List(Of Rule)
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
    Private Function AddPrepositions() As List(Of Rule)
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
    Private Function AddAdjectives() As List(Of Rule)
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
    Private Function AddDeterminers() As List(Of Rule)
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
    Private Function AddNounPhrases() As List(Of Rule)
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
    Private Function AddVerbPhrases() As List(Of Rule)
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
    Private Function AddPunctuation() As List(Of Rule)
        Dim NewRule As New Rule
        AddPunctuation = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$PUNCT$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add(".")
        AddPunctuation.Add(NewRule)
    End Function
    ''' <summary>
    ''' Adds Internal Grammar 
    ''' </summary>
    ''' <returns></returns>
    Private Function AddRules() As List(Of Rule)
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
#End Region


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

#Region "MAIN ALGORITHYM"
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
            Randomize()
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
    Private Function Expand(ByRef StartStr As String, ByRef Expansion As String) As String
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
    Private Function Expand(ByRef CustomRules As List(Of Rule), ByRef StartStr As String, ByRef Expansion As String) As String

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
#End Region

#Region "FUNCTIONS"
    ''' <summary>
    ''' Adds The basic Grammar to given rules
    ''' </summary>
    ''' <returns></returns>
    Public Function AddRules(ByRef Rules As List(Of Rule)) As List(Of Rule)
        Rules.AddRange(AddVerbs)
        Rules.AddRange(AddNouns)
        Rules.AddRange(AddSentences)
        Rules.AddRange(AddPunctuation)
        Rules.AddRange(AddAdjectives)
        Rules.AddRange(AddDeterminers)
        Rules.AddRange(AddNounPhrases)
        Rules.AddRange(AddPrepositionalPhrases)
        Rules.AddRange(AddPrepositions)
        Rules.AddRange(AddVerbPhrases)
        Return Rules
    End Function
    Public Function GenerateRandomSentencefromGramar(ByRef CFG As List(Of Rule)) As String
        Randomize()
        Return Expand(CFG, " $S$ ", "")

    End Function
    ''' <summary>
    ''' generates sentence with Internal Grammar CFG_RULES
    ''' </summary>
    ''' <returns></returns>
    Public Function GenerateRandomSentence() As String
        Randomize()
        Return Expand(" $S$ ", "")
    End Function
    ''' <summary>
    ''' Adds a string to a existing rule; Rules must not be duplicated, all rules must have at least 1 string
    ''' </summary>
    ''' <param name="Rules">ruleset / grammar</param>
    ''' <param name="Str">string to be added / Word / Phrase</param>
    ''' <param name="PartOfSpeech">Part of Speech to be added to (in custom rulesets this can be a userdefined PartofSpeech)</param>
    ''' <returns>Populated ruleset</returns>
    Public Function AddRuleStr(ByRef Rules As List(Of Rule), ByRef Str As String, ByRef PartOfSpeech As String) As List(Of Rule)
        For Each item In Rules
            If item.SentenceType.PartOfSpeech = PartOfSpeech = True Then
                item.SentenceStr.Add(Str)
            Else
            End If
        Next
        Return Rules
    End Function
#End Region

End Class
