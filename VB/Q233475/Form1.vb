Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Namespace Q233475
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

		End Sub

		Private Sub OnRepositoryItemGridLookUpEditCustomDisplayText(ByVal sender As Object, ByVal e As CustomDisplayTextEventArgs) Handles repositoryItemGridLookUpEdit1.CustomDisplayText
			Dim edit As RepositoryItemGridLookUpEdit = TryCast(sender, RepositoryItemGridLookUpEdit)
			If edit Is Nothing Then
				edit = (CType(sender, GridLookUpEdit)).Properties
			End If
			e.DisplayText = edit.View.GetRowCellValue(edit.View.LocateByValue(0, colCategoryID1, e.Value), "Total").ToString()
		End Sub

		Private Sub OnRepositoryItemGridLookUpEditCloseUp(ByVal sender As Object, ByVal e As CloseUpEventArgs) Handles repositoryItemGridLookUpEdit1.CloseUp
			If gridView1.ActiveEditor IsNot Nothing Then
				CType(gridView1.ActiveEditor, TextEdit).SelectAll()
			End If
		End Sub
	End Class
End Namespace