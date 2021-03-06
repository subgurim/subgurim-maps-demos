﻿using System;
using Subgurim.Controles;

namespace Demos.Geo
{
    public partial class GeoXml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GMap1.setCenter(new GLatLng(49.496675, -102.65625), 3);
            GMap1.Add(new GGeoXml("http://gmaps-samples.googlecode.com/svn/trunk/ggeoxml/blackbirds.kml"));
            GMap1.Add(new GGeoXml("http://api.flickr.com/services/feeds/groups_pool.gne?id=322338@N20&format=rss_200&georss=1"));
        }
    }
}