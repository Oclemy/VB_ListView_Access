Imports System.Data.OleDb

Public Class Form1

    'DECLARATIONS
    Private Const conString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/Hp/Documents/DataBases/spacecraftsDB.mdb;"
    ReadOnly con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    ReadOnly dt As DataTable = New DataTable()

    'WHEN FORM IS LOADED
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetupListView()
    End Sub

    'SETUP LISTVIEW
    Private Sub SetupListView()
        'SET LISTVIEW PROPERTIES
        mListView.View = View.Details
        mListView.FullRowSelect = True

        'CONSTRUCT COLUMNS
        mListView.Columns.Add("ID", 50)
        mListView.Columns.Add("Name", 160)
        mListView.Columns.Add("Propellant", 170)
        mListView.Columns.Add("Destination", 170)
    End Sub

    'INSERT INTO DATABASE
    Public Sub Add()

        'INSERT SQL STATEMENT
        Const SQL As String = "INSERT INTO spacecraftsTB(S_Name,S_Propellant,S_Destination) VALUES(@NAME,@PROPELLANT,@DESTINATION)"
        cmd = New OleDbCommand(SQL, con)

        'ADD PARAMETERS
        cmd.Parameters.AddWithValue("@NAME", nameTxt.Text)
        cmd.Parameters.AddWithValue("@PROPELLANT", propellantTxt.Text)
        cmd.Parameters.AddWithValue("@DESTINATION", destinationTxt.Text)

        'OPEN CONNECTION And INSERT INTO DATABASE THEN CLOSE CONNECTION
        Try
            con.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Successfully Inserted")
                CleartextBoxes()
            End If
            con.Close()
            Retrieve()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    'POPULATE LISTVIEW
    Private Sub Populate(id As String, spacecraft As String, propellant As String, destination As String)

        'ROW ARRAY
        Dim row As String() = New String() {id, spacecraft, propellant, destination}
        Dim item As ListViewItem = New ListViewItem(row)

        'ADD TO ROWS COLLECTION
        mListView.Items.Add(item)
    End Sub

    'RETRIEVE FROM DataBase
    Private Sub Retrieve()

        mListView.Items.Clear()

        'SELECT SQL STATEMENT
        Dim sql As String = "SELECT * FROM spacecraftsTB "
        cmd = New OleDbCommand(sql, con)

        'OPEN CONNECTION,RETRIEVE,FILL LISTVIEW
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)

            'LOOP THRU DATATABLE
            For Each row In dt.Rows
                Populate(row(0), row(1), row(2), row(3))
            Next

            'CLEAR DATATABLE
            dt.Rows.Clear()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    'UPDATE DATABASE
    Private Sub UpdateLV(id As String, spacecraft As String, propellant As String, destination As String)
        'SQL STATEMENT
        Dim sql As String = "UPDATE spacecraftsTB SET S_Name='" + spacecraft + "',S_Propellant='" + propellant + "',S_Destination='" + destination + "' WHERE ID=" + id + ""
        cmd = New OleDbCommand(sql, con)

        'OPEN CONNECTION,EXECUTE UPDATE,CLOSE CONNECTION'
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.UpdateCommand = con.CreateCommand()
            adapter.UpdateCommand.CommandText = sql

            If (adapter.UpdateCommand.ExecuteNonQuery() > 0) Then
                MsgBox("Successfully Updated")
                CleartextBoxes()
            End If
            con.Close()
            Retrieve()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    'DELETE FROM DATABASE
    Private Sub Delete(id As String)
        'ELETE SQL STATEMENT
        Dim sql As String = "DELETE FROM spacecraftsTB WHERE ID=" + id + ""
        cmd = New OleDbCommand(sql, con)

        'OPEN CONNECTION,EXECUTE DELETE,CLOSE CONNECTION
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.DeleteCommand = con.CreateCommand()
            adapter.DeleteCommand.CommandText = sql

            'PROMPT FOR CONFIRMATION BEFORE DELETE
            If MessageBox.Show("Are you sure to permanently delete this?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                If cmd.ExecuteNonQuery() > 0 Then
                    CleartextBoxes()
                    MsgBox("Successfully deleted")
                End If
            End If
            con.Close()
            Retrieve()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub

    'RESET TEXTBOXES
    Private Sub CleartextBoxes()
        nameTxt.Text = ""
        propellantTxt.Text = ""
        destinationTxt.Text = ""
    End Sub

    'ADD BUTTON CLICKED
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Add()
    End Sub

    'RETRIEVE BUTTON CLICKED
    Private Sub retrieveBtn_Click(sender As Object, e As EventArgs) Handles retrieveBtn.Click
        Retrieve()
    End Sub

    'UPDATE BUTTON CLICKED
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim selectedIndex As Int32 = mListView.SelectedIndices(0)
        
        If Not selectedIndex = -1 Then
            Dim id As String = mListView.SelectedItems(0).SubItems(0).Text
            ' Dim id As Int32 = Convert.ToInt32(selected)
            UpdateLV(id, nameTxt.Text, propellantTxt.Text, destinationTxt.Text)
        End If
       
    End Sub


    'DELETE BUTTON CLICKED
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
      Dim selectedIndex As Int32 = mListView.SelectedIndices(0)

        If Not selectedIndex = -1 Then
            Dim id As String = mListView.SelectedItems(0).SubItems(0).Text
            ' Dim id As Int32 = Convert.ToInt32(selected)
            Delete(id)
        End If
    End Sub

    'CLEAR BUTTON CLICKED
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        mListView.Items.Clear()
        CleartextBoxes()
    End Sub

    'LISTVIEW SELECTION CHANGED
    Private Sub mListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mListView.SelectedIndexChanged
        Try
            Dim selectedIndex As Int32 = mListView.SelectedIndices(0)

            If Not selectedIndex = -1 Then

                If mListView.SelectedItems(0).SubItems(0).Text IsNot Nothing Then

                    'GET SELECTED ITEMS
                    Dim spacecraft As String = mListView.SelectedItems(0).SubItems(1).Text
                    Dim propellant As String = mListView.SelectedItems(0).SubItems(2).Text
                    Dim destination As String = mListView.SelectedItems(0).SubItems(3).Text

                    'SET THEM TO TEXTBOXES
                    nameTxt.Text = spacecraft
                    propellantTxt.Text = propellant
                    destinationTxt.Text = destination


                End If
            End If

        Catch ex As ArgumentOutOfRangeException

        End Try
        
    End Sub

    
End Class