using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoundlessTradeApp
{
    public partial class Form1 : Form
    {
        private ArrayList itemEnglish;
        private ArrayList itemList;
        private ArrayList planetList;
        private String API_URL_BASE = "https://butt.boundless.mayumi.fi/api/item/";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            String Planet_URL = "https://butt.boundless.mayumi.fi/api/planets/";
            String Item_URL = "https://butt.boundless.mayumi.fi/api/itemlist/";
            String English_URL = "https://butt.boundless.mayumi.fi/gameFiles/raw/english.json";

            itemEnglish = readEnglish(getData(English_URL));
            //String url = "https://butt.boundless.mayumi.fi/api/item/COAL_DEFAULT_COMPACT";
            //ArrayList l = readTradeValues(getData(url), "COAL_DEFAULT_COMPACT");
            //itemListBox.Items.Add(l[0]);
            dataGridView1.Rows.Clear();
            new Thread(delegate ()
            {
                itemList = readItemList(getData(Item_URL));
            }).Start();



            /*
            foreach(String[] tmp in itemEnglish)
            {
                itemListBox.Items.Add(tmp[1]);
            }*/
        }
        private bool firstAdd = true;
        private void invoke(float profit, String[] toAdd, String name)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<float, string[], string>(invoke), new object[] { profit, toAdd, name });
                return;
            }
            if (!toAdd.Equals(""))
            {
                if(firstAdd)
                {
                    firstAdd = false;
                    dataGridView1.Rows[0].SetValues(name, profit, toAdd[0], toAdd[1]);
                    label1.Text = "Fetching : " + name;
                    return;
                }
                dataGridView1.Rows.Add(name, profit, toAdd[0], toAdd[1]);
                //itemListBox.Items.Add(toAdd);
            }
            
            label1.Text = name;
            /*
            foreach (ArrayList tmp in itemList)
            {
                String name = (String)tmp[0];
                String profit = (String)((ArrayList)tmp[1])[0];
                itemListBox.Items.Add(name + " " + profit);
            }*/
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

        private ArrayList readEnglish(String data)
        {
            /*
             * 0 : StringId
             * 1 : English Name of the Item
             */
            ArrayList result = new ArrayList();
            String[] array = data.Split('\n');
            foreach (String tmp in array)
            {
                if(tmp.Contains(":"))
                {
                    String[] temp = tmp.Split(':');
                    String[] toAdd = { temp[0].Trim().Trim('"'), temp[1].Trim().Trim(',').Trim('"') };
                    result.Add(toAdd);
                }
            }
            
            return result;
        }

        private ArrayList readTradeValues(String data, String temporary)
        {
            ArrayList result = new ArrayList();
            ArrayList buyList = new ArrayList();
            ArrayList sellList = new ArrayList();
            String[] array = data.Split('\n');
            /*
             * 0 : price
             * 1 : quantity
             * 2 : guild
             * 3 : beacon
             * 4 : planet id
             */
            bool buy = true;
            bool first_cheapest = true;
            bool first_expensive = true;
            String cheapest_String = "";
            String expensive_String = "";
            String c_qty = "";
            String e_qty = "";
            float cheapest = 0;
            float expensive = 0;
            for (int i = 0; i < array.Length;)
            {
                String tmp = array[i];
                //Console.WriteLine(tmp);
                if (tmp.Contains("sell"))
                    buy = false;
                if (tmp.Contains("\"buy\":"))
                    buy = true;
                if (tmp.Contains("price"))
                {
                    String price    = array[i].Split(':')[1].Trim().Trim(',').Trim();
                    String quantity = array[i+1].Split(':')[1].Trim().Trim(',').Trim();
                    String guild    = array[i+2].Split(':')[1].Trim().Trim(',').Trim('"').Trim();
                    String beacon   = array[i+3].Split(':')[1].Trim().Trim(',').Trim('"').Trim();
                    String planet   = array[i+4].Split(':')[1].Trim();
                    //Console.WriteLine(temporary + ":" + buy + ":" + price + ":" + quantity + ":" + guild + ":" + beacon + ":" + planet);

                    String[] toAdd = { price, quantity, guild, beacon, planet };

                    if(buy)
                    {
                        if (cheapest < float.Parse(price) && float.Parse(price) > 1 || first_cheapest)
                        {
                            c_qty = quantity;
                            first_cheapest = false;
                            cheapest_String = price;
                            cheapest = float.Parse(price);
                        }
                        buyList.Add(toAdd);
                    }
                    else
                    {
                        if (expensive > float.Parse(price) && float.Parse(price) < 100000000 || first_expensive)
                        {
                            e_qty = quantity;
                            first_expensive = false;
                            expensive_String = price;
                            expensive = float.Parse(price);
                        }
                        sellList.Add(toAdd);
                    }

                    i++;
                }
                else
                {
                    i++;
                }
            }
            float profit = cheapest - expensive;
            String[] sellBuy = { "They sell from(qty " + e_qty + "): " + expensive_String, "They buy from(qty " + c_qty + "): " + cheapest_String };
            result.Add(sellBuy);
            result.Add(profit);
            result.Add(buyList);
            result.Add(sellList);
            return result;
        }

        private ArrayList readItemList(String data)
        {
            ArrayList result = new ArrayList();
            String[] array = data.Split('\n');
            /*
             * 0 : api link
             * 1 : numeric id
             * 2 : string id
             */
            for (int i=0; i<array.Length ;)
            {
                String tmp = array[i];
                if (tmp.Contains("id"))
                {
                    // API = i-1
                    String apiLink = array[i - 1].Split(':')[0].Trim().Trim('"');
                    // numeric id = i
                    String numericId = array[i].Split(':')[1].Trim().Trim(',');
                    // string id = i+1
                    String stringId = array[i + 1].Split(':')[1].Trim().Trim('"');

                    String[] toAdd = { apiLink, numericId, stringId };

                    String URL = API_URL_BASE + apiLink;

                    ArrayList tradeValues = readTradeValues(getData(URL), apiLink);
                    ArrayList add = new ArrayList();

                    String engName = "";
                    foreach(String[] s in itemEnglish)
                    {
                        if(s[0].Contains(stringId))
                        {
                            engName = s[1];
                        }
                    }

                    add.Add(engName);
                    add.Add(tradeValues);
                    add.Add(toAdd);
                    if ((float)tradeValues[1] > 0 && (float)tradeValues[1] != -1)
                        try
                        {
                            invoke((float)tradeValues[1], (string[])tradeValues[0], apiLink);
                        }
                        catch(Exception)
                        {
                            return result;
                        }
                    
                    result.Add(add);

                    i += 1;
                }
                else
                {
                    i++;
                }
            }
            try
            {
                String[] n = {"", ""};
                invoke(0, n, "Done");
            }
            catch (Exception)
            {
                return result;
            }
            return result;
        }

        private double dTime = 0;
        private bool double_click = false;
        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*dTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            
            if (double_click)
            {
                String s = (String)itemListBox.SelectedItem;
                s = s.Split('\t')[0].Trim();
                Console.WriteLine(s);
                System.Diagnostics.Process.Start("https://butt.boundless.mayumi.fi/#item=" + s);
            }
            else
                new Thread(delegate() 
                {
                    while (dTime + 500 > DateTimeOffset.Now.ToUnixTimeMilliseconds())
                    {
                        double_click = true;
                    }
                }).Start();*/
        }

        private int oldRowIndex = -1;
        private int oldColIndex = -1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            int index = e.RowIndex;
            int colIndex = e.ColumnIndex;
            Console.WriteLine(colIndex);
            if (index != -1)
                Console.WriteLine(dataGridView1.Rows[index].Cells[0].Value.ToString());
            if (index != -1 && oldRowIndex==index && oldColIndex == colIndex)
            {
                String s = dataGridView1.Rows[index].Cells[0].Value.ToString();
                s = s.Split('\t')[0].Trim();
                System.Diagnostics.Process.Start("https://butt.boundless.mayumi.fi/#item=" + s);
            }
            
            oldRowIndex = index;
            oldColIndex = colIndex;
        }
    }
}
