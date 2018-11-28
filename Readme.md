<!-- default file list -->
*Files to look at*:

* [IconInfo.cs](./CS/App_Code/IconInfo.cs) (VB: [IconInfo.vb](./VB/App_Code/IconInfo.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# Icon Library Explorer


<p> In this example, you can see all icons that are available in our <a href="https://documentation.devexpress.com/#AspNet/CustomDocument15861">Icon Library</a>.</p>
<p>To easily find the required image, you can filter them by image size or used collection or group data by columns. In addition, you can use the Search Panel to find an icon by its text. Then, copy the required icon ID from the "Full Icon ID" column and insert it to the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebImagePropertiesBase_IconIDtopic">IconID</a> property in your project:</p>


```cs
    settings.Items.Add(item => {
        item.Text = "Home";
        item.Image.IconID = "navigation_home_16x16";
    });
```


<p><br><strong>See also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/T501932">How to use the DevExpress Icon Collection</a><br /><a href="https://demos.devexpress.com/ASPxMultiUseControlsDemos/Features/IconLibraryExplorer.aspx">Icon Library Explorer Demo</a></p>

<br/>


