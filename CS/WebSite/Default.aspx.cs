using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Web;


public partial class _Default : System.Web.UI.Page {
    protected void grid_HeaderFilterFillItems(object sender, ASPxGridViewHeaderFilterEventArgs e) {
        if (e.Column.FieldName != "CategoryNameNull")
            return;

        e.Values.Insert(0, FilterValue.CreateShowBlanksValue(e.Column, "Blanks"));
        e.Values.Insert(1, FilterValue.CreateShowNonBlanksValue(e.Column, "Non Blanks"));
    }
}
