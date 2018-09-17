using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SelectDB
{
    public partial class SelectDB : Form
    {

        /// <summary>
        /// 这个软件应该有很多不完美的地方，我整出来后就懒得再搞了。所以应该不会再优化了，不过大多数东西都整出来了，之后要改的话应该不难，
        /// 各位应该可以自己改出来想要的效果。
        /// 备注有的地方可能从后面看更详细些，因为我从末尾开始写上来，至于为什么我说可能，因为我这金鱼一样的记忆，而且我很懒，所以才有了这个东西。
        /// 应该差不多了，本来都不想写备注，但是这还是我第一次传东西到github上，想着还是写写算了，就这样吧，该看直播去了。。。
        /// </summary>

        private string strConn;//连接数据库的字符串
        private string DBName;//记录数据库名
        private string TableName;//记录表名
        private string Result;//记录最终结果
        SqlConnection conn = new SqlConnection();//先整个实例出来
        MyPannel myPannel = new MyPannel();

        public SelectDB()
        {
            InitializeComponent();
        }

        //登录选择输入用户名密码登录
        private void button_Login_Click(object sender, EventArgs e)
        {
            //看看是不是个想试试有没有系统漏洞的人
            if(textBox_UserName.Text == string.Empty || textBox_Pwd.Text == string.Empty)
            {
                MessageBox.Show("用户名或密码未输入");
                return;
            }

            strConn = "data source = " + textBox_SeverName.Text + ";" +
                        " initial catalog = master;" +
                        " uid = " + textBox_UserName.Text + ";" +
                        " pwd = " + textBox_Pwd.Text + ";";

            conn.ConnectionString = strConn;
            try
            {
                conn.Open();//测试是否能连接上数据库

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "打开数据库失败");
                return;
            }

            myPannel.Show(new List<Panel> { panel_SelectDB });
        }

        //登录点击Windows登录验证
        private void button_WinConfirm_Click(object sender, EventArgs e)
        {
            strConn = "data source = " + textBox_SeverName.Text +
                        "; initial catalog = master; integrated security = true";

            conn.ConnectionString = strConn;
            try
            {
                conn.Open();//测试是否能连接上数据库

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "打开数据库失败");
                return;
            }

            myPannel.Show(new List<Panel> { panel_SelectDB });
        }

        //当整个窗体加载时，一开始名字没起好，有点重复，见谅
        private void SelectDB_Load(object sender, EventArgs e)
        {
            myPannel.Show(new List<Panel> { panel_EnterDB });
        }

        //panel显示改变
        private void panel_SelectDB_VisibleChanged(object sender, EventArgs e)
        {
            //清空
            groupBox_SelectDB.Controls.Clear();

            int j = 0;
            int k = 1;
            int l = 1;

            conn.ConnectionString = strConn;
            try
            {
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("select name from master..sysdatabases", conn);
                da.Fill(ds, "DBName");//得到所有数据库名

                for (int i = 0; i < ds.Tables["DBName"].Rows.Count; i++)
                {
                    //抄的
                    RadioButton temp_DBName = new RadioButton();
                    temp_DBName.Width = 100;
                    temp_DBName.Name = "radioButton_DBN_" + i.ToString();
                    temp_DBName.Text = ds.Tables["DBName"].Rows[i]["name"].ToString();
                    if(i == 4 * l)
                    {
                        l++;
                        k++;
                        j = 0;
                    }
                    temp_DBName.Location = new Point(20 + 100 * j, 20 * k);
                    j++;
                    //抄的
                    this.groupBox_SelectDB.Controls.Add(temp_DBName);
                    temp_DBName.CheckedChanged += new EventHandler(temp_DBName_CheckedChanged);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "打开数据库失败");
            }
        }

        //单选按钮的事件处理函数
        private void temp_DBName_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            if (rad.Checked)
            {
                DBName = rad.Text;
            }
        }

        //选了数据库点击下一步
        private void button_SelectDB_Click(object sender, EventArgs e)
        {
            //看看选了没
            if (DBName == null)
            {
                MessageBox.Show("未选择数据库!");
                return;
            }
            myPannel.Show(new List<Panel> { panel_SelectTable });
        }

        //返回到登录界面
        private void button_DBReturn_Click(object sender, EventArgs e)
        {
            myPannel.Show(new List<Panel> { panel_EnterDB });
        }

        //panel显示改变时的函数
        private void panel_SelectTable_VisibleChanged(object sender, EventArgs e)
        {
            //清空
            groupBox_SelectTable.Controls.Clear();

            string strSqlDA = "use " + DBName +
                              " Select Name from sysobjects where Type='U'";
            int j = 0;
            int k = 1;
            int l = 1;

            conn.ConnectionString = strConn;
            try
            {
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(strSqlDA, conn);
                da.Fill(ds, "TableName");//得到所有表名

                for (int i = 0; i < ds.Tables["TableName"].Rows.Count; i++)
                {
                    //网上抄的，就是动态添加单选按钮
                    RadioButton temp_TableName = new RadioButton();
                    temp_TableName.Width = 100;
                    temp_TableName.Name = "radioButton_TN_" + i.ToString();
                    temp_TableName.Text = ds.Tables["TableName"].Rows[i]["Name"].ToString();
                    if (i == 4 * l)
                    {
                        l++;
                        k++;
                        j = 0;
                    }
                    temp_TableName.Location = new Point(20 + 100 * j, 20 * k);
                    j++;
                    //添加到group里，网上抄的
                    this.groupBox_SelectTable.Controls.Add(temp_TableName);
                    //添加事件处理函数，网上抄的
                    temp_TableName.CheckedChanged += new EventHandler(temp_TableName_CheckedChanged);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "打开数据库失败");
            }
        }

        //当groupBox_SelectTable里的单选按钮点击后的事件
        private void temp_TableName_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            if (rad.Checked)
            {
                //得到表名
                TableName = rad.Text;
            }
        }

        //选择表后点击下一步
        private void button_SelectTable_Click(object sender, EventArgs e)
        {
            //先看看选没选
            if (TableName == null)
            {
                MessageBox.Show("未选择表!");
                return;
            }
            myPannel.Show(new List<Panel> { panel_SelectColName });
        }

        //返回到选择数据库
        private void button_TNReturn_Click(object sender, EventArgs e)
        {
            myPannel.Show(new List<Panel> { panel_SelectDB});
        }

        //panel显示情况改变时，就把控件刷新
        private void panel_SelectColName_VisibleChanged(object sender, EventArgs e)
        {
            //先清空一下，不然用了返回就难受了
            checkedListBox_SelectColName.Items.Clear();

            //句子抄的
            string strSqlDA = "use " + DBName +
                              " Select Name from syscolumns where ID=OBJECT_ID(N'" + TableName +
                              "') Order By ColID";

            conn.ConnectionString = strConn;
            try
            {
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(strSqlDA, conn);
                da.Fill(ds, "ColName");//得到所有字段名

                for (int i = 0; i < ds.Tables["ColName"].Rows.Count; i++)
                {
                    //把字段名添加到这个box里
                    this.checkedListBox_SelectColName.Items.Add(ds.Tables["ColName"].Rows[i]["Name"].ToString());
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "打开数据库失败");
            }
        }

        //把选择的字段的结果记录下来，并在文本框中展示出来
        private void checkedListBox_SelectColName_SelectedValueChanged(object sender, EventArgs e)
        {
            Result = string.Empty;
            //CheckedItems才是正确的，不要用SelectedItems
            foreach (var item in checkedListBox_SelectColName.CheckedItems)
            {
                if (Result != string.Empty)
                {
                    Result += ", ";
                }
                Result += item.ToString();
            }
            //在文本框中展示出来
            textBox_ColName.Text = Result;
        }

        //把结果复制到粘贴板
        private void button_Copy_Click(object sender, EventArgs e)
        {
            //这个try没什么卵用，懒得删而已
            try
            {
                Clipboard.SetText(Result);
                MessageBox.Show("复制成功!\n" + "Result: " + Clipboard.GetText()
                    + "\n若Result结果不正确，请重新复制.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "复制失败!");
            }
        }

        //返回到选表界面
        private void button_CNReturn_Click(object sender, EventArgs e)
        {
            myPannel.Show(new List<Panel> { panel_SelectTable });
        }
    }

    //负责更改panel的显示隐藏，这个小程序其实不用弄这个，而且我也不知到怎么让它记忆每一步的操作，这样返回功能就更高级了
    //到时候有时间再说吧，haha，到时候，有时间
    public class MyPannel
    {
        private List<Panel> NowPannelColl = new List<Panel>();
        private List<Panel> OldPannelColl = new List<Panel>();

        public List<Panel> NowPannelColl1 { get => NowPannelColl; set => NowPannelColl = value; }
        public List<Panel> OldPannelColl1 { get => OldPannelColl; set => OldPannelColl = value; }

        //隔一段时间后我应该也能看懂吧
        public void Show(List<Panel> panels)
        {
            OldPannelColl1 = NowPannelColl1;

            foreach (Panel p in OldPannelColl1)
            {
                p.Visible = false;
            }

            NowPannelColl1 = panels;

            foreach (Panel p in panels)
            {
                p.Visible = true;
            }
        }
    }
}
