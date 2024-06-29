using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStorage.Classes
{
    public enum Gender
    {
        Male,
        Female
    }

    internal class Author
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public Author() { }

        public Author(string name, string email, Gender gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Nombre: {Name}\tCorreo: {Email}\tGenero: {Gender}";
        }

    }

}
