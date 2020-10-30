using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoundlessTradeApp
{
    public partial class WayFinder : Form
    {
        struct PlanetWays
        {
            String planet;
            String[] paths;
        }

        ArrayList planetList;
        ArrayList planetWays;

        public WayFinder()
        {
            InitializeComponent();
        }

        private void findTheWayButton_Click(object sender, EventArgs e)
        {
            
        }


        private void WayFinder_Load(object sender, EventArgs e)
        {
            String Planet_URL = "https://butt.boundless.mayumi.fi/api/planets/";
            String Gateway_URL = "https://www.boundless-maps.com/source/gateways.json";
        }

        private String getData(String url)
        {
            string s;
            using (WebClient client = new WebClient())
            {
                s = client.DownloadString(url);
            }
            return s;
        }

        private ArrayList getPlanetList(String data)
        {
            ArrayList result = new ArrayList();


            return result;
        }

        private ArrayList setPaths()
        {
            ArrayList result = new ArrayList();


            return result;
        }
    }
}
