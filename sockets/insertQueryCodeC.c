#include <stdio.h>
#include <mysql.h>

int main() {
    MYSQL *conn;
    MYSQL_RES *res;
    MYSQL_ROW row;

    const char *server = "localhost";    // MySQL server address
    const char *user = "root";           // MySQL username
    const char *password = "root@13";  // MySQL password
    const char *dbname = "cdb";    // 	Database name

    // Initialize MySQL connection
    conn = mysql_init(NULL);
    if (conn == NULL)
   {
        fprintf(stderr, "mysql_init() failed\n");
        return EXIT_FAILURE;
    }

    // Connect to the MySQL database
    if (mysql_real_connect(conn, server, user, password, dbname, 0, NULL, 0) == NULL) {
        fprintf(stderr, "mysql_real_connect() failed\n");
        mysql_close(conn);
        return EXIT_FAILURE;
    }

    // Prepare the SQL query to insert data
    const char *query = "INSERT INTO data (A, B) VALUES ('value1', 'value2')";

    // Execute the query
    if (mysql_query(conn, query)) 
    {
        fprintf(stderr, "INSERT failed. Error: %s\n", mysql_error(conn));
        mysql_close(conn);
        return EXIT_FAILURE;
    }

    printf("Data inserted successfully!\n");

    // Close the connection
    mysql_close(conn);
    return EXIT_SUCCESS;
}
