using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjectManagement
{
    public partial class ProjectApp : Form
    {
        private List<Project> projects = new List<Project>();
        private Project selectedProject;
        private const string FilePath = "projects.json";

        public ProjectApp()
        {
            InitializeComponent();
            LoadProjects();
        }

        private void LoadProjects()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                projects = JsonConvert.DeserializeObject<List<Project>>(json) ?? new List<Project>();
            }
            UpdateProjectList();
        }

        private void SaveProjects()
        {
            string json = JsonConvert.SerializeObject(projects, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        private void UpdateProjectList()
        {
            lstProjects.Items.Clear();
            foreach (var project in projects)
            {
                lstProjects.Items.Add(project.Name);
            }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            string name = txtProjectName.Text.Trim();
            string client = txtClient.Text.Trim();
            string manager = txtManager.Text.Trim();
            string requirements = txtRequirements.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(client) || string.IsNullOrEmpty(manager))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
                return;
            }

            projects.Add(new Project(name, client, manager, requirements));
            SaveProjects();
            UpdateProjectList();
            MessageBox.Show("Projekt erfolgreich erstellt!");
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (lstProjects.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Projekt aus.");
                return;
            }

            string projectName = lstProjects.SelectedItem.ToString();
            var projectToRemove = projects.FirstOrDefault(p => p.Name == projectName);

            if (projectToRemove != null)
            {
                DialogResult result = MessageBox.Show(
                    $"Sind Sie sicher, dass Sie das Projekt \"{projectToRemove.Name}\" löschen möchten?",
                    "Projekt löschen",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    projects.Remove(projectToRemove);
                    SaveProjects();
                    UpdateProjectList();
                    MessageBox.Show("Projekt erfolgreich gelöscht.");
                }
            }
            else
            {
                MessageBox.Show("Projekt nicht gefunden!");
            }
        }

        private void lstProjects_DoubleClick(object sender, EventArgs e)
        {
            if (lstProjects.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Projekt aus.");
                return;
            }

            string projectName = lstProjects.SelectedItem.ToString();
            selectedProject = projects.FirstOrDefault(p => p.Name == projectName);

            if (selectedProject != null)
            {
                txtProjectName.Text = selectedProject.Name;
                txtClient.Text = selectedProject.Client;
                txtManager.Text = selectedProject.Manager;
                txtRequirements.Text = selectedProject.Requirements;
                UpdateProjectInfoList();
            }
        }
        private void btnSearchInfo_Click(object sender, EventArgs e)
        {
            string searchTag = txtSearchTag.Text.Trim();

            if (string.IsNullOrEmpty(searchTag))
            {
                MessageBox.Show("Bitte geben Sie ein Tag ein.");
                return;
            }

            var matchingProjects = projects
                .Where(p => p.Informations.Any(info => info.Tags.Contains(searchTag)))
                .ToList();

            lstProjects.Items.Clear();

            if (matchingProjects.Any())
            {
                foreach (var project in matchingProjects)
                {
                    lstProjects.Items.Add(project.Name);
                }
            }
            else
            {
                MessageBox.Show("Kein Projekt mit diesem Tag gefunden.");
                UpdateProjectList();  // Falls keine Übereinstimmung gefunden wurde, zeige alle Projekte
            }
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            if (lstProjects.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Projekt aus.");
                return;
            }

            string projectName = lstProjects.SelectedItem.ToString();
            selectedProject = projects.FirstOrDefault(p => p.Name == projectName);

            if (selectedProject != null)
            {
                txtProjectName.Text = selectedProject.Name;
                txtClient.Text = selectedProject.Client;
                txtManager.Text = selectedProject.Manager;
                txtRequirements.Text = selectedProject.Requirements;
            }
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            if (selectedProject == null)
            {
                MessageBox.Show("Kein Projekt zur Bearbeitung ausgewählt.");
                return;
            }

            selectedProject.Name = txtProjectName.Text.Trim();
            selectedProject.Client = txtClient.Text.Trim();
            selectedProject.Manager = txtManager.Text.Trim();
            selectedProject.Requirements = txtRequirements.Text.Trim();

            SaveProjects();
            UpdateProjectList();
            MessageBox.Show("Projekt erfolgreich gespeichert!");
        }

        private void btnBackToOverview_Click(object sender, EventArgs e)
        {
            // Alle Eingabefelder leeren
            txtProjectName.Clear();
            txtClient.Clear();
            txtManager.Clear();
            txtRequirements.Clear();
            txtInfoContent.Clear();
            txtInfoTags.Clear();
            txtSearchTag.Clear(); // Tag-Suche zurücksetzen
            lstProjectInfos.Items.Clear();
            selectedProject = null;

            // Alle Projekte wieder anzeigen
            UpdateProjectList();
        }
        private void btnSearchByTag_Click(object sender, EventArgs e)
        {
            string searchTag = txtSearchTag.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTag))
            {
                MessageBox.Show("Bitte geben Sie ein Tag ein.");
                return;
            }

            // Suche Projekte mit dem angegebenen Tag
            var matchingProjects = projects
                .Where(p => p.Informations.Any(info => info.Tags.Any(tag => tag.ToLower() == searchTag)))
                .ToList();

            lstProjects.Items.Clear();

            if (matchingProjects.Any())
            {
                foreach (var project in matchingProjects)
                {
                    lstProjects.Items.Add(project.Name);
                }
            }
            else
            {
                MessageBox.Show("Kein Projekt mit diesem Tag gefunden.");
                UpdateProjectList(); // Falls keine Übereinstimmung gefunden wurde, zeige alle Projekte
            }
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            if (selectedProject == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Projekt aus.");
                return;
            }

            string content = txtInfoContent.Text.Trim();
            string type = cmbInfoType.SelectedItem?.ToString();
            string tagsInput = txtInfoTags.Text.Trim();

            if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Bitte geben Sie eine Information und einen Typ ein.");
                return;
            }

            List<string> tags = tagsInput.Split(',')
                .Select(t => t.Trim())
                .Where(t => !string.IsNullOrEmpty(t))
                .Distinct()
                .ToList();

            if (tags.Count > 3)
            {
                MessageBox.Show("Maximal 3 Tags erlaubt.");
                return;
            }

            selectedProject.AddInformation(new ProjectInfo(content, type, tags));
            SaveProjects();
            UpdateProjectInfoList();
            MessageBox.Show("Information hinzugefügt!");
        }

        private void UpdateProjectInfoList()
        {
            lstProjectInfos.Items.Clear();
            if (selectedProject != null)
            {
                foreach (var info in selectedProject.Informations)
                {
                    lstProjectInfos.Items.Add($"{info.Type}: {info.Content} (Tags: {string.Join(", ", info.Tags)})");
                }
            }
        }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Client { get; set; }
        public string Manager { get; set; }
        public string Requirements { get; set; }
        public List<ProjectInfo> Informations { get; set; }

        public Project(string name, string client, string manager, string requirements)
        {
            Name = name;
            Client = client;
            Manager = manager;
            Requirements = requirements;
            Informations = new List<ProjectInfo>();
        }

        public void AddInformation(ProjectInfo info)
        {
            Informations.Add(info);
        }
    }

    public class ProjectInfo
    {
        public string Content { get; set; }
        public string Type { get; set; }
        public List<string> Tags { get; set; }

        public ProjectInfo(string content, string type, List<string> tags)
        {
            Content = content;
            Type = type;
            Tags = tags ?? new List<string>();
        }
    }
}
