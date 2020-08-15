namespace Ex_resolvido_video_119.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
