using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace mysql
{
    public partial class MainForm : Form
    {
        MySqlHelper mysql;
        public MainForm()
        {
            InitializeComponent();
            mysql = null;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (mysql == null )
            {
                string ConnStr = string.Format(@"server={0};uid={1};pwd={2};database={3};charset=utf8",
                    textBoxServer.Text.Trim(), textBoxAccount.Text.Trim(), textBoxPassword.Text, textBoxDB.Text.Trim());
                mysql = new MySqlHelper();
                mysql.Open(ConnStr);
                tabControlMain.Enabled = true;
                buttonConnect.Text = "断开";
                buttonRefreshCakeTypes.PerformClick();
            }
            else
            {
                mysql.Close();
                tabControlMain.Enabled = false;
                mysql = null;
                buttonConnect.Text = "连接";

            }

        }
        private void buttonAddType_Click(object sender, EventArgs e)
        {
            if (textBoxTypeName.Text.Trim().Length == 0 || textBoxTypeShow.Text.Trim().Length == 0)
                return;
            try
            {
                MySqlParameter[] param_list=new MySqlParameter[2];
                param_list[0] = new MySqlParameter("@type_name", "type_" + textBoxTypeName.Text.Trim());
                param_list[1] = new MySqlParameter("@type_show", textBoxTypeShow.Text.Trim());
                mysql.ExecuteNonQuery(CommandType.Text, "insert into `cake_types` (`type_name`,`type_show`) values(@type_name ,@type_show);", param_list);
                //mysql.ExecuteNonQuery(CommandType.Text, "ALTER TABLE `cake_images` add @type_name BOOL default 0;", param);
                mysql.ExecuteNonQuery(CommandType.Text, string.Format("ALTER TABLE `cake_images` add `type_{0}` bool default 0;", textBoxTypeName.Text.Trim()), null);
                buttonRefreshCakeTypes.PerformClick();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        private void buttonRefreshCakeTypes_Click(object sender, EventArgs e)
        {
            checkedListBoxTypes.Items.Clear();
            try
            {
                MySqlDataReader reader = mysql.ExecuteReader(CommandType.Text, "select * from `cake_types`;", null);
                while (reader.Read())
                {
                    CakeType type = new CakeType();
                    type.Text = reader["type_show"].ToString();
                    type.Value= reader["type_name"].ToString();
                    checkedListBoxTypes.Items.Add(type);
                }
                reader.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        #region "文件操作"
        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            textBoxImgFileName.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            //openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string file_name in openFileDialog.SafeFileNames)
                {
                    textBoxImgFileName.AppendText(string.Format("{0};", file_name));
                }
            }
        }
        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            bool type_check = false;
            if (textBoxImgFileName.Text.Trim().Length == 0)
                return;
            if (checkedListBoxTypes.Items.Count == 0)
            {
                MessageBox.Show("类别未刷新");
                return;
            }
            string[] str_list=textBoxImgFileName.Text.Trim().Split(';');
            //INSERT INTO `cake_images` (列1, 列2,...) VALUES(值1, 值2,....)
            string sql_str = "INSERT INTO `cake_images` (`";
            foreach(CakeType type in checkedListBoxTypes.Items)
            {
                sql_str += type.Value;
                sql_str += "`,`";
            }
            sql_str += "file_name`,`cake_code`) values(";
            int i = 0 ;
            foreach (CakeType type in checkedListBoxTypes.Items)
            {
                if (checkedListBoxTypes.GetItemChecked(i))
                {
                    sql_str += "1,";
                    type_check = true;
                }
                else
                    sql_str += "0,";
                i++;
            }
            if (!type_check)
            {
                MessageBox.Show("未选择类别");
                return;
            }

            try {
                mysql.BeginTransaction();
                foreach (string file_name in str_list)
                {
                    string file = file_name.Trim();
                    if (file.Length == 0)
                        continue;

                    string code = file.Substring(0, file.IndexOf('.'));
                    string sql_cmd = sql_str + "'" + file_name + "','"+ code+ "')";
                    mysql.ExecuteNonQuery(CommandType.Text, sql_cmd, null);
                }
                mysql.Commit();
                MessageBox.Show("完成");
            }
            catch(Exception ee)
            {
                mysql.RollBack();
                MessageBox.Show("插入失败,已回滚。\r\n"+ee.ToString());
            }
            
        }
        private void buttonDeleFile_Click(object sender, EventArgs e)
        {
            if (textBoxImgFileName.Text.Trim().Length == 0)
                return;
            string[] str_list = textBoxImgFileName.Text.Trim().Split(';');
            string sql_str = "delete from `cake_images` where `file_name`='";
            try
            {
                mysql.BeginTransaction();
                foreach (string file_name in str_list)
                {
                    if (file_name.Trim().Length == 0)
                        continue;
                    string sql_cmd = sql_str  + file_name + "'";
                    mysql.ExecuteNonQuery(CommandType.Text, sql_cmd, null);
                }
                mysql.Commit();
                MessageBox.Show("完成");
            }
            catch (Exception ee)
            {
                mysql.RollBack();
                MessageBox.Show("删除失败,已回滚。\r\n" + ee.ToString());
            }
        }


        #endregion


    }

    public class CakeType
    {
        private string type_name, type_show;
        public override string ToString()
        {
            return type_show;
        }
        public string Text
        {
            set { type_show = value; }
            get { return type_show; }
        }
        public string Value
        {
            set { type_name = value; }
            get { return type_name; }
        }
    }
}
