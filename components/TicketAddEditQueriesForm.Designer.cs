using System.Drawing;

namespace PRsTicketsListing.components
{
    partial class TicketAddEditQueriesForm
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
            this.queryContent = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.labelQueryContent = new System.Windows.Forms.Label();
            this.labelQueryDescription = new System.Windows.Forms.Label();
            this.buttonAddQuery = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryContent
            // 
            this.queryContent.Location = new System.Drawing.Point(115, 12);
            this.queryContent.Multiline = true;
            this.queryContent.Name = "queryContent";
            this.queryContent.Size = new System.Drawing.Size(656, 93);
            this.queryContent.TabIndex = 0;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(116, 111);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(656, 111);
            this.description.TabIndex = 1;
            // 
            // labelQueryContent
            // 
            this.labelQueryContent.AutoSize = true;
            this.labelQueryContent.Location = new System.Drawing.Point(67, 15);
            this.labelQueryContent.Name = "labelQueryContent";
            this.labelQueryContent.Size = new System.Drawing.Size(43, 16);
            this.labelQueryContent.TabIndex = 2;
            this.labelQueryContent.Text = "Query";
            // 
            // labelQueryDescription
            // 
            this.labelQueryDescription.AutoSize = true;
            this.labelQueryDescription.Location = new System.Drawing.Point(35, 114);
            this.labelQueryDescription.Name = "labelQueryDescription";
            this.labelQueryDescription.Size = new System.Drawing.Size(75, 16);
            this.labelQueryDescription.TabIndex = 3;
            this.labelQueryDescription.Text = "Description";
            // 
            // buttonAddQuery
            // 
            this.buttonAddQuery.Location = new System.Drawing.Point(665, 228);
            this.buttonAddQuery.Name = "buttonAddQuery";
            this.buttonAddQuery.Size = new System.Drawing.Size(106, 41);
            this.buttonAddQuery.TabIndex = 4;
            this.buttonAddQuery.Text = "Add";
            this.buttonAddQuery.UseVisualStyleBackColor = true;
            this.buttonAddQuery.Click += new System.EventHandler(this.buttonAddQuery_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(553, 228);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 41);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TicketAddEditQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 275);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddQuery);
            this.Controls.Add(this.labelQueryDescription);
            this.Controls.Add(this.labelQueryContent);
            this.Controls.Add(this.description);
            this.Controls.Add(this.queryContent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketAddEditQueriesForm";
            this.Text = "Add New Query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queryContent;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label labelQueryContent;
        private System.Windows.Forms.Label labelQueryDescription;
        private System.Windows.Forms.Button buttonAddQuery;
        private System.Windows.Forms.Button buttonCancel;
    }
}