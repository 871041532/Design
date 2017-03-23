using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class ParseExcel
    {
        //打开、读取、关闭（版本1）
        public void openReadClose01()
        {
            String sConnectionString = "Provider=Microsoft.Jet.OLEDB.12.0;"+"Data Source=c:/test.xls;"+"Extended Properties=Excel 8.0;";
            OleDbConnection objConn = new OleDbConnection(sConnectionString);
            objConn.Open();
            OleDbCommand objCmdSelect = new OleDbCommand("SELECT * FROM [sheet1]", objConn);
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
            objAdapter1.SelectCommand = objCmdSelect;
            DataSet objDataset1 = new DataSet();
            //将Excel中数据填充到数据集
            objAdapter1.Fill(objDataset1, "XLData");
            objConn.Close();
        }
    }
    
}
