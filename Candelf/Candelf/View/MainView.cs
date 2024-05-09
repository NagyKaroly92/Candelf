using Candelf.UserControls.View;

namespace Candelf
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainListView.SelectedItems.Count > 0)
            {
                switch (MainListView.SelectedItems[0].Index)
                {
                    case 0:
                        groupBox1.Text = MainListView.SelectedItems[0].Text;
                        groupBox1.Controls.Clear();
                        break;
                    case 1:
                        SetNewControl(new AlapadatokUserControl());
                        break;
                    default:
                        break;
                }
            }
        }

        private void SetNewControl(Control newControl)
        {
            groupBox1.Text = MainListView.SelectedItems[0].Text;
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(new AlapadatokUserControl());
            groupBox1.Controls[0].Size = groupBox1.Size;
            groupBox1.Controls[0].Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
    }
}
