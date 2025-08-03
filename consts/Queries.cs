using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRsTicketsListing.consts
{
    public static class Queries
    {
        /**
         * Main table Tickets, to keep all the info about tickets
         */
        private const string CREATE_TABLE_TICKETS = @"
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
                            queries BOOLEAN NOT NULL DEFAULT 0,
                            comment TEXT NULL
                        )
                    ";

        /**
         * Table for keeping the project names
         */
        private const string CREATE_TABLE_PROJECT_NAMES = @"
                        CREATE TABLE IF NOT EXISTS projects (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            CONSTRAINT unique_project_name UNIQUE(name)
                        )
                    ";

        private const string INSERT_PROJECT_NAMES = @"
                        INSERT OR IGNORE INTO [projects] (name) 
                        VALUES ('Frontend'), 
                            ('Api'), 
                            ('MiddleLayer'), 
                            ('NG Frontend')
                    ";

        /**
         * Table for keeping Queries if ticket requires
         */
        private const string CREATE_TABLE_TICKET_QUERIES = @"
                        CREATE TABLE IF NOT EXISTS queries (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            ticket_number TEXT NOT NULL,
                            description TEXT NOT NULL,
                            query TEXT NOT NULL
                        )
                    ";

        private const string ADD_QUERIES_COLUMN_TABLE_TICKETS = @"ALTER TABLE tickets ADD COLUMN queries BOOLEAN DEFAULT 0;";

        private const string CREATE_TABLE_SETTINGS = @"
                        CREATE TABLE IF NOT EXISTS settings (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            tag TEXT NOT NULL,
                            value TEXT NOT NULL
                        )
                    ";

        public static readonly string[] TABLE_CREATE_QUERIES = new string[]{ 
            CREATE_TABLE_TICKETS,
            CREATE_TABLE_PROJECT_NAMES,
            CREATE_TABLE_TICKET_QUERIES,
            CREATE_TABLE_SETTINGS,
            INSERT_PROJECT_NAMES
        };

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
                                tickets.queries,
                                tickets.comment
                            FROM [tickets] LEFT JOIN [projects] ON tickets.project_id = projects.id
                            ORDER BY tickets.created_at";
        public const string SELECT_RECORD = @"SELECT * FROM [tickets] WHERE id = @recordId";
        public const string INSERT_TICKET = @"
            INSERT INTO tickets 
            (created_at, jira_number, jira_link, github_link, title, project_id, target_branch, 
             merged, dev_depl, uat_depl, client_notified, queries, comment) 
            VALUES 
            (@created_at, @jira_number, @jira_link, @github_link, @title, @project_id, @target_branch, 
             @merged, @dev_depl, @uat_depl, @client_notified, @queries, @comment)";

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
                                    queries = @queries,
                                    comment = @comment WHERE id = @id";

        public const string SELECT_PROJECT_NAMES = @"SELECT * FROM [projects]";

        public const string SELECT_TICKET_QUERIES = @"
                                SELECT 
                                    queries.id, 
                                    queries.ticket_number,
                                    queries.description, 
                                    queries.query 
                                FROM [queries] WHERE ticket_number = @ticketNumber";

        public const string INSERT_TICKET_QUERY = @"
                                INSERT INTO queries
                                    (ticket_number, description, query)
                                VALUES (@ticket_number, @description, @query)";
    }
}
