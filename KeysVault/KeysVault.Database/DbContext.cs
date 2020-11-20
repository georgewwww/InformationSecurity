using KeysVault.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace KeysVault.Database
{
    /// <summary>
    /// This class gives direct access to Functions with SQL Queries to Database.
    /// </summary>
    public class DbContext
    {
        private static DbContext _instance;
        private string ConnectionString;

        protected DbContext()
        {
            ConnectionString = Globals.DatabaseConnection.Instance().GetValue();
        }

        public static DbContext Instance()
        {
            if (_instance == null)
            {
                _instance = new DbContext();
            }

            return _instance;
        }

        /// <summary>
        /// Add New Password to Database.
        /// </summary>
        /// <param name="password">Password Entity to be saved.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int AddNewPassword(Password password)
        {
            int AffectedRows = -1;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Insert into Passwords (Name, Email, Username, Website, Text, Notes, DateCreated, DateModified) values (@Name, @Email, @Username, @Website, @Text, @Notes, @DateCreated, @DateModified)", connection))
                {
                    command.Parameters.Add(new SqlParameter("Name", password.Name));
                    command.Parameters.Add(new SqlParameter("Email", password.Email));
                    command.Parameters.Add(new SqlParameter("Username", password.Username));
                    command.Parameters.Add(new SqlParameter("Website", password.Website));
                    command.Parameters.Add(new SqlParameter("Text", password.Text));
                    command.Parameters.Add(new SqlParameter("Notes", password.Notes));
                    command.Parameters.Add(new SqlParameter("DateCreated", password.DateCreated));
                    command.Parameters.Add(new SqlParameter("DateModified", password.DateModified));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }

            return AffectedRows;
        }

        /// <summary>
        /// Add List of New Passwords to Database.
        /// </summary>
        /// <param name="passwords">List of Passwords.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int AddNewPasswords(List<Password> passwords)
        {
            //use transaction in here -gul:0401171330

            int AffectedRows = 0;
            foreach (Password password in passwords)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(
                    "Insert into Passwords (Name, Email, Username, Website, Text, Notes, DateCreated, DateModified) values (@Name, @Email, @Username, @Website, @Text, @Notes, @DateCreated, @DateModified)", connection))
                    {
                        command.Parameters.Add(new SqlParameter("Name", password.Name));
                        command.Parameters.Add(new SqlParameter("Email", password.Email));
                        command.Parameters.Add(new SqlParameter("Username", password.Username));
                        command.Parameters.Add(new SqlParameter("Website", password.Website));
                        command.Parameters.Add(new SqlParameter("Text", password.Text));
                        command.Parameters.Add(new SqlParameter("Notes", password.Notes));
                        command.Parameters.Add(new SqlParameter("DateCreated", password.DateCreated));
                        command.Parameters.Add(new SqlParameter("DateModified", password.DateModified));

                        connection.Open();

                        AffectedRows += command.ExecuteNonQuery();
                    }
                }
            }

            return AffectedRows;
        }

        /// <summary>
        /// Get List of Passwords.
        /// </summary>
        /// <returns>List of Passwords.</returns>
        public List<Password> GetPasswords()
        {
            List<Password> passwords = new List<Password>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Select * from Passwords", connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Password password;

                    while (reader.Read())
                    {
                        password = new Password
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Username = reader["Username"].ToString(),
                            Website = reader["Website"].ToString(),
                            Text = reader["Text"].ToString(),
                            Notes = reader["Notes"].ToString(),
                            DateCreated = Convert.ToDateTime(reader["DateCreated"].ToString()),
                            DateModified = Convert.ToDateTime(reader["DateModified"].ToString())
                        };

                        passwords.Add(password);
                    }
                }
            }

            return passwords;
        }

        /// <summary>
        /// Update the supplied Password
        /// </summary>
        /// <param name="password">Password Entity to be updated.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int UpdatePasswordById(Password password)
        {
            int AffectedRows = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Update Passwords set Name= @Name, Email=@Email, Username= @Username, Website= @Website, Text= @Text, Notes= @Notes, DateCreated= @DateCreated, DateModified= @DateModified where Id = @Id", connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", password.Id));
                    command.Parameters.Add(new SqlParameter("Name", password.Name));
                    command.Parameters.Add(new SqlParameter("Email", password.Email));
                    command.Parameters.Add(new SqlParameter("Username", password.Username));
                    command.Parameters.Add(new SqlParameter("Website", password.Website));
                    command.Parameters.Add(new SqlParameter("Text", password.Text));
                    command.Parameters.Add(new SqlParameter("Notes", password.Notes));
                    command.Parameters.Add(new SqlParameter("DateCreated", password.DateCreated));
                    command.Parameters.Add(new SqlParameter("DateModified", password.DateModified));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }
            return AffectedRows;
        }

        /// <summary>
        /// Updates List of Passwords.
        /// </summary>
        /// <param name="passwords">List of Password Entities.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int UpdatePasswords(List<Password> passwords)
        {
            //we'll use transaction in here
            int AffectedRows = 0;

            foreach (Password password in passwords)
            {
                AffectedRows += UpdatePasswordById(password);
            }

            return AffectedRows;
        }

        /// <summary>
        /// Deletes the Password.
        /// </summary>
        /// <param name="passwordId">Password ID for Password.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int DeletePasswordById(int passwordId)
        {
            int AffectedRows = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Delete from Passwords where Id = @Id", connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", passwordId));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }

            return AffectedRows;
        }

        /// <summary>
        /// Add Settings to Database for the User.
        /// </summary>
        /// <param name="settings">Settings Entity to Saved.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int AddSettings(Settings settings)
        {
            int AffectedRows = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Insert into Settings (DateTimeFormat, ShowEmailColumn, ShowUsernameColumn, ShowPasswordColumn) values (@DateTimeFormat, @ShowEmailColumn, @ShowUsernameColumn, @ShowPasswordColumn)", connection))
                {
                    command.Parameters.Add(new SqlParameter("DateTimeFormat", settings.DateTimeFormat));
                    command.Parameters.Add(new SqlParameter("ShowEmailColumn", settings.ShowEmailColumn));
                    command.Parameters.Add(new SqlParameter("ShowUsernameColumn", settings.ShowUsernameColumn));
                    command.Parameters.Add(new SqlParameter("ShowPasswordColumn", settings.ShowPasswordColumn));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }

            return AffectedRows;
        }

        /// <summary>
        /// Get Settings against the Supplied User ID
        /// </summary>
        /// <returns>Settings Entity for User.</returns>
        public Settings GetSettings()
        {
            Settings settings = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Select * from Settings", connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        settings = new Settings
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            ShowEmailColumn = Convert.ToBoolean(reader["ShowEmailColumn"]),
                            ShowUsernameColumn = Convert.ToBoolean(reader["ShowUsernameColumn"]),
                            ShowPasswordColumn = Convert.ToBoolean(reader["ShowPasswordColumn"]),
                            DateTimeFormat = reader["DateTimeFormat"].ToString(),
                            Master = reader["Master"].ToString()
                        };
                    }
                }
            }

            return settings;
        }

        /// <summary>
        /// Updates Settings
        /// </summary>
        /// <param name="settings">Settings Entity to be updated.</param>
        /// <returns>Number of Rows Affected.</returns>
        public int UpdateSettings(Settings settings)
        {
            int AffectedRows = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(
                "Update Settings set DateTimeFormat= @DateTimeFormat, ShowEmailColumn=@ShowEmailColumn, ShowUsernameColumn= @ShowUsernameColumn, ShowPasswordColumn = @ShowPasswordColumn where Id = @Id", connection))
                {
                    command.Parameters.Add(new SqlParameter("Id", settings.Id));
                    command.Parameters.Add(new SqlParameter("DateTimeFormat", settings.DateTimeFormat));
                    command.Parameters.Add(new SqlParameter("ShowEmailColumn", settings.ShowEmailColumn));
                    command.Parameters.Add(new SqlParameter("ShowUsernameColumn", settings.ShowUsernameColumn));
                    command.Parameters.Add(new SqlParameter("ShowPasswordColumn", settings.ShowPasswordColumn));

                    connection.Open();

                    AffectedRows = command.ExecuteNonQuery();
                }
            }
            return AffectedRows;
        }
    }
}
