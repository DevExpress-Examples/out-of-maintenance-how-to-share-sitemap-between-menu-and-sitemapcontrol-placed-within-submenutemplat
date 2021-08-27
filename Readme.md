<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128565095/11.1.9%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3622)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to share SiteMap between Menu and SiteMapControl placed within SubMenuTemplate
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3622/)**
<!-- run online end -->


<p>This example illustrates how to share the same SiteMap between ASPxMenu and ASPxSiteMapControl placed to show information from different SiteMap node levels. Here are steps you need to execute:</p><p>- Place ASPxSiteMapControl within <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxMenuASPxMenuBase_SubMenuTemplatetopic"><u>ASPxMenu.SubMenuTemplate</u></a>;<br />
- Specify the ASPxSiteMapControl.DataSource property. ASPxSiteMapControl and ASPxMenu should have different ASPxSiteMapDataSource;<br />
- Handle the ASPxSiteMapControl.DataBinding event;<br />
- Define the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxSiteMapControlASPxSiteMapDataSource_StartingNodeUrltopic"><u>ASPxSiteMapDataSource.StartingNodeUrl</u></a> property according to the parent menu node's NavigateUrl:</p>

<br/>


