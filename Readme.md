# How to share SiteMap between Menu and SiteMapControl placed within SubMenuTemplate


<p>This example illustrates how to share the same SiteMap between ASPxMenu and ASPxSiteMapControl placed to show information from different SiteMap node levels. Here are steps you need to execute:</p><p>- Place ASPxSiteMapControl within <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxMenuASPxMenuBase_SubMenuTemplatetopic"><u>ASPxMenu.SubMenuTemplate</u></a>;<br />
- Specify the ASPxSiteMapControl.DataSource property. ASPxSiteMapControl and ASPxMenu should have different ASPxSiteMapDataSource;<br />
- Handle the ASPxSiteMapControl.DataBinding event;<br />
- Define the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxSiteMapControlASPxSiteMapDataSource_StartingNodeUrltopic"><u>ASPxSiteMapDataSource.StartingNodeUrl</u></a> property according to the parent menu node's NavigateUrl:</p>

<br/>


