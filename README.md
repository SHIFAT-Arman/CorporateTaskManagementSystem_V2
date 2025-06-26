# CorporateTaskManagementSystem_V2

### Objective:
The system’s main goal is to create an efficient system which will achieve improved team coordination and effective transparency between managers and employees of a corporate company. It will help the employees to keep track of their designated tasks in a well manner.

### System Features:
1. User login and role-based access.
2. Unique identification entities based on access level
3. Allow searching, updating, adding and deleting information of employees, departments, teams and tasks with their designated role-based access.
4. Everyone can edit their own Profile.

### Users:
1. Admin:
- Create, Update, Search, Delete Employees from the system.
- Create, Update, Search, Delete Departments from the system.
- Create, Update, Search, Delete Teams from the system.
- Create, Update, Search, Delete Tasks from the system.
2. Department Head:
- Create, Search Employee in the system.
- Create, Update, Search, Delete Teams from the system.
- Create, Update, Search, Delete Tasks from the system.
3. Team Lead:
- Search Employee in the system.
- Create, Update, Search, Delete Teams from the system.
- Create, Update, Search, Delete Tasks from the system.
4. Employee:
- Update Task Status in the system.

# Database (SQL)
- Use SSMS-21 > Connect with optional and windows auth
- Database > Import Data tier Application > import the .bacpac file from the repo
### Create a SqlDbDataAccess.cs File in Models
Add the following code
```csharp
using System.Data.SqlClient;

namespace CorporateTaskManagementSystem_V2.Model
{
    public class SqlDbDataAccess
{
    private const string connectionString = @"Data Source=<Server Name>;Initial Catalog=CorpTaskMS_V2;Integrated Security=True;Encrypt=False"; // change to your server name

    public SqlCommand GetQuery(string query)
    {
        var connection = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(query);
        cmd.Connection = connection;

        return cmd;
    }
}
}
```
  
