using LinkedListLMS;
namespace LinkedListLMS
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            StudentLinkedList list = new StudentLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Insert Student");
                Console.WriteLine("2. Search Student by Index Number");
                Console.WriteLine("3. Delete Student by Index Number");
                Console.WriteLine("4. Print All Students");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Index Number: ");
                        string index = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter GPA: ");
                        double gpa = double.Parse(Console.ReadLine());
                        Console.Write("Enter Admission Year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Enter NIC: ");
                        string nic = Console.ReadLine();
                        Student student = new Student(index, name, gpa, year, nic);
                        list.AddStudent(student);
                        break;

                    case 2:
                        Console.Write("Enter Index Number to Search: ");
                        string searchIndex = Console.ReadLine();
                        Student found = list.SearchStudent(searchIndex);
                        if (found != null)
                            Console.WriteLine("Student Found: " + found);
                        else
                            Console.WriteLine("Student not found.");
                        break;

                    case 3:
                        Console.Write("Enter Index Number to Delete: ");
                        string deleteIndex = Console.ReadLine();
                        list.RemoveStudent(deleteIndex);
                        break;

                    case 4:
                        list.PrintAllStudents();
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

            } while (choice != 5);
        }
    }
}