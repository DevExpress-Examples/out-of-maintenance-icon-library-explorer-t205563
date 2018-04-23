using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using DevExpress.Web.ASPxThemes;
using DevExpress.Images;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

public partial class _Default: System.Web.UI.Page {

    private GridViewPagerMode PagerMode
    {
        get
        {
            return (GridViewPagerMode)(Session["PagerMode"] ?? GridViewPagerMode.ShowPager);
        }
        set
        {
            Session["PagerMode"] = value;
        }
    }
    protected void Page_Init(object sender, EventArgs e) {
        if (Session["PagerMode"] != null)
            cbEndless.Checked = (Session["PagerMode"].ToString() == GridViewPagerMode.EndlessPaging.ToString());

        if (Session["ListOfIcons"] == null)
            Session["ListOfIcons"] = GenerateIconList();

        gridView.SettingsPager.Mode = PagerMode;

        gridView.DataSource = Session["ListOfIcons"] as List<IconInfo>;
        gridView.DataBind();
    }

    protected void cbEndless_CheckedChanged(object sender, EventArgs e) {
        PagerMode = cbEndless.Checked ? GridViewPagerMode.EndlessPaging : GridViewPagerMode.ShowPager;

        gridView.SettingsPager.Mode = PagerMode;
        gridView.ResetToFirstPage();
    }
    public List<IconInfo> GenerateIconList() {
        List<IconInfo> list = new List<IconInfo>();
        foreach (var field in typeof(IconID).GetFields()) {
            string fullIconID = field.GetValue("").ToString();

            string size = Regex.Match(field.Name, "[1-9][0-9]x[1-9][0-9]").ToString();
            string[] sName = Regex.Split(field.Name, "[1-9][0-9]x[1-9][0-9]", RegexOptions.Compiled);
            string[] properties = Regex.Split(sName[0], "(?=[A-Z][a-z])|(?<=[a-z])(?=[A-Z])", RegexOptions.Compiled);


            //fix for names divided by number (like Chart3dclusteredcolumn16x16)
            string category;
            string iconName;
            if (properties.Length == 2) {
                string[] properties2 = properties[1].Split('3');
                category = properties2[0];
                iconName = "3" + properties2[1];
            }
            else {
                category = properties[1];
                iconName = properties[2];
            }


            string collection = sName[1];
            if (collection == string.Empty)
                collection = "Colored";
            else
                collection = FirstCharToUpper(collection);

            IconInfo icon = new IconInfo(category, size, collection, iconName, fullIconID, field.Name);
            list.Add(icon);
        }
        return list;
    }
    public static string FirstCharToUpper(string input) {
        if (String.IsNullOrEmpty(input))
            return input;
        return input.First().ToString().ToUpper() + input.Substring(1);
    }

    protected void gridView_CustomCallback(object sender, ASPxGridViewCustomCallbackEventArgs e) {
        if (e.Parameters == "clear") {
            ASPxGridView gridView = sender as ASPxGridView;
            gridView.FilterExpression = "";
            foreach (GridViewDataColumn column in gridView.Columns) {
                if (column.GroupIndex > -1)
                    gridView.UnGroup(column);
                if (column.SortIndex > -1)
                    column.SortIndex = -1;
            }
            gridView.SearchPanelFilter = "";
            gridView.PageIndex = 0;
        }

    }

    protected void clbPanel_Callback(object sender, CallbackEventArgsBase e) {
        if (e.Parameter == "changePagerMode") {
            if (cbEndless.Checked)
                gridView.SettingsPager.Mode = PagerMode = GridViewPagerMode.EndlessPaging;
            else
                gridView.SettingsPager.Mode = PagerMode = GridViewPagerMode.ShowPager;
        }
    }
}

