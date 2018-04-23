Imports Microsoft.VisualBasic
Imports System
Namespace Q233475
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q233475.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.repositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCategoryID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.productsTableAdapter = New Q233475.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.categoriesTableAdapter = New Q233475.nwindDataSetTableAdapters.CategoriesTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.productsBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemGridLookUpEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(292, 273)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colCategoryID})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colProductID
			' 
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 0
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			' 
			' colCategoryID
			' 
			Me.colCategoryID.ColumnEdit = Me.repositoryItemGridLookUpEdit1
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 2
			' 
			' repositoryItemGridLookUpEdit1
			' 
			Me.repositoryItemGridLookUpEdit1.AutoHeight = False
			Me.repositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemGridLookUpEdit1.DataSource = Me.categoriesBindingSource
			Me.repositoryItemGridLookUpEdit1.DisplayMember = "Total"
			Me.repositoryItemGridLookUpEdit1.ImmediatePopup = True
			Me.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1"
			Me.repositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
			Me.repositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.repositoryItemGridLookUpEdit1.ValueMember = "CategoryID"
			Me.repositoryItemGridLookUpEdit1.View = Me.repositoryItemGridLookUpEdit1View
'			Me.repositoryItemGridLookUpEdit1.CustomDisplayText += New DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(Me.OnRepositoryItemGridLookUpEditCustomDisplayText);
'			Me.repositoryItemGridLookUpEdit1.CloseUp += New DevExpress.XtraEditors.Controls.CloseUpEventHandler(Me.OnRepositoryItemGridLookUpEditCloseUp);
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' repositoryItemGridLookUpEdit1View
			' 
			Me.repositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID1, Me.colCategoryName, Me.colTotal})
			Me.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View"
			Me.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
			Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowHorzLines = False
			Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = False
			Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowVertLines = False
			' 
			' colCategoryID1
			' 
			Me.colCategoryID1.FieldName = "CategoryID"
			Me.colCategoryID1.Name = "colCategoryID1"
			Me.colCategoryID1.OptionsColumn.ShowInCustomizationForm = False
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.OptionsColumn.ShowInCustomizationForm = False
			' 
			' colTotal
			' 
			Me.colTotal.FieldName = "Total"
			Me.colTotal.Name = "colTotal"
			Me.colTotal.UnboundExpression = "Concat(' ', ToStr([CategoryID]), ' ', [CategoryName])"
			Me.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.colTotal.Visible = True
			Me.colTotal.VisibleIndex = 0
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 273)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As Q233475.nwindDataSetTableAdapters.ProductsTableAdapter
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents repositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
		Private repositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As Q233475.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private colCategoryID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colTotal As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

