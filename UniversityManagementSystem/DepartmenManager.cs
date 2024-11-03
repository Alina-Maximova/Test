using System.Collections.Generic;

namespace UniversityManagementSystem
{
    public class DepartmenManager
    {
        public class Departmen
        {
            public string Name { get; set; }
            public string Code { get; set; }

            public Departmen(string name, string code)
            {
                Name = name;
                Code = code;
            }
        }

        private List<Departmen> _institutes = new List<Departmen>();

        public void AddDepartmen(Departmen institute)
        {
            if (string.IsNullOrEmpty(institute.Name))
            {
                throw new ArgumentException("Departmen name cannot be empty.");
            }

            _institutes.Add(institute);
        }

        public List<Departmen> GetDepartmens()
        {
            return _institutes;
        }

        public Departmen FindDepartmenByCode(string code)
        {
            return _institutes.Find(i => i.Code == code);
        }

        public void DeleteDepartmen(string code)
        {
            _institutes.RemoveAll(i => i.Code == code);
        }

        public void UpdateDepartmen(string code, Departmen updatedDepartmen)
        {
            var instituteToUpdate = _institutes.Find(i => i.Code == code);
            if (instituteToUpdate != null)
            {
                instituteToUpdate.Name = updatedDepartmen.Name;
            }
        }
    }


}