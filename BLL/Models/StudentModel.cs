#nullable disable
using BLL.DAL;

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Record { get; set; }
        public int Id => Record.Id;
        public string Name => Record.Name;
        public string Surname => Record.Surname;
        public DateTime BirthDate => (DateTime)Record.BirthDate;
        public decimal Gpa => (decimal)Record.Gpa;

    }
}
