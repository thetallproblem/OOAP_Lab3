using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP_Lab3WithPattern
{
    public partial class Form1 : Form
    {
        SortContext sortContext;
        List<int> list;
        Random random;
        double time_sort;
        
        public Form1()
        {
            InitializeComponent();
            list = new List<int>();
            random = new Random(); 
        }

        private void createList()
        {
            list.Clear();
            for (int i = 0; i < dataGridViewList.RowCount; i++)
                list.Add(Convert.ToInt32(dataGridViewList[0, i].Value));
        }
        private void createSortData()
        {
            for (int i = 0; i < list.Count(); i++)
                dataGridViewSort.Rows.Add(Convert.ToString(list[i]));
        }

        private void GenerateRandomList(object sender, EventArgs e)
        {
            dataGridViewList.Rows.Clear();
            for (int i = 0; i < numericUpDownRandLen.Value; i++)
                dataGridViewList.Rows.Add(Convert.ToString(random.Next(0, 100)));
        }

        private void ClickSortData(object sender, EventArgs e)
        {
            dataGridViewSort.Rows.Clear();
            if (dataGridViewList.Rows.Count == 0)
            {
                MessageBox.Show("Массив пустой");
                return;
            }
            createList();

            if (radioButtonBubble.Checked)
                sortContext = new SortContext(0);
            else if (radioButtonQuick.Checked)
                sortContext = new SortContext(1);
            else
            {
                MessageBox.Show("Не выбран алгоритм сортировки");
                return;
            }

            long start = DateTime.Now.Ticks;
            sortContext.Sort(list);
            long end = DateTime.Now.Ticks;

            createSortData();
            groupBoxRes.Visible = true;
            labelResult.Text = "Затраченное количество тиков: " + Convert.ToString(end-start);
        }
    }
}

public class SortContext
{
    private int type_sort;

    public SortContext(int _type)
    {
        type_sort = _type;
    }

    public void Sort(List<int> list)
    {
        if (type_sort == 0)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        else if (type_sort == 1)
        {
            QuickSort(list, 0, list.Count - 1);
        }
    }

    private void QuickSort(List<int> list, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(list, low, high);
            QuickSort(list, low, pi - 1);
            QuickSort(list, pi + 1, high);
        }
    }
    private int Partition(List<int> list, int low, int high)
    {
        int pivot = list[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (list[j] <= pivot)
            {
                i++;
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        int temp1 = list[i + 1];
        list[i + 1] = list[high];
        list[high] = temp1;

        return i + 1;
    }
}