using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace Q233475 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }

        private void OnRepositoryItemGridLookUpEditCustomDisplayText(object sender, CustomDisplayTextEventArgs e) {
            RepositoryItemGridLookUpEdit edit = sender as RepositoryItemGridLookUpEdit;
            if (edit == null) edit = ((GridLookUpEdit)sender).Properties;
            e.DisplayText = edit.View.GetRowCellValue(edit.View.LocateByValue(0, colCategoryID1, e.Value), "Total").ToString();
        }

        private void OnRepositoryItemGridLookUpEditCloseUp(object sender, CloseUpEventArgs e) {
            if (gridView1.ActiveEditor != null)
                ((TextEdit)gridView1.ActiveEditor).SelectAll();
        }
    }
}