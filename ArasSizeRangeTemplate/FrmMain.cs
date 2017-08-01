using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArasSizeRangeTemplate
{
    public partial class FrmMain : Form
    {
        public static string mc_Collar_CM = "36,37,38,39,40,41,42,43,44,45,46,47,48,49,50";
        public static string mc_Collar_ICON = "13,14,14.5,15,15.5,16,16,16.5,17";

        public static string mc_Sleeve_CM = "79,81,83,87,91,94,97,98";
        public static string mc_Sleeve_ICON = "13,14,14.5,15,15.5,16,16,16.5,17";

        public static string mc_Collar_prefix = "Collar";
        public static string mc_Sleeve_prefix = "Sleeve";

        public FrmMain()
        {
            InitializeComponent();

            settingControls(false);
        }
       
        public string SettingLevelSpace(int int_level)
        {
            StringBuilder l_returnString=new StringBuilder();

            for (int i = 0; i < int_level*4; i++)
			{
			    l_returnString.Append(" ");
			}

            return l_returnString.ToString();
        }                            

        public void CreateCollar()
        {
            string[] l_collar = mc_Collar_CM.Split(',');

            for (int i = 0; i < l_collar.Length; i++)
            {
                CheckBox l_chk_Collar = new CheckBox();

                l_chk_Collar.Name = mc_Collar_prefix + "-" + l_collar[i];
                l_chk_Collar.Text = l_collar[i];
                l_chk_Collar.Width = 50;               

                l_chk_Collar.Location = new Point(20, 30 * i + 20);
                l_chk_Collar.Click += new System.EventHandler(this.chk_Collar_Click);
                pan_Collar.Controls.Add(l_chk_Collar);
            }
        }

        public void GetValue()
        {
            string[] l_collar = mc_Collar_CM.Split(',');
            string[] l_sleeve = mc_Sleeve_CM.Split(',');

            StringBuilder l_getAML = new StringBuilder();
            for (int i = 0; i < l_collar.Length; i++)
            {
                #region get collar
                StringBuilder l_getCollar_AML = new StringBuilder();
                CheckBox l_chk_Collar = (CheckBox)(pan_Collar.Controls[i]);
                //CheckBox l_chk_Collar = (CheckBox)l_getCollar_Control[0];
                if (l_chk_Collar.Checked)
                {
                    l_getCollar_AML.Append(SettingLevelSpace(1) + "<Item type=\"Size Range_D1\" action=\"add\">" + "\r\n");
                    l_getCollar_AML.Append(SettingLevelSpace(2) + "<cn_size>" + l_chk_Collar.Text + "</cn_size>" + "\r\n");

                    #region get sleeve

                    StringBuilder l_getSleeve_AML = new StringBuilder();
                    Control[] l_getSleevePan = pan_Collar.Controls.Find(l_chk_Collar.Name + "-" + mc_Sleeve_prefix, true);

                    if (l_getSleevePan.Length > 0)
                    {
                        Panel l_panSleeve = (Panel)l_getSleevePan[0];
                        for (int j = 0; j < l_sleeve.Length; j++)
                        {
                            CheckBox l_chk_sleeve = (CheckBox)(l_panSleeve.Controls.Find(mc_Sleeve_prefix + "-" + l_sleeve[j], true)[0]);                             
                            if (l_chk_sleeve.Checked)
                            {
                                l_getSleeve_AML.Append(SettingLevelSpace(3) + "<Item type=\"Size Range_D1_D2\" action=\"add\">" + "\r\n");
                                l_getSleeve_AML.Append(SettingLevelSpace(4) + "<cn_size2>" + l_chk_sleeve.Text + "</cn_size2>" + "\r\n");
                                l_getSleeve_AML.Append(SettingLevelSpace(3) + "</Item>" + "\r\n");
                            }
                        }
                    }

                    if (l_getSleeve_AML.Length > 0)
                    {
                        l_getCollar_AML.Append(SettingLevelSpace(2) + "<Relationships>" + "\r\n");
                        l_getCollar_AML.Append(l_getSleeve_AML);
                        l_getCollar_AML.Append(SettingLevelSpace(2) + "</Relationships>" + "\r\n");
                    }

                    #endregion

                    l_getCollar_AML.Append(SettingLevelSpace(1) + "</Item>" + "\r\n");
                }

                #endregion

                l_getAML.Append(l_getCollar_AML.ToString());
            }

            if (l_getAML.Length > 0)
            {
                l_getAML.Insert(0, "<Relationships>" + "\r\n");

                l_getAML.Append("</Relationships>" + "\r\n");
            }

            txt_AML.Text = l_getAML.ToString();
        }

        //-------------------------------------------------------------

        private void chk_Collar_Click(object sender, EventArgs e)
        {
            CheckBox l_chk_Collar = (CheckBox)sender;
            string[] l_sleeve = mc_Sleeve_CM.Split(',');

            if (l_chk_Collar.Checked)
            {
                if (radio_CollarSleeve.Checked)
                {
                    Panel l_pan_Sleeve = new Panel();

                    //l_pan_Sleeve.AutoScroll = true;
                    l_pan_Sleeve.Name = l_chk_Collar.Name + "-" + mc_Sleeve_prefix;
                    l_pan_Sleeve.Location = new Point(70, l_chk_Collar.Top);
                    l_pan_Sleeve.BorderStyle = BorderStyle.FixedSingle;
                    l_pan_Sleeve.Width = 530;
                    l_pan_Sleeve.Height = 25;

                    for (int i = 0; i < l_sleeve.Length; i++)
                    {
                        CheckBox l_chk_Sleeve = new CheckBox();

                        l_chk_Sleeve.Name = mc_Sleeve_prefix + "-" + l_sleeve[i];
                        l_chk_Sleeve.Text = l_sleeve[i];
                        l_chk_Sleeve.Width = 40;

                        l_chk_Sleeve.Location = new Point(55 * i + 20, 0);
                        l_chk_Sleeve.Click += new System.EventHandler(this.chk_Sleeve_Click);

                        l_pan_Sleeve.Controls.Add(l_chk_Sleeve);
                    }

                    pan_Collar.Controls.Add(l_pan_Sleeve);
                }
            }
            else
            {
                Control[] l_pan_sleeve = pan_Collar.Controls.Find(l_chk_Collar.Name + "-" + mc_Sleeve_prefix, true);
                pan_Collar.Controls.Remove(l_pan_sleeve[0]);
            }

            GetValue();
        }

        private void chk_Sleeve_Click(object sender, EventArgs e)
        {
            GetValue();
        }

        public void settingControls(bool bln_Run)
        {
            btn_Start.Enabled = !bln_Run;
            btn_Restart.Enabled = bln_Run;

            if(!bln_Run)
            {
                txt_AML.Text = "";
            }
        }

        public void showMessage(string pi_message)
        {
            MessageBox.Show(pi_message);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {                

                pan_Collar.Controls.Clear();
                CreateCollar();

                settingControls(true);
            }
            catch (Exception ex)
            {
                showMessage(ex.Message);
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            try
            {
                pan_Collar.Controls.Clear();

                settingControls(false);
            }
            catch (Exception ex)
            {
                showMessage(ex.Message);
            }
        }

        private void txt_AML_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;
            if (e.KeyChar == (char)1)       // Ctrl-A 相当于输入了AscII=1的控制字符
            {
                textBox.SelectAll();
                e.Handled = true;      // 不再发出“噔”的声音
            }
        }
    }
}
