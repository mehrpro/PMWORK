
namespace PMWORK.CodingForms
{
    partial class SubGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxGroup = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gvSubGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxCompany = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtSubGroupTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtGroupIndex = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyIndex = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.numSubGroup = new DevExpress.XtraEditors.SpinEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvSubGroup = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubGroupIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubGroupTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubGroupTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cbxGroup);
            this.panelControl1.Controls.Add(this.cbxCompany);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.txtSubGroupTitle);
            this.panelControl1.Controls.Add(this.txtGroupIndex);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtCompanyIndex);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.numSubGroup);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 189);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(546, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "بستن";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(627, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "ذخیره";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(708, 50);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "گروه اصلی";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(708, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "شرکت";
            // 
            // cbxGroup
            // 
            this.cbxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGroup.Location = new System.Drawing.Point(513, 47);
            this.cbxGroup.Name = "cbxGroup";
            this.cbxGroup.Parmida_ActivePlusMultiKeys = false;
            this.cbxGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGroup.Properties.PopupView = this.gvSubGroup;
            this.cbxGroup.Size = new System.Drawing.Size(189, 20);
            this.cbxGroup.TabIndex = 15;
            this.cbxGroup.EditValueChanged += new System.EventHandler(this.cbxGroup_EditValueChanged);
            // 
            // gvSubGroup
            // 
            this.gvSubGroup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvSubGroup.Name = "gvSubGroup";
            this.gvSubGroup.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSubGroup.OptionsView.ShowGroupPanel = false;
            // 
            // cbxCompany
            // 
            this.cbxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCompany.Location = new System.Drawing.Point(513, 21);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Parmida_ActivePlusMultiKeys = false;
            this.cbxCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCompany.Properties.PopupView = this.searchLookUpEdit1View;
            this.cbxCompany.Size = new System.Drawing.Size(189, 20);
            this.cbxCompany.TabIndex = 15;
            this.cbxCompany.EditValueChanged += new System.EventHandler(this.cbxCompany_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(210, 125);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Parmida_ActivePlusMultiKeys = false;
            this.txtDescription.Size = new System.Drawing.Size(492, 20);
            this.txtDescription.TabIndex = 13;
            // 
            // txtSubGroupTitle
            // 
            this.txtSubGroupTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubGroupTitle.Location = new System.Drawing.Point(513, 99);
            this.txtSubGroupTitle.Name = "txtSubGroupTitle";
            this.txtSubGroupTitle.Parmida_ActivePlusMultiKeys = false;
            this.txtSubGroupTitle.Size = new System.Drawing.Size(189, 20);
            this.txtSubGroupTitle.TabIndex = 14;
            // 
            // txtGroupIndex
            // 
            this.txtGroupIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupIndex.Location = new System.Drawing.Point(452, 47);
            this.txtGroupIndex.Name = "txtGroupIndex";
            this.txtGroupIndex.Parmida_ActivePlusMultiKeys = false;
            this.txtGroupIndex.Properties.DisplayFormat.FormatString = "00";
            this.txtGroupIndex.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtGroupIndex.Properties.ReadOnly = true;
            this.txtGroupIndex.Size = new System.Drawing.Size(55, 20);
            this.txtGroupIndex.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(708, 128);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "توضیحات";
            // 
            // txtCompanyIndex
            // 
            this.txtCompanyIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyIndex.Location = new System.Drawing.Point(452, 21);
            this.txtCompanyIndex.Name = "txtCompanyIndex";
            this.txtCompanyIndex.Parmida_ActivePlusMultiKeys = false;
            this.txtCompanyIndex.Properties.DisplayFormat.FormatString = "00";
            this.txtCompanyIndex.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtCompanyIndex.Properties.ReadOnly = true;
            this.txtCompanyIndex.Size = new System.Drawing.Size(55, 20);
            this.txtCompanyIndex.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(708, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "عنوان گروه فرعی";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(708, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "کد گروه فرعی";
            // 
            // numSubGroup
            // 
            this.numSubGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSubGroup.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numSubGroup.Location = new System.Drawing.Point(644, 73);
            this.numSubGroup.Name = "numSubGroup";
            this.numSubGroup.Parmida_ActivePlusMultiKeys = false;
            this.numSubGroup.Properties.Appearance.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numSubGroup.Properties.AppearanceDisabled.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numSubGroup.Properties.AppearanceFocused.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numSubGroup.Properties.AppearanceReadOnly.TextOptions.RightToLeftFixed = System.Windows.Forms.RightToLeft.No;
            this.numSubGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numSubGroup.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numSubGroup.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.numSubGroup.Size = new System.Drawing.Size(58, 20);
            this.numSubGroup.TabIndex = 12;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvSubGroup);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 189);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 261);
            this.panelControl2.TabIndex = 1;
            // 
            // dgvSubGroup
            // 
            this.dgvSubGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubGroup.Location = new System.Drawing.Point(2, 2);
            this.dgvSubGroup.MainView = this.gridView2;
            this.dgvSubGroup.Name = "dgvSubGroup";
            this.dgvSubGroup.Size = new System.Drawing.Size(796, 257);
            this.dgvSubGroup.TabIndex = 0;
            this.dgvSubGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridView2.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridView2.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Empty.Options.UseTextOptions = true;
            this.gridView2.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridView2.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView2.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridView2.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Preview.Options.UseTextOptions = true;
            this.gridView2.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView2.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView2.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView2.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.SubGroupIndex,
            this.SubGroupTitle,
            this.Description});
            this.gridView2.GridControl = this.dgvSubGroup;
            this.gridView2.Name = "gridView2";
            // 
            // ID
            // 
            this.ID.Caption = "شناسه";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 90;
            // 
            // SubGroupIndex
            // 
            this.SubGroupIndex.Caption = "کد گروه فرعی";
            this.SubGroupIndex.FieldName = "SubGroupIndex";
            this.SubGroupIndex.Name = "SubGroupIndex";
            this.SubGroupIndex.Visible = true;
            this.SubGroupIndex.VisibleIndex = 1;
            this.SubGroupIndex.Width = 194;
            // 
            // SubGroupTitle
            // 
            this.SubGroupTitle.Caption = "عنوان گروه فرعی";
            this.SubGroupTitle.FieldName = "SubGroupTitle";
            this.SubGroupTitle.Name = "SubGroupTitle";
            this.SubGroupTitle.Visible = true;
            this.SubGroupTitle.VisibleIndex = 2;
            this.SubGroupTitle.Width = 243;
            // 
            // Description
            // 
            this.Description.Caption = "توضیحات";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 3;
            this.Description.Width = 251;
            // 
            // SubGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "SubGroupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گروه فرعی";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubGroupTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSubGroup;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtSubGroupTitle;
        private DevExpress.XtraEditors.TextEdit txtGroupIndex;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCompanyIndex;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit numSubGroup;
        private DevExpress.XtraGrid.GridControl dgvSubGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn SubGroupIndex;
        private DevExpress.XtraGrid.Columns.GridColumn SubGroupTitle;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
    }
}