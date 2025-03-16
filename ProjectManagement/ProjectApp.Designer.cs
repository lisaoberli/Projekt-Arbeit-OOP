namespace ProjectManagement
{
    partial class ProjectApp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblProjectName, lblClient, lblManager, lblRequirements;
        private System.Windows.Forms.Label lblProjects, lblInfoContent, lblInfoType, lblInfoTags, lblProjectInfos, lblSearchTag;
        private System.Windows.Forms.TextBox txtProjectName, txtClient, txtManager, txtRequirements, txtInfoContent, txtInfoTags, txtSearchTag;
        private System.Windows.Forms.Button btnCreateProject, btnDeleteProject, btnEditProject, btnSaveProject, btnAddInfo, btnSearchInfo, btnBackToOverview;
        private System.Windows.Forms.ComboBox cmbInfoType;
        private System.Windows.Forms.ListBox lstProjects, lstProjectInfos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblProjectName = new Label();
            txtProjectName = new TextBox();
            lblClient = new Label();
            txtClient = new TextBox();
            lblManager = new Label();
            txtManager = new TextBox();
            lblRequirements = new Label();
            txtRequirements = new TextBox();
            btnCreateProject = new Button();
            btnEditProject = new Button();
            btnSaveProject = new Button();
            btnDeleteProject = new Button();
            btnBackToOverview = new Button();
            lblProjects = new Label();
            lstProjects = new ListBox();
            lblInfoContent = new Label();
            txtInfoContent = new TextBox();
            lblInfoType = new Label();
            cmbInfoType = new ComboBox();
            lblInfoTags = new Label();
            txtInfoTags = new TextBox();
            btnAddInfo = new Button();
            lblProjectInfos = new Label();
            lstProjectInfos = new ListBox();
            lblSearchTag = new Label();
            txtSearchTag = new TextBox();
            btnSearchInfo = new Button();
            SuspendLayout();
            // 
            // lblProjectName
            // 
            lblProjectName.Location = new Point(20, 20);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(100, 23);
            lblProjectName.TabIndex = 0;
            lblProjectName.Text = "Projektname:";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(150, 20);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(250, 23);
            txtProjectName.TabIndex = 1;
            // 
            // lblClient
            // 
            lblClient.Location = new Point(20, 50);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(100, 23);
            lblClient.TabIndex = 2;
            lblClient.Text = "Kunde:";
            // 
            // txtClient
            // 
            txtClient.Location = new Point(150, 50);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(250, 23);
            txtClient.TabIndex = 3;
            // 
            // lblManager
            // 
            lblManager.Location = new Point(20, 80);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(100, 23);
            lblManager.TabIndex = 4;
            lblManager.Text = "Projektleiter:";
            // 
            // txtManager
            // 
            txtManager.Location = new Point(150, 80);
            txtManager.Name = "txtManager";
            txtManager.Size = new Size(250, 23);
            txtManager.TabIndex = 5;
            // 
            // lblRequirements
            // 
            lblRequirements.Location = new Point(20, 110);
            lblRequirements.Name = "lblRequirements";
            lblRequirements.Size = new Size(120, 23);
            lblRequirements.TabIndex = 6;
            lblRequirements.Text = "Kernanforderungen:";
            // 
            // txtRequirements
            // 
            txtRequirements.Location = new Point(150, 110);
            txtRequirements.Multiline = true;
            txtRequirements.Name = "txtRequirements";
            txtRequirements.Size = new Size(250, 50);
            txtRequirements.TabIndex = 7;
            // 
            // btnCreateProject
            // 
            btnCreateProject.Location = new Point(20, 180);
            btnCreateProject.Name = "btnCreateProject";
            btnCreateProject.Size = new Size(250, 30);
            btnCreateProject.TabIndex = 8;
            btnCreateProject.Text = "Projekt erstellen";
            btnCreateProject.Click += btnCreateProject_Click;
            // 
            // btnEditProject
            // 
            btnEditProject.Location = new Point(20, 220);
            btnEditProject.Name = "btnEditProject";
            btnEditProject.Size = new Size(250, 30);
            btnEditProject.TabIndex = 9;
            btnEditProject.Text = "Projekt bearbeiten";
            btnEditProject.Click += btnEditProject_Click;
            // 
            // btnSaveProject
            // 
            btnSaveProject.Location = new Point(20, 260);
            btnSaveProject.Name = "btnSaveProject";
            btnSaveProject.Size = new Size(250, 30);
            btnSaveProject.TabIndex = 10;
            btnSaveProject.Text = "Änderungen speichern";
            btnSaveProject.Click += btnSaveProject_Click;
            // 
            // btnDeleteProject
            // 
            btnDeleteProject.Location = new Point(20, 300);
            btnDeleteProject.Name = "btnDeleteProject";
            btnDeleteProject.Size = new Size(250, 30);
            btnDeleteProject.TabIndex = 11;
            btnDeleteProject.Text = "Projekt löschen";
            btnDeleteProject.Click += btnDeleteProject_Click;
            // 
            // btnBackToOverview
            // 
            btnBackToOverview.Location = new Point(20, 340);
            btnBackToOverview.Name = "btnBackToOverview";
            btnBackToOverview.Size = new Size(250, 30);
            btnBackToOverview.TabIndex = 12;
            btnBackToOverview.Text = "Zurück zur Übersicht";
            btnBackToOverview.Click += btnBackToOverview_Click;
            // 
            // lblProjects
            // 
            lblProjects.Location = new Point(450, 20);
            lblProjects.Name = "lblProjects";
            lblProjects.Size = new Size(100, 23);
            lblProjects.TabIndex = 13;
            lblProjects.Text = "Projekte:";
            // 
            // lstProjects
            // 
            lstProjects.ItemHeight = 15;
            lstProjects.Location = new Point(450, 46);
            lstProjects.Name = "lstProjects";
            lstProjects.Size = new Size(300, 169);
            lstProjects.TabIndex = 14;
            lstProjects.DoubleClick += lstProjects_DoubleClick;
            // 
            // lblInfoContent
            // 
            lblInfoContent.Location = new Point(20, 380);
            lblInfoContent.Name = "lblInfoContent";
            lblInfoContent.Size = new Size(100, 23);
            lblInfoContent.TabIndex = 15;
            lblInfoContent.Text = "Information:";
            // 
            // txtInfoContent
            // 
            txtInfoContent.Location = new Point(150, 380);
            txtInfoContent.Name = "txtInfoContent";
            txtInfoContent.Size = new Size(250, 23);
            txtInfoContent.TabIndex = 16;
            // 
            // lblInfoType
            // 
            lblInfoType.Location = new Point(20, 410);
            lblInfoType.Name = "lblInfoType";
            lblInfoType.Size = new Size(100, 23);
            lblInfoType.TabIndex = 17;
            lblInfoType.Text = "Typ:";
            // 
            // cmbInfoType
            // 
            cmbInfoType.Items.AddRange(new object[] { "Text", "Bild (URL)", "Dokument (URL)" });
            cmbInfoType.Location = new Point(150, 410);
            cmbInfoType.Name = "cmbInfoType";
            cmbInfoType.Size = new Size(250, 23);
            cmbInfoType.TabIndex = 18;
            // 
            // lblInfoTags
            // 
            lblInfoTags.Location = new Point(20, 440);
            lblInfoTags.Name = "lblInfoTags";
            lblInfoTags.Size = new Size(100, 23);
            lblInfoTags.TabIndex = 19;
            lblInfoTags.Text = "Tags:";
            // 
            // txtInfoTags
            // 
            txtInfoTags.Location = new Point(150, 440);
            txtInfoTags.Name = "txtInfoTags";
            txtInfoTags.Size = new Size(250, 23);
            txtInfoTags.TabIndex = 20;
            // 
            // btnAddInfo
            // 
            btnAddInfo.Location = new Point(20, 470);
            btnAddInfo.Name = "btnAddInfo";
            btnAddInfo.Size = new Size(250, 30);
            btnAddInfo.TabIndex = 21;
            btnAddInfo.Text = "Information hinzufügen";
            btnAddInfo.Click += btnAddInfo_Click;
            // 
            // lblProjectInfos
            // 
            lblProjectInfos.Location = new Point(450, 228);
            lblProjectInfos.Name = "lblProjectInfos";
            lblProjectInfos.Size = new Size(137, 23);
            lblProjectInfos.TabIndex = 22;
            lblProjectInfos.Text = "Projekt-Informationen:";
            // 
            // lstProjectInfos
            // 
            lstProjectInfos.ItemHeight = 15;
            lstProjectInfos.Location = new Point(450, 254);
            lstProjectInfos.Name = "lstProjectInfos";
            lstProjectInfos.Size = new Size(300, 94);
            lstProjectInfos.TabIndex = 23;
            // 
            // lblSearchTag
            // 
            lblSearchTag.Location = new Point(450, 366);
            lblSearchTag.Name = "lblSearchTag";
            lblSearchTag.Size = new Size(100, 23);
            lblSearchTag.TabIndex = 24;
            lblSearchTag.Text = "Nach Tag suchen:";
            // 
            // txtSearchTag
            // 
            txtSearchTag.Location = new Point(556, 363);
            txtSearchTag.Name = "txtSearchTag";
            txtSearchTag.Size = new Size(194, 23);
            txtSearchTag.TabIndex = 25;
            // 
            // btnSearchInfo
            // 
            btnSearchInfo.Location = new Point(450, 392);
            btnSearchInfo.Name = "btnSearchInfo";
            btnSearchInfo.Size = new Size(300, 30);
            btnSearchInfo.TabIndex = 26;
            btnSearchInfo.Text = "Nach Tag suchen";
            btnSearchInfo.Click += btnSearchByTag_Click;
            // 
            // ProjectApp
            // 
            ClientSize = new Size(767, 515);
            Controls.Add(lblProjectName);
            Controls.Add(txtProjectName);
            Controls.Add(lblClient);
            Controls.Add(txtClient);
            Controls.Add(lblManager);
            Controls.Add(txtManager);
            Controls.Add(lblRequirements);
            Controls.Add(txtRequirements);
            Controls.Add(btnCreateProject);
            Controls.Add(btnEditProject);
            Controls.Add(btnSaveProject);
            Controls.Add(btnDeleteProject);
            Controls.Add(btnBackToOverview);
            Controls.Add(lblProjects);
            Controls.Add(lstProjects);
            Controls.Add(lblInfoContent);
            Controls.Add(txtInfoContent);
            Controls.Add(lblInfoType);
            Controls.Add(cmbInfoType);
            Controls.Add(lblInfoTags);
            Controls.Add(txtInfoTags);
            Controls.Add(btnAddInfo);
            Controls.Add(lblProjectInfos);
            Controls.Add(lstProjectInfos);
            Controls.Add(lblSearchTag);
            Controls.Add(txtSearchTag);
            Controls.Add(btnSearchInfo);
            Name = "ProjectApp";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
