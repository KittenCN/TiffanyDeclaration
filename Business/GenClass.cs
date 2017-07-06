using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace BHair.Business
{
    public class GenClass
    {
        public string strSplit(string strStoreTemp)
        {
            string strResult = "";
            string[] strStore = strStoreTemp.Split(',');
            if (strStore[0] != "" && strStore[0] != null && strStore.Length > 1)
            {
                for (int i = 0; i < strStoreTemp.Length - 1; i++)
                {
                    strResult = strResult + "'" + strStore[i] + "',";
                }
            }
            else
            {
                strResult = strResult + "'" + strStore[0] + "'";
            }
            if(strResult.Substring(strResult.Length - 1)==",")
            {
                strResult = strResult.Substring(0, strResult.Length - 2);
            }
            return strResult;
        }

        public Boolean boolStore(string strStore,string strStoreGroup)
        {
            Boolean boolResult = false;
            string[] strTemp = strStoreGroup.Split(',');
            if(strTemp.Length==1 && strStore==strTemp[0])
            {
                boolResult = true;
            }
            else
            {
                if(strTemp.Length>1)
                {
                    for(int i=0;i<strTemp.Length-1;i++)
                    {
                        if(strTemp[i]==strStore)
                        {
                            boolResult = true;
                            break; 
                        }
                    }
                }
            }
            return boolResult;
        }
        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            if(dgv.Columns.Count >0 && dgv.Rows.Count > 0 && dgv.Rows[0].Cells[0].Value != null)
            {
                for (int count = 0; count < dgv.Columns.Count; count++)
                {
                    DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                    dt.Columns.Add(dc);
                }
                for (int count = 0; count < dgv.Rows.Count; count++)
                {
                    DataRow dr = dt.NewRow();
                    for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                    {
                        dr[countsub] = dgv.Rows[count].Cells[countsub].Value.ToString();
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        public static DataTable GetDataTableFromWorksheet(bool hasTitle,Boolean TitleFlag,Excel.Worksheet worksheet)
        {
            DataTable dtResult = new DataTable();
            try
            {
                if (worksheet == null) return null;
                int iRowCount = worksheet.UsedRange.Rows.Count;
                int iColCount = worksheet.UsedRange.Columns.Count;
                //生成列头
                for (int i = 0; i < iColCount; i++)
                {
                    var name = "column" + i;
                    if (hasTitle)
                    {
                        var txt = "";
                        if (TitleFlag==false)
                        {
                            txt = ((Excel.Range)worksheet.Cells[1, i + 1]).Text.ToString();                       
                        }
                        else
                        {
                            txt = name;
                        }
                        if (!string.IsNullOrEmpty(txt)) name = txt;
                    }
                    while (dtResult!=null && dtResult.Columns.Contains(name)) name = name + "_1";//重复行名称会报错。
                    dtResult.Columns.Add(new DataColumn(name, typeof(string)));
                }
                //生成行数据
                Excel.Range range;
                int rowIdx = hasTitle ? 2 : 1;
                for (int iRow = rowIdx; iRow <= iRowCount; iRow++)
                {
                    DataRow dr = dtResult.NewRow();
                    for (int iCol = 1; iCol <= iColCount; iCol++)
                    {
                        range = (Excel.Range)worksheet.Cells[iRow, iCol];
                        dr[iCol - 1] = (range.Value2 == null) ? "" : range.Text.ToString();
                    }
                    dtResult.Rows.Add(dr);
                }
            }
            catch (Exception ex){ return null; }
            return dtResult;
        }

        public static Boolean CheckDT(DataTable dt,string strCheck)
        {
            Boolean boolResult = false;
            int intTotalRowsNum = dt.Rows.Count;
            for(int x = 0; x < intTotalRowsNum; x++)
            {
                for(int y = x + 1; y < intTotalRowsNum; y++)
                {
                    if ((dt.Rows[x][strCheck].ToString() == dt.Rows[y][strCheck].ToString()) && dt.Rows[x][strCheck].ToString() != null && dt.Rows[y][strCheck].ToString() != null && dt.Rows[x][strCheck].ToString().Length > 0 && dt.Rows[y][strCheck].ToString().Length > 0)
                    {
                        boolResult = true;
                        goto done;
                    }
                }
            }
        done:
            return boolResult;
        }
        public static Boolean CheckDT(DataTable dt, string strCheck,string strQu)
        {
            Boolean boolResult = false;
            int intTotalRowsNum = dt.Rows.Count;
            for (int x = 0; x < intTotalRowsNum; x++)
            {
                for (int y = x + 1; y < intTotalRowsNum; y++)
                {
                    if ((dt.Rows[x][strQu].ToString() == dt.Rows[y][strQu].ToString() && dt.Rows[x][strCheck].ToString() == dt.Rows[y][strCheck].ToString()) && dt.Rows[x][strCheck].ToString() != null && dt.Rows[y][strCheck].ToString() != null && dt.Rows[x][strCheck].ToString().Length > 0 && dt.Rows[y][strCheck].ToString().Length > 0)
                    {
                        boolResult = true;
                        goto done;
                    }
                }
            }
        done:
            return boolResult;
        }
        public static DataTable GetTableFromDgv(DataGridView dgv, string strDataTableName)
        {
            DataTable dt = new DataTable();
            AccessHelper ah = new AccessHelper();
            string strSQL = "delete from " + strDataTableName;
            ah.ExecuteSQLNonquery(strSQL);
            strSQL = "select top 1 * from " + strDataTableName;           
            dt = ah.SelectToDataTable(strSQL);
            DataTable dtNew = dt.Clone();
            DataRow dr = dtNew.NewRow();
            int intdgvRowsCount = dgv.Rows.Count;
            int intdgvColsCount = dgv.Columns.Count;
            if (intdgvRowsCount > 0 && intdgvColsCount > 0)
            {
                for (int x = 0; x < intdgvRowsCount; x++)
                {
                    for (int y = 0; y < intdgvColsCount; y++)
                    {
                        if(dgv.Rows[x].Cells[y].Value != null)
                        {
                            dr[y + 1] = dgv.Rows[x].Cells[y].Value;
                        }                        
                    }
                    dtNew.Rows.Add(dr.ItemArray);
                    dr = dtNew.NewRow();
                }
            }
            return dtNew;
        }

        public static Boolean CheckDB_String(DataTable dtin,string strCheck,string strin)
        {
            Boolean boolResult = false;
            foreach(DataRow dr in dtin.Rows)
            {
                if(dr[strCheck].ToString() == strin)
                {
                    boolResult = true;
                    goto done;
                }
            }
        done:
            return boolResult;
        }

        public static void dgCellPainting(DataGridView dgStandard, string strColumnName, DataGridViewCellPaintingEventArgs e)
        {
            if (dgStandard.Rows.Count > 0)
            {
                if (dgStandard.Rows[0].Cells[0].Value.ToString().Trim() != string.Empty)
                {
                    try
                    {
                        if (dgStandard.Columns[strColumnName].Index == e.ColumnIndex && e.RowIndex >= 0)
                        {
                            using (
                                Brush gridBrush = new SolidBrush(dgStandard.GridColor),
                                backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                            {
                                using (Pen gridLinePen = new Pen(gridBrush))
                                {
                                    // 擦除原单元格背景
                                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                                    if (e.RowIndex != dgStandard.RowCount - 1)
                                    {
                                        if (e.Value.ToString() != dgStandard.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value.ToString())
                                        {
                                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1,
                                            e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);//下边缘的线 
                                        }
                                    }
                                    else
                                    {
                                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1,
                                            e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);//下边缘的线                       
                                    }
                                    //右侧的线
                                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, //x1,y1,x2,y2
                                        e.CellBounds.Top, e.CellBounds.Right - 1,
                                        e.CellBounds.Bottom - 1);

                                    if (e.RowIndex == 0)
                                    {
                                        //绘制值
                                        if (e.Value != null)
                                        {

                                            e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
                                                Brushes.Crimson,
                                                e.CellBounds.X + (e.CellBounds.Width - e.Graphics.MeasureString(e.Value.ToString().Trim(), e.CellStyle.Font).Width) / 2,
                                                e.CellBounds.Y + 2, StringFormat.GenericDefault);
                                        }
                                    }
                                    else
                                    {
                                        if (e.Value.ToString() != dgStandard.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.ToString())
                                        {
                                            //绘制值
                                            if (string.IsNullOrEmpty(e.Value.ToString().Trim()).Equals(false))
                                            {
                                                e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
                                                    Brushes.Crimson, e.CellBounds.X + (e.CellBounds.Width - e.Graphics.MeasureString(e.Value.ToString().Trim(), e.CellStyle.Font).Width) / 2,
                                                    e.CellBounds.Y + 2, StringFormat.GenericDefault);
                                            }
                                        }
                                    }
                                    e.Handled = true;
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
        }
    }
}
