' *********************************************************************************
' Surname, Initials:Kalombo A.K
' Student Number:218095095
' Practical: P2018A-09
' Class name: Fishing season
' *********************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmFishingSeason
    'Setting up period and week record structure
    Private PeriodIn() As period
    Private Structure period
        Public name As String
        Public nPeriods As Integer
        Public nWeeks As Integer
        Public Rating As Double
        Public Week() As week
        Public Index As Integer
    End Structure
    Private Structure week
        Public nFish() As Integer
        Public nVisitors As Integer
        Public Visitor() As Integer
        Public AveFish() As Double
        Public TotAveFish As Double
    End Structure

    'Setting up subruitin that rights to grid
    Private Sub WriteGrd(ByVal r As Integer, ByVal c As Integer, ByVal t As String)

        grdUj.Row = r
        grdUj.Col = c
        grdUj.Text = t

    End Sub

    'Initializing sub routin
    Private col, row As Integer

    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        Dim A, B As Integer

        row = CInt(InputBox("How many periods are there", "Number of periods"))
        col = CInt(InputBox("How many weeks are there for all periods", "Number of weeks"))

        grdUj.Cols = col + 3
        grdUj.Rows = row + 1
        For A = 1 To row
            WriteGrd(A, 0, "Period " & CStr(A))
        Next A
        For B = 1 To col
            WriteGrd(0, B, "Week " & CStr(B))
        Next B
        WriteGrd(0, col + 1, "Highest index")
        WriteGrd(0, col + 2, "Rating")
        grdUj.DebugState = False

    End Sub

    'Collecting data for Subroutins
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim A, B, C As Integer
        ReDim PeriodIn(row)

        For A = 1 To row
            PeriodIn(A).name = InputBox("What is the name of period " & CInt(A), "Name of period")

            PeriodIn(A).nWeeks = col
            ReDim PeriodIn(A).Week(col)
            For B = 1 To PeriodIn(A).nWeeks
                PeriodIn(A).Week(B).nVisitors = CInt(InputBox("How many visitors are there in week " & CStr(B), "Number of visitors"))

                ReDim PeriodIn(A).Week(B).AveFish(PeriodIn(A).Week(B).nVisitors)
                ReDim PeriodIn(A).Week(B).nFish(PeriodIn(A).Week(B).nVisitors)
                For C = 1 To PeriodIn(A).Week(B).nVisitors
                    PeriodIn(A).Week(B).nFish(C) = CInt(InputBox("How many fish did visitor " & CStr(C) & " catch in week " & CStr(B) & "?", "Number of fish caught by visitor"))
                    PeriodIn(A).Week(B).AveFish(C) = CDbl(InputBox("What is the total average weight of the fish caught by visitor " & CStr(C) & " in week " & CStr(B) & "?", "Total weight of fish"))
                Next C
            Next B
        Next A
    End Sub

    'Subroutin that calculates the average weight of fish caught by each visitors
    Private answer As Double

    Private Sub CalcAve(ByVal TotalAve As Double, ByVal TotFish As Integer)
        answer = TotalAve / TotFish
    End Sub

    'Calculating and desplaying average per week 
    Private Sub btnCalcAve_Click(sender As Object, e As EventArgs) Handles btnCalcAve.Click
        Dim A, B, C, TotFish As Integer
        Dim TotalAve As Double

        For A = 1 To row
            For B = 1 To PeriodIn(A).nWeeks
                TotalAve = 0
                TotFish = 0
                For C = 1 To PeriodIn(A).Week(B).nVisitors
                    TotalAve += PeriodIn(A).Week(B).AveFish(C)
                    TotFish += PeriodIn(A).Week(B).nFish(C)
                Next C
                CalcAve(TotalAve, TotFish)
                PeriodIn(A).Week(B).TotAveFish = answer
                WriteGrd(A, B, Format(answer, "0.00"))
            Next B
        Next A
    End Sub

    'Highest average weight index
    Private Sub btnIndex_Click(sender As Object, e As EventArgs) Handles btnIndex.Click
        Dim A, B, indexnew As Integer
        Dim Highest As Double

        For A = 1 To row

            indexnew = 1
            Highest = PeriodIn(A).Week(1).TotAveFish
            For B = 2 To PeriodIn(A).nWeeks
                If Highest < PeriodIn(A).Week(B).TotAveFish Then
                    Highest = PeriodIn(A).Week(B).TotAveFish
                    indexnew += 1
                End If
            Next B
            PeriodIn(A).Index = indexnew
            WriteGrd(A, col + 1, CStr(indexnew))
        Next A
    End Sub

    'Sub routin for calculating average
    Private Answre As String
    Private Sub DetermineRating(ByVal HighestAve As Double)
        Select Case HighestAve
            Case 0 To 15
                Answre = ("A")
            Case < 25
                Answre = ("B")
            Case >= 25
                Answre = ("C")
        End Select
    End Sub

    'Calculating Rating per period and desplaying it
    'using subroutin Determinerating
    Private Sub btnRat_Click(sender As Object, e As EventArgs) Handles btnRat.Click
        Dim A, B As Integer
        Dim Highest As Double

        For A = 1 To row

            Highest = PeriodIn(A).Week(1).TotAveFish
            For B = 1 To PeriodIn(A).nWeeks
                If Highest < PeriodIn(A).Week(B).TotAveFish Then
                    Highest = PeriodIn(A).Week(B).TotAveFish
                End If
                DetermineRating(Highest)
                PeriodIn(A).Rating = Highest
                WriteGrd(A, col + 2, CStr(Answre))
            Next B
        Next A

        'Determining if the rating is a decreasing trend
        Dim Decreasing As Boolean
        Dim Counter As Integer

        Counter = 1
        While Counter < col And Decreasing = True
            If PeriodIn(Counter).Rating < PeriodIn(Counter + 1).Rating Then
                Decreasing = False
            End If
            Counter += 1
        End While
        If Decreasing = True Then
            txtChangeRat.Text = "It's Decreasing"
        End If
        If Decreasing = False Then
                txtChangeRat.Text = "It's not decreasing"
            End If
    End Sub
End Class