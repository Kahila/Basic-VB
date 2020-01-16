
Option Explicit On
Option Strict On
Option Infer Off
Public Class frmPracEight

    'Setting up record structure
    Private Pride() As PrideInfo
    Private Structure PrideInfo
        Public Codname, location As String
        Public PrideRat As Integer
        Public LeastTav As Double
    End Structure

    Private lion() As LionInfo
    Private Structure LionInfo
        Public NickNamr() As String
        Public age(), Days() As Integer
        Public KMtrav(), AveKm() As Double
    End Structure

    'Setting Subroutin which will be used to write to grid
    Private Sub WriteGrd(ByVal r As Integer, ByVal c As Integer, ByVal text As String)

        GrdUIj.Row = r
        GrdUIj.Col = c
        GrdUIj.Text = text
    End Sub

    'initializing uj grid
    'Setting number of rows and columns
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click

        Dim A, B As Integer
        GrdUIj.Cols = CInt(txtPride.Text) + 1
        GrdUIj.Rows = CInt(txtLion.Text) + 3

        For A = 1 To CInt(txtPride.Text)
            WriteGrd(0, A, "Pride " & CStr(A))
        Next A
        For B = 1 To CInt(txtLion.Text)
            WriteGrd(B, 0, "Lion " & CInt(B))
        Next B
        WriteGrd(CInt(txtLion.Text) + 1, 0, "Lowest movement")
        WriteGrd(CInt(txtLion.Text) + 2, 0, "Rating")
    End Sub

    'Sub ruitin that returns an average
    'Given an array of double values
    Private ave As Double
    Private Sub GetAve(ByVal total As Double, ByVal Divident As Integer)
        ave = total / Divident
    End Sub

    'Inputing of data
    'storing then to record structure
    'Calculating average KM
    'Displaying average KM onto Uj grid
    'Setting average to three decimals 

    Private Sub btnPrideInfo_Click(sender As Object, e As EventArgs) Handles btnPrideInfo.Click
        Dim A, B, C As Integer
        Dim value As Double
        ReDim Pride(CInt(txtPride.Text))
        ReDim lion(CInt(txtLion.Text))

        For A = 1 To CInt(txtPride.Text)
            Pride(A).Codname = (InputBox("What is the Code name of pride " & CStr(A)))
            Pride(A).location = InputBox("Where is pride " & CStr(A) & " located")

            ReDim lion(A).NickNamr(CInt(txtLion.Text))
            ReDim lion(A).age(CInt(txtLion.Text))
            ReDim lion(A).Days(CInt(txtLion.Text))
            ReDim lion(A).AveKm(CInt(txtLion.Text))

            For B = 1 To CInt(txtLion.Text)
                lion(A).NickNamr(B) = InputBox("What is the nickname of lion " & CStr(B))
                lion(A).age(B) = CInt(InputBox("How old is " & lion(A).NickNamr(B)))
                lion(A).Days(B) = CInt(InputBox("How many days was lion " & lion(A).NickNamr(B) & " monitored for?"))

                ReDim lion(B).KMtrav(lion(A).Days(B))

                value = 0
                For C = 1 To lion(A).Days(B)
                    lion(B).KMtrav(C) = CDbl(InputBox("How far did " & lion(A).NickNamr(B) & " travel in day " & CStr(C)))
                    value += lion(B).KMtrav(C)
                Next C
                lion(A).AveKm(B) = ave
                GetAve(value, lion(A).Days(B))
                WriteGrd(B, A, Format(ave, "0,000"))
            Next B
        Next A
    End Sub

    'Calculating lowest average movement lion
    'Displaying the name of the lowest average movement lion
    Private Sub btnLowestM_Click(sender As Object, e As EventArgs) Handles btnLowestM.Click
        Dim A, B As Integer
        Dim lowest(CInt(txtLion.Text)), low As Double
        Dim Name As String

        For A = 1 To CInt(txtPride.Text)
            low = lion(A).KMtrav(1)
            Name = lion(A).NickNamr(1)
            For B = 1 To CInt(txtLion.Text)
                If low > lion(A).KMtrav(B) Then
                    low = lion(A).KMtrav(B)
                    Name = lion(A).NickNamr(B)
                End If
            Next B
            WriteGrd(CInt(txtLion.Text) + 1, A, Name)
            Pride(A).LeastTav = low
        Next A
    End Sub

    'Calculating pride rating
    'finding if lion averege is odd or even
    Private Sub btnPriderat_Click(sender As Object, e As EventArgs) Handles btnPriderat.Click
        Dim A, B, C As Integer
        Dim MultThree As Double
        Dim Rating As Integer

        For A = 1 To CInt(txtPride.Text)
            MultThree = 3 * (Pride(A).LeastTav)
            C = 0
            For B = 1 To CInt(txtLion.Text)
                If MultThree < lion(A).KMtrav(B) Then
                    C += 1
                End If
                Rating = C Mod 2
            Next B
            If Rating = 0 Then
                WriteGrd(CInt(txtLion.Text) + 2, A, "A")
            End If
            If Rating = 1 Then
                WriteGrd(CInt(txtLion.Text) + 2, A, "B")
            End If
        Next A
    End Sub
End Class
