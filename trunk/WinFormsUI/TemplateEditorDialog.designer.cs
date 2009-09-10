namespace Dataweb.nShape.WinFormsUI {

	partial class TemplateEditorDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		//private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateEditorDialog));
			this.applyButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.buttonPanel = new System.Windows.Forms.Panel();
			this.okButton = new System.Windows.Forms.Button();
			this.templateController = new Dataweb.nShape.Controllers.TemplateController();
			this.templatePresenter = new Dataweb.nShape.WinFormsUI.TemplatePresenter();
			this.buttonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// applyButton
			// 
			this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.applyButton.Enabled = false;
			this.applyButton.Location = new System.Drawing.Point(551, 6);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(75, 23);
			this.applyButton.TabIndex = 2;
			this.applyButton.Text = "Apply";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.Location = new System.Drawing.Point(470, 6);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// buttonPanel
			// 
			this.buttonPanel.BackColor = System.Drawing.Color.Transparent;
			this.buttonPanel.Controls.Add(this.applyButton);
			this.buttonPanel.Controls.Add(this.cancelButton);
			this.buttonPanel.Controls.Add(this.okButton);
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new System.Drawing.Point(0, 424);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonPanel.Size = new System.Drawing.Size(638, 35);
			this.buttonPanel.TabIndex = 6;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Location = new System.Drawing.Point(389, 6);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// templateController
			// 
			this.templateController.Project = null;
			this.templateController.TemplateShapeReplaced += new System.EventHandler<Dataweb.nShape.Controllers.TemplateControllerTemplateShapeReplacedEventArgs>(this.templateController_TemplateShapeReplaced);
			this.templateController.TemplateTitleChanged += new System.EventHandler<Dataweb.nShape.Controllers.TemplateControllerStringChangedEventArgs>(this.templateController_TemplateTitleChanged);
			this.templateController.TemplateShapeControlPointMappingChanged += new System.EventHandler<Dataweb.nShape.Controllers.TemplateControllerPointMappingChangedEventArgs>(this.templateController_TemplateShapeControlPointMappingChanged);
			this.templateController.TemplateDescriptionChanged += new System.EventHandler<Dataweb.nShape.Controllers.TemplateControllerStringChangedEventArgs>(this.templateController_TemplateDescriptionChanged);
			this.templateController.TemplatePropertyChanged += new System.EventHandler(this.templateController_TemplatePropertyChanged);
			this.templateController.TemplateNameChanged += new System.EventHandler<Dataweb.nShape.Controllers.TemplateControllerStringChangedEventArgs>(this.templateController_TemplateNameChanged);
			this.templateController.TemplateShapePropertyMappingDeleted += new System.EventHandler<Dataweb.nShape.Controllers.TemplateControllerPropertyMappingChangedEventArgs>(this.templateController_TemplateShapePropertyMappingDeleted);
			this.templateController.TemplateShapePropertyMappingSet += new System.EventHandler<Dataweb.nShape.Controllers.TemplateControllerPropertyMappingChangedEventArgs>(this.templateController_TemplateShapePropertyMappingSet);
			this.templateController.TemplateModelObjectReplaced += new System.EventHandler<Dataweb.nShape.Controllers.TemplateControllerModelObjectReplacedEventArgs>(this.templateController_TemplateModelObjectReplaced);
			// 
			// templatePresenter
			// 
			this.templatePresenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.templatePresenter.Location = new System.Drawing.Point(0, 0);
			this.templatePresenter.Name = "templatePresenter";
			this.templatePresenter.Size = new System.Drawing.Size(638, 424);
			this.templatePresenter.TabIndex = 7;
			this.templatePresenter.Controller = this.templateController;
			// 
			// TemplateEditorDialog
			// 
			this.ClientSize = new System.Drawing.Size(638, 459);
			this.Controls.Add(this.templatePresenter);
			this.Controls.Add(this.buttonPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TemplateEditorDialog";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "nShape Template Editor";
			this.Shown += new System.EventHandler(this.TemplateEditorDialog_Shown);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TemplateEditorDialog_FormClosed);
			this.buttonPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Panel buttonPanel;
		private System.Windows.Forms.Button okButton;
		private Dataweb.nShape.Controllers.TemplateController templateController;
		private TemplatePresenter templatePresenter;
	}
}