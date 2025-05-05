using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace PRsTicketsListing.components
{
    partial class AddTicketDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnInsertDetails = new System.Windows.Forms.Button();
            this.jiraNumberInput = new System.Windows.Forms.TextBox();
            this.jiraTicketLinkInput = new System.Windows.Forms.TextBox();
            this.githubLinkInput = new System.Windows.Forms.TextBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.projectNameInput = new System.Windows.Forms.ComboBox();
            this.targetBranchInput = new System.Windows.Forms.TextBox();
            this.commentInput = new System.Windows.Forms.TextBox();
            this.jiraTicketLabel = new System.Windows.Forms.Label();
            this.jiraTicketLink = new System.Windows.Forms.Label();
            this.githubLinkLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.targetBranchLabel = new System.Windows.Forms.Label();
            this.mergedLabel = new System.Windows.Forms.Label();
            this.devDeployedLabel = new System.Windows.Forms.Label();
            this.uatDeployedLabel = new System.Windows.Forms.Label();
            this.clientNotifiedLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.createdAtInput = new System.Windows.Forms.TextBox();
            this.createdAtLabel = new System.Windows.Forms.Label();
            this.checkBoxMerged = new System.Windows.Forms.CheckBox();
            this.checkBoxDevDeployed = new System.Windows.Forms.CheckBox();
            this.checkBoxUatDeployed = new System.Windows.Forms.CheckBox();
            this.checkBoxClientNotified = new System.Windows.Forms.CheckBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.addNewRecordTitle = new System.Windows.Forms.Label();
            this.checkBoxQueries = new System.Windows.Forms.CheckBox();
            this.queriesLabel = new System.Windows.Forms.Label();
            this.btnShowQueries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertDetails
            // 
            this.btnInsertDetails.Location = new System.Drawing.Point(424, 497);
            this.btnInsertDetails.Name = "btnInsertDetails";
            this.btnInsertDetails.Size = new System.Drawing.Size(90, 38);
            this.btnInsertDetails.TabIndex = 13;
            this.btnInsertDetails.Text = "Add";
            this.btnInsertDetails.UseVisualStyleBackColor = true;
            this.btnInsertDetails.Click += new System.EventHandler(this.btnInsertEditTicket_Click);
            // 
            // jiraNumberInput
            // 
            this.jiraNumberInput.Location = new System.Drawing.Point(137, 85);
            this.jiraNumberInput.Name = "jiraNumberInput";
            this.jiraNumberInput.Size = new System.Drawing.Size(160, 22);
            this.jiraNumberInput.TabIndex = 2;
            // 
            // jiraTicketLinkInput
            // 
            this.jiraTicketLinkInput.Location = new System.Drawing.Point(136, 112);
            this.jiraTicketLinkInput.Name = "jiraTicketLinkInput";
            this.jiraTicketLinkInput.Size = new System.Drawing.Size(373, 22);
            this.jiraTicketLinkInput.TabIndex = 3;
            // 
            // githubLinkInput
            // 
            this.githubLinkInput.Location = new System.Drawing.Point(136, 140);
            this.githubLinkInput.Name = "githubLinkInput";
            this.githubLinkInput.Size = new System.Drawing.Size(373, 22);
            this.githubLinkInput.TabIndex = 4;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(136, 168);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(373, 22);
            this.titleInput.TabIndex = 5;
            // 
            // projectNameInput
            // 
            this.projectNameInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectNameInput.Location = new System.Drawing.Point(136, 196);
            this.projectNameInput.Name = "projectNameInput";
            this.projectNameInput.Size = new System.Drawing.Size(373, 24);
            this.projectNameInput.TabIndex = 6;
            // 
            // targetBranchInput
            // 
            this.targetBranchInput.Location = new System.Drawing.Point(136, 224);
            this.targetBranchInput.Name = "targetBranchInput";
            this.targetBranchInput.Size = new System.Drawing.Size(373, 22);
            this.targetBranchInput.TabIndex = 7;
            // 
            // commentInput
            // 
            this.commentInput.Location = new System.Drawing.Point(137, 352);
            this.commentInput.Multiline = true;
            this.commentInput.Name = "commentInput";
            this.commentInput.Size = new System.Drawing.Size(373, 117);
            this.commentInput.TabIndex = 12;
            // 
            // jiraTicketLabel
            // 
            this.jiraTicketLabel.AutoSize = true;
            this.jiraTicketLabel.Location = new System.Drawing.Point(11, 88);
            this.jiraTicketLabel.Name = "jiraTicketLabel";
            this.jiraTicketLabel.Size = new System.Drawing.Size(120, 16);
            this.jiraTicketLabel.TabIndex = 12;
            this.jiraTicketLabel.Text = "Jira Ticket Number";
            // 
            // jiraTicketLink
            // 
            this.jiraTicketLink.AutoSize = true;
            this.jiraTicketLink.Location = new System.Drawing.Point(34, 115);
            this.jiraTicketLink.Name = "jiraTicketLink";
            this.jiraTicketLink.Size = new System.Drawing.Size(96, 16);
            this.jiraTicketLink.TabIndex = 13;
            this.jiraTicketLink.Text = "Jira Ticket Link";
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Location = new System.Drawing.Point(58, 143);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(72, 16);
            this.githubLinkLabel.TabIndex = 14;
            this.githubLinkLabel.Text = "Github Link";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(97, 171);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 16);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "Title";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(42, 199);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(89, 16);
            this.projectNameLabel.TabIndex = 16;
            this.projectNameLabel.Text = "Project Name";
            // 
            // targetBranchLabel
            // 
            this.targetBranchLabel.AutoSize = true;
            this.targetBranchLabel.Location = new System.Drawing.Point(38, 227);
            this.targetBranchLabel.Name = "targetBranchLabel";
            this.targetBranchLabel.Size = new System.Drawing.Size(92, 16);
            this.targetBranchLabel.TabIndex = 17;
            this.targetBranchLabel.Text = "Target Branch";
            // 
            // mergedLabel
            // 
            this.mergedLabel.AutoSize = true;
            this.mergedLabel.Location = new System.Drawing.Point(76, 251);
            this.mergedLabel.Name = "mergedLabel";
            this.mergedLabel.Size = new System.Drawing.Size(54, 16);
            this.mergedLabel.TabIndex = 18;
            this.mergedLabel.Text = "Merged";
            // 
            // devDeployedLabel
            // 
            this.devDeployedLabel.AutoSize = true;
            this.devDeployedLabel.Location = new System.Drawing.Point(187, 254);
            this.devDeployedLabel.Name = "devDeployedLabel";
            this.devDeployedLabel.Size = new System.Drawing.Size(98, 16);
            this.devDeployedLabel.TabIndex = 19;
            this.devDeployedLabel.Text = "DEV Deployed";
            // 
            // uatDeployedLabel
            // 
            this.uatDeployedLabel.AutoSize = true;
            this.uatDeployedLabel.Location = new System.Drawing.Point(348, 253);
            this.uatDeployedLabel.Name = "uatDeployedLabel";
            this.uatDeployedLabel.Size = new System.Drawing.Size(98, 16);
            this.uatDeployedLabel.TabIndex = 20;
            this.uatDeployedLabel.Text = "UAT Deployed";
            // 
            // clientNotifiedLabel
            // 
            this.clientNotifiedLabel.AutoSize = true;
            this.clientNotifiedLabel.Location = new System.Drawing.Point(42, 284);
            this.clientNotifiedLabel.Name = "clientNotifiedLabel";
            this.clientNotifiedLabel.Size = new System.Drawing.Size(89, 16);
            this.clientNotifiedLabel.TabIndex = 21;
            this.clientNotifiedLabel.Text = "Client Notified";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(64, 355);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(64, 16);
            this.commentLabel.TabIndex = 22;
            this.commentLabel.Text = "Comment";
            // 
            // createdAtInput
            // 
            this.createdAtInput.Location = new System.Drawing.Point(137, 57);
            this.createdAtInput.Name = "createdAtInput";
            this.createdAtInput.Size = new System.Drawing.Size(100, 22);
            this.createdAtInput.TabIndex = 31;
            // 
            // createdAtLabel
            // 
            this.createdAtLabel.AutoSize = true;
            this.createdAtLabel.Location = new System.Drawing.Point(58, 60);
            this.createdAtLabel.Name = "createdAtLabel";
            this.createdAtLabel.Size = new System.Drawing.Size(70, 16);
            this.createdAtLabel.TabIndex = 24;
            this.createdAtLabel.Text = "Created At";
            // 
            // checkBoxMerged
            // 
            this.checkBoxMerged.AutoSize = true;
            this.checkBoxMerged.Location = new System.Drawing.Point(137, 255);
            this.checkBoxMerged.Name = "checkBoxMerged";
            this.checkBoxMerged.Size = new System.Drawing.Size(18, 17);
            this.checkBoxMerged.TabIndex = 8;
            this.checkBoxMerged.UseVisualStyleBackColor = true;
            // 
            // checkBoxDevDeployed
            // 
            this.checkBoxDevDeployed.AutoSize = true;
            this.checkBoxDevDeployed.Location = new System.Drawing.Point(291, 255);
            this.checkBoxDevDeployed.Name = "checkBoxDevDeployed";
            this.checkBoxDevDeployed.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDevDeployed.TabIndex = 9;
            this.checkBoxDevDeployed.UseVisualStyleBackColor = true;
            // 
            // checkBoxUatDeployed
            // 
            this.checkBoxUatDeployed.AutoSize = true;
            this.checkBoxUatDeployed.Location = new System.Drawing.Point(452, 254);
            this.checkBoxUatDeployed.Name = "checkBoxUatDeployed";
            this.checkBoxUatDeployed.Size = new System.Drawing.Size(18, 17);
            this.checkBoxUatDeployed.TabIndex = 10;
            this.checkBoxUatDeployed.UseVisualStyleBackColor = true;
            // 
            // checkBoxClientNotified
            // 
            this.checkBoxClientNotified.AutoSize = true;
            this.checkBoxClientNotified.Location = new System.Drawing.Point(137, 284);
            this.checkBoxClientNotified.Name = "checkBoxClientNotified";
            this.checkBoxClientNotified.Size = new System.Drawing.Size(18, 17);
            this.checkBoxClientNotified.TabIndex = 11;
            this.checkBoxClientNotified.UseVisualStyleBackColor = true;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(14, 497);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(90, 38);
            this.btnCancelAdd.TabIndex = 14;
            this.btnCancelAdd.Text = "Close";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // addNewRecordTitle
            // 
            this.addNewRecordTitle.AutoSize = true;
            this.addNewRecordTitle.Location = new System.Drawing.Point(11, 9);
            this.addNewRecordTitle.Name = "addNewRecordTitle";
            this.addNewRecordTitle.Size = new System.Drawing.Size(59, 16);
            this.addNewRecordTitle.TabIndex = 30;
            this.addNewRecordTitle.Text = "Adding...";
            // 
            // checkBoxQueries
            // 
            this.checkBoxQueries.AutoSize = true;
            this.checkBoxQueries.Location = new System.Drawing.Point(137, 315);
            this.checkBoxQueries.Name = "checkBoxQueries";
            this.checkBoxQueries.Size = new System.Drawing.Size(18, 17);
            this.checkBoxQueries.TabIndex = 32;
            this.checkBoxQueries.UseVisualStyleBackColor = true;
            // 
            // queriesLabel
            // 
            this.queriesLabel.AutoSize = true;
            this.queriesLabel.Location = new System.Drawing.Point(48, 314);
            this.queriesLabel.Name = "queriesLabel";
            this.queriesLabel.Size = new System.Drawing.Size(83, 16);
            this.queriesLabel.TabIndex = 33;
            this.queriesLabel.Text = "DB Queries?";
            // 
            // btnShowQueries
            // 
            this.btnShowQueries.Location = new System.Drawing.Point(414, 9);
            this.btnShowQueries.Name = "btnShowQueries";
            this.btnShowQueries.Size = new System.Drawing.Size(100, 34);
            this.btnShowQueries.TabIndex = 34;
            this.btnShowQueries.Text = "Add Queries";
            this.btnShowQueries.UseVisualStyleBackColor = true;
            // 
            // AddTicketDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 547);
            this.Controls.Add(this.btnShowQueries);
            this.Controls.Add(this.queriesLabel);
            this.Controls.Add(this.checkBoxQueries);
            this.Controls.Add(this.addNewRecordTitle);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.checkBoxClientNotified);
            this.Controls.Add(this.checkBoxUatDeployed);
            this.Controls.Add(this.checkBoxDevDeployed);
            this.Controls.Add(this.checkBoxMerged);
            this.Controls.Add(this.createdAtInput);
            this.Controls.Add(this.createdAtLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.clientNotifiedLabel);
            this.Controls.Add(this.uatDeployedLabel);
            this.Controls.Add(this.devDeployedLabel);
            this.Controls.Add(this.mergedLabel);
            this.Controls.Add(this.targetBranchLabel);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.jiraTicketLink);
            this.Controls.Add(this.jiraTicketLabel);
            this.Controls.Add(this.commentInput);
            this.Controls.Add(this.targetBranchInput);
            this.Controls.Add(this.projectNameInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.githubLinkInput);
            this.Controls.Add(this.jiraTicketLinkInput);
            this.Controls.Add(this.jiraNumberInput);
            this.Controls.Add(this.btnInsertDetails);
            this.Name = "AddTicketDetailsForm";
            this.Text = "New Ticket Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BackgroundWorker backgroundWorker1;
        private Button btnInsertDetails;
        private TextBox jiraNumberInput;
        private TextBox jiraTicketLinkInput;
        private TextBox githubLinkInput;
        private TextBox titleInput;
        private ComboBox projectNameInput;
        private TextBox targetBranchInput;
        private TextBox commentInput;
        private Label jiraTicketLabel;
        private Label jiraTicketLink;
        private Label githubLinkLabel;
        private Label titleLabel;
        private Label projectNameLabel;
        private Label targetBranchLabel;
        private Label mergedLabel;
        private Label devDeployedLabel;
        private Label uatDeployedLabel;
        private Label clientNotifiedLabel;
        private Label commentLabel;
        private TextBox createdAtInput;
        private Label createdAtLabel;
        private CheckBox checkBoxMerged;
        private CheckBox checkBoxDevDeployed;
        private CheckBox checkBoxUatDeployed;
        private CheckBox checkBoxClientNotified;
        private Button btnCancelAdd;
        private Label addNewRecordTitle;
        private CheckBox checkBoxQueries;
        private Label queriesLabel;
        private Button btnShowQueries;
    }
}