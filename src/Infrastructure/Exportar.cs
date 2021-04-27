using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;

namespace Infrastructure
{
    public class Exportar
    {
        public static void Excel<T>(List<T> data, string filePath)
        {
            var table = ListToDataTable(data);
            XLWorkbook _wb = new XLWorkbook();
            _wb.AddWorksheet(table,"Proveedores");
            
            _wb.SaveAs(filePath);
        }

        public static DataTable ListToDataTable<T>(List<T> data)
        {
            var props = TypeDescriptor.GetProperties(typeof(T));

            DataTable dataTable = new DataTable();
            foreach (PropertyDescriptor prop in props)
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            DataRow row;
            foreach (T item in data)
            {
                row = dataTable.NewRow();
                foreach (PropertyDescriptor prop in props)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
