Option Explicit On
Option Strict On
Imports System.Runtime.Intrinsics.X86

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub MYRATE()
        Dim FVal, Guess, PVal, Payment, TotPmts, APR As Double
        Dim PayType As DueDate
        Dim Fmt As String = String.Empty
        Fmt = "##0.00"    ' Define percentage format.
        FVal = 0    ' Usually 0 for a loan.
        Guess = 0.1    ' Guess of 10 percent.
        PVal = CDbl(InputBox("How much did you borrow?"))
        Payment = CDbl(InputBox("What's your monthly payment?"))
        TotPmts = CDbl(InputBox("How many monthly payments do you have to make?"))
        PayType = CType(MsgBox("Do you make payments at the end of the month?",
        vbYesNo), DueDate)
        If PayType = vbNo Then PayType = DueDate.BegOfPeriod Else PayType = DueDate.EndOfPeriod
        MsgBox(Rate(TotPmts, -Payment, PVal, FVal, PayType, Guess))
        APR = (Rate(TotPmts, -Payment, PVal, FVal, PayType, Guess) * 12) * 100
        MsgBox("Your interest rate is " & Format(APR, Fmt) & " percent (monthly).")
    End Sub

    Private Sub PAYMENT()
        Dim FVal, PVal, APR, TotPmts, PayType, Payment As Double
        Dim Fmt As String = String.Empty
        Fmt = "###,###,##0.00"    ' Define money format.
        FVal = 4000    ' Usually 0 for a loan.
        PVal = CDbl(InputBox("How much do you want to borrow ( Finanzierungssumme) ?"))
        APR = CDbl(InputBox("What is the annual percentage rate of your loan?"))
        If APR > 1 Then APR /= 100    ' Ensure proper form.
        APR = CDbl(InputBox("What is the monthly percentage rate of your loan?"))
        If APR > 1 Then APR /= 100    ' Ensure proper form.
        TotPmts = CDbl(InputBox("How many monthly payments will you make?"))
        PayType = MsgBox("Do you make payments at the end of month?", vbYesNo)
        If PayType = vbNo Then PayType = DueDate.BegOfPeriod Else PayType = DueDate.EndOfPeriod
        Payment = Pmt(APR / 12, TotPmts, -PVal, FVal, DueDate.BegOfPeriod)
        MsgBox("Your payment will be " & Format(Payment, Fmt) & " per month.")
    End Sub

    Private Sub PV()
        Dim tasaInteres As Double = 0.05 ' Tasa de interés / Refinanzierung / 12
        Dim flujoEfectivo As Double = 1000 ' Flujo de efectivo
        Dim periods As Integer = 5 ' Número de períodos /Total Rechnungen nach Anzahlung
        ' Cálculo del valor actual utilizando la función financiera PV
        '  Valor Actual = VA(Refinanzierung / 12 ; Total Rechnungen nach Anzahlung ; -Mietrate ; -Restwert ; 1) 
        Dim valorActual As Double = Microsoft.VisualBasic.Financial.PV(tasaInteres, periods, 0, -flujoEfectivo, DueDate.BegOfPeriod)

        ' Imprimir el valor actual
        'Console.WriteLine("El valor actual es: " & valorActual.ToString("0.00"))
        MsgBox("El valor actual es: " & valorActual.ToString("0.00"))
        ' Esperar a que el usuario presione una tecla para salir
        'Console.ReadKey()
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
        Dim TotPmts As Decimal = 0
        Dim kondition As String = String.Empty
        TotPmts = CDec(InputBox("Ingresa un monto "))
        kondition = InputBox("Ingresa una kondition 1")
        MsgBox("Your GetJahreszinsByKondition is " & GetJahreszinsByKondition(kondition, TotPmts) & ".")
    End Sub

    Private Function GetJahreszinsByKondition(ByVal kondition As String, ByVal amount As Decimal) As Decimal

        Dim MyDict As New Dictionary(Of String, Dictionary(Of String, Decimal))
        Dim result, jahreszins As Decimal
        'Private ContractsDocumentDictionary As New Dictionary(Of String, String)(System.StringComparer.OrdinalIgnoreCase) to ignore case sensitive
        Dim param As String
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
        MyDict = New Dictionary(Of String, Dictionary(Of String, Decimal)) From
        {
             {
               "kondition 1",
                  New Dictionary(Of String, Decimal) From
                    {
                         {"param1", CDec(4.5)},
                         {"param2", CDec(3.75)},
                         {"param3", CDec(3.25)},
                         {"param4", CDec(2.75)}
                    }
             },
              {
               "kondition 2",
                  New Dictionary(Of String, Decimal) From
                    {
                        {"param1", CDec(5.5)},
                        {"param2", CDec(4.75)},
                        {"param3", CDec(4.25)},
                        {"param4", CDec(3.75)}
                    }
             },
              {
               "kondition 3",
                  New Dictionary(Of String, Decimal) From
                    {
                       {"param1", CDec(6.5)},
                       {"param2", CDec(5.0)},
                       {"param3", CDec(4.5)},
                       {"param4", CDec(4.0)}
                    }
             }
        }
#End Region
        jahreszins = amount * MyDict.Item(kondition).Item(param)
        Return jahreszins
    End Function

    Shared Function GetConstMyDynamicControlDictionary() As Dictionary(Of String, String)
        Dim dictionaryControlsExternal As New Dictionary(Of String, String) From {
            {"_COOPERA_Rucknah_Bemerkun_InputControl", "_COOPERA_Rucknahmeverpflichtung_Label"},
            {"_COOPERA_sicherheit_Bemerkung_InputControl", "_COOPERA_Hinterlage_sicherheit_Label"},
            {"_COOPERA_Nachhal_Bemerkun_InputControl", "_COOPERA_Nachhaltigkeit_Label"},
            {"_COOPERA_Versicherungs_Account_InputControl", "_COOPERA_Versicherungs_Label"},
            {"_COOPERA_Schuld_Account01_InputControl", "_COOPERA_Schuldbeitritt_Label"},
            {"_COOPERA_Schuld_Account02_InputControl", "_COOPERA_Schuldbeitritt_Label"},
            {"_COOPERA_Schuld_Account03_InputControl", "_COOPERA_Schuldbeitritt_Label"},
            {"_COOPERA_Schuld_Account04_InputControl", "_COOPERA_Schuldbeitritt_Label"},
            {"_COOPERA_Eigentumsanzeige_Account_InputControl", "_COOPERA_Eigentumsanzeige_Label"}
        }
        Return dictionaryControlsExternal
    End Function

    Private Sub ENUMERATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENUMERATIONToolStripMenuItem.Click
        Dim dc As Dictionary(Of String, String)
        Dim ind As Integer = 0
        dc = GetConstMyDynamicControlDictionary()
        For Each kv As KeyValuePair(Of String, String) In dc
            MsgBox(kv.Key + " " + kv.Value + " " + ind.ToString())
            ind += 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Número que deseas redondear
        Dim numero As Double = CDbl(txtNumeroSinRedondear.Text)
        '1.23
        ' Valor de redondeo (en este caso, 0.05)
        Dim valorDeRedondeo As Double = 0.05
        ' Realizar el redondeo
        Dim resultado As Double = Math.Ceiling(numero / valorDeRedondeo) * valorDeRedondeo
        txtNumeroRedondeado.Text = resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero As Double = CDbl(txtNumeroSinRedondear.Text)
        txtNumeroRedondeado.Text = numero.ToString("F2")
    End Sub

    Private Sub FINANZASFUNCIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FINANZASFUNCIONESToolStripMenuItem.Click

    End Sub

    Private Sub PVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PVToolStripMenuItem.Click

    End Sub
End Class
