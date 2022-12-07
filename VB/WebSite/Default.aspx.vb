' Developer Express Code Central Example:
' How to share the same SiteMap between ASPxMenu and ASPxSiteMapControl placed within ASPxMenu.SubMenuTemplate
' 
' This example illustrates how to share the same SiteMap between ASPxMenu and
' ASPxSiteMapControl placed to show information from different SiteMap node
' levels. Here are steps you need to execute:
' - Place ASPxSiteMapControl within
' ASPxMenu.SubMenuTemplate
' (http://documentation.devexpress.com/#AspNet/DevExpressWebASPxMenuASPxMenuBase_SubMenuTemplatetopic);
' -
' Specify the ASPxSiteMapControl.DataSource property. ASPxSiteMapControl and
' ASPxMenu should have different ASPxSiteMapDataSource;
' - Handle the
' ASPxSiteMapControl.DataBinding event;
' - Define the
' ASPxSiteMapDataSource.StartingNodeUrl
' (http://documentation.devexpress.com/#AspNet/DevExpressWebASPxSiteMapControlASPxSiteMapDataSource_StartingNodeUrltopic)
' property according to the parent menu node's NavigateUrl:
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3622

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Web


Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Public Function GetDataSource() As Object
        Dim ds As New ASPxSiteMapDataSource()
        ds.SiteMapProvider = menuSiteMapDataSource.SiteMapProvider
        Return ds
    End Function
    Protected Sub ASPxSiteMapControl1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        Dim sitemapControl As ASPxSiteMapControl = TryCast(sender, ASPxSiteMapControl)
        Dim container As DevExpress.Web.MenuItemTemplateContainer = TryCast(sitemapControl.NamingContainer, DevExpress.Web.MenuItemTemplateContainer)
        TryCast(sitemapControl.DataSource, ASPxSiteMapDataSource).StartingNodeUrl = container.Item.NavigateUrl
    End Sub
End Class
