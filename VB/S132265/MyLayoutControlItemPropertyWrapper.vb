Imports Microsoft.VisualBasic
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors.Mask
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace DXSample
	Public Class MyLayoutControlItemPropertyWrapper
		Inherits LayoutControlItemWrapper
		Protected ReadOnly Property Editor() As TextEdit
			Get
				Return TryCast(Item.Control, TextEdit)
			End Get
		End Property

		<Category("Mask"), DefaultValue(AutoCompleteType.Default)> _
		Public Property AutoComplete() As AutoCompleteType
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.AutoComplete
				Else
					Return AutoCompleteType.Default
				End If
			End Get
			Set(ByVal value As AutoCompleteType)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.AutoComplete = value
				End If
			End Set
		End Property

		<Category("Mask"), DefaultValue(False)> _
		Public Property BeepOnError() As Boolean
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.BeepOnError
				Else
					Return False
				End If
			End Get
			Set(ByVal value As Boolean)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.BeepOnError = value
				End If
			End Set
		End Property

		<Category("Mask"), DefaultValue("")> _
		Public Property EditMask() As String
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.EditMask
				Else
					Return String.Empty
				End If
			End Get
			Set(ByVal value As String)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.EditMask = value
				End If
			End Set
		End Property

		<Category("Mask"), DefaultValue(True)> _
		Public Property IgnoreMaskBlank() As Boolean
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.IgnoreMaskBlank
				Else
					Return True
				End If
			End Get
			Set(ByVal value As Boolean)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.IgnoreMaskBlank = True
				End If
			End Set
		End Property

		<Category("Mask"), DefaultValue(MaskType.None)> _
		Public Property MaskType() As MaskType
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.MaskType
				Else
					Return MaskType.None
				End If
			End Get
			Set(ByVal value As MaskType)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.MaskType = value
				End If
			End Set
		End Property

		<Category("Mask"), DefaultValue(ControlChars.NullChar)> _
		Public Property PlaceHolder() As Char
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.PlaceHolder
				Else
					Return ControlChars.NullChar
				End If
			End Get
			Set(ByVal value As Char)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.PlaceHolder = ControlChars.NullChar
				End If
			End Set
		End Property

		<Category("Mask"), DefaultValue(True)> _
		Public Property SaveLiteral() As Boolean
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.SaveLiteral
				Else
					Return True
				End If
			End Get
			Set(ByVal value As Boolean)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.SaveLiteral = value
				End If
			End Set
		End Property

		<Category("Mask"), DefaultValue(True)> _
		Public Property ShowPlaceHolders() As Boolean
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.ShowPlaceHolders
				Else
					Return True
				End If
			End Get
			Set(ByVal value As Boolean)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.ShowPlaceHolders = value
				End If
			End Set
		End Property

		<Category("Mask"), DefaultValue(False)> _
		Public Property UseMaskAsDisplayFormat() As Boolean
			Get
				If Editor IsNot Nothing Then
					Return Editor.Properties.Mask.UseMaskAsDisplayFormat
				Else
					Return False
				End If
			End Get
			Set(ByVal value As Boolean)
				If Editor IsNot Nothing Then
					Editor.Properties.Mask.UseMaskAsDisplayFormat = value
				End If
			End Set
		End Property

		Public Overrides Function Clone() As BasePropertyGridObjectWrapper
			Return New MyLayoutControlItemPropertyWrapper()
		End Function
	End Class
End Namespace