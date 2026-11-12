using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        // 建立表單並載入控制項設定。
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal RATE = 0.005m; // 每月利率為0.5%。
            // 儲存起始餘額、月份數量，以及目前計算的月份。
            decimal balance; 
            int months;

            // 嘗試將使用者輸入的起始餘額轉換為數字。
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if(int.TryParse(monthsTextBox.Text, out months))
                {
                    int count = 1; // 計算月份的計數器。
                    while(count <= months)
                    {
                       balance = balance * (1 + RATE); // 計算每月利息並更新餘額。
                        detailListBox.Items.Add($"Month {count}: {balance:C2}"); // 將每月的餘額加入明細清單。
                        count = count + 1; // 增加月份計數器。
                    }
                    // 顯示最終結餘。
                    endingBalanceLabel.Text = balance.ToString("C");
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric value for number of months.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                endingBalanceLabel.Text = balance.ToString("C"); // 顯示最終結餘。
            }
            else
            {
                // 輸入格式錯誤時顯示提示訊息。
                MessageBox.Show("Please enter valid numeric values for starting balance and number of months.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除文字方塊、結餘標籤及明細清單。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 將輸入焦點移回起始餘額文字方塊。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
