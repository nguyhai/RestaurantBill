Public Class frmRestaurantBill

    ' Add it up here so we can change it easier. We could have also added it in calculate method. 
    Const pizzaPrice As Double = 1.75
    Const friesPrice As Double = 2.0
    Const drinkPrice As Double = 1.25

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Clear list box on click
        lstDisplay.Items.Clear()

        ' Delcare variables
        Dim numOfPizza As Integer
        Dim numOfFries As Integer
        Dim numOfDrinks As Integer
        Dim totalCost As Double

        If Integer.TryParse(txtPizza.Text, numOfPizza) And Integer.TryParse(txtFries.Text, numOfFries) And Integer.TryParse(txtDrinks.Text, numOfDrinks) Then

            ' Need 2 sub procedures, one for the ordering, and one to calculate the total cost, and one to display the bill
            totalCost = Calculate(numOfPizza, numOfFries, numOfDrinks)
            Display(totalCost, numOfPizza, numOfFries, numOfDrinks)
        Else
            MessageBox.Show("Please enter valid inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function Calculate(numOfPizza As Integer, numOfFries As Integer, numOfDrinks As Integer) As Double
        Dim totalCost As Double
        totalCost = numOfPizza * pizzaPrice + numOfFries * friesPrice + numOfDrinks * drinkPrice
        Return totalCost
    End Function
    Private Sub Display(totalCost As Double, numOfPizza As Integer, numOfFries As Integer, numOfDrinks As Integer)
        ' This will probably be long - Display only items that are ordered
        lstDisplay.Items.Add("Item" + vbTab + vbTab + vbTab + "Quantity" + vbTab + "Price")
        lstDisplay.Items.Add("")

        If numOfPizza > 0 Then
            lstDisplay.Items.Add("Pizza Slices" + vbTab + vbTab + numOfPizza.ToString() + vbTab + FormatCurrency(numOfPizza * pizzaPrice))
        End If
        If numOfFries > 0 Then
            lstDisplay.Items.Add("Fries" + vbTab + vbTab + vbTab + numOfFries.ToString() + vbTab + FormatCurrency(numOfFries * friesPrice))
        End If
        If numOfDrinks > 0 Then
            lstDisplay.Items.Add("Drinks" + vbTab + vbTab + vbTab + numOfDrinks.ToString() + vbTab + FormatCurrency(numOfDrinks * drinkPrice))
        End If

        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Total Cost: " & totalCost.ToString("C2"))
    End Sub


End Class
