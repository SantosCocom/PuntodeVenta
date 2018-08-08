using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using AccesoADatos;
using System.Windows.Forms;

namespace MenuPrincipal
{
    class ExportExcel
    {
        string archivo = @"G:\formato.xlsx";
        string nomhoja = "Hoja1";

        public void ExportarExcel(DataGridView dgv)
        {
            Microsoft.Office.Interop.Excel._Application AppExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = AppExcel.Workbooks.Open(archivo);
            Microsoft.Office.Interop.Excel._Worksheet Hoja = workbook.Sheets[nomhoja];

            AppExcel.Visible = false;

            
            string fecha = DateTime.Now.ToString();
            Hoja.Range["C5"].Value = FrameBD.quienAccede;// Periodo escolar
            Hoja.Range["D5"].Value = fecha;

            
            

            

            // Fecha Falta

            AppExcel.DisplayAlerts = false;
            workbook.ActiveSheet.ExportAsFixedFormat(0, @"G:\reporte.pdf");

            AppExcel.Quit();
            AppExcel = null;


            System.Diagnostics.Process P = new System.Diagnostics.Process();
            P.StartInfo.FileName = @"G:\reporte.pdf";
            //P.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            P.Start();
            //Espera el proceso para que lo termine y continuar
            
            //Liberar
            
        }

    }
}

