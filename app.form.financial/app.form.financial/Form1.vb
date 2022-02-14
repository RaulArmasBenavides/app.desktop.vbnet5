﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub MYRATE()
        Dim Fmt, FVal, Guess, PVal, Payment, TotPmts, PayType, APR
        Const ENDPERIOD = 0, BEGINPERIOD = 1    ' When payments are made.
        Fmt = "##0.00"    ' Define percentage format.
        FVal = 0    ' Usually 0 for a loan.
        Guess = 0.1    ' Guess of 10 percent.
        PVal = InputBox("How much did you borrow?")
        Payment = InputBox("What's your monthly payment?")
        TotPmts = InputBox("How many monthly payments do you have to make?")
        PayType = MsgBox("Do you make payments at the end of the month?",
        vbYesNo)
        If PayType = vbNo Then PayType = BEGINPERIOD Else PayType = ENDPERIOD
        MsgBox(Rate(TotPmts, -Payment, PVal, FVal, PayType, Guess))
        APR = (Rate(TotPmts, -Payment, PVal, FVal, PayType, Guess) * 12) * 100
        MsgBox("Your interest rate is " & Format(APR, Fmt) & " percent (monthly).")
    End Sub

    Private Sub PAYMENT()
        Dim Fmt, FVal, PVal, APR, TotPmts, PayType, Payment
        Const ENDPERIOD = 0, BEGINPERIOD = 1    ' When payments are made.
        Fmt = "###,###,##0.00"    ' Define money format.
        FVal = 0    ' Usually 0 for a loan.
        PVal = InputBox("How much do you want to borrow?")
        APR = InputBox("What is the annual percentage rate of your loan?")
        If APR > 1 Then APR = APR / 100    ' Ensure proper form.
        APR = InputBox("What is the monthly percentage rate of your loan?")
        If APR > 1 Then APR = APR / 100    ' Ensure proper form.
        TotPmts = InputBox("How many monthly payments will you make?")
        PayType = MsgBox("Do you make payments at the end of month?", vbYesNo)
        If PayType = vbNo Then PayType = BEGINPERIOD Else PayType = ENDPERIOD
        Payment = Pmt(APR, TotPmts, -PVal, FVal, PayType)
        MsgBox("Your payment will be " & Format(Payment, Fmt) & " per month.")
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub RATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RATEToolStripMenuItem.Click
        MYRATE()
    End Sub

    Private Sub PAYMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAYMENTToolStripMenuItem.Click
        PAYMENT()
    End Sub

    Private Sub EJEMPLOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJEMPLOToolStripMenuItem.Click
        Dim TotPmts
        Dim kondition As String
        TotPmts = InputBox("Ingresa un monto ")
        kondition = InputBox("Ingresa una kondition 1")
        MsgBox("Your GetJahreszinsByKondition is " & GetJahreszinsByKondition(kondition, TotPmts) & ".")
    End Sub

    Private Function GetJahreszinsByKondition(ByVal kondition As String, ByVal amount As Decimal) As Decimal

        Dim DictDict As New Dictionary(Of String, Dictionary(Of String, Decimal))
        Dim param As String = String.Empty;
        Dim result, jahreszins As Decimal
        If (amount <= 15000) Then
            param = "param1"
        ElseIf (amount > 15000 And amount <= 50000) Then
            param = "param2"
        ElseIf (amount > 50000 And amount <= 100000) Then
            param = "param3"
        ElseIf (amount > 100000) Then
            param = "param4"
        Else
            param = "param5"
        End If

#Region "Loading Dictionary"
        DictDict = New Dictionary(Of String, Dictionary(Of String, Decimal)) From
        {
             {
               "kondition 1",
                  New Dictionary(Of String, Decimal) From
                    {
                         {"param1", 4.5},
                         {"param2", 3.75},
                         {"param3", 3.25},
                         {"param4", 2.75}
                    }
             },
              {
               "kondition 2",
                  New Dictionary(Of String, Decimal) From
                    {
                        {"param1", 5.5},
                        {"param2", 4.75},
                        {"param3", 4.25},
                        {"param4", 3.75}
                    }
             },
              {
               "kondition 3",
                  New Dictionary(Of String, Decimal) From
                    {
                       {"param1", 6.5},
                       {"param2", 5.0},
                       {"param3", 4.5},
                       {"param4", 4.0}
                    }
             }
        }
#End Region
        jahreszins = amount * DictDict.Item(kondition).Item(param)
        Return jahreszins
    End Function
End Class
