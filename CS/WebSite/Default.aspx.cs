using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Web.ASPxMenu;
using DevExpress.Web.ASPxSiteMapControl;


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
        DevExpress.Web.ASPxMenu.MenuItemTemplateContainer container = sitemapControl.NamingContainer as DevExpress.Web.ASPxMenu.MenuItemTemplateContainer;
        (sitemapControl.DataSource as ASPxSiteMapDataSource).StartingNodeUrl = container.Item.NavigateUrl;
    }
}
