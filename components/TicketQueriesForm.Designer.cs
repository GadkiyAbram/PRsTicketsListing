namespace PRsTicketsListing.components
{
    partial class TicketQueriesForm
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
            this.ticketQueriesTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.query = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketQueriesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.ticketQueriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketQueriesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Description,
            this.query});
            this.ticketQueriesTable.Location = new System.Drawing.Point(12, 56);
            this.ticketQueriesTable.Name = "ticketQueriesTable";
            this.ticketQueriesTable.RowHeadersWidth = 51;
            this.ticketQueriesTable.RowTemplate.Height = 24;
            this.ticketQueriesTable.Size = new System.Drawing.Size(1143, 642);
            this.ticketQueriesTable.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "description";
            this.Description.Width = 125;
            // 
            // query
            // 
            this.query.HeaderText = "Query";
            this.query.MinimumWidth = 6;
            this.query.Name = "query";
            this.query.Width = 125;
            // 
            // btnAddQuery
            // 
            this.btnAddQuery.Location = new System.Drawing.Point(12, 12);
            this.btnAddQuery.Name = "btnAddQuery";
            this.btnAddQuery.Size = new System.Drawing.Size(113, 38);
            this.btnAddQuery.TabIndex = 1;
            this.btnAddQuery.Text = "Add";
            this.btnAddQuery.UseVisualStyleBackColor = true;
            this.btnAddQuery.Click += new System.EventHandler(this.btnAddQuery_Click);
            // 
            // TicketQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 710);
            this.Controls.Add(this.btnAddQuery);
            this.Controls.Add(this.ticketQueriesTable);
            this.Name = "TicketQueriesForm";
            this.Text = "Ticket Queries";
            ((System.ComponentModel.ISupportInitialize)(this.ticketQueriesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ticketQueriesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn query;
        private System.Windows.Forms.Button btnAddQuery;
    }
}