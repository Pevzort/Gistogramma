using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gistogramma
{
    public partial class MainWindow : Form
    {
        public List<float> Results {  get; set; }

        public List<float> AverrageResults { get; set; }

        public float Area { get; set; }

        public float BestSystem { get; set; }

        public float WorstSystem { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MakeNewGrids();
            Results = new List<float>();
            AverrageResults = new List<float>();
            scList = new List<float>();
        }

        private void MakeNewGrids()
        {
            resGrid.Columns.Clear();
            paramsGrid.Columns.Clear();
            gridNumbersBegin.Columns.Clear();
            systemsGrid.Columns.Clear();
            systemsGrid.Columns.Add("Column1", "Наименования объектов");
            paramsGrid.Columns.Add("Column1", "Наименования параметров");
            paramsGrid.Columns.Add("Column2", "Веса");
        }

        private void varUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (varUpDown.Value < gridNumbersBegin.Columns.Count)
            {
                while (varUpDown.Value != gridNumbersBegin.Columns.Count)
                    gridNumbersBegin.Columns.RemoveAt(gridNumbersBegin.Columns.Count - 1);
            }
            else
            {
                while (gridNumbersBegin.Columns.Count != varUpDown.Value)
                    gridNumbersBegin.Columns.Add($"Column{gridNumbersBegin.Columns.Count + 1}",
                        $"Вар-т {gridNumbersBegin.Columns.Count + 1}");
            }

            if (varUpDown.Value < systemsGrid.Rows.Count)
            {
                while (varUpDown.Value !=  systemsGrid.Rows.Count)
                    systemsGrid.Rows.RemoveAt(systemsGrid.Rows.Count - 1);
            }
            else
            {
                while (systemsGrid.Rows.Count != varUpDown.Value)
                    systemsGrid.Rows.Add();
            }
        }

        private void paramsUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (paramsUpDown.Value != 0)
            {
                if (gridNumbersBegin.Columns.Count == 0)
                {
                    MessageBox.Show("Задайте кол-во вариантов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    paramsUpDown.Value = 0;
                    paramsGrid.Rows.Clear();
                }
                else
                {
                    if (paramsUpDown.Value < paramsGrid.Rows.Count)
                    {
                        while (paramsUpDown.Value != paramsGrid.Rows.Count)
                            paramsGrid.Rows.RemoveAt(paramsGrid.Rows.Count - 1);

                        while (paramsUpDown.Value != gridNumbersBegin.Rows.Count)
                            gridNumbersBegin.Rows.RemoveAt(gridNumbersBegin.Rows.Count - 1);
                    }
                    else
                    {
                        while (paramsGrid.Rows.Count != paramsUpDown.Value)
                        {
                            paramsGrid.Rows.Add();
                            gridNumbersBegin.Rows.Add();
                        }
                    }
                }
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (CheckGrid())
            {
                Area = FindArea();
                MakeDecision();
                FillGridWithResults();
                ChartParams();
                ChartSystemResults();
            }
        }

        private bool CheckGrid()
        {
            for (int i = 0; i <= gridNumbersBegin.Columns.Count - 1; i++)
            {
                for (int j = 0; j <= gridNumbersBegin.Rows.Count - 1; j++)
                {
                    if (gridNumbersBegin.Rows[j].Cells[i].Value == null)
                    {
                        MessageBox.Show($"Заполните ячейку [{i + 1};{j + 1}] матрицы начальных значений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void FindWorstSystem()
        {
            WorstSystem = 0;
            List<float> list = new List<float>();
            for (int i = 0; i <= gridNumbersBegin.Rows.Count - 1; i++)
            {
                float max = findMaximumAtRow(i);
                float min = findMinimumAtRow(i);
                if (max > 0 && min < 0)
                {
                    WorstSystem = 0;
                }
                else if (min >= 0)
                {
                    list.Add(Variant2(max, min));
                }
                else if (max <= 0)
                {
                    WorstSystem = 0;
                }
            }

            if (weightBox.Checked && scList.Count != 0)
            {
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    WorstSystem += (float)Math.Pow(list[i], 2) * scList[i];
                }
            }
            else if (!weightBox.Checked)
            {
                foreach (var item in list)
                {
                    WorstSystem += (float)Math.Pow(item, 2) * sc;
                }
            }
            else
            {
                return;
            }
        }

        private void FindBestSystem()
        {
            BestSystem = 0;
            if (weightBox.Checked && scList.Count != 0)
            {
                foreach (var item in scList)
                {
                    BestSystem += item;
                }
            }
            else if (!weightBox.Checked)
            {
                BestSystem = Area / (float)2;
            }
            else
            {
                return;
            }
        }

        private void MakeDecision()
        {
            Results.Clear();
            sc = float.Parse((Area / Convert.ToInt32(paramsUpDown.Value)).ToString()) / (float)2;
            List<float> weights = new List<float>();
            if (weightBox.Checked)
            {
                scList = MakeSc();
            }
            FindWorstSystem();
            FindBestSystem();
            for (int i = 0; i <= gridNumbersBegin.Columns.Count - 1; i++)
            {
                float sum = 0;
                List<float> list = new List<float>();
                for (int j = 0; j <= gridNumbersBegin.Rows.Count - 1; j++)
                {
                    float max = findMaximumAtRow(j);
                    float min = findMinimumAtRow(j);
                    if (max > 0 && min < 0)
                    {
                        list.Add(Variant1(max, min, i, j));
                    }
                    else if (min >= 0)
                    {
                        list.Add(Variant2(max, i, j));
                    }
                    else if (max <= 0)
                    {
                        list.Add(Variant1(max, min, i, j));
                    }
                }

                if (list.Count > 0)
                {
                    if (weightBox.Checked && scList.Count != 0)
                    {
                        List<float> toSum = new List<float>();

                        foreach (var item in list)
                        {
                            toSum.Add((float)Math.Pow(item, 2));
                        }

                        AddResult(toSum);
                    }
                    else if (!weightBox.Checked)
                    {
                        foreach (var item in list)
                        {
                            sum += (float)Math.Pow(item, 2);
                        }

                        AddResult(sum);
                    }
                    else
                    {
                        break;
                    }

                    if (list.Count > 0)
                        AverrageResults.Add(list.Average());
                }
                else
                {
                    break;
                }
            }
        }

        private float FindArea()
        {
            List<float> area = new List<float>();
            for (int i = 0; i <= gridNumbersBegin.Rows.Count - 1; i++)
            {
                List<float> list = new List<float>();
                for (int j = 0; j <= gridNumbersBegin.Columns.Count - 1; j++)
                {
                    list.Add(float.Parse(gridNumbersBegin.Rows[i].Cells[j].Value.ToString()));
                }
                if (list.Count != 0)
                    area.Add(list.Max());
                else
                    break;
            }
            return area.Sum();
        }

        private List<float> MakeSc()
        {
            bool check = true;
            List<float> weights = new List<float>();
            List<float> result = new List<float>();
            float sum = 0;
            for (int i = 0; i <= paramsGrid.Rows.Count - 1; i++)
            {
                if (paramsGrid.Rows[i].Cells[1].Value == null)
                {
                    check = false;
                    MessageBox.Show($"Заполните ячейку [2;{i + 1}] показателей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                sum += float.Parse(paramsGrid.Rows[i].Cells[1].Value.ToString());
            }

            if (check)
            {
                for (int i = 0; i <= paramsGrid.Rows.Count - 1; i++)
                {
                    weights.Add(float.Parse(paramsGrid.Rows[i].Cells[1].Value.ToString()) / sum);
                }

                foreach (var item in weights)
                {
                    result.Add(float.Parse((Area * item).ToString()) / (float)2);
                }
            }

            return result;
        }

        private List<float> NormalizeValues(List<float> list)
        {
            List<float> result = new List<float>();

            foreach (var value in list)
            {
                result.Add((value - WorstSystem) / (BestSystem - WorstSystem));
            }

            return result;
        }

        private void FillGridWithResults()
        {
            resGrid.Columns.Clear();
            if (Results.Count > 0)
            {
                var sorted = Results.Select((x, i) => new KeyValuePair<float, int>(x, i)).OrderBy(x => x.Key).ToList();
                List<float> toNormalizeValues = sorted.Select(x => x.Key).ToList();
                List<int> toAddIndexes = sorted.Select(x => x.Value).ToList();
                List<float> toAddValues = NormalizeValues(toNormalizeValues);
                for (int i = 0; i < varUpDown.Value; i++)
                {
                    if (systemsGrid.Rows[i].Cells[0].Value != null)
                    {
                        resGrid.Columns.Add($"Column{i + 1}", $"{systemsGrid.Rows[toAddIndexes[i]].Cells[0].Value}");
                    }
                    else
                    {
                        resGrid.Columns.Add($"Column{i + 1}", $"Вар-т {toAddIndexes[i] + 1}");
                    }
                }
                resGrid.Rows.Add();
                resGrid.Rows.Add();
                resGrid.Rows[0].HeaderCell.Value = "Sф";
                resGrid.Rows[1].HeaderCell.Value = "Sф/Sпр";
                for (int i = 0; i <= resGrid.Columns.Count - 1; i++)
                {
                    resGrid.Rows[0].Cells[i].Value = toAddValues[i] * 100;
                    resGrid.Rows[1].Cells[i].Value = toNormalizeValues[i] / Area * 100;
                }
            }
        }

        public void ChartParams()
        {
            Charter ChartParams = new Charter();
            ChartParams.Text = "Параметры";
            ChartParams.Show();
            for (int i = 0; i <= gridNumbersBegin.Columns.Count -1 ; i++)
            {
                List<string> paramsName = new List<string>();
                List<float> list = new List<float>();
                for (int j = 0; j <= gridNumbersBegin.Rows.Count - 1; j++)
                {
                    if (paramsGrid.Rows[j].Cells[0].Value != null)
                        paramsName.Add(paramsGrid.Rows[j].Cells[0].Value.ToString());
                    else
                        paramsName.Add($"{j + 1}");
                    float max = findMaximumAtRow(j);
                    float min = findMinimumAtRow(j);
                    if (max > 0 && min < 0)
                    {
                        list.Add(Variant1(max, min, i, j));
                    }
                    else if (min >= 0)
                    {
                        list.Add(Variant2(max, i, j));
                    }
                    else if (max <= 0)
                    {
                        list.Add(Variant1(max, min, i, j));
                    }
                }
                if (systemsGrid.Rows[i].Cells[0].Value == null)
                {
                    ChartParams.MakeParamsChart(list, paramsName, $"Вар-т {i + 1}");
                }
                else
                {
                    ChartParams.MakeParamsChart(list, paramsName, systemsGrid.Rows[i].Cells[0].Value.ToString());
                }
            }
        }

        public void ChartSystemResults()
        {
            if (Results.Count > 0)
            {
                List<float> list = NormalizeValues(Results);
                Charter ChartSystems = new Charter();
                ChartSystems.Text = "Объекты";
                ChartSystems.Show();
                for (int i = 0; i <= list.Count - 1; i++)
                {
                    if (systemsGrid.Rows[i].Cells[0].Value == null)
                    {
                        ChartSystems.MakeSystemsChart(list[i], $"Вар-т {i + 1}");
                    }
                    else
                    {
                        ChartSystems.MakeSystemsChart(list[i], systemsGrid.Rows[i].Cells[0].Value.ToString());
                    }
                }
            }
        }

        private void AddResult(List<float> list)
        {
            float sum = 0;
            for (int i = 0; i <= list.Count - 1; i++)
            {
                sum += list[i] * scList[i];
            }

            Results.Add(sum);
        }

        private void AddResult(float sum)
        {
            float toAdd = sum * sc;
            Results.Add(toAdd);
        }

        private float Variant1(float max, float min, int i, int j) => (float)1
            - ((max - float.Parse(gridNumbersBegin.Rows[j].Cells[i].Value.ToString())) / (max - min));

        private float Variant2(float max, float min) => min / max;

        private float Variant2(float max, int i, int j) =>
            float.Parse(gridNumbersBegin.Rows[j].Cells[i].Value.ToString()) / max;

        private float findMaximumAtRow(int i)
        {
            List<float> list = new List<float>();
            for (int j = 0; j <= gridNumbersBegin.Columns.Count - 1; j++)
            {
                list.Add(float.Parse(gridNumbersBegin.Rows[i].Cells[j].Value.ToString()));
            }

            return list.Max();
        }

        private float findMinimumAtRow(int i)
        {
            List<float> list = new List<float>();
            for (int j = 0; j <= gridNumbersBegin.Columns.Count - 1; j++)
            {
                list.Add(float.Parse(gridNumbersBegin.Rows[i].Cells[j].Value.ToString()));
            }

            return list.Min();
        }

        private float sc;

        private List<float> scList { get; set; }

        private void randButton_Click(object sender, EventArgs e)
        {
            if (paramsUpDown.Value > 0 && varUpDown.Value > 0)
            {
                Random random = new Random();
                for (int i = 0; i <= gridNumbersBegin.Columns.Count - 1; i++)
                {
                    for (int j = 0; j <= gridNumbersBegin.Rows.Count - 1; j++)
                    {
                        gridNumbersBegin.Rows[j].Cells[i].Value = random.Next();
                    }
                }
            }
            else
            {
                MessageBox.Show("Задайте кол-во вариантов и параметров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParamsNameChange(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i <= paramsGrid.Rows.Count -1; i++)
            {
                if (paramsGrid.Rows[i].Cells[0].Value != null)
                    gridNumbersBegin.Rows[i].HeaderCell.Value = paramsGrid.Rows[i].Cells[0].Value;
            }
        }

        private void SystemsNameChange(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i <= systemsGrid.Rows.Count -1; i++)
            {
                if (systemsGrid.Rows[i].Cells[0].Value != null)
                    gridNumbersBegin.Columns[i].HeaderCell.Value = systemsGrid.Rows[i].Cells[0].Value;
            }
        }
    }
}
