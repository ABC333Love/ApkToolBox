using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoAPKTool.model;
using Newtonsoft.Json;

namespace AutoAPKTool
{
    public partial class AppInfoUI : Form
    {
        public AppInfoUI()
        {
            InitializeComponent();
        }


        public void setAppInfo(string appInfo)
        {
            AppInfoModel model =  JsonConvert.DeserializeObject<AppInfoModel>(appInfo);
            if (model == null)
            {
                MessageBox.Show("未获取到app信息！", "提示");
                return;
            }

            this.AppNameBox.Text = model.name;
            this.AppPkgNameBox.Text = model.pkg;
            this.AppVersionBox.Text = model.appVersion;
            this.SignHashMd5Box.Text = model.signHashMd5;
            this.SignByteArrayBox.Text = model.signByteArray;
            this.SignHashBox.Text = model.signHash;
            this.SignCharStringBox.Text = model.signCharString;
            this.PermissionsList.Text = model.permissions;
            byte[] bytes = Convert.FromBase64String(model.icon);
            MemoryStream ms = new MemoryStream(bytes);
            ms.Position = 0;
            Image img = Image.FromStream(ms);
            ms.Close();
            this.icon.Image = img;
        }
    }
}
