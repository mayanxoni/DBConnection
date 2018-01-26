Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim sql As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\Users\MayanXoni\Documents\Visual Studio 2010\Projects\DBConnection\DBConnection\bin\Debug\MyDB.accdb"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validating form controls to check the NULL
        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("Enter the Student name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txtName.Focus()
        End If

        If Len(Trim(txtCourse.Text)) = 0 Then
            MessageBox.Show("Enter the Course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txtCourse.Focus()
        End If

        If Len(Trim(cmbGender.Text)) = 0 Then
            MessageBox.Show("Select the Gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            cmbGender.Focus()
        End If

        If ((radioGen.Checked = False) And (radioOBC.Checked = False) And (radioSC.Checked = False) And (radioST.Checked = False)) Then

            MessageBox.Show("Select the Category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            radioGen.Focus()
        End If

        If Len(Trim(txtAddress.Text)) = 0 Then
            MessageBox.Show("Enter the Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txtAddress.Focus()
        End If

        If Len(Trim(txtEmail.Text)) = 0 Then
            MessageBox.Show("Enter the Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txtEmail.Focus()
        End If

        If Len(Trim(txtContact.Text)) = 0 Then
            MessageBox.Show("Enter the Contact", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txtContact.Focus()
        End If

        If Len(Trim(cmbState.Text)) = 0 Then
            MessageBox.Show("Select the State", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            cmbState.Focus()
        End If

        If Len(Trim(txtCity.Text)) = 0 Then
            MessageBox.Show("Enter the Country Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
            txtCity.Focus()
        End If

        Try
            Dim str As String
            If radioGen.Checked = True Then
                str = radioGen.Text
            ElseIf radioOBC.Checked = True Then
                str = radioOBC.Text
            ElseIf radioSC.Checked = True Then
                str = radioSC.Text
            Else
                str = radioST.Text
            End If

            ' Writing SQL statement to insert the values into the Database
            sql = "INSERT INTO student VALUES ('" & txtName.Text & "','" & txtCourse.Text & "','" & cmbGender.Text & "','" & dob.Value & "','" & str & "','" & txtAddress.Text & "','" & txtEmail.Text & "','" & txtContact.Text & "','" & cmbState.Text & "','" & txtCity.Text & "')"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "student")
            MessageBox.Show("Registration sucessfully completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            clear()       ' Calling clear method to clear the form controls
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Exception generated", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Declaring clear method to clear all the form controls 
    Sub clear()
        txtName.Clear()
        txtCourse.Clear()
        cmbGender.SelectedIndex = -1
        dob.Text = ""
        radioGen.Checked = False
        radioOBC.Checked = False
        radioSC.Checked = False
        radioST.Checked = False
        txtAddress.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        cmbState.SelectedIndex = -1
        txtCity.Clear()
    End Sub
End Class