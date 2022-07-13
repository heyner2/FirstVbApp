Public Class btnStart

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Go.Click




    End Sub



    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stLastName = "Palacios"
        stFirstName = "Heyner"

        MsgBox("hello and welcome " & stFirstName & " " & stLastName)

    End Sub

    Private Sub dataTypes_Click(sender As Object, e As EventArgs) Handles dataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtRegisteredDate As Date

        stMake = "ford"
        stModel = "Escort"
        iDoors = 5
        bTaxed = True
        stColor = "black"
        iEngineSize = 1200
        decPrice = 9999.99
        dtRegisteredDate = #11/25/1991#

        MsgBox("The car is a " & stMake & " the model is " &
               stModel & " its color is " &
               stColor & " The price is " & decPrice)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSubmitInfo.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stProfesion As String

        stFirstName = txtFirstName.Text
        stLastName = txtLast.Text
        stGender = txtGender.Text
        stProfesion = lstProfesion.SelectedItem

        MsgBox("You are " & stFirstName & " " & stLastName & " and your gender is a " &
               stGender & " And your occupation is " & stProfesion)

    End Sub

    Private Sub lstProfesion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProfesion.SelectedIndexChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iResult As Integer

        iNumber1 = txtNum1.Text
        iNumber2 = txtNum2.Text

        iResult = iNumber1 + iNumber2
        MsgBox("the sum is " & iResult)


        iNumber1 = txtNum1.Text
        iNumber2 = txtNum2.Text

        iResult = iNumber1 - iNumber2
        MsgBox("the deduction is " & iResult)


        iNumber1 = txtNum1.Text
        iNumber2 = txtNum2.Text

        iResult = iNumber1 * iNumber2
        MsgBox("the multiplication is " & iResult)


        iNumber1 = txtNum1.Text
        iNumber2 = txtNum2.Text

        iResult = iNumber1 / iNumber2
        MsgBox("the division is " & iResult)

        iResult = iNumber1 ^ iNumber2
        MsgBox("the raise to the power of " & iNumber2 & " is " & iResult)

        iResult = iNumber1 \ iNumber2
        MsgBox("the integer result of a division is " & iResult)

        iResult = iNumber1 Mod iNumber2
        MsgBox("the remaining result of a division is " & iResult)

    End Sub

    Private Sub btnAritmetic_Click(sender As Object, e As EventArgs) Handles btnAritmetic.Click
        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decDiscount As Integer
        Dim decTotcalCost As Integer

        decPrice = 5
        iQuantity = 10
        decDiscount = 2



        decTotcalCost = (decPrice - decDiscount) * iQuantity


        'aposthrofes are for comments
        MsgBox("The total price is " & decTotcalCost)



    End Sub

    Private Sub txtCountry_TextChanged(sender As Object, e As EventArgs) Handles txtCountry.TextChanged

    End Sub

    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String

        stCountry = txtCountry.Text



        Select Case stCountry

            Case Is = "El salvador"
                MsgBox("que paso bro")
            Case Is = "Brazil"
                MsgBox("Obrigado, muito gusto")
            Case Else
                MsgBox("otro en caso, pero tengo el else del if")
        End Select


        If stCountry.ToLower = "Australia" Then
            MsgBox("Hello Ya")
        ElseIf stCountry.ToLower = "Germany" Then
            MsgBox("Guthentatg")
        Else
            MsgBox("HI there")
        End If


        txtCountry.Text = ""
    End Sub

    Private Sub btnLoop_Click(sender As Object, e As EventArgs) Handles btnLoop.Click

        Dim iCount As Integer
        Dim iNumber As Integer

        iNumber = 0
        For iCount = 1 To 5
            iNumber = iNumber + 1

            MsgBox(iNumber)
            Beep()
            Threading.Thread.Sleep(1000)
            MsgBox("The index is " & iCount)

        Next

    End Sub

    Private Sub btnLoopBySteps_Click(sender As Object, e As EventArgs) Handles btnLoopBySteps.Click

        Dim iCount As Integer

        For iCount = 0 To 50 Step 5

            MsgBox("The count is " & iCount)

        Next

    End Sub

    Private Sub btnLoopWithNewLine_Click(sender As Object, e As EventArgs) Handles btnLoopWithNewLine.Click

        Dim iCount As Integer
        Dim stOut As String

        For iCount = 50 To 0 Step -5
            stOut = stOut & iCount & vbNewLine
        Next

        MsgBox(stOut)

    End Sub

    Private Sub btnLoopArray_Click(sender As Object, e As EventArgs) Handles btnLoopArray.Click

        Dim aStFruits(4) As String

        aStFruits(0) = "Banana"
        aStFruits(1) = "Mango"
        aStFruits(2) = "Watermelon"
        aStFruits(3) = "strawberry"
        aStFruits(4) = "coconut"

        Dim i As Integer
        For i = 0 To (aStFruits.Length - 1)
            MsgBox(aStFruits(i))
        Next


    End Sub
End Class

