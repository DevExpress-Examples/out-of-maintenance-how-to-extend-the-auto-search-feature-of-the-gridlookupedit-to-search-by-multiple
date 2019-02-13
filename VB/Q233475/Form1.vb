Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace Q233475
    Partial Public Class Form1
        Inherits Form

        Private dataSet As DataSet
        Private random As Random

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            random = New Random()
            dataSet = New DataSet()
            dataSet.Tables.Add(GetCategoriesDataTable())
            dataSet.Tables.Add(GetProductsDataTable())
            Dim keyColumn As DataColumn = dataSet.Tables("Categories").Columns("CategoryID")
            Dim foreignKeyColumn As DataColumn = dataSet.Tables("Products").Columns("CategoryID")
            dataSet.Relations.Add("CategoriesProducts", keyColumn, foreignKeyColumn)
            productsBindingSource.DataSource = dataSet
            categoriesBindingSource.DataSource = dataSet
        End Sub

        Private Function GetCategoriesDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Categories"
            table.Columns.Add(New DataColumn("CategoryID", GetType(Integer)))
            table.Columns.Add(New DataColumn("CategoryName", GetType(String)))

            For i As Integer = 0 To 10 - 1
                table.Rows.Add(i, "Category " & i)
            Next

            Return table
        End Function

        Private Function GetProductsDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.TableName = "Products"
            table.Columns.Add(New DataColumn("ProductID", GetType(Integer)))
            table.Columns.Add(New DataColumn("ProductName", GetType(String)))
            table.Columns.Add(New DataColumn("CategoryID", GetType(Integer)))

            For i As Integer = 0 To 100 - 1
                table.Rows.Add(i, "Product " & i, random.[Next](10))
            Next

            Return table
        End Function

        Private Sub OnRepositoryItemGridLookUpEditCloseUp(ByVal sender As Object, ByVal e As CloseUpEventArgs)
            If gridView1.ActiveEditor IsNot Nothing Then CType(gridView1.ActiveEditor, TextEdit).SelectAll()
        End Sub

        Private Sub OnRepositoryItemGridLookUpEditCustomDisplayText(ByVal sender As Object, ByVal e As CustomDisplayTextEventArgs)
            Dim edit As RepositoryItemGridLookUpEdit = TryCast(sender, RepositoryItemGridLookUpEdit)
            If edit Is Nothing Then edit = (CType(sender, GridLookUpEdit)).Properties
            e.DisplayText = edit.View.GetRowCellValue(edit.View.LocateByValue(0, colCategoryID1, e.Value), "Total").ToString()
        End Sub
    End Class
End Namespace