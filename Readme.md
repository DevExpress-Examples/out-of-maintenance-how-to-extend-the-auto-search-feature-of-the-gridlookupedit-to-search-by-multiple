<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628693/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1795)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q233475/Form1.cs) (VB: [Form1.vb](./VB/Q233475/Form1.vb))
<!-- default file list end -->
# How to extend the auto-search feature of the GridLookUpEdit to search by multiple columns

Starting from version 11.1, we added the [SearchLookUpEdit](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraEditors.SearchLookUpEdit.class) editor that provides the capability to perform searching through all columns out of the box. Thus, it is sufficient to set the [PopupFilterMode](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraEditors.PopupFilterMode.enum) property to *Default*. 
This example demonstrates how to achieve this functionality via the editor.

