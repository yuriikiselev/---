using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace VkAPITutorial
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            
            GetToken.DocumentCompleted += GetToken_DocumentCompleted;
            GetToken.Navigate("https://oauth.vk.com/authorize?client_id=7225946&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.52");
        }

        private void GetToken_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (GetToken.Url.ToString().IndexOf("access_token=") != -1)
            {
                GetUserToken();
            }
        }

        private void GetUserToken()
        {
            char[] Symbols = { '=', '&' };
            string[] URL = GetToken.Url.ToString().Split(Symbols);
            File.WriteAllText("UserInf.txt", URL[1] + "\n");
            File.AppendAllText("UserInf.txt", URL[5]);
            this.Visible = false;
        }

        private void GetToken_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
        }
    }
}