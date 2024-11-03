using System.Collections.Generic;

namespace UniversityManagementSystem
{
    public class UniversityManager
    {
        public class Institute
        {
            public string Name { get; set; }
            public string Code { get; set; }

            public Institute(string name, string code)
            {
                Name = name;
                Code = code;
            }
        }

        private List<Institute> _institutes = new List<Institute>();

        public void AddInstitute(Institute institute)
        {
            if (string.IsNullOrEmpty(institute.Name))
            {
                throw new ArgumentException("Institute name cannot be empty.");
            }

            _institutes.Add(institute);
        }

        public List<Institute> GetInstitutes()
        {
            return _institutes;
        }

        public Institute FindInstituteByCode(string code)
        {
            return _institutes.Find(i => i.Code == code);
        }

        public void DeleteInstitute(string code)
        {
            _institutes.RemoveAll(i => i.Code == code);
        }

        public void UpdateInstitute(string code, Institute updatedInstitute)
        {
            var instituteToUpdate = _institutes.Find(i => i.Code == code);
            if (instituteToUpdate != null)
            {
                instituteToUpdate.Name = updatedInstitute.Name;
            }
        }
    }


}
