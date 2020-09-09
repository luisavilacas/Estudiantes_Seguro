using System.Data.Entity;

namespace APIStudentSecurity.Models
{
    public class DataContext: DbContext 
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}