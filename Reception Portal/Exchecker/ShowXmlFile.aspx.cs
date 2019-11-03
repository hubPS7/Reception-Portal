using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text;

namespace Exchecker
{
    public partial class ShowXmlFile : System.Web.UI.Page
    {

        private XmlDocument doc;
        private XmlElement root;

        protected void Page_Load(object sender, EventArgs e)
        {
           xmlread();
         
        }

        public void xmlread()
        {
            try
            {
                string PATH = Server.MapPath("\\Xmlfile\\ExchangeCentre.xml");
                doc = new XmlDocument();
                doc.Load(PATH);
                root = doc.DocumentElement;
                string value = root.GetElementsByTagName("ExchangeCentre")[0].InnerText;
                ExchangeCentre.Text = "Your Chief Fire Warden today is " + value +")";
                OnGoingWork.Text = root.GetElementsByTagName("OnGoingWork")[0].InnerText;
                CurrentBuldngMaintenance.Text = root.GetElementsByTagName("CurrentBuldngMaintenance")[0].InnerText;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

   
    }
}