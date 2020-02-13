namespace NC_DBInterface.db_objects
{
    public class Member
    {
        public string id;
        public string name;
        public string lastName;
        public bool status;

        public Member(string id, string name, string last_name, bool status)
        {
            this.id = id;
            this.name = name;
            this.lastName = last_name;
            this.status = status;
        }
    }
}
