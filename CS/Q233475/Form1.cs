using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Data;
using System.Windows.Forms;

namespace Q233475
{
    public partial class Form1 : Form
    {
        DataSet dataSet;
        Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            dataSet = new DataSet();
            dataSet.Tables.Add(GetCategoriesDataTable());
            dataSet.Tables.Add(GetProductsDataTable());
            DataColumn keyColumn = dataSet.Tables["Categories"].Columns["CategoryID"];
            DataColumn foreignKeyColumn = dataSet.Tables["Products"].Columns["CategoryID"];
            dataSet.Relations.Add("CategoriesProducts", keyColumn, foreignKeyColumn);
            productsBindingSource.DataSource = dataSet;
            categoriesBindingSource.DataSource = dataSet;
        }
        DataTable GetCategoriesDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Categories";
            table.Columns.Add(new DataColumn("CategoryID", typeof(int)));
            table.Columns.Add(new DataColumn("CategoryName", typeof(string)));
            for (int i = 0; i < 10; i++)
                table.Rows.Add(i, "Category " + i);
            return table;
        }

        DataTable GetProductsDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Products";
            table.Columns.Add(new DataColumn("ProductID", typeof(int)));
            table.Columns.Add(new DataColumn("ProductName", typeof(string)));
            table.Columns.Add(new DataColumn("CategoryID", typeof(int)));
            for (int i = 0; i < 100; i++)
                table.Rows.Add(i, "Product " + i, random.Next(10));
            return table;
        }

        private void OnRepositoryItemGridLookUpEditCloseUp(object sender, CloseUpEventArgs e)
        {
            if (gridView1.ActiveEditor != null)
                ((TextEdit)gridView1.ActiveEditor).SelectAll();
        }

        private void OnRepositoryItemGridLookUpEditCustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            RepositoryItemGridLookUpEdit edit = sender as RepositoryItemGridLookUpEdit;
            if (edit == null) edit = ((GridLookUpEdit)sender).Properties;
            e.DisplayText = edit.View.GetRowCellValue(edit.View.LocateByValue(0, colCategoryID1, e.Value), "Total").ToString();
        }
    }
}