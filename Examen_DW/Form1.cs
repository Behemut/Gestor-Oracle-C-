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
    public partial class Form1 : Form
    {

        //VARIABLES
        OracleConnection ora = new OracleConnection("DATA SOURCE = localhost/orcl; PASSWORD=123456;USER ID= system");
        OracleCommand cmd;
        OracleDataAdapter da;
   

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reseteo();
            MostrarDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
             
                ora.Open();
                MessageBox.Show("Base de datos conectada");
                MostrarDatos();
                txtDepartamento.AutoCompleteCustomSource = CargarDepartamentos();
                txtDepartamento.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtDepartamento.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private AutoCompleteStringCollection CargarDepartamentos()
        {
            AutoCompleteStringCollection Departamentos = new AutoCompleteStringCollection();
            Departamentos.Add("Sonsonate");
            Departamentos.Add("Ahuachapan");
            Departamentos.Add("Santa Ana");
            Departamentos.Add("La Libertad");
            Departamentos.Add("Chalatenango");
            Departamentos.Add("San Salvador");
            Departamentos.Add("Cuzcatlan");
            Departamentos.Add("Cabañas");
            Departamentos.Add("La Paz");
            Departamentos.Add("San Vicente");
            Departamentos.Add("Usulutan");
            Departamentos.Add("San Miguel");
            Departamentos.Add("Morazan");
            Departamentos.Add("La Union");
            return Departamentos;
        }


        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          try
            {
                if (rbEditar.Checked == true)
                {
                    dgvEmpleados.Enabled = true;


                    mskCod.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    string var;
                    var = dgvEmpleados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    EditarEmpleados(var, txtNombres, txtApellidos, mskSalario, txtDepartamento);
                 
                }
                else if (rbEliminar.Checked == true)
                {
                    mskCod.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    string var;
                    var = dgvEmpleados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    EditarEmpleados(var, txtNombres, txtApellidos, mskSalario, txtDepartamento);
               
                }
                else if (rbAgregar.Checked == true)
                {
                    Reseteo();
                }

                else
                {
                    mskCod.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    string var;
                    var = dgvEmpleados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    EditarEmpleados(var, txtNombres, txtApellidos, mskSalario, txtDepartamento);
                    Reseteo();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Reseteo()
        {
            foreach (Control c in this.Controls )
            {
                if (c is TextBox )
                {
                    c.Text = "";
                }
                else if (c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado(mskCod.Text, dgvEmpleados);
        }

 

        private void button2_Click(object sender, EventArgs e)
        {
            if(rbAgregar.Checked==true)
            {
                AgregarEmpleados();

                MostrarDatos();
            }
            else if (rbEliminar.Checked==true)
            {
              DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar este usuario del sistema?", "Eliminando Usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EliminarEmpleado(mskCod.Text);
                    MostrarDatos();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Hacer nada 
                }
            }
            else if(rbEditar.Checked==true)
            {
                ActualizarEmpleado(mskCod.Text);

                MostrarDatos();
            }
        }


        //OPERACION DE ORACLE CON C# NET

        public void MostrarDatos()
        {
            cmd = new OracleCommand("SELECT codempleado as Codigo, nombres, apellidos, salario, departamento FROM Empleados", ora);
            cmd.CommandType = System.Data.CommandType.Text;
            da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            da.Fill(tabla);
            dgvEmpleados.DataSource = tabla;
            ora.Close();
        }


        public bool AgregarEmpleados() {
            try {
            ora.Open();
    cmd = new OracleCommand("INSERT INTO  Empleados  VALUES('" + mskCod.Text + "','" + txtNombres.Text + "','" + txtApellidos.Text + "'," + mskSalario.Text  + ",'" +txtDepartamento.Text + "')", ora);

                da = new OracleDataAdapter();
                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();
      
                ora.Close();
                return true;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public void ActualizarEmpleado(string cod)
        {
            try
            {
                ora.Open();
                cmd = new OracleCommand("UPDATE Empleados SET Nombres ='" + txtNombres.Text  + "', Apellidos='" + txtApellidos.Text + "', Salario =" + Convert.ToDouble(mskSalario.Text) + ", Departamento='" + txtDepartamento.Text + "' WHERE codempleado='" + cod + "'", ora);

                da = new OracleDataAdapter();
                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();

                ora.Close();
       
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
    
            }
        }

        public void EditarEmpleados(string Cod, TextBox Nom, TextBox Ape, MaskedTextBox Sal, TextBox Dept)
        {
            try
            {
                ora.Open();
                cmd = new OracleCommand();
                cmd.Connection = ora;
                cmd.CommandText = "SELECT * FROM Empleados Where codempleado = '" + Cod + "'";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read()) // C#
                {
                    Nom.Text = dr["NOMBRES"].ToString();
                    Ape.Text = dr["APELLIDOS"].ToString();
                    Sal.Text = dr["SALARIO"].ToString();
                    Dept.Text = dr["DEPARTAMENTO"].ToString();

                    // or use dr.GetOracleString(0).ToString()

                    ora.Close();
                }
            }
            catch (Exception ex) // catches any error
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void EliminarEmpleado(string cod)
        {
            try
            {
                ora.Close();
                cmd = new OracleCommand();
                cmd.Connection = ora;
                cmd.CommandText = "DELETE FROM Empleados Where codempleado = '" + cod + "'";
                cmd.CommandType = CommandType.Text;
                ora.Open();
                cmd.ExecuteNonQuery();
                ora.Close();
            }
            catch (Exception ex) // catches any error
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void BuscarEmpleado(string cod, DataGridView dgv)
        {
            try
            {
                ora.Open();
                cmd = new OracleCommand();
                cmd.Connection = ora;
                cmd.CommandText = "SELECT * FROM Empleados Where codempleado = '" + cod + "'";
                cmd.CommandType = CommandType.Text;


                da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                dgv.DataSource = tabla;
                ora.Close();
            }
            catch (Exception ex) // catches any error
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void rbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            Reseteo();
        }

    
        private void button3_Click_1(object sender, EventArgs e)
        {
            frmVolcado volcado = new frmVolcado();
            volcado.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRespaldo respaldo = new frmRespaldo();
            respaldo.Show();
            this.Hide();
        }
    }
}
