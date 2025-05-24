using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLMS
{
    class Student
    {
        private string indexNumber;
        private string name;
        private double gPA;
        private int admissionYear;
        private string nIC;
        private Student next;
        public string IndexNumber { get => indexNumber; set => indexNumber = value; }
        public string Name { get => name; set => name = value; }
        public double GPA { get => gPA; set => gPA = value; }
        public int AdmissionYear { get => admissionYear; set => admissionYear = value; }
        public string NIC { get => nIC; set => nIC = value; }
        internal Student Next { get => next; set => next = value; }

        public Student(string indexNumber, string name, double gpa, int admissionYear, string nic)
        {
            IndexNumber = indexNumber;
            Name = name;
            GPA = gpa;
            AdmissionYear = admissionYear;
            NIC = nic;
            Next = null;
        }

        public override string ToString()
        {
            return $"Index: {IndexNumber}, Name: {Name}, GPA: {GPA}, Year: {AdmissionYear}, NIC: {NIC}";
        }
    }
}
