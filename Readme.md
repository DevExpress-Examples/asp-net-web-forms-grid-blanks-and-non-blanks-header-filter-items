<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128533717/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4218)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to create the ShowBlanksValue and ShowNonBlanksValue items
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4218/)**
<!-- run online end -->


<p>By design, GridViewDataComboBoxColumn does not render (Blank) and (NonBlank) items if the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewDataColumnSettings_HeaderFilterModetopic"><u>HeaderFilterMode</u></a> property is set to <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewHeaderFilterModeEnumtopic"><u>CheckedList</u></a>. However, you can add these items in the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_HeaderFilterFillItemstopic"><u>HeaderFilterFillItems</u></a> event handler. Just call the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewFilterValue_CreateShowBlanksValuetopic"><u>FilterValue.CreateShowBlanksValue</u></a> and <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewFilterValue_CreateShowNonBlanksValuetopic"><u>FilterValue.CreateShowNonBlanksValue</u></a> methods. </p>

<br/>


