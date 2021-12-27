
Imports System
Imports System.Windows.Forms
'/ <summary>
'/ Custom Tree node, used for Tee5Demo
'/ </summary>

Class DemoNode
    Inherits TreeNode
    Private fabsoluteindex As Integer
    Public Sub New([text] As String)
        Me.Text = [text]
    End Sub 'New
    
#If VS2005 Then
    Public Overloads ReadOnly Property Level() As Integer
#Else
    Public ReadOnly Property Level() As Integer
#End If
        Get
            Dim n As TreeNode = Me.Parent
            Dim l As Integer = 0
            While Not (n Is Nothing)
                l += 1
                n = n.Parent
            End While
            Return l
        End Get
    End Property


	Public Property AbsoluteIndex() As Integer
		Get
			Return fabsoluteindex
		End Get
		Set(ByVal value As Integer)
			fabsoluteindex = value
		End Set
	End Property
	Public Function MoveForward() As TreeNode
		Dim res As TreeNode = Nothing
		' any children ?
		If Nodes.Count > 0 Then
			res = Nodes(0)
			' any siblings ?
		ElseIf Not (NextNode Is Nothing) Then
			res = NextNode
		ElseIf Not (Parent Is Nothing) Then
			Dim tmpNode As TreeNode = Parent
			While tmpNode.NextNode Is Nothing
				tmpNode = tmpNode.Parent
			End While
			res = tmpNode.NextNode
		End If
		Return res
	End Function 'MoveForward
	Public Function MoveBackward() As TreeNode
		Dim res As TreeNode = Nothing
		' any siblings
		If Not (PrevNode Is Nothing) Then
			If PrevNode.Nodes.Count > 0 Then
				Dim tmpNode As TreeNode = PrevNode
				While tmpNode.Nodes.Count > 0
					tmpNode = tmpNode.Nodes(tmpNode.Nodes.Count - 1)
				End While
				res = tmpNode
			Else
				res = PrevNode
			End If
			' parent node ?
		ElseIf Not (Parent Is Nothing) Then
			res = Parent
		End If
		Return res
	End Function 'MoveBackward
End Class 'DemoNode 
