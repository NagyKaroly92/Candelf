using Candelf.UserControls.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candelf.UserControls.View
{
    public partial class AlapadatokUserControl : UserControl
    {
        private readonly AlapadatokViewModel viewModel;

        public AlapadatokUserControl()
        {
            InitializeComponent();
            viewModel = new AlapadatokViewModel();
            DataContext = viewModel;
            //this.BTNAlapanyagAdd.Click += (sender, e) => viewModel.AddAlapanyag();
            this.BTNAlapanyagAdd.Click += (sender, e) => viewModel.AddItemCommand.Execute(null);
            this.TBAlapanyag.DataBindings.Add("Text", viewModel, "TBAlapanyagText");
            var binding = this.DGAlapanyag.DataBindings.Add("DataSource", viewModel, nameof(viewModel.AlapanyagList), true, DataSourceUpdateMode.OnPropertyChanged);
            binding.FormatString = "C2";
            binding.FormattingEnabled = true;
            //new List<DTO> { new DTO() { Aaaa = 0, Bbbb = "test1" }, new DTO() { Aaaa = 2, Bbbb = "test2" } };
            DGMeret.DataSource = viewModel.AlapanyagList;
            DGAlapanyag.DataSource = viewModel.AlapanyagList.Count;
            //DGMeret.DataBindings.Add("DataContext", viewModel, "AlapanyagList", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void AlapadatokUserControl_SizeChanged(object sender, EventArgs e)
        {
            DGAlapanyag.Refresh();
            this.GBAlapanyag.Location = new Point(10, 20);
            this.GBAlapanyag.Width = (this.Width / 3) - 10;
            this.GBIllat.Location = new Point(GBAlapanyag.Width + 20, 20);
            this.GBIllat.Width = (this.Width / 3) - 10;
            this.GBMeret.Location = new Point(GBIllat.Width + GBIllat.Location.X + 10, 20);
            this.GBMeret.Width = (this.Width / 3) - 20;
            this.GBAlapanyag.Height = this.GBIllat.Height = this.GBMeret.Height;
            DGAlapanyag.Size = DGIllat.Size = new Size(DGMeret.Size.Width +8, DGMeret.Size.Height);
        }
    }
}
