using System.Text;

namespace GetHostIdByWL
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void HardIdButton_Click(object sender, EventArgs e)
        {
            StringBuilder HardwareId = new StringBuilder(100);
            WinlicenseSDK.WLHardwareGetIDW(HardwareId);
            this.HardIdEdit.Text = HardwareId.ToString();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(HardIdEdit.Text);
        }

        private void btn_send_email_Click(object sender, EventArgs e)
        {
            //string send = txtSend.Text.Trim();//发件人邮箱地址
            //string to = txtTo.Text.Trim();//收件人邮箱地址
            //if (regex(send) && regex(to))//判断发件人邮箱地址&&收件人邮箱地址不为空
            //{
            //    if (send != "" && to != "" && txtpwd.Text != "")
            //    {
            //        DialogResult result = MessageBox.Show("确认发送", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //        if (result == DialogResult.OK)
            //        {
            //            try
            //            {
            //                MailMessage mailMessage = new MailMessage();
            //                mailMessage.From = new MailAddress(send);//发件人邮箱地址
            //                mailMessage.To.Add(new MailAddress(to));//收件人邮箱地址
            //                mailMessage.Subject = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSubject.Text));//对邮件主题进行编码
            //                mailMessage.Body = Convert.ToBase64String(Encoding.UTF8.GetBytes(rtboxContent.Text));//对邮件内容进行编码
            //                SmtpClient client = new SmtpClient();
            //                client.Host = "smtp." + send.Substring(send.IndexOf("@") + 1);//邮箱的服务器的地址
            //                client.EnableSsl = true;//是否加密连接
            //                client.UseDefaultCredentials = false;//不和请求一起发送
            //                client.Credentials = new NetworkCredential(send, txtpwd.Text);//验证发件人的身份
            //                client.Send(mailMessage);//发送邮件
            //                MessageBox.Show("发送成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            catch
            //            {
            //                MessageBox.Show("发送失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("发件人邮箱、发件人密码、收件人邮箱不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("请输入正确的电子邮件", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
