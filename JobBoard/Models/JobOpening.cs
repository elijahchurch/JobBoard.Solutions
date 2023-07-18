using System.Collections.Generic;

namespace JobBoard.Models
{
    public class JobOpening
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        private static List<JobOpening> _allthejobs = new List<JobOpening> { };

        public JobOpening(string name, string description, string email)
        {
            Name = name;
            Description = description;
            Email = email;
            _allthejobs.Add(this);
        }

        public static List<JobOpening> GetAll()
        {
            return _allthejobs;
        }

        public static void ClearAll()
        {
            _allthejobs.Clear();
        }

    }
}