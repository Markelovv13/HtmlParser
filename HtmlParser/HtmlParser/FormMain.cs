using HtmlParser.Core;
using HtmlParser.Core.Habra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace HtmlParser
{
    public partial class FormMain : Form
    {
        ParserWorker<string[]> parser;
        List<ParserSettings> parserSettings = new List<ParserSettings>();
        public FormMain()
        {
            InitializeComponent();

            parser = new ParserWorker<string[]>(new Parser());
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;

            LoadXmlConfig();

            cbSites.DataSource = parserSettings;
            cbSites.DisplayMember = "SiteName";
            cbSites.ValueMember = "BaseUrl";

        }

        private void LoadXmlConfig()
        {
            ParserSettings parserSettingsTemp = new ParserSettings(); 
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Config.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        parserSettingsTemp.BaseUrl = attr.Value;
                    }
                }
                foreach (XmlNode childNode in xnode.ChildNodes)
                {
                    if (childNode.Name == "prefix")
                    {
                        parserSettingsTemp.Prefix = childNode.InnerText;
                    }
                    if (childNode.Name == "siteName")
                    {
                        parserSettingsTemp.SiteName = childNode.InnerText;
                    }
                    if (childNode.Name == "desc")
                    {
                        parserSettingsTemp.Desc = childNode.InnerText;
                    }
                    if (childNode.Name == "className")
                    {
                        parserSettingsTemp.ClassName = childNode.InnerText;
                    }
                }
                parserSettings.Add(parserSettingsTemp);
            }
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listbTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            parser.Settings = (IParserSettings)cbSites.SelectedItem;
            parser.Settings.StartPoint = (int)numStartPoint.Value;
            parser.Settings.EndPoint = (int)numEndPoint.Value;
            parser.Start();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
