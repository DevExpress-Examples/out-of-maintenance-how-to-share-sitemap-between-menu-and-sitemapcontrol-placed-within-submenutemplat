// Developer Express Code Central Example:
// How to share the same SiteMap between ASPxMenu and ASPxSiteMapControl placed within ASPxMenu.SubMenuTemplate
// 
// This example illustrates how to share the same SiteMap between ASPxMenu and
// ASPxSiteMapControl placed to show information from different SiteMap node
// levels. Here are steps you need to execute:
// - Place ASPxSiteMapControl within
// ASPxMenu.SubMenuTemplate
// (http://documentation.devexpress.com/#AspNet/DevExpressWebASPxMenuASPxMenuBase_SubMenuTemplatetopic);
// -
// Specify the ASPxSiteMapControl.DataSource property. ASPxSiteMapControl and
// ASPxMenu should have different ASPxSiteMapDataSource;
// - Handle the
// ASPxSiteMapControl.DataBinding event;
// - Define the
// ASPxSiteMapDataSource.StartingNodeUrl
// (http://documentation.devexpress.com/#AspNet/DevExpressWebASPxSiteMapControlASPxSiteMapDataSource_StartingNodeUrltopic)
// property according to the parent menu node's NavigateUrl:
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3622

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web;


public partial class _Default : System.Web.UI.Page {
    protected void Page_Load (object sender, EventArgs e) {

    }
    public object GetDataSource() {
        ASPxSiteMapDataSource ds = new ASPxSiteMapDataSource();
        ds.SiteMapProvider = menuSiteMapDataSource.SiteMapProvider;
        return ds;
    }
    protected void ASPxSiteMapControl1_DataBinding(object sender, EventArgs e) {
        ASPxSiteMapControl sitemapControl = sender as ASPxSiteMapControl;
        DevExpress.Web.MenuItemTemplateContainer container = sitemapControl.NamingContainer as DevExpress.Web.MenuItemTemplateContainer;
        (sitemapControl.DataSource as ASPxSiteMapDataSource).StartingNodeUrl = container.Item.NavigateUrl;
    }
}
