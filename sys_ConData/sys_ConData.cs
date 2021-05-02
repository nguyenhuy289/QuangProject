using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace sys_ConData
{
    public class sys_ConData
    {
        private SqlCommand Command;
        private SqlConnection Conn;
        private SqlTransaction Tran;
        private cmdType MyCmdType;
        private int _TimeOut;
        private int flagCheckConnect;
        private string aaaPathConstr_;
        private string aaPathLicense;
        private string aastrLicense;
        private bool isLicense;
        public int CmdTimeOut;
        public sys_ConData()
        {
            this.flagCheckConnect = 0;
            this.aaaPathConstr_ = "";
            this.aaPathLicense = "";
            this.aastrLicense = "";
            this.isLicense = false;
            this.CmdTimeOut = 300;
        }
        public void Add_MyParametersCommand(string ParatmetersName, SqlDbType My_sqldbType, object My_ValueColumn)
        {
            try
            {
                this.Command.Parameters.Add(new SqlParameter(ParatmetersName, My_sqldbType, 0));
                this.Command.Parameters[ParatmetersName].Value = My_ValueColumn;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public void Add_MyParametersCommand(string ParametersName, SqlDbType My_sqldbType, int My_size, object My_ValueColumn)
        {
            try
            {
                this.Command.Parameters.Add(new SqlParameter(ParametersName, My_sqldbType, My_size));
                this.Command.Parameters[ParametersName].Value = My_ValueColumn;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public void Add_NewCommand(string strSQL, cmdType cmdType)
        {
            try
            {
                if (this.flagCheckConnect == 0)
                {
                    this.Conn = this.ConnectionData();
                }
                this.MyCmdType = cmdType;
                if (cmdType == sys_ConData.cmdType.Query)
                {
                    this.Command = new SqlCommand(strSQL, this.Conn, this.Tran);
                }
                else
                {
                    this.Command = new SqlCommand(strSQL, this.Conn, this.Tran);
                    this.Command.CommandType = CommandType.StoredProcedure;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public void BeginTransaction()
        {
            try
            {
                this.Conn = this.ConnectionData();
                this.Tran = this.Conn.BeginTransaction();
                this.flagCheckConnect = 1;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public void CommitTransaction()
        {
            try
            {
                this.Tran.Commit();
                this.Conn.Close();
                this.flagCheckConnect = 0;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }


        public SqlConnection ConnectionData()
        {
            SqlConnection connection;
            try
            {
                string str2 = this.DocFileText();
                SqlConnection connection2 = new SqlConnection(this.DocFileText());
                connection2.Open();
                connection = connection2;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return connection;
        }

        public string DocFileText()
        {
            string connectionString;
            try
            {
                if (sys_Con.ConnectionString == "")
                {
                    sys_Con.ConnectionString = sys_Con.MaHoa04(this.ReadSetting("constr"), "PhuongNamSoft", true);
                }
                connectionString = sys_Con.ConnectionString;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return connectionString;
        }


        public void ExecCommand_NoReturn(SqlCommand cmd)
        {
            try
            {
                cmd.CommandTimeout = this.CmdTimeOut;
                cmd.ExecuteNonQuery();
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }


        public DataTable ExecCommand_ReturnTable(SqlCommand cmd)
        {
            DataTable table;
            DataTable dataTable = new DataTable();
            try
            {
                if (this.MyCmdType == cmdType.Query)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                }
                else
                {
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    cmd.CommandTimeout = this.CmdTimeOut;
                    adapter2.SelectCommand = cmd;
                    adapter2.Fill(dataTable);
                }
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
                table = dataTable;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return table;
        }

        public object ExecCommand_Scalar(SqlCommand cmd)
        {
            object obj2;
            try
            {
                cmd.CommandTimeout = this.CmdTimeOut;
                object obj3 = cmd.ExecuteScalar();
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
                obj2 = obj3;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return obj2;
        }

        public void ExecProc_NoReturn(string ProcName)
        {
            try
            {
                if (this.flagCheckConnect == 0)
                {
                    this.Conn = this.ConnectionData();
                }
                this.Command = new SqlCommand(ProcName, this.Conn, this.Tran);
                this.Command.CommandType = CommandType.StoredProcedure;
                this.Command.CommandTimeout = this.CmdTimeOut;
                this.Command.ExecuteNonQuery();
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public DataTable ExecProc_ReturnTable(string ProcName)
        {
            DataTable table;
            DataTable dataTable = new DataTable();
            try
            {
                if (this.flagCheckConnect == 0)
                {
                    this.Conn = this.ConnectionData();
                }
                this.Command = new SqlCommand(ProcName, this.Conn, this.Tran);
                this.Command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                this.Command.CommandTimeout = this.CmdTimeOut;
                adapter.SelectCommand = this.Command;
                adapter.Fill(dataTable);
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
                table = dataTable;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return table;
        }

        public object ExecProc_Scalar(string ProcName)
        {
            object obj2;
            try
            {
                if (this.flagCheckConnect == 0)
                {
                    this.Conn = this.ConnectionData();
                }
                this.Command = new SqlCommand(ProcName, this.Conn, this.Tran);
                this.Command.CommandType = CommandType.StoredProcedure;
                this.Command.CommandTimeout = this.CmdTimeOut;
                object obj3 = this.Command.ExecuteScalar();
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
                obj2 = obj3;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return obj2;
        }

        public DataTable ExecQuery_ReturnTable(string strSQL)
        {
            DataTable table;
            try
            {
                DataTable dataTable = new DataTable();
                this.Conn = this.ConnectionData();
                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, this.Conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataTable);
                this.Conn.Close();
                table = dataTable;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return table;
        }

        public object ExecQuery_Scalar(string strSQL)
        {
            object obj2;
            try
            {
                this.Conn = this.ConnectionData();
                this.Command = new SqlCommand(strSQL, this.Conn);
                object obj3 = this.Command.ExecuteScalar();
                this.Conn.Close();
                obj2 = obj3;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return obj2;
        }

        public void FillDataSet(SqlCommand cmd, ref DataSet dset)
        {
            try
            {
                if (this.MyCmdType == cmdType.Query)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    cmd.CommandTimeout = this.CmdTimeOut;
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Fill(dset);
                }
                else
                {
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    cmd.CommandTimeout = this.CmdTimeOut;
                    adapter2.SelectCommand = cmd;
                    adapter2.Fill(dset);
                }
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public void FillDataTable(SqlCommand cmd, ref DataTable Table)
        {
            try
            {
                if (this.MyCmdType == cmdType.Query)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    cmd.CommandTimeout = this.CmdTimeOut;
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Fill(Table);
                }
                else
                {
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    cmd.CommandTimeout = this.CmdTimeOut;
                    adapter2.SelectCommand = cmd;
                    adapter2.Fill(Table);
                }
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public void FillDataTable(string strSQL, cmdType cmdType, ref DataTable tb)
        {
            try
            {
                if (this.flagCheckConnect == 0)
                {
                    this.Conn = this.ConnectionData();
                }
                if (cmdType == sys_ConData.cmdType.Query)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(strSQL, this.Conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Fill(tb);
                }
                else
                {
                    this.Command = new SqlCommand(strSQL, this.Conn);
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    this.Command.CommandTimeout = this.CmdTimeOut;
                    adapter2.SelectCommand = this.Command;
                    adapter2.Fill(tb);
                }
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public SqlCommand Get_NewCommand()
        {
            SqlCommand command;
            try
            {
                command = this.Command;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return command;
        }

        private string getConfigFilePath()
        {
            string str2 = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", "");
            string[] strArray = str2.Split(new char[] { '/' });
            return (str2.Replace(strArray[strArray.Length - 1], "") + "Setting.config");
        }

        private XmlDocument loadConfigDocument()
        {
            XmlDocument document = null;
            XmlDocument document2;
            try
            {
                document = new XmlDocument();
                document.Load(this.getConfigFilePath());
                document2 = document;
            }
            catch (FileNotFoundException exception1)
            {
                FileNotFoundException ex = exception1;
                ProjectData.SetProjectError(ex);
                FileNotFoundException innerException = ex;
                throw new Exception("No configuration file found.", innerException);
            }
            return document2;
        }

        private string ReadSetting(string Key)
        {
            string str;
            try
            {
                string attribute = "";
                XmlNode objA = this.loadConfigDocument().SelectSingleNode("//connectionStrings");
                if (ReferenceEquals(objA, null))
                {
                    throw new InvalidOperationException("appSettings section not found in config file.");
                }
                XmlElement element = (XmlElement)objA.SelectSingleNode($"//add[@name='{Key}']");
                if (!ReferenceEquals(element, null))
                {
                    attribute = element.GetAttribute("connectionString");
                }
                str = attribute;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
            return str;
        }

        private void RemoveSetting(string key)
        {
            XmlDocument document = this.loadConfigDocument();
            XmlNode objA = document.SelectSingleNode("//appSettings");
            try
            {
                if (ReferenceEquals(objA, null))
                {
                    throw new InvalidOperationException("appSettings section not found in config file.");
                }
                objA.RemoveChild(objA.SelectSingleNode($"//add[@key='{key}']"));
                document.Save(this.getConfigFilePath());
            }
            catch (NullReferenceException exception1)
            {
                NullReferenceException ex = exception1;
                ProjectData.SetProjectError(ex);
                NullReferenceException innerException = ex;
                throw new Exception($"The key {key} does not exist.", innerException);
            }
        }

        public void RollBackTransaction()
        {
            try
            {
                this.Tran.Rollback();
                this.Conn.Close();
                this.flagCheckConnect = 0;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public void UpdateTable(SqlCommand cmd, DataTable table)
        {
            try
            {
                if (this.flagCheckConnect == 0)
                {
                    this.Conn = this.ConnectionData();
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandTimeout = this.CmdTimeOut;
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(table);
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        public void UpdateTable(string strSQL, cmdType CmdType, DataTable table)
        {
            try
            {
                if (this.flagCheckConnect == 0)
                {
                    this.Conn = this.ConnectionData();
                }
                if (CmdType == cmdType.Query)
                {
                    this.Command = new SqlCommand(strSQL, this.Conn, this.Tran);
                    SqlDataAdapter adapter = new SqlDataAdapter(this.Command);
                    this.Command.CommandTimeout = this.CmdTimeOut;
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(table.GetChanges());
                }
                else if (CmdType == cmdType.Store)
                {
                    this.Command = new SqlCommand(strSQL, this.Conn, this.Tran);
                    this.Command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(this.Command);
                    this.Command.CommandTimeout = this.CmdTimeOut;
                    SqlCommandBuilder builder2 = new SqlCommandBuilder(adapter);
                    adapter.Update(table);
                }
                if (this.flagCheckConnect == 0)
                {
                    this.Conn.Close();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                throw ex;
            }
        }

        private void WriteSetting(string key, string value)
        {
            XmlDocument document = this.loadConfigDocument();
            XmlNode objA = document.SelectSingleNode("//connectionStrings");
            if (ReferenceEquals(objA, null))
            {
                throw new InvalidOperationException("appSettings section not found in config file.");
            }
            try
            {
                XmlElement element = (XmlElement)objA.SelectSingleNode($"//add[@name='{key}']");
                if (!ReferenceEquals(element, null))
                {
                    string attribute = element.GetAttribute("connectionString");
                    element.SetAttribute("connectionString", value);
                }
                else
                {
                    element = document.CreateElement("add");
                    element.SetAttribute("Name", key);
                    element.SetAttribute("connectionString", value);
                    objA.AppendChild(element);
                }
                document.Save(this.getConfigFilePath());
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                throw;
            }
        }
        
        public enum cmdType
        {
            Query,
            Store
        }




    }
}
