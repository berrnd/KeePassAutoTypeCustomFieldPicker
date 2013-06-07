using System.Windows.Forms;
using KeePass.Plugins;
using KeePass.Util;

namespace AutoTypeCustomFieldPicker
{
    public sealed class AutoTypeCustomFieldPickerExt : Plugin
    {
        private const string PLACEHOLDER = "{PICKCUSTOMFIELD}";
        private const string UPDATEURL = "https://raw.github.com/berrnd/KeePassAutoTypeCustomFieldPicker/master/AutoTypeCustomFieldPicker/UpdateInfo.txt";

        private IPluginHost PluginHost = null;
        private string CurrentPlaceholderResolved = string.Empty;

        public override bool Initialize(IPluginHost host)
        {
            this.PluginHost = host;
            if (this.PluginHost == null)
                return false;

            AutoType.FilterSendPre += this.AutoType_FilterSendPre;
            AutoType.SequenceQuery += this.AutoType_SequenceQuery;

            return true;
        }

        public override void Terminate()
        {
            AutoType.FilterSendPre -= this.AutoType_FilterSendPre;
            AutoType.SequenceQuery -= this.AutoType_SequenceQuery;
        }

        public override string UpdateUrl
        {
            get { return UPDATEURL; }
        }

        private void AutoType_FilterSendPre(object sender, AutoTypeEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.CurrentPlaceholderResolved) && e.Entry.GetAutoTypeSequence().Contains(this.CurrentPlaceholderResolved))
                e.Entry.AutoType.DefaultSequence = e.Entry.AutoType.DefaultSequence.Replace(this.CurrentPlaceholderResolved, PLACEHOLDER);
        }

        private void AutoType_SequenceQuery(object sender, SequenceQueryEventArgs e)
        {
            if (e.Entry.GetAutoTypeSequence().Contains(PLACEHOLDER))
            {
                DlgPickCustomField picker = new DlgPickCustomField();
                picker.PickCustomField(PLACEHOLDER, e.Entry);

                if (picker.DialogResult == DialogResult.OK && picker.SelectedField != null)
                {
                    this.CurrentPlaceholderResolved = picker.SelectedField.Value;
                    e.Entry.AutoType.DefaultSequence = e.Entry.AutoType.DefaultSequence.Replace(PLACEHOLDER, picker.SelectedField.Value);
                }
            }
        }
    }
}
