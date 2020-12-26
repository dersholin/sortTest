using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SortingExp_排序範例
{
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();
        int[] RandomArray = new int[10];
        int Temp, QNo, RRg,Count01, Count02, Count03;
        long TTime;
        public Form1()
        {
            InitializeComponent();
            ButtonOff();
            label4.Text = "";
        }
        private void ButtonOff()
        {
            btnBubble.Enabled = false;
            btnInsert.Enabled = false;
            btnMerge.Enabled = false;
            btnQuick.Enabled = false;
            btnRadix.Enabled = false;
            btnSelect.Enabled = false;
            btnShell.Enabled = false;
            btnTree.Enabled = false;
        }
        private void ButtonOn()
        {
            btnBubble.Enabled = true;
            btnInsert.Enabled = true;
            btnMerge.Enabled = true;
            btnQuick.Enabled = true;
            btnRadix.Enabled = true;
            btnSelect.Enabled = true;
            btnShell.Enabled = true;
            btnTree.Enabled = true;
        }
        private void ShowChart()
        {
            chart1.Series["Number"].Points.Clear();
            for (Count03 = 0; Count03 < RandomArray.Length; Count03++)
            {
                chart1.Series["Number"].Points.AddY(RandomArray[Count03]);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;                                 //禁止空格键(ASC II 0x20=space),如果為空格鍵則其值為(char)0((char)0為空值)
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;    //輸入為負(ASC II 0x2D=-)且整個textbox的總長度為0(在最前面)
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;                                                //處理非法字符
                }
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;                                 //禁止空格键(ASC II 0x20=space),如果為空格鍵則其值為(char)0((char)0為空值)
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;    //輸入為負(ASC II 0x2D=-)且整個textbox的總長度為0(在最前面)
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;                                                //處理非法字符
                }
            }
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            CtOn();
            try
            {
                QNo = Convert.ToInt16(TxQNo.Text);
            }
            catch
            {
                MessageBox.Show("數據數量超出範圍");
                TxQNo.Clear();
                TxQNo.AppendText("32767");
                QNo = 32767;
            }
            try
            {
                RRg = Convert.ToInt16(TxRRg.Text);
            }
            catch
            {
                MessageBox.Show("數據範圍超出");
                TxRRg.Clear();
                TxRRg.AppendText("32767");                
                RRg = 32767;
            }
            finally
            {
                Random RND = new Random(Guid.NewGuid().GetHashCode());
                Array.Resize(ref RandomArray, QNo);
                for (Count01 = 0; Count01 < RandomArray.Length; Count01++)
                {
                    RandomArray[Count01] = RND.Next(1, RRg);
                }
                ButtonOn();
                ShowChart();
                btnRandom.Enabled = false;              
                CtOff();
            }
        }
        private void CtOff()
        {
            watch.Stop();
            TTime += watch.ElapsedMilliseconds;
            label4.Text = Convert.ToString(TTime) + "ms";
            TTime = 0;
        }
        private void CtOn()
        {
            watch.Reset();
            watch.Start();
        }
        private void btnBubble_Click(object sender, EventArgs e)
        {
            CtOn();
            for (Count01 = RandomArray.Length - 1; Count01 > 0; Count01--)     //掃瞄次數
            {
                for (Count02 = 0; Count02 < Count01; Count02++)     //比較、交換次數
                {
                    // 比較相鄰兩數，如第一數較大則交換
                    if (RandomArray[Count02] > RandomArray[Count02 + 1])
                    {
                        Temp = RandomArray[Count02];
                        RandomArray[Count02] = RandomArray[Count02 + 1];
                        RandomArray[Count02 + 1] = Temp;                       
                    }
                }
            }
            ShowChart();
            CtOff();
            btnRandom.Enabled = true;
            ButtonOff();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            CtOn();
            for (Count01 = 0; Count01 < RandomArray.Length-1 ; Count01++)         //掃描5次
            {
                for (Count02 = Count01 + 1; Count02 < RandomArray.Length; Count02++)  //由i+1比較起，比較5次
                {
                    if (RandomArray[Count01] > RandomArray[Count02])  //比較第i及第j個元素
                    {
                        Temp = RandomArray[Count01];
                        RandomArray[Count01] = RandomArray[Count02];
                        RandomArray[Count02] = Temp;
                    }
                }    
            }
            ShowChart();
            CtOff();
            btnRandom.Enabled = true;
            ButtonOff();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            CtOn();
            for (Count01 = 1; Count01 < RandomArray.Length; Count01++)  //掃描迴圈次數為SIZE-1
            {
                Temp = RandomArray[Count01];
                Count02 = Count01 - 1;
                while (Count02 >= 0 && Temp < RandomArray[Count02])  //如果第二元素小於第一元素
                {
                    RandomArray[Count02 + 1] = RandomArray[Count02]; //就把所有元素往後推一個位置
                    Count02--;
                }
                RandomArray[Count02 + 1] = Temp;       //最小的元素放到第一個元素               
            }
            ShowChart();
            CtOff();
            btnRandom.Enabled = true;
            ButtonOff();
        }
        private void btnShell_Click(object sender, EventArgs e)
        {
            CtOn();
            int jmp = RandomArray.Length / 2;
            while (jmp != 0)
            {
                for (Count01 = jmp; Count01 < RandomArray.Length; Count01++)
                {
                    Temp = RandomArray[Count01];
                    Count02 = Count01 - jmp;
                    while (Count02 >= 0 && Temp < RandomArray[Count02])
                    //插入排序法
                    {
                        RandomArray[Count02 + jmp] = RandomArray[Count02];
                        Count02 = Count02 - jmp;
                    }
                    RandomArray[jmp + Count02] = Temp;
                }
                jmp = jmp / 2; //控制迴圈數
            }
            ShowChart();
            CtOff();
            btnRandom.Enabled = true;
            ButtonOff();
        }
        private void btnQuick_Click(object sender, EventArgs e)
        {
            CtOn();
            QuickSort(RandomArray, 0, RandomArray.Length-1);
            ShowChart();
            CtOff();
            btnRandom.Enabled = true;
            ButtonOff();
        }
        private void btnMerge_Click(object sender, EventArgs e)
        {
            CtOn();
            mergeSort(RandomArray, 0, RandomArray.Length-1);
            ShowChart();
            CtOff();
            btnRandom.Enabled = true;
            ButtonOff();
        }
        private void btnRadix_Click(object sender, EventArgs e)
        {
            CtOn();
            int   k;
            for (Count01  = 1; Count01 <= 32767; Count01 = Count01 * 10)//n為基數，由個位數開始排序
            {
                //設定暫存陣列，[0~9位數][資料個數]，所有內容均為0
                int[,] tmp = new int[10, 32767];
                for (Count03 = 0; Count03 < RandomArray.Length; Count03++) //比對所有資料
                {
                    Count02 = (RandomArray[Count03] / Count01) % 10; //m為n位數的值，如36取十位數(36/10)%10=3 
                    tmp[Count02, Count03] = RandomArray[Count03]; //把data[i]的值暫存於tmp裡
                }

                k = 0;
                for (Count03 = 0; Count03 < 10; Count03++)
                {
                    for (Count02 = 0; Count02 < RandomArray.Length; Count02++)
                    {
                        if (tmp[Count03, Count02] != 0) //因一開始設定tmp={0}，故不為0者即為
                        {
                            //data暫存在tmp 裡的值，把tmp裡的值放回data[ ]裡
                            RandomArray[k] = tmp[Count03, Count02];
                            k++;
                        }
                    }
                }
            }
            ShowChart();
            CtOff();
            btnRandom.Enabled = true;
            ButtonOff();
        }
        private void btnTree_Click(object sender, EventArgs e)
        {
            CtOn();
            Heap(RandomArray, RandomArray.Length);
            ShowChart();
            CtOff();
            btnRandom.Enabled = true;
            ButtonOff();
        }
        #region 快速排序法I
        //private static void QuickSort(int[] a, int low, int high)
        //{
        //    if (low >= high)
        //    {
        //        return;
        //    }
        //    int pivot = QuickSortOnce(a, low, high);//輸出每一次排序。

        //    //對樞軸左端進行排序。
        //    QuickSort(a, low, pivot - 1);
        //    //對樞軸右端進行排序。
        //    QuickSort(a, pivot + 1, high);
        //}
        //private static int QuickSortOnce(int[] a, int low, int high)
        //{
        //    //將首個元素作為樞軸。
        //    int pivot = a[low];
        //    int i = low, j = high;
        //    while (i < j)
        //    {
        //        //從右往左，尋找首個小於povit的元素。
        //        while (a[j] >= pivot && i < j)
        //        {
        //            j--;
        //        }
        //        //執行到此，j一定指向從右端起首個小於或等於povit的元素。執行替換。
        //        a[i] = a[j];
        //        //從左往右，尋找首個大於povit的元素。
        //        while (a[i] <= pivot && i < j)
        //        {
        //            i++;
        //        }
        //        ////執行到此，j一定指向從右端起首個大於或等於povit的元素。執行替換。
        //        a[j] = a[i];
        //    }
        //    //退出while迴圈，執行至此，必定是i==j的情況。i（或j）指向的既是樞軸的位置，定位該趟排序的樞軸並將該位置返回。
        //    a[i] = pivot;
        //    return i;
        //}
        #endregion
        #region 快速排序法II
        static void QuickSort(int[] array, int left, int right)
        {
            int temp;
            if (left < right)
            {
                int i = left;
                int j = right + 1;
                while (true)
                {
                    while (i + 1 < array.Length && array[++i] < array[left]) ;
                    while (j - 1 > -1 && array[--j] > array[left]) ;
                    if (i >= j)
                        break;
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    //Swap(array, i, j);
                }
                temp = array[left];
                array[left] = array[j];
                array[j] = temp;
                //Swap(array, left, j);
                QuickSort(array, left, j - 1);
                QuickSort(array, j + 1, right);
            }
        }
        #endregion
        #region 合併排序法
        public static void mergeSort(int[] list, int left, int right)
        {
            int mid;
            if (left < right)
            {
                mid = (left + right) / 2;
                mergeSort(list, left, mid);//排序左半邊
                mergeSort(list, mid + 1, right);//排序右半邊
                merge(list, left, mid, right);//組合
            }
        }
        public static void merge(int[] list, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];//設定暫存陣列長度
            int left1 = left, left2 = mid + 1, index = 0;//設定左邊極限
            while ((left1 <= mid) && (left2 <= right))
            {
                if (list[left1] < list[left2])
                {
                    temp[index] = list[left1];
                    left1++;
                    index++;
                }
                else
                {
                    temp[index] = list[left2];
                    left2++;
                    index++;
                }
            }
            while (left1 <= mid)
            {
                temp[index] = list[left1];
                left1++;
                index++;
            }
            while (left2 <= right)
            {
                temp[index] = list[left2];
                left2++;
                index++;
            }
            for (int i = 0; i < right - left + 1; i++)
                list[left + i] = temp[i];
        }
        #endregion
        #region 堆積樹排序法
        public static void Heap(int[] data, int size)
        {

            int i, tmp;
            for (i = (size / 2); i > 0; i--) //建立堆積樹節點	
                Ad_heap(data, i, size - 1);           
            for (i = size - 2; i > 0; i--) //堆積排序
            {
                tmp = data[i + 1];        //頭尾節點交換
                data[i + 1] = data[1];
                data[1] = tmp;
                Ad_heap(data, 1, i);      //處理剩餘節點               
            }
        }
        public static void Ad_heap(int[] data, int i, int size)
        {
            int j, tmp, post;
            j = 2 * i;
            tmp = data[i];
            post = 0;
            while (j <= size && post == 0)
            {
                if (j < size)
                {
                    if (data[j] < data[j + 1]) //找出最大節點
                        j++;
                }
                if (tmp >= data[j]) //若樹根較大，結束比較過程
                    post = 1;
                else
                {
                    data[j / 2] = data[j];//若樹根較小，則繼續比較
                    j = 2 * j;
                }
            }
            data[j / 2] = tmp;      //指定樹根為父節點
        }
        #endregion
    }
}
