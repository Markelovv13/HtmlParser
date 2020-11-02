using HtmlParser.Core;
using HtmlParser.Core.Habra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HtmlParser
{
    public partial class FormMain : Form
    {
        ParserWorker<string[]> parser;
        public FormMain()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new HabraParser()
                );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
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
            parser.Settings = new HabraSettings((int)numStartPoint.Value, (int)numEndPoint.Value);
            parser.Start();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
