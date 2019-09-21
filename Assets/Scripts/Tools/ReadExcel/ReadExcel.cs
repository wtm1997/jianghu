using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Data;
using Excel;

public static class ReadExcel
{
    
    public static List<string> GameReadExcel(string path)
    {
        FileStream stream = File.Open(Application.dataPath + path, FileMode.Open, FileAccess.Read, FileShare.Read);
        IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

        DataSet result = excelDataReader.AsDataSet();
        Debug.Log("[ReadExcel][GameReadExcel] result = " + result);

        int columns = result.Tables[0].Columns.Count;//列
        int rows = result.Tables[0].Rows.Count;//行
        List<string> excelData = new List<string>();
        string value = "";
        string all = "";

        for (int i = 1; i < rows; i++)
        {
            all = "";
            for (int j = 0; j < columns; j++)
            {
                value = result.Tables[0].Rows[i][j].ToString();
                if (value == "")
                    continue;
                all = all + value + "|";
            }

            if (all != "")
            {
                excelData.Add(all);
            }
            else
            {
                Debug.LogError("[ReadExcel][GameReadExcel] excel data is  null");
            }
        }

        return excelData;
    }
}
