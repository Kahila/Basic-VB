' ********************************************************************************* 
'  Surname, Initials:AK Kalombo
'  Student Number:218095095
'  Practical: P2018A-10
'  Class name: Shake your spear ;)
' *********************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmSkakespear

    'Subroutin that will be used to write to grid
    Private Sub WriteGrd(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        GrdUj.Row = r
        GrdUj.Col = c
        GrdUj.Text = t
    End Sub

    'a)
    'Setting up Season record structure
    Private Season() As SeasonRec
    Private Structure SeasonRec
        Public Sname As String
        Public nPerform As Integer
        Public Play() As PlayRac
        Public BestIndex As Integer
    End Structure
    'Setting up Play record structure
    Private Structure PlayRac
        Public PlayName As String
        Public SoldTick() As Integer
        Public TotTickIncome As Double

    End Structure

    'b)
    'Initializing Uj grid
    Private Row, Col As Integer
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        Dim A, B As Integer
        Row = CInt(InputBox("How many Seasons are there?", "Number of seasons"))
        Col = CInt(InputBox("How many Plays are there per season", "Number of plays"))

        GrdUj.Rows = Row + 1
        GrdUj.Cols = Col + 2

        For A = 1 To Row
            WriteGrd(A, 0, "Season " & CStr(A))
        Next A
        For B = 1 To Col
            WriteGrd(0, B, "Play " & CStr(B))
        Next B
        GrdUj.DebugState = False
        WriteGrd(0, Col + 1, "Best Play Index")

    End Sub

    'c)
    'Inputing data for record structures
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim A, B, C As Integer
        ReDim Season(Row)

        For A = 1 To Row
            Season(A).Sname = InputBox("What is the name of season " & A, "Season name")
            Season(A).nPerform = CInt(InputBox("What is the Number of Performances in season " & A, "Number of performance"))
            ReDim Season(A).Play(Col)
            For B = 1 To Col
                Season(A).Play(B).PlayName = InputBox("What is the name of play " & B, "Play name")
                ReDim Season(A).Play(B).SoldTick(3)
                For C = 1 To 3
                    Season(A).Play(B).SoldTick(C) = CInt(InputBox("How many tickets where sold for category " & C & " in season " & B, "Sold tickets in category"))
                Next C
            Next B
        Next A
    End Sub

    'd)
    'Subroutin for calculating the base price
    'Will be used to Adjust tickets price based on the base price
    Private NewBasePrice As Double
    Private Sub CalcAdjustPrice(ByVal BasePrice As Double, ByVal CatATickets As Integer)

        Select Case CatATickets
            Case > 120
                NewBasePrice = BasePrice * 1.5
            Case 75 To 120
                NewBasePrice = BasePrice * 1.2
            Case > 0
                NewBasePrice = BasePrice
        End Select
    End Sub

    'e)
    'Function that will be used to calculate the total ticket income
    'It accepts perimitors in the order price
    Private Function CalcTotalincome(ByVal Price As Double, ByVal CatA As Integer, ByVal CatB As Integer, ByVal CatC As Integer, ByVal Total As Double) As Double
        Dim C As Integer

        Total = 0
        For C = 1 To 3
            Total += CatA * Price + CatB * Price * 2 + CatC * Price * 3
        Next C
        Return Total
    End Function

    'f)
    'Calculating total ticket income 
    'Summing the income from all three categories
    Private Sub btnTTincome_Click(sender As Object, e As EventArgs) Handles btnTTincome.Click
        Dim A, B, C As Integer
        'Dim totalTickIncome As Double
        Dim Baseprice As Double
        Dim Income As Double

        For A = 1 To Row
            For B = 1 To Col
                For C = 1 To 3
                    Baseprice = CDbl(InputBox("What is the base price of the ticket in category" & C, "Base price"))
                    CalcAdjustPrice(Baseprice, Season(A).Play(B).SoldTick(C))
                Next C
                CalcTotalincome(Baseprice, Season(A).Play(B).SoldTick(1), Season(A).Play(B).SoldTick(2), Season(A).Play(B).SoldTick(3), Income)
                'Return
                WriteGrd(A, B, CStr(CalcTotalincome(Baseprice, Season(A).Play(B).SoldTick(1), Season(A).Play(B).SoldTick(2), Season(A).Play(B).SoldTick(3), Income)))
                Season(A).Play(B).TotTickIncome = NewBasePrice
            Next B
        Next A
    End Sub

    'g)
    'Calculating the name of best play per season
    'displaying the name of best play per season
    Private Sub btnIndex_Click(sender As Object, e As EventArgs) Handles btnIndex.Click
        Dim A, B, Index As Integer
        Dim Best As Double

        For A = 1 To Row
            Index = 1
            Best = Season(A).Play(1).TotTickIncome
            For B = 1 To Col
                If Best < Season(A).Play(B).TotTickIncome Then
                    Best = Season(A).Play(B).TotTickIncome
                    Index = B
                End If
            Next B
            Season(A).BestIndex = Index
            WriteGrd(A, Col + 1, Season(A).Play(Index).PlayName)
        Next A

        'h)
        'Calculating of increasing ticket income
        'Displaying of outcome of increasing ticket income evaluation
        Dim Trend As Boolean = True
        Dim counter As Integer = 1

        While Trend And counter < Row
            If Season(counter).BestIndex < Season(counter + 1).BestIndex Then
                Trend = False
            Else
                counter += 1
            End If
        End While
        If Trend Then
            txtTrend.Text = "It is increasing "
        Else
            txtTrend.Text = "It is not increasing"
        End If
    End Sub
End Class
