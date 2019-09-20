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
'"Vdintr": ["GAVE",]
Public Class ContextFreeGrammar
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


        'STANDARD
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "DO", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "DID", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "DOES", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BE", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "AM", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "IS", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "WERE", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "HAVE", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "HAS", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "HAD", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "COULD", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "SHOULD", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "MUST", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "MAY", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "MIGHT", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "WILL", "$VAV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "WOULD", "$VAV$")

        'STANDARD

        'STANDARD

        'STANDARD
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "!", "$PUNCT$")



        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "THATS GREAT!", "$INTERJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "WOW AMAZING!", "$INTERJ$")

        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "HOUSE", "$N$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BED", "$PNP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "LION", "$PN$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "DOG", "$PN$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BOB", "$PNN$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "MAT", "$PNP$")



        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "RIDE", "$V$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "CREEP", "$V$")

        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "RED", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "GREEN", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "LARGE", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "SMALL", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "RAGING", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "HUNTING", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "FANTASTIC", "$ADJ$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "WONDERFUL", "$ADJ$")

        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BEFORE", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "AFTER", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "ABOVE", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BELOW", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "IN", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "ON", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "OVER", "$PREP$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "OF", "$PREP$")


        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "SLEEPS", "$VITV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "WALKS", "$VITV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "LAUGHS", "$VINTRA$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "SEES", "$VTV$")


        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "SOFTLY", "$ADV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "BOLDLY", "$ADV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "HAPPILY", "$ADV$")
        TOY_GRAMMAR = AddRuleStr(TOY_GRAMMAR, "LOUDLY!", "$ADV$")
        Return TOY_GRAMMAR
    End Function
#End Region

#Region "Internal Grammar"
    ''' <summary>
    ''' Adds Internal Grammar 
    ''' </summary>
    ''' <returns></returns>
    Private Function AddRules() As List(Of Rule)
        AddRules = New List(Of Rule)
        AddRules.AddRange(AddVerbs)
        AddRules.AddRange(AddNouns)
        AddRules.AddRange(AddDitransitiveVerb)
        AddRules.AddRange(AddTransitiveVerb)
        AddRules.AddRange(AddInTransitiveVerb)
        AddRules.AddRange(AddConjunctions)
        AddRules.AddRange(AddInterjections)
        AddRules.AddRange(AddAuxVerbs)
        AddRules.AddRange(AddSentences)
        AddRules.AddRange(AddPunctuation)
        AddRules.AddRange(AddAdjectives)
        AddRules.AddRange(AddDeterminers)
        AddRules.AddRange(AddNounPhrases)
        AddRules.AddRange(AddPrepositionalPhrases)
        AddRules.AddRange(AddPrepositions)
        AddRules.AddRange(AddVerbPhrases)
        AddRules.AddRange(AddAdVerb)
        AddRules.AddRange(AddParticipleVerb)
        AddRules.AddRange(AddProperNouns)
        AddRules.AddRange(AddProperNoun_Name)
        AddRules.AddRange(AddProperNoun_Place)
    End Function

#Region "Sentence components"
    ''' <summary>
    ''' Adds Toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Function AddSentences() As List(Of Rule)
        Dim NewRule As New Rule
        AddSentences = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$S$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$NP$ $VP$ $PUNCT$")
        NewRule.SentenceStr.Add("$NP$ $CONJ$ $VP$ $PUNCT$")
        'NewRule.SentenceStr.Add("$NP$ $VAV$ $VP$ $PUNCT$")
        'NewRule.SentenceStr.Add("$NP$ $VP$, $PP$ $PUNCT$")
        'NewRule.SentenceStr.Add("$NP$ $PP$, $VP$ $PUNCT$")
        'NewRule.SentenceStr.Add("$VAV$ $NP$ $VP$ ?")
        'NewRule.SentenceStr.Add("WHO $VAV$ $NP$ $VP$ ?")
        'NewRule.SentenceStr.Add("WHAT $VAV$ $NP$ $VP$ ?")
        'NewRule.SentenceStr.Add("WHY $VAV$ $NP$ $VP$ ?")
        'NewRule.SentenceStr.Add("WHEN $VAV$ $NP$ $VP$ ?")
        'NewRule.SentenceStr.Add("WHERE $VAV$ $NP$ $VP$ ?")
        'NewRule.SentenceStr.Add("WHICH $VAV$ $NP$ $VP$ ?")
        'NewRule.SentenceStr.Add("HOW $VAV$ $NP$ $VP$ ?")
        AddSentences.Add(NewRule)
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
#End Region

#Region "Extra Components"
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
        NewRule.SentenceStr.Add("$PREP$ $NP$")
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
    ''' CONJUNCTIONS
    ''' </summary>
    ''' <returns></returns>
    Private Function AddConjunctions() As List(Of Rule)
        Dim NewRule As New Rule
        AddConjunctions = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$CONJ$"
        NewRule.SentenceStr = New List(Of String)
        AddConjunctions.Add(NewRule)
        'Standards
        AddConjunctions = AddRuleStr(AddConjunctions, "BUT", "$CONJ$")
        AddConjunctions = AddRuleStr(AddConjunctions, "AND", "$CONJ$")
        AddConjunctions = AddRuleStr(AddConjunctions, "OR", "$CONJ$")
    End Function

    ''' <summary>
    ''' INTERJECTIONS 
    ''' </summary>
    ''' <returns></returns>
    Private Function AddInterjections() As List(Of Rule)
        Dim NewRule As New Rule
        AddInterjections = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$INTERJ$"
        NewRule.SentenceStr = New List(Of String)
        AddInterjections.Add(NewRule)
        AddInterjections = AddRuleStr(AddInterjections, "WOW", "$INTERJ$")
    End Function

#End Region

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
        'Default (Singular)
        AddDeterminers = AddRuleStr(AddDeterminers, "THE", "$DET$")
        AddDeterminers = AddRuleStr(AddDeterminers, "A", "$DET$")
    End Function

#Region "Prime Grammar components"
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
#Region "NOUNS"
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
    ''' NounPhrase to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Function AddNounPhrases() As List(Of Rule)
        Dim NewRule As New Rule
        AddNounPhrases = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$NP$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$DET$ $N$")
        NewRule.SentenceStr.Add("$DET$ $PN$")
        NewRule.SentenceStr.Add("$PNN$")
        NewRule.SentenceStr.Add("$DET$ $PNP$")
        NewRule.SentenceStr.Add("$DET$ $ADJ$ $N$")
        NewRule.SentenceStr.Add("$NP$ $CONJ$ $N$,")
        AddNounPhrases.Add(NewRule)
    End Function

    ''' <summary>
    ''' Adds Nouns to toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Function AddProperNouns() As List(Of Rule)
        Dim NewRule As New Rule
        AddProperNouns = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$PN$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$N$")
        AddProperNouns.Add(NewRule)
    End Function

    ''' <summary>
    ''' Adds Nouns to toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Function AddProperNoun_Name() As List(Of Rule)
        Dim NewRule As New Rule
        AddProperNoun_Name = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$PNN$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$N$")
        AddProperNoun_Name.Add(NewRule)
    End Function
    ''' <summary>
    ''' Adds Nouns to toy grammar
    ''' </summary>
    ''' <returns></returns>
    Private Function AddProperNoun_Place() As List(Of Rule)
        Dim NewRule As New Rule
        AddProperNoun_Place = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$PNP$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$N$")
        AddProperNoun_Place.Add(NewRule)
    End Function
#End Region
#Region "VERBS"
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
    ''' Verbs to be added (Toy) grammar
    ''' </summary>
    ''' <returns></returns>
    Private Shared Function AddAuxVerbs() As List(Of Rule)
        Dim NewRule As New Rule
        AddAuxVerbs = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$VAV$"
        NewRule.SentenceStr = New List(Of String)
        AddAuxVerbs.Add(NewRule)
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
        NewRule.SentenceStr.Add(" $VITV$ ")
        NewRule.SentenceStr.Add(" $VTV$ $NP$")
        NewRule.SentenceStr.Add(" $VDTRANS$ $NP$")
        NewRule.SentenceStr.Add(" $V$")
        NewRule.SentenceStr.Add(" $V$ $ADV$")
        NewRule.SentenceStr.Add(" $V$ $PP$")
        NewRule.SentenceStr.Add("$VP$ $CONJ$ $VP$")

        AddVerbPhrases.Add(NewRule)
    End Function

    ''' <summary>
    ''' INTRANSITIVE VERBS
    ''' </summary>
    ''' <returns></returns>
    Private Function AddInTransitiveVerb() As List(Of Rule)
        Dim NewRule As New Rule
        AddInTransitiveVerb = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$VITV$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$V$")
        AddInTransitiveVerb.Add(NewRule)

    End Function
    ''' <summary>
    ''' ADDVERB VERBS
    ''' </summary>
    ''' <returns></returns>
    Private Function AddAdVerb() As List(Of Rule)
        Dim NewRule As New Rule
        AddAdVerb = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$ADV$"
        NewRule.SentenceStr = New List(Of String)
        AddAdVerb.Add(NewRule)
    End Function
    ''' <summary>
    ''' TRANSITIVE VERBS
    ''' </summary>
    ''' <returns></returns>
    Private Function AddTransitiveVerb() As List(Of Rule)
        Dim NewRule As New Rule
        AddTransitiveVerb = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$VTV$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$V$")
        AddTransitiveVerb.Add(NewRule)
    End Function
    ''' <summary>
    ''' DITRANSITIVE VERB
    ''' </summary>
    ''' <returns></returns>
    Private Function AddDitransitiveVerb() As List(Of Rule)
        Dim NewRule As New Rule
        AddDitransitiveVerb = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$VDTRANS$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$V$")
        AddDitransitiveVerb.Add(NewRule)
    End Function
    ''' <summary>
    ''' AddParticipleVerb
    ''' </summary>
    ''' <returns></returns>
    Private Function AddParticipleVerb() As List(Of Rule)
        Dim NewRule As New Rule
        AddParticipleVerb = New List(Of Rule)
        NewRule.SentenceType.PartOfSpeech = "$VPV$"
        NewRule.SentenceStr = New List(Of String)
        NewRule.SentenceStr.Add("$V$")
        AddParticipleVerb.Add(NewRule)
    End Function

#End Region
#End Region


#End Region



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
    Public Function Expand(ByRef CustomRules As List(Of Rule), ByRef StartStr As String, ByRef Expansion As String) As String

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

#End Region

#Region "FUNCTIONS"
    ''' <summary>
    ''' Adds The basic Grammar to given rules
    ''' </summary>
    ''' <returns></returns>
    Public Function AddRules(ByRef Rules As List(Of Rule)) As List(Of Rule)
        AddRules = New List(Of Rule)
        AddRules.AddRange(AddVerbs)
        AddRules.AddRange(AddNouns)
        AddRules.AddRange(AddDitransitiveVerb)
        AddRules.AddRange(AddTransitiveVerb)
        AddRules.AddRange(AddInTransitiveVerb)
        AddRules.AddRange(AddConjunctions)
        AddRules.AddRange(AddInterjections)
        AddRules.AddRange(AddAuxVerbs)
        AddRules.AddRange(AddSentences)
        AddRules.AddRange(AddPunctuation)
        AddRules.AddRange(AddAdjectives)
        AddRules.AddRange(AddDeterminers)
        AddRules.AddRange(AddNounPhrases)
        AddRules.AddRange(AddPrepositionalPhrases)
        AddRules.AddRange(AddPrepositions)
        AddRules.AddRange(AddVerbPhrases)
        AddRules.AddRange(AddAdVerb)
        AddRules.AddRange(AddParticipleVerb)
        AddRules.AddRange(AddProperNouns)
        AddRules.AddRange(AddProperNoun_Name)
        AddRules.AddRange(AddProperNoun_Place)

        Return Rules
    End Function
    ''' <summary>
    ''' Generates Output from Sentence Grammar String with custome grammar
    ''' </summary>
    ''' <param name="CFG">Grammar / Ruleset</param>
    ''' <returns>Expanded Sentence</returns>
    Public Function GenerateRandomSentencefromGramar(ByRef CFG As List(Of Rule)) As String
        Randomize()
        Return Expand(CFG, "$S$ ", "")

    End Function
    ''' <summary>
    ''' generates sentence with Internal Grammar CFG_RULES
    ''' </summary>
    ''' <returns></returns>
    Public Function GenerateRandomSentence() As String
        Randomize()
        Return Expand(StandardGrammar, "$S$ ", "")
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
