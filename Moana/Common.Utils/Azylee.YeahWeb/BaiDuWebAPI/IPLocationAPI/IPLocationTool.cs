﻿using Azylee.YeahWeb.HttpUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Azylee.YeahWeb.BaiDuWebAPI.IPLocationAPI
{
    public static class IPLocationTool
    {
        const string URL = "http://map.baidu.com/?qt=ipLocation";
        public static IPLocationModel GetLocation()
        {
            IPLocationWebModel model = null;
            try
            {
                CookieCollection cookie = new CookieCollection();
                string rss1 = HttpToolPlus.Get(URL, ref cookie);//第一次请求以获取Cookie
                string rss2 = HttpToolPlus.Get(URL, ref cookie);//携带第一次的Cookie获取数据
                model = JsonConvert.DeserializeObject<IPLocationWebModel>(rss2);
                return model.ToIPLocationModel();
            }
            catch (Exception e) { return null; }
        }
    }
}
