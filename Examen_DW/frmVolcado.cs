using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using Oracle.DataAccess;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Examen_DW
{
    public partial class frmVolcado : Form
    {

        //VARIABLES
        OracleConnection ora = new OracleConnection("DATA SOURCE = localhost/orcl; PASSWORD=123456;USER ID= system");
        OracleCommand cmd;
        OracleDataAdapter da;
        OracleDataReader dr;
        DataTable dt;

        public frmVolcado()
        {
            InitializeComponent();
        }

        private void frmVolcado_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {

                ora.Open();
                cmd = new OracleCommand("DELETE FROM EMPLEADOS", ora);
                cmd.CommandType = CommandType.Text;

                da = new OracleDataAdapter();
                da.SelectCommand = cmd;

                OracleString rowId;
                cmd.ExecuteOracleNonQuery(out rowId);


                MessageBox.Show("Datos Eliminados de la DB");
                MostrarDatos();
                ora.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                ora.Close();
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("sqlldr system/123456 control=C:\\Texto\\LOAD_DATA.txt");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            MostrarDatos();
            MessageBox.Show(process.StandardOutput.ReadToEnd());
        }

        public void MostrarDatos()
        {
            cmd = new OracleCommand("SELECT codempleado as Codigo, nombres, apellidos, salario, departamento FROM Empleados", ora);
            cmd.CommandType = System.Data.CommandType.Text;


            da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            da.Fill(tabla);

            ora.Close();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                cmd = new OracleCommand("begin CrearTexto; end;", ora);
                cmd.CommandType = CommandType.Text;

                da = new OracleDataAdapter();
                da.SelectCommand = cmd;

                //           cmd.CommandType = System.Data.CommandType.StoredProcedure;
                OracleString rowId;
                cmd.ExecuteOracleNonQuery(out rowId);


                MessageBox.Show("TABLA EXPORTADA");
                replaceString();
                ora.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                ora.Close();
            }

        }


        private void replaceString()
        {
            String filename;
            String search;
            String replace;

            filename = "C:\\Texto\\exportado.txt";
            search = ",";
            replace = ".";

            StreamReader sr = new StreamReader(filename);
            String[] rows = Regex.Split(sr.ReadToEnd(), "\r\n");
            sr.Close();

            StreamWriter sw = new StreamWriter(filename);
            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i].Contains(search))
                {
                    rows[i] = rows[i].Replace(search, replace);
                }
                sw.WriteLine(rows[i]);
            }
            sw.Close();
        }

        public void LlenarTablaImportar()
        {

            var lines = File.ReadAllLines("C:\\Texto\\exportado.txt");
            if (lines.Count() > 0)
            {
                foreach (var columnName in lines.FirstOrDefault()
                    .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    dataGridView1.Columns.Add(columnName, columnName);
                }
                foreach (var cellValues in lines.Skip(1))
                {
                    var cellArray = cellValues
                        .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cellArray.Length == dataGridView1.Columns.Count)
                        dataGridView1.Rows.Add(cellArray);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
         
            dataGridView1.DataSource = null;
            LlenarTablaImportar();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Examen_DW.Form1();
            principal.Show();
            this.Close();

        }
    }
}

