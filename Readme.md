<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128533717/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4218)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Grid View for ASP.NET Web Forms - How to create ShowBlanksValue and ShowNonBlanksValue items in the header filter

[GridViewDataComboBoxColumn](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewDataComboBoxColumn) does not render **(Blank)** and **(NonBlank)** items if the [HeaderFilterMode](https://docs.devexpress.com/AspNet/DevExpress.Web.GridDataColumnSettings.HeaderFilterMode) property is set to `CheckedList`. 
Call the [FilterValue.CreateShowBlanksValue](https://docs.devexpress.com/AspNet/DevExpress.Web.FilterValue.CreateShowBlanksValue(DevExpress.Web.GridViewDataColumn-System.String)) and [FilterValue.CreateShowNonBlanksValue](https://docs.devexpress.com/AspNet/DevExpress.Web.FilterValue.CreateShowNonBlanksValue(DevExpress.Web.GridViewDataColumn-System.String)) methods in the [HeaderFilterFillItems](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.HeaderFilterFillItems) event handler to add these items.

![](grid-with-header-menu.png)

```csharp
protected void grid_HeaderFilterFillItems(object sender, ASPxGridViewHeaderFilterEventArgs e) {
    if (e.Column.FieldName != "CategoryNameNull")
        return;
    e.Values.Insert(0, FilterValue.CreateShowBlanksValue(e.Column, "Blanks"));
    e.Values.Insert(1, FilterValue.CreateShowNonBlanksValue(e.Column, "Non Blanks"));
}
```

## Files to Review

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-blanks-and-non-blanks-header-filter-items&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-blanks-and-non-blanks-header-filter-items&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
