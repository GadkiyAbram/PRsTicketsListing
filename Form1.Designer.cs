using System.Windows.Forms;
using System.Drawing;

namespace PRsTicketsListing
{
    partial class Form1
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
            this.ticketsDataTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetTicketsData = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiraTicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiraTicketLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.githubLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devDeployed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uatDeployed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNotified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsDataTable
            // 
            this.ticketsDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.createdAt,
            this.jiraTicketLink,
            this.jiraTicketNumber,
            this.githubLink,
            this.title,
            this.projectName,
            this.targetBranch,
            this.merged,
            this.devDeployed,
            this.uatDeployed,
            this.clientNotified,
            this.comment
            });
            this.ticketsDataTable.Location = new System.Drawing.Point(12, 64);
            this.ticketsDataTable.Name = "ticketsDataTable";
            this.ticketsDataTable.RowHeadersWidth = 51;
            this.ticketsDataTable.RowTemplate.Height = 24;
            this.ticketsDataTable.Size = new System.Drawing.Size(1428, 684);
            this.ticketsDataTable.TabIndex = 0;
            this.ticketsDataTable.CellDoubleClick += showRecord_DoubleClick;
            this.ticketsDataTable.AutoGenerateColumns = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Ticket Data";
            this.button1.Click += new System.EventHandler(this.showAddNewRecord_Click);
            // 
            // btnGetTicketsData
            // 
            this.btnGetTicketsData.Location = new System.Drawing.Point(168, 27);
            this.btnGetTicketsData.Name = "btnGetTicketsData";
            this.btnGetTicketsData.Size = new System.Drawing.Size(147, 31);
            this.btnGetTicketsData.TabIndex = 1;
            this.btnGetTicketsData.Text = "Get Tickets Data";
            this.btnGetTicketsData.UseVisualStyleBackColor = true;
            this.btnGetTicketsData.Click += new System.EventHandler(this.btnGetTicketsData_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "Created";
            this.createdAt.MinimumWidth = 6;
            this.createdAt.Name = "createdAt";
            this.createdAt.Width = 125;
            // 
            // jiraTicketNumber
            // 
            this.jiraTicketNumber.HeaderText = "Jira Ticket Number";
            this.jiraTicketNumber.MinimumWidth = 6;
            this.jiraTicketNumber.Name = "jiraTicketNumber";
            this.jiraTicketNumber.Width = 125;
            // 
            // jiraTicketLink
            // 
            this.jiraTicketLink.HeaderText = "Jira Ticket Link";
            this.jiraTicketLink.MinimumWidth = 6;
            this.jiraTicketLink.Name = "jiraTicketLink";
            this.jiraTicketLink.Width = 125;
            // 
            // githubLink
            // 
            this.githubLink.HeaderText = "Github Link";
            this.githubLink.MinimumWidth = 6;
            this.githubLink.Name = "githubLink";
            this.githubLink.Width = 125;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.Width = 125;
            // 
            // projectName
            // 
            this.projectName.HeaderText = "Project Name";
            this.projectName.MinimumWidth = 6;
            this.projectName.Name = "projectName";
            this.projectName.Width = 125;
            // 
            // targetBranch
            // 
            this.targetBranch.HeaderText = "Target Branch";
            this.targetBranch.MinimumWidth = 6;
            this.targetBranch.Name = "targetBranch";
            this.targetBranch.Width = 125;
            // 
            // merged
            // 
            this.merged.HeaderText = "Merged";
            this.merged.MinimumWidth = 6;
            this.merged.Name = "merged";
            this.merged.Width = 125;
            // 
            // devDeployed
            // 
            this.devDeployed.HeaderText = "DEV Deployed";
            this.devDeployed.MinimumWidth = 6;
            this.devDeployed.Name = "devDeployed";
            this.devDeployed.Width = 125;
            // 
            // uatDeployed
            // 
            this.uatDeployed.HeaderText = "UAT Deployed";
            this.uatDeployed.MinimumWidth = 6;
            this.uatDeployed.Name = "uatDeployed";
            this.uatDeployed.Width = 125;
            // 
            // clientNotified
            // 
            this.clientNotified.HeaderText = "Client Notified";
            this.clientNotified.MinimumWidth = 6;
            this.clientNotified.Name = "clientNotified";
            this.clientNotified.Width = 125;
            // 
            // comment
            // 
            this.comment.HeaderText = "Comment";
            this.comment.MinimumWidth = 6;
            this.comment.Name = "comment";
            this.comment.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 760);
            this.Controls.Add(this.btnGetTicketsData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ticketsDataTable);
            this.Name = "Form1";
            this.Text = "MarkerTrax Tickets Listing";
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        private void TicketsDataTable_DoubleClick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private DataGridView ticketsDataTable;
        private Button button1;
        private Button btnGetTicketsData;
        private DataGridViewTextBoxColumn jiraTicketNumber;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn createdAt;
        private DataGridViewTextBoxColumn jiraTicketLink;
        private DataGridViewTextBoxColumn githubLink;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn projectName;
        private DataGridViewTextBoxColumn targetBranch;
        private DataGridViewTextBoxColumn merged;
        private DataGridViewTextBoxColumn devDeployed;
        private DataGridViewTextBoxColumn uatDeployed;
        private DataGridViewTextBoxColumn clientNotified;
        private DataGridViewTextBoxColumn comment;
    }
}

