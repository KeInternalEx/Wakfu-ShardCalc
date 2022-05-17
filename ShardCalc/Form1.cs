using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShardCalc
{
    public partial class Form1 : Form
    {
        private double numShards = 0;
        private static Dictionary<string, double> rarityTable = new Dictionary<string, double>
        {
            { "Uncommon", 1 },
            { "Rare", 8 },
            { "Mythical", 32 },
            { "Legendary", 128 },
            { "Souvenir", 128 },
            { "Epic", 1024 },
            { "Relic", 1024 }
        };

        public Form1()
        {
            InitializeComponent();

            this.checkedListBox1.SetItemChecked(0, true);
        }

        private void updateCrushResult()
        {
            try
            {
                var lots = Convert.ToInt32(this.lots.Text);
                var lotPrice = Convert.ToInt32(this.lotPrice.Text);
                var shardPrice = Convert.ToDouble(this.shardPrice.Text);

                var sellPrice = lots * lotPrice;
                var crushPrice = shardPrice * this.numShards;

                this.sell.Text = String.Format("{0:0,0.00}", sellPrice) + "K /\n" + String.Format("{0:0,0.00}", crushPrice) + "K\n" + String.Format("{0:0,0.00}", crushPrice - sellPrice) + "K";
            }
            catch
            {
                this.sell.Text = "0K / 0K";
            }
        }

        private void updateResult(string checkedItem = null)
        {
            try
            {
                var lots = Convert.ToDouble(this.lots.Text);
                var level = Convert.ToDouble(this.level.Text);
                var rarity = checkedItem ?? this.checkedListBox1.CheckedItems[0] as string;
                var mod = this.identified.Checked ? 1 : 1.2;

                

                this.numShards = Math.Pow(2, (level - 200) / 30) * 2.0d * rarityTable[rarity] * mod * lots;

                this.result.Text = this.numShards.ToString("N2") + " Shards";


                updateCrushResult();
            }
            catch
            {
                this.result.Text = "0 Shards";
            }
        }

        private void lots_TextChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void level_TextChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;

                updateResult(this.checkedListBox1.Items[e.Index] as string);
            }
        }

        private void shardPrice_TextChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void lotPrice_TextChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void identified_CheckedChanged(object sender, EventArgs e)
        {
            updateResult();
        }
    }
}
