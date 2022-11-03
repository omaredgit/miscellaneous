using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts.Encapsulation
{
    //All data is protected just accesible thru methods and not directly ENCAPSULATION

    public class Developer
    {
        private string _firstName;
        private string _secondName;
        private string _firstLastName;
        private string _secondLastName;
        private int _count;

        public Developer(string firstName, string secondName, string firstLastName, string secondLastName)
        {
            _firstName = firstName;
            _secondName = secondName;
            _firstLastName = firstLastName;
            _secondLastName = secondLastName;
            _count = 1;
        }

        public string FirstName
        {
            get => $"{_firstName} {_count.ToString()}";
        }

        public string TwoFirstNames
        {
            get => $"{_firstName} {_secondName} {_count.ToString()}";
        }

        public string ThreeFirstNames
        {
            get => $"{_firstName} {_secondName} {_firstLastName} {_count.ToString()}";
        }

        public string FourFirstNames
        {
            get => $"{_firstName} {_secondName} {_firstLastName} {_secondLastName} {_count.ToString()}";
        }

        public int IncreaseTheCount
        {
            set => _count = value ;
        }
    }
}
