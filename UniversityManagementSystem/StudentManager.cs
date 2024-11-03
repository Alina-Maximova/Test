using System.Collections.Generic;

namespace UniversityManagementSystem
{
    public class SrudentManager
    {
        public class Srudent
        {
            public string Name { get; set; }
            public string Code { get; set; }

            public Srudent(string name, string code)
            {
                Name = name;
                Code = code;
            }
        }

        private List<Srudent> _institutes = new List<Srudent>();

        public void AddSrudent(Srudent institute)
        {
            if (string.IsNullOrEmpty(institute.Name))
            {
                throw new ArgumentException("Srudent name cannot be empty.");
            }

            _institutes.Add(institute);
        }

        public List<Srudent> GetSrudents()
        {
            return _institutes;
        }

        public Srudent FindSrudentByCode(string code)
        {
            return _institutes.Find(i => i.Code == code);
        }

        public void DeleteSrudent(string code)
        {
            _institutes.RemoveAll(i => i.Code == code);
        }

        public void UpdateSrudent(string code, Srudent updatedSrudent)
        {
            var instituteToUpdate = _institutes.Find(i => i.Code == code);
            if (instituteToUpdate != null)
            {
                instituteToUpdate.Name = updatedSrudent.Name;
            }
        }
    }


}