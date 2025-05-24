using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLMS
{
    class StudentLinkedList
    {
        public Student head;

        public void AddStudent(Student newStudent)
        {
            if (SearchStudent(newStudent.IndexNumber) != null)
            {
                Console.WriteLine("Index number already exists.");
                return;
            }

            if (head == null || string.Compare(newStudent.IndexNumber, head.IndexNumber) < 0) //compares the index numbers in ASCII order, if newStudent > head, then newStudent comes front
            {
                newStudent.Next = head;
                head = newStudent;
                return;
            }

            Student current = head;
            while (current.Next != null && string.Compare(current.Next.IndexNumber, newStudent.IndexNumber) < 0)
            {
                current = current.Next;
            }

            newStudent.Next = current.Next;
            current.Next = newStudent;
        }

        public Student SearchStudent(string indexNumber)
        {
            Student current = head;
            while (current != null)
            {
                if (current.IndexNumber == indexNumber)
                    return current;
                current = current.Next;
            }
            return null;
        }

        public void RemoveStudent(string indexNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.IndexNumber == indexNumber)
            {
                head = head.Next;
                Console.WriteLine("Student removed.");
                return;
            }

            Student current = head;
            while (current.Next != null && current.Next.IndexNumber != indexNumber)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                current.Next = current.Next.Next;
                Console.WriteLine("Student removed.");
            }
        }

        public void PrintAllStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No students to display.");
                return;
            }

            Student current = head;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }
    }
}
