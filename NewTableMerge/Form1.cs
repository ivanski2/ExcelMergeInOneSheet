using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.XSSF.UserModel;




namespace NewTableMerge
{
    public partial class Form1 : Form
    {
        string[] filename;
        string[] xlsfiles = new string[] { };
        public Form1()
        {
            InitializeComponent();
           

        }

        private static void MergeData(string path, DataTable dt)
        {
            // write data in workbook from xls document.
            XSSFWorkbook workbook = new XSSFWorkbook(path);
            // read the current table data
            XSSFSheet sheet = (XSSFSheet)workbook.GetSheetAt(0);
            // read the current row data
            XSSFRow headerRow = (XSSFRow)sheet.GetRow(0);
            // LastCellNum is the number of cells of current rows
            int cellCount = headerRow.LastCellNum;

            if (dt.Rows.Count == 0)
            {

                // build header for there is no data after the first implementation
                for (int i = headerRow.FirstCellNum; i < cellCount; i++)
                {
                    // get data as the column header of DataTable
                    DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);

                    dt.Columns.Add(column);
                }
            }
            else
            {

                // TODO: check if the subsequent sheet corresponds
            }
            // LastRowNum is the number of rows of current table
            int rowCount = sheet.LastRowNum + 1;
            for (int i = (sheet.FirstRowNum + 1); i < rowCount; i++)
            {
                XSSFRow row = (XSSFRow)sheet.GetRow(i);
                DataRow dataRow = dt.NewRow();
                for (int j = row.FirstCellNum; j < cellCount; j++)
                {
                    if (row.GetCell(j) != null)
                        // get data and convert them into character string type, then save them into the rows of datatable
                        dataRow[j] = row.GetCell(j).ToString();


                }
                dt.Rows.Add(dataRow);
            }
            workbook = null;
            sheet = null;
        }

        public static void ExportDataTableToExcel(DataTable dtSource, string strFileName)
        {
            // create workbook
            XSSFWorkbook workbook = new XSSFWorkbook();
            // the table named mySheet
            XSSFSheet sheet = (XSSFSheet)workbook.CreateSheet("mySheet");
            // create the first row
            XSSFRow dataRow = (XSSFRow)sheet.CreateRow(0);
            foreach (DataColumn column in dtSource.Columns)
            {
                // create the cells in the first row, and add data into these cells circularly
                dataRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);

            }
            //create rows on the basis of data from datatable(not including table header), and add data into cells in every row
            for (int i = 0; i < dtSource.Rows.Count; i++)
            {
                dataRow = (XSSFRow)sheet.CreateRow(i + 1);
                for (int j = 0; j < dtSource.Columns.Count; j++)
                {
                    dataRow.CreateCell(j).SetCellValue(dtSource.Rows[i][j].ToString());
                }
            }
            using (MemoryStream ms = new MemoryStream())
            {
                using (FileStream fs = new FileStream(strFileName, FileMode.Create, FileAccess.Write))
                {

                    workbook.Write(fs);// write mySheet table in xls document and save it
                }
            }
        }


            private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            // string[] files = new string[] { };
            for (int i = 0; i < xlsfiles.Length; i++)
            {
                MergeData(xlsfiles[i], dt);
            }
            ExportDataTableToExcel(dt, @"result.xlsx");

        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.xls*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            string path = Directory.GetCurrentDirectory();

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                xlsfiles = choofdlog.FileNames;
                filename = choofdlog.SafeFileNames;
                for (int i = 0; i < xlsfiles.Length; i++)
                {
                    listBox1_excelFile.Items.Add(filename[i]);
                }
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            listBox1_excelFile.SelectionMode = SelectionMode.MultiSimple;
            for (int i = 0; i < listBox1_excelFile.Items.Count; i++)
                listBox1_excelFile.SetSelected(i, true);
        }
    }
}
