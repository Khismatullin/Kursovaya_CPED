using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;
using MathNet.Numerics.LinearAlgebra;

namespace Kursovaya_CPED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewInputData1.AutoSize = false;

            OpenFileDialog ofd = new OpenFileDialog();
            //Задаем расширение имени файла по умолчанию.
            ofd.DefaultExt = "*.xls;*.xlsx";
            //Задаем строку фильтра имен файлов, которая определяет
            //варианты, доступные в поле "Файлы типа" диалогового
            //окна.
            ofd.Filter = "Excel Sheet(*.xlsx)|*.xlsx";
            //Задаем заголовок диалогового окна.
            ofd.Title = "Выберите документ для загрузки данных";
            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook;
            ExcelObj.Worksheet NwSheet;
            ExcelObj.Range ShtRange;
            DataTable dt = new DataTable();

            //ofd.InitialDirectory = @"C:\Users\Almir\Desktop";
            ofd.FileName = "C:\\Users\\Almir\\Desktop\\Computer processing of experimental data\\Kursovaya_CPED1.xlsx";
            if (ofd.FileName != "")
            {
                workbook = app.Workbooks.Open(ofd.FileName, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value);

                //Устанавливаем номер листа из котрого будут извлекаться данные
                //Листы нумеруются от 1
                NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                ShtRange = NwSheet.UsedRange;
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(
                       new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                dt.AcceptChanges();

                string[] columnNames = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columnNames[0] = dt.Columns[i].ColumnName;
                }

                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] =
                (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }

                dataGridViewInputData1.DataSource = dt;
                app.Quit();
            }
            else
                Application.Exit();
            dataGridViewInputData1.AutoSize = false;
            //DataGridViewColumn.Frozen[""] = true;

            //============================================================================================================

            dataGridViewInputData2.AutoSize = false;

            OpenFileDialog ofd1 = new OpenFileDialog();
            //Задаем расширение имени файла по умолчанию.
            ofd1.DefaultExt = "*.xls;*.xlsx";
            //Задаем строку фильтра имен файлов, которая определяет
            //варианты, доступные в поле "Файлы типа" диалогового
            //окна.
            ofd1.Filter = "Excel Sheet(*.xlsx)|*.xlsx";
            //Задаем заголовок диалогового окна.
            ofd1.Title = "Выберите документ для загрузки данных";
            ExcelObj.Application app1 = new ExcelObj.Application();
            ExcelObj.Workbook workbook1;
            ExcelObj.Worksheet NwSheet1;
            ExcelObj.Range ShtRange1;
            DataTable dt1 = new DataTable();

            //ofd.InitialDirectory = @"C:\Users\Almir\Desktop";
            ofd1.FileName = "C:\\Users\\Almir\\Desktop\\Computer processing of experimental data\\Kursovaya_CPED2.xlsx";
            if (ofd1.FileName != "")
            {
                workbook1 = app1.Workbooks.Open(ofd1.FileName, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value);

                //Устанавливаем номер листа из котрого будут извлекаться данные
                //Листы нумеруются от 1
                NwSheet1 = (ExcelObj.Worksheet)workbook1.Sheets.get_Item(1);
                ShtRange1 = NwSheet1.UsedRange;
                for (int Cnum = 1; Cnum <= ShtRange1.Columns.Count; Cnum++)
                {
                    dt1.Columns.Add(
                       new DataColumn((ShtRange1.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                dt1.AcceptChanges();

                string[] columnNames1 = new String[dt1.Columns.Count];
                for (int i = 0; i < dt1.Columns.Count; i++)
                {
                    columnNames1[0] = dt1.Columns[i].ColumnName;
                }

                for (int Rnum = 2; Rnum <= ShtRange1.Rows.Count; Rnum++)
                {
                    DataRow dr = dt1.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange1.Columns.Count; Cnum++)
                    {
                        if ((ShtRange1.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] =
                (ShtRange1.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt1.Rows.Add(dr);
                    dt1.AcceptChanges();
                }

                dataGridViewInputData2.DataSource = dt1;
                app1.Quit();
            }
            else
                Application.Exit();
            dataGridViewInputData2.AutoSize = false;
            //DataGridViewColumn.Frozen[""] = true;
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            int dgvColumnCount1 = dataGridViewInputData1.ColumnCount;
            int dgvRowCount1 = dataGridViewInputData1.RowCount;

            string[,] massivData1 = new string[dgvRowCount1, dgvColumnCount1];            
            double sumColumn1 = 0;
            double[] srednee1 = new double[dgvColumnCount1];
            double sumSigm1 = 0;
            double[,] covariazionnaya1 = new double[dgvColumnCount1, dgvColumnCount1];

            for (int m = 0; m < dataGridViewInputData1.ColumnCount; m++)     //rowCount=75 columnCount=10
            {
                for (int k = 0; k < dataGridViewInputData1.RowCount; k++)
                {
                    massivData1[k, m] = dataGridViewInputData1[m, k].Value.ToString();   //row, column
                    sumColumn1 += Convert.ToDouble(massivData1[k, m]);
                }
                srednee1[m] = sumColumn1 / dgvRowCount1;
                richTextBoxSrednee1.Text += Math.Round(srednee1[m], 2).ToString();
                richTextBoxSrednee1.Text += " ";
                sumColumn1 = 0;
            }

            for (int m = 0; m < dataGridViewInputData1.ColumnCount; m++)     //rowCount=75 columnCount=10
            {
                for (int t = 0; t < dataGridViewInputData1.ColumnCount; t++)
                {
                    for (int i = 0; i < dataGridViewInputData1.RowCount; i++)
                    {
                        sumSigm1 += (Convert.ToDouble(massivData1[i, m]) - srednee1[m]) * (Convert.ToDouble(massivData1[i, t]) - srednee1[t]);
                    }
                    covariazionnaya1[m,t] = sumSigm1 / dgvRowCount1;
                    richTextBoxCovariazionnaya1.Text += Math.Round(covariazionnaya1[m,t], 2).ToString();
                    richTextBoxCovariazionnaya1.Text += " ";
                    sumSigm1 = 0;
                }
                richTextBoxCovariazionnaya1.Text += Environment.NewLine;
            }

            double[,] ishodnyeDannye1 = new double[dataGridViewInputData1.RowCount, dataGridViewInputData1.ColumnCount];

            for (int m = 0; m < dataGridViewInputData1.RowCount - 1; m++)     //rowCount= columnCount=
            {
                for (int d = 0; d < dataGridViewInputData1.ColumnCount; d++)
                {
                    ishodnyeDannye1[m, d] = Convert.ToDouble(dataGridViewInputData1[d, m].Value);
                }
            }
            var ishodnyeDannyeM1 = Matrix<double>.Build.DenseOfArray(ishodnyeDannye1);


            //===============================================================================================================

            int dgvColumnCount2 = dataGridViewInputData2.ColumnCount;
            int dgvRowCount2 = dataGridViewInputData2.RowCount;

            string[,] massivData2 = new string[dgvRowCount2, dgvColumnCount2];
            double sumColumn2 = 0;
            double[] srednee2 = new double[dgvColumnCount2];
            double sumSigm2 = 0;
            double[,] covariazionnaya2 = new double[dgvColumnCount2, dgvColumnCount2];

            for (int m = 0; m < dataGridViewInputData2.ColumnCount; m++)     //rowCount=75 columnCount=10
            {
                for (int k = 0; k < dataGridViewInputData2.RowCount; k++)
                {
                    massivData2[k, m] = dataGridViewInputData2[m, k].Value.ToString();   //row, column
                    sumColumn2 += Convert.ToDouble(massivData2[k, m]);
                }
                srednee2[m] = sumColumn2 / dgvRowCount2;
                richTextBoxSrednee2.Text += Math.Round(srednee2[m], 2).ToString();
                richTextBoxSrednee2.Text += " ";
                sumColumn2 = 0;
            }

            for (int m = 0; m < dataGridViewInputData2.ColumnCount; m++)     //rowCount=75 columnCount=10
            {
                for (int t = 0; t < dataGridViewInputData2.ColumnCount; t++)
                {
                    for (int i = 0; i < dataGridViewInputData2.RowCount; i++)
                    {
                        sumSigm2 += (Convert.ToDouble(massivData2[i, m]) - srednee2[m]) * (Convert.ToDouble(massivData2[i, t]) - srednee2[t]);
                    }
                    covariazionnaya2[m,t] = sumSigm2 / dgvRowCount2;
                    richTextBoxCovariazionnaya2.Text += Math.Round(covariazionnaya2[m,t], 2).ToString();
                    richTextBoxCovariazionnaya2.Text += " ";
                    sumSigm2 = 0;
                }
                richTextBoxCovariazionnaya2.Text += Environment.NewLine;
            }
            
            double[,] ishodnyeDannye2 = new double[dataGridViewInputData2.RowCount, dataGridViewInputData2.ColumnCount];
            
            for (int m = 0; m < dataGridViewInputData2.RowCount - 1; m++)     //rowCount= columnCount=
            {
                for (int d = 0; d < dataGridViewInputData2.ColumnCount; d++)
                {
                    ishodnyeDannye2[m, d] = Convert.ToDouble(dataGridViewInputData2[d, m].Value);
                }
            }
            var ishodnyeDannyeM2 = Matrix<double>.Build.DenseOfArray(ishodnyeDannye2);

            //s^
            var covariazionnaya1M = Matrix<double>.Build.DenseOfArray(covariazionnaya1);
            var covariazionnaya2M = Matrix<double>.Build.DenseOfArray(covariazionnaya2);

            richTextBoxUnionCovariazionnaya.Text += 1.0/(4+5-2)*(covariazionnaya1M.Multiply(4) + covariazionnaya2M.Multiply(5));

            //(s^)-1
            richTextBoxInverseUnionCovariazionnaya.Text += (1.0 / (4 + 5 - 2) * (covariazionnaya1M.Multiply(4) + covariazionnaya2M.Multiply(5))).Inverse();

        }
    }
}
