namespace PepperJack
{
    public class Employee
    {
        // FIXME: Would have loved to use CamelCase on these, like you normally do in C# but didn't manage to find a way with Dapper to easily customize how the columns are mapped.
        public int emp_no { get; set; }
        public string birth_date { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string hire_date { get; set; }
    }
}
