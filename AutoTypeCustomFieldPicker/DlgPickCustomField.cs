using System.Collections.Generic;
using System.Windows.Forms;
using KeePassLib;
using KeePassLib.Security;

namespace AutoTypeCustomFieldPicker
{
    public partial class DlgPickCustomField : Form
    {
        public DlgPickCustomField()
        {
            InitializeComponent();
        }

        public MyFieldObject SelectedField;

        public void PickCustomField(string placeholder, PwEntry entry)
        {
            this.label_PlaceholderInfo.Text = string.Format(this.label_PlaceholderInfo.Text, placeholder);

            foreach (KeyValuePair<string, ProtectedString> item in entry.Strings)
                this.listBox_CustomFields.Items.Add(new MyFieldObject(item.Key, item.Value.ReadString()));

            this.ShowDialog();
        }

        private void button_OK_Click(object sender, System.EventArgs e)
        {
            if (this.listBox_CustomFields.SelectedItem != null)
                this.SelectedField = this.listBox_CustomFields.SelectedItem as MyFieldObject;

            this.Close();
        }

        private void listBox_CustomFields_DoubleClick(object sender, System.EventArgs e)
        {
            if (this.listBox_CustomFields.SelectedItem != null)
                this.SelectedField = this.listBox_CustomFields.SelectedItem as MyFieldObject;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
