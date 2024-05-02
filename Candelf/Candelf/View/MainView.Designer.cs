namespace Candelf
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Gomb 1" }, -1, Color.Empty, SystemColors.Window, new Font("Segoe UI", 21F));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Gomb 2" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 21F));
            MainListView = new ListView();
            SuspendLayout();
            // 
            // MainListView
            // 
            MainListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MainListView.Font = new Font("Segoe UI", 21F);
            listViewItem1.Tag = "Gomb 1";
            MainListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            MainListView.Location = new Point(12, 12);
            MainListView.MultiSelect = false;
            MainListView.Name = "MainListView";
            MainListView.Size = new Size(134, 419);
            MainListView.TabIndex = 0;
            MainListView.UseCompatibleStateImageBehavior = false;
            MainListView.View = View.List;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainListView);
            Name = "MainView";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView MainListView;
    }
}
