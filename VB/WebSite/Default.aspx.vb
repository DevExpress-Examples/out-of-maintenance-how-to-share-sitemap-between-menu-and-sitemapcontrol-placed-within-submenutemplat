Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Web.ASPxMenu
Imports DevExpress.Web.ASPxSiteMapControl


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
        Dim container As DevExpress.Web.ASPxMenu.MenuItemTemplateContainer = TryCast(sitemapControl.NamingContainer, DevExpress.Web.ASPxMenu.MenuItemTemplateContainer)
        TryCast(sitemapControl.DataSource, ASPxSiteMapDataSource).StartingNodeUrl = container.Item.NavigateUrl
    End Sub
End Class
