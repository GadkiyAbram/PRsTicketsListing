using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRsTicketsListing.consts
{
    public static class Queries
    {
        public const string CREATE_TABLE_TICKETS = @"
                        CREATE TABLE IF NOT EXISTS tickets (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            created_at TEXT NOT NULL,
                            jira_number TEXT NULL,
                            jira_link TEXT NULL,
                            github_link TEXT NULL,
                            title TEXT NULL,
                            project_id INTEGER NULL,
                            target_branch TEXT NULL,
                            merged BOOLEAN NOT NULL DEFAULT 0,
                            dev_depl BOOLEAN NOT NULL DEFAULT 0,
                            uat_depl BOOLEAN NOT NULL DEFAULT 0,
                            client_notified BOOLEAN NOT NULL DEFAULT 0,
                            comment TEXT NULL
                        )
                    ";
        public const string CREATE_TABLE_PROJECT_NAMES = @"
                        CREATE TABLE IF NOT EXISTS projects (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL
                        )
                    ";

        public const string SELECT_TICKETS = @"SELECT 
                                tickets.id, 
                                tickets.created_at,
                                tickets.jira_number,
                                tickets.jira_link,
                                tickets.github_link,
                                tickets.title,
                                tickets.project_id,
                                projects.name AS name,
                                tickets.target_branch,
                                tickets.merged,
                                tickets.dev_depl,
                                tickets.uat_depl,
                                tickets.client_notified,
                                tickets.comment
                            FROM [tickets] LEFT JOIN [projects] ON tickets.project_id = projects.id";
        public const string SELECT_RECORD = @"SELECT * FROM [tickets] WHERE id = @recordId";
        public const string INSERT_TICKET = @"
            INSERT INTO tickets 
            (created_at, jira_number, jira_link, github_link, title, project_id, target_branch, 
             merged, dev_depl, uat_depl, client_notified, comment) 
            VALUES 
            (@created_at, @jira_number, @jira_link, @github_link, @title, @project_id, @target_branch, 
             @merged, @dev_depl, @uat_depl, @client_notified, @comment)";

        public const string UPDATE_TICKET = @"UPDATE tickets SET 
                                    created_at = @created_at, 
                                    jira_number = @jira_number,
                                    jira_link = @jira_link,
                                    github_link = @github_link,
                                    title = @title,
                                    project_id = @project_id,
                                    target_branch = @target_branch,
                                    merged = @merged,
                                    dev_depl = @dev_depl,
                                    uat_depl = @uat_depl,
                                    client_notified = @client_notified,
                                    comment = @comment WHERE id = @id";

        public const string SELECT_PROJECT_NAMES = @"SELECT * FROM [projects]";
    }
}
