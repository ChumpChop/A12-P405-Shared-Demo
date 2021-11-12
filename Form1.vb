Public Class Form1
    'Private member
    Private arrUserList As New ArrayList()

    Private Sub UpdateDisplay()
        'Clear the list
        lstUsers.Items.Clear()

        'Add the users to the list box
        For Each objUser As User In arrUserList
            lstUsers.Items.Add(objUser.Username & ", " & objUser.Password &
            " (" & User.MinPasswordLength & ")")
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Load 100 users
        For intIndex As Integer = 1 To 100
            'Create a new user
            Dim objUser As New User
            'objUser.Username = "Stephanie" & intIndex
            'objUser.Password = "password15"
            objUser = User.CreateUser(userName:="Stephanie" & intIndex, password:="password15")

            'Add the user to the array list
            arrUserList.Add(objUser)
        Next

        'Update the display
        UpdateDisplay()
    End Sub

    Private Sub nudMinPasswordLength_ValueChanged(sender As Object, e As EventArgs) Handles nudMinPasswordLength.ValueChanged

        'Set the minimum password length
        User.MinPasswordLength = CInt(nudMinPasswordLength.Value)

        'Update the display
        UpdateDisplay()
    End Sub
End Class
