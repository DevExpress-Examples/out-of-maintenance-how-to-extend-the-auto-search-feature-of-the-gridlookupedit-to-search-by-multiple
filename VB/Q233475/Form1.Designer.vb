Namespace Q233475
    Partial Class Form1
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.categoriesBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemGridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.gridControl1.DataSource = Me.productsBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemGridLookUpEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(292, 273)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            Me.productsBindingSource.DataMember = "Products"
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductID, Me.colProductName, Me.colCategoryID})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            Me.colProductID.Visible = True
            Me.colProductID.VisibleIndex = 0
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            Me.colCategoryID.ColumnEdit = Me.repositoryItemGridLookUpEdit1
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.Visible = True
            Me.colCategoryID.VisibleIndex = 2
            Me.repositoryItemGridLookUpEdit1.AutoHeight = False
            Me.repositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemGridLookUpEdit1.DataSource = Me.categoriesBindingSource
            Me.repositoryItemGridLookUpEdit1.DisplayMember = "Total"
            Me.repositoryItemGridLookUpEdit1.ImmediatePopup = True
            Me.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1"
            Me.repositoryItemGridLookUpEdit1.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
            Me.repositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.repositoryItemGridLookUpEdit1.ValueMember = "CategoryID"
            Me.repositoryItemGridLookUpEdit1.View = Me.repositoryItemGridLookUpEdit1View
            AddHandler Me.repositoryItemGridLookUpEdit1.CustomDisplayText, AddressOf Me.OnRepositoryItemGridLookUpEditCustomDisplayText
            AddHandler Me.repositoryItemGridLookUpEdit1.CloseUp, AddressOf Me.OnRepositoryItemGridLookUpEditCloseUp
            Me.categoriesBindingSource.DataMember = "Categories"
            Me.repositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID1, Me.colCategoryName, Me.colTotal})
            Me.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View"
            Me.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowHorzLines = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = False
            Me.repositoryItemGridLookUpEdit1View.OptionsView.ShowVertLines = False
            Me.colCategoryID1.FieldName = "CategoryID"
            Me.colCategoryID1.Name = "colCategoryID1"
            Me.colCategoryID1.OptionsColumn.ShowInCustomizationForm = False
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.OptionsColumn.ShowInCustomizationForm = False
            Me.colTotal.FieldName = "Total"
            Me.colTotal.Name = "colTotal"
            Me.colTotal.UnboundExpression = "Concat(' ', ToStr([CategoryID]), ' ', [CategoryName])"
            Me.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.String
            Me.colTotal.Visible = True
            Me.colTotal.VisibleIndex = 0
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(292, 273)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, AddressOf Me.Form1_Load
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.productsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.categoriesBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemGridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private productsBindingSource As System.Windows.Forms.BindingSource
        Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
        Private repositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Private categoriesBindingSource As System.Windows.Forms.BindingSource
        Private colCategoryID1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
        Private colTotal As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
