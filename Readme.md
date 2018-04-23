# How to extend the auto-search feature of the GridLookUpEdit to search by multiple columns


<p>Starting from version 9.1.0, the GridLookUpEdit provides the capability to use the "Contains" operator as the auto-search criteria (<a href="https://www.devexpress.com/Support/Center/p/S30733">GridLookUpEdit - Add "Contains" filter mode with highlighting</a>). This example demonstrates how to extend this functionality, and use values from several columns to find a necessary record. To implement this, values from these columns are combined and displayed in the editor as a single string.</p>


<h3>Description</h3>

<p>In this example, the RepositoryItemLookUpEdit&#39;s view has one unbound column. This column is populated with values using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridColumnsGridColumn_UnboundExpressiontopic">Unbound Expression</a>, which simply convert values of several columns into a String and concatenates them. The FieldName property of this column is used as the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemLookUpEditBase_DisplayMembertopic">DisplayMember</a> for the GridLookUpEdit to support the auto-search functionality. However, values of this column won&#39;t be automatically displayed in the editor. You need to handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItem_CustomDisplayTexttopic">RepositoryItem.CustomDisplayText</a> event to populate the display text manually (<a data-ticket="AS3686">GridLookup - Allow using unbound columns for DisplayMember</a>).</p><p>In additional, you need to set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemGridLookUpEdit_PopupFilterModetopic">PopupFilterMode</a> property to PopupFilterMode.Contains to enable the Contains filter. You may also want to set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItemLookUpEditBase_TextEditStyletopic">RepositoryItemLookUpEditBase.TextEditStyle</a> property to TextEditStyles.Standard to allow entering the text.</p>

<br/>


