using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.unionpay.acp.sdk;
using System.Text;
using System.IO;

namespace upacp_demo_app.demo.api_05_app
{
    public partial class VerifyAppData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                        
            /**
             * 对控件给商户APP返回的应答信息验签，前段请直接把string型的json串post上来
             */
            StreamReader reader = new StreamReader(Request.InputStream);
            string data = reader.ReadToEnd();
            Response.Write(AcpService.ValidateAppResponse(data, Encoding.UTF8)?"true":"false");
        }

    }
}
