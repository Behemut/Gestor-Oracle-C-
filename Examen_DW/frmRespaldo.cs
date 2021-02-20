using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OracleClient;
using Oracle.DataAccess;
using System.Diagnostics;

namespace Examen_DW
{
    public partial class frmRespaldo : Form
    {
        //  OracleConnection ora = new OracleConnection("DATA SOURCE = localhost/orcl; PASSWORD=123456;USER ID= system");
        OracleConnection ora;
        OracleCommand cmd;
        OracleDataAdapter da;

        string ubicacion;

        string usuario;
        string password;

        string carpeta;
        string tipo;
        string valor;


        public frmRespaldo()
        {
            InitializeComponent();
        }

        private void frmRespaldo_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("Completo");

            comboBox2.DataSource = null;
        }

        private void advancedWizardPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ubicacion = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            if (Probar(txtUsuario.Text, txtPassword.Text))
            {
                MessageBox.Show("Conexion con exito!", "Probar conexion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Verifique los datos!", "Probar conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Probar(string user, string pass)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = localhost/orcl; PASSWORD='" + pass + "';USER ID= '" + user + "'");
            try
            {
               
                ora.Open();
                ora.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        public void LLenarSchemas()
        {
            try
            {   //   select USERNAME from SYS.ALL_USERS;
                OracleConnection ora = new OracleConnection("DATA SOURCE = localhost/orcl; PASSWORD='" + password + "';USER ID= '" + usuario + "'");
                cmd = new OracleCommand("select USERNAME from SYS.ALL_USERS", ora);
                cmd.CommandType = System.Data.CommandType.Text;
                da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                comboBox2.DataSource = tabla;
                comboBox2.DisplayMember = "USERNAME";
                comboBox2.ValueMember = "USERNAME";
                ora.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LlenarTabla()
        {
            try
            {   //   select USERNAME from SYS.ALL_USERS;
                OracleConnection ora = new OracleConnection("DATA SOURCE = localhost/orcl; PASSWORD='" + password + "';USER ID= '" + usuario + "'");
                cmd = new OracleCommand("SELECT table_name FROM dba_tables", ora);
                cmd.CommandType = System.Data.CommandType.Text;
                da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                comboBox2.DataSource = tabla;
                comboBox2.DisplayMember = "TABLE_NAME";
                comboBox2.ValueMember = "TABLE_NAME";
                ora.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
        }

        private void advancedWizard1_Finish(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Completo")
            {
                if (CrearDir())
                {
                    string inst;
                    inst = "expdp " + usuario + "/" + password + " dumpfile=copia_oracle_" + carpeta + ".dmp logfile=copia_oracle_" + carpeta + ".log  directory=" + carpeta + " full=y";
                    EjecutarCMD(inst);
                }
              else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Esquema")
            {
                if (CrearDir())
                {
                    string inst;
                    inst = "expdp " + usuario + "/" + password + " dumpfile=Esquema_" + carpeta + ".dmp logfile=Esquema_" + carpeta + ".log  schemas=" + valor + "  directory=" + carpeta + "";
                    EjecutarCMD(inst);
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Tabla especifica")
            {
                if (CrearDir())
                {
                    string inst;
                    inst = "expdp " + usuario + "/" + password + " dumpfile=Esquema_" + carpeta + ".dmp logfile=Esquema_" + carpeta + ".log  tables=" + valor + "  directory=" + carpeta + "";
                    EjecutarCMD(inst);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            carpeta = txtNombre.Text;
        }

        public void EjecutarCMD(string instruccion)
        {
           Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine(instruccion);
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            MessageBox.Show("Respaldo finalizado!", "RESPALDO DE "+ carpeta + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show("expdp " + usuario  + "/" + password + " dumpfile=copia_oracle_"+ carpeta +".dmp logfile=copia_oracle_"+carpeta+".log  directory="+ carpeta +" full=y");
        }

        public bool CrearDir()
        {
            try
            {  // Create or replace directory CARPETA_EXPORT as 'C:/SQL_LOADER/';
                OracleConnection ora = new OracleConnection("DATA SOURCE = localhost/orcl; PASSWORD='" + password + "';USER ID= '" + usuario + "'");
                ora.Open();

                string instruccion = "Create or replace directory " + carpeta + " as '" + ubicacion + "'";
                cmd = new OracleCommand(instruccion, ora);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                return true;

                //  MessageBox.Show(instruccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void advancedWizardPage2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         if (comboBox1.SelectedItem.ToString() == "Completo")
                {
                    label5.Visible = false;
                    comboBox2.Visible = false;
                tipo = "Completo";
                valor = "";
                
                }
                else if (comboBox1.SelectedItem.ToString() == "Esquema")
                {
                    label5.Text = "Esquema:";
                    label5.Visible = true;
                    comboBox2.Visible = true;
                tipo = "Esquema";
                LLenarSchemas();
                 
                }
               else  if (comboBox1.SelectedItem.ToString() == "Tabla especifica")
                {
                label5.Text = "Tabla:";
                tipo = "Tabla especifica";

                label5.Visible = true;
                comboBox2.Visible = true;
                LlenarTabla();
            }
         }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = comboBox2.SelectedValue.ToString();
        }

        private void advancedWizard1_Next(object sender, AdvancedWizardControl.EventArguments.WizardEventArgs e)
        {
            txtRUsuario.Text = usuario;
            txtRUbicacion.Text  = ubicacion;
            txtRDir.Text = carpeta;

            txtRTipo.Text = tipo;
            txtResultado.Text = valor;

        }
    }
}

