Public Class Form1
    ' Purpose: To calculate the days until Christmas
    ' Date: 13 February 2024
    ' Author: Ihsaan Ifzal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The code below is handled when the form is loaded
        dtpToday.Value = DateTime.Now
        ' This will display today's date in the DateTimePicker object
        dtpChristmas.Value = New DateTime(DateTime.Now.Year, 12, 25)
        ' This will display the next Christmas date in the DateTimePicker object
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This button executes the code to read in today's date and the next Christmas date
        dtpToday.Value = DateTime.Now
        ' This will display today's date in the DateTimePicker object
        dtpChristmas.Value = New DateTime(DateTime.Now.Year, 12, 25)
        ' This will display the next Christmas date in the DateTimePicker object

        Dim dateChristmas As Integer = DateDiff(DateInterval.Day, dtpToday.Value, dtpChristmas.Value)
        ' This declares dateChristmas as a variable to handle the days until Christmas
        ' The line also finds the difference between the two dates displayed in the DateTimePicker objects
        ' It returns the difference in days

        MsgBox("There are " & dateChristmas & " days till Christmas.")
        ' This opens a message box and returns the days until Christmas
    End Sub
End Class
