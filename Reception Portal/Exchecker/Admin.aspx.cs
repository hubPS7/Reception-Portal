using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Net.Mail;
using System.Xml;
using System.IO;

namespace Exchecker
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            createxml();
        }

        public void createxml()
        {
            try
            {
                //Create XML Code here-- Pankaj
                XmlDocument XDoc = new XmlDocument();

                //// Create root node.
                XmlNode docNode = XDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XDoc.AppendChild(docNode);

                //Add the node to the document.

                XmlElement Xsource = XDoc.CreateElement("Networks");
                XDoc.AppendChild(Xsource);

                XmlElement XTemp = XDoc.CreateElement("HiberniaNetworkData");

                XTemp = XDoc.CreateElement("ExchangeCentre");
                XTemp.InnerText = ExchangeCentre.Text + lblName.Text + " (x" + extension.Text;
                Xsource.AppendChild(XTemp);

                XTemp = XDoc.CreateElement("OnGoingWork");
                XTemp.InnerText = Ongoingwork.Text;
                Xsource.AppendChild(XTemp);

                XTemp = XDoc.CreateElement("CurrentBuldngMaintenance");
                XTemp.InnerText = currentBuildingmaintenance.Text;
                Xsource.AppendChild(XTemp);

             
                string date = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}.xml", DateTime.Now);

                string path = Server.MapPath("\\Xmlfile\\ExchangeCentre.xml");

                using (StreamWriter sw = new StreamWriter(path))
                {  
                    XDoc.Save(sw);
                    ExchangeCentre.Text = "";
                    Ongoingwork.Text = "";
                    currentBuildingmaintenance.Text = "";
                    extension.Text = "";
                }
            }
            catch (Exception e)
            {
                throw e;
                //ExchangeCentre.Text = "";
                //Ongoingwork.Text = "";
                //currentBuildingmaintenance.Text = "";
            }
          

        }
    }
}