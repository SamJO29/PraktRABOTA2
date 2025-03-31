using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktRABOTA2
{
    internal class Program1
    {

        
    }
}





/*

Задача 1
 internal class Program
    {
        static void Main(string[] args)
        {
            Student студент1 = new Student("Иванов", "Иван", "Иванович", new DateTime(2000, 5, 15),
                                         "Москва, ул. Пушкина, д. 1", "123-456-7890",
                                         "ivanov@mail.com", 2, "Группа A",
                                         "123456");

            Student студент2 = new Student("Петров", "Петр", "Петрович", new DateTime(1999, 8, 20),
                                             "Москва, ул. Лермонтова, д. 2", "098-765-4321",
                                             "petrov@mail.com", 3, "Группа B",
                                             "654321");

            Student студент3 = new Student("Сидоров", "Сидор", "Сидорович", new DateTime(2001, 3, 10),
                                             "Москва, ул. Чехова, д. 3", "111-222-3333",
                                             "sidorov@mail.com", 1, "Группа A",
                                             "789012");

            Console.WriteLine(студент1);
            Console.WriteLine();
            Console.WriteLine(студент2);
            Console.WriteLine();
            Console.WriteLine(студент3);
            Console.WriteLine();

            Console.WriteLine("Сравнение студентов по фамилии:");
            int результатСравнения = Student.CompareByLastName(студент1, студент2);
            if (результатСравнения < 0)
                Console.WriteLine($"{студент1.LastName} предшествует {студент2.LastName}");
            else if (результатСравнения > 0)
                Console.WriteLine($"{студент1.LastName} следует после {студент2.LastName}");
            else
                Console.WriteLine($"{студент1.LastName} и {студент2.LastName} одинаковы");

            Console.WriteLine();

            Console.WriteLine("Сравнение студентов по курсу:");
            результатСравнения = Student.CompareByCourse(студент2, студент3);
            if (результатСравнения < 0)
                Console.WriteLine($"{студент2.FirstName} учится на более низком курсе, чем {студент3.FirstName}");
            else if (результатСравнения > 0)
                Console.WriteLine($"{студент2.FirstName} учится на более высоком курсе, чем {студент3.FirstName}");
            else
                Console.WriteLine($"{студент2.FirstName} и {студент3.FirstName} учатся на одном курсе");

            студент1.Address = "Москва, ул. Новая, д. 10";
            студент1.Phone = "555-555-5555";
            Console.WriteLine("\nОбновленная информация о студенте 1:");
            Console.WriteLine(студент1);
        }
    }

    public class Student
    {
        private string фамилия;
        private string имя;
        private string отчество;
        private DateTime датаРождения;
        private string адрес;
        private string телефон;
        private string электронныйАдрес;
        private int курс;
        private string группа;
        private string номерЗачетнойКнижки;

        public Student()
        {
            фамилия = "Amir";
            имя = "Nahushev";
            отчество = "Est";
            датаРождения = DateTime.MinValue;
            адрес = "Неизвестно";
            телефон = "Неизвестно";
            электронныйАдрес = "Неизвестно";
            курс = 0;
            группа = "Неизвестно";
            номерЗачетнойКнижки = "Неизвестно";
        }

        public Student(string фамилия, string имя, string отчество, DateTime датаРождения,
                       string адрес, string телефон, string электронныйАдрес, int курс, string группа,
                       string номерЗачетнойКнижки)
        {
            this.фамилия = фамилия;
            this.имя = имя;
            this.отчество = отчество;
            this.датаРождения = датаРождения;
            this.адрес = адрес;
            this.телефон = телефон;
            this.электронныйАдрес = электронныйАдрес;
            this.курс = курс;
            this.группа = группа;
            this.номерЗачетнойКнижки = номерЗачетнойКнижки;
        }

        public string LastName
        {
            get { return фамилия; }
            set { фамилия = value; }
        }

        public string FirstName
        {
            get { return имя; }
            set { имя = value; }
        }

        public string MiddleName
        {
            get { return отчество; }
            set { отчество = value; }
        }

        public DateTime BirthDate
        {
            get { return датаРождения; }
        }

        public string Address
        {
            get { return адрес; }
            set { адрес = value; }
        }

        public string Phone
        {
            get { return телефон; }
            set { телефон = value; }
        }

        public string Email
        {
            get { return электронныйАдрес; }
            set { электронныйАдрес = value; }
        }

        public int Course
        {
            get { return курс; }
            set { курс = value; }
        }

        public string Group
        {
            get { return группа; }
            set { группа = value; }
        }

        public string StudentRecordBookNumber
        {
            get { return номерЗачетнойКнижки; }
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}, " +
                   $"Дата рождения: {BirthDate.ToShortDateString()}, " +
                   $"Адрес: {Address}, Телефон: {Phone}, " +
                   $"Электронный адрес: {Email}, Курс: {Course}, " +
                   $"Группа: {Group}, Номер зачетной книжки: {StudentRecordBookNumber}";
        }

        public static int CompareByLastName(Student s1, Student s2)
        {
            return string.Compare(s1.LastName, s2.LastName);
        }

        public static int CompareByCourse(Student s1, Student s2)
        {
            return s1.Course.CompareTo(s2.Course);
        }
    }




Задача 2 


static void Main(string[] args)
        {
            {
                Book book1 = new Book("Достоевский", "Федор", "Михайлович", "Преступление и наказание", "001", 1866, 430);
                Book book2 = new Book("Толстой", "Лев", "Николаевич", "Война и мир", "002", 1869, 1225);

                Console.WriteLine(book1);
                Console.WriteLine();
                Console.WriteLine(book2);

                // Сравнение книг по году издания
                int comparisonResult = Book.CompareByYearOfPublication(book1, book2);
                if (comparisonResult < 0)
                    Console.WriteLine($"{book1.Title} издан раньше, чем {book2.Title}");
                else if (comparisonResult > 0)
                    Console.WriteLine($"{book1.Title} издан позже, чем {book2.Title}");
                else
                    Console.WriteLine($"{book1.Title} и {book2.Title} изданы в одном году");
            }



        }
        public class Book
        {
            private string lastNameAuthor; // Фамилия автора
            private string firstNameAuthor; // Имя автора
            private string middleNameAuthor; // Отчество автора
            private string title; // Название книги
            private string code; // Код
            private int yearOfPublication; // Год издания
            private int numberOfPages; // Количество страниц

            // Конструктор без параметров
            public Book()
            {
                lastNameAuthor = "Неизвестно";
                firstNameAuthor = "Неизвестно";
                middleNameAuthor = "Неизвестно";
                title = "Неизвестно";
                code = "Неизвестно";
                yearOfPublication = 0;
                numberOfPages = 0;
            }

            // Конструктор с параметрами
            public Book(string lastNameAuthor, string firstNameAuthor, string middleNameAuthor,
                        string title, string code, int yearOfPublication, int numberOfPages)
            {
                this.lastNameAuthor = lastNameAuthor;
                this.firstNameAuthor = firstNameAuthor;
                this.middleNameAuthor = middleNameAuthor;
                this.title = title;
                this.code = code;
                this.yearOfPublication = yearOfPublication;
                this.numberOfPages = numberOfPages;
            }

            // Свойства
            public string LastNameAuthor
            {
                get { return lastNameAuthor; }
                set { lastNameAuthor = value; }
            }

            public string FirstNameAuthor
            {
                get { return firstNameAuthor; }
                set { firstNameAuthor = value; }
            }

            public string MiddleNameAuthor
            {
                get { return middleNameAuthor; }
                set { middleNameAuthor = value; }
            }

            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string Code
            {
                get { return code; }
            }

            public int YearOfPublication
            {
                get { return yearOfPublication; }
                set { yearOfPublication = value; }
            }

            public int NumberOfPages
            {
                get { return numberOfPages; }
                set { numberOfPages = value; }
            }

            // Переопределение метода ToString()
            public override string ToString()
            {
                return $"Автор: {LastNameAuthor} {FirstNameAuthor} {MiddleNameAuthor}, " +
                       $"Название: {Title}, Код: {Code}, " +
                       $"Год издания: {YearOfPublication}, Количество страниц: {NumberOfPages}";
            }

            // Метод для сравнения книг по году издания
            public static int CompareByYearOfPublication(Book b1, Book b2)
            {
                return b1.YearOfPublication.CompareTo(b2.YearOfPublication);
            }

            // Метод для сравнения книг по количеству страниц
            public static int CompareByNumberOfPages(Book b1, Book b2)
            {
                return b1.NumberOfPages.CompareTo(b2.NumberOfPages);
            }



        }


Задача 3

class Patient
{
   
    private string lastName;
    private string firstName;
    private string middleName;
    private string address;
    private int medicalCardNumber;
    private string diagnosis;

    
    public Patient(string lastName, string firstName, string middleName,
                   string address, int medicalCardNumber, string diagnosis)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.middleName = middleName;
        this.address = address;
        this.medicalCardNumber = medicalCardNumber;
        this.diagnosis = diagnosis;
    }

    
    public void SetLastName(string lastName) => this.lastName = lastName;
    public void SetFirstName(string firstName) => this.firstName = firstName;
    public void SetMiddleName(string middleName) => this.middleName = middleName;
    public void SetAddress(string address) => this.address = address;
    public void SetMedicalCardNumber(int medicalCardNumber) => this.medicalCardNumber = medicalCardNumber;
    public void SetDiagnosis(string diagnosis) => this.diagnosis = diagnosis;


    public string GetLastName() => lastName;
    public string GetFirstName() => firstName;
    public string GetMiddleName() => middleName;
    public string GetAddress() => address;
    public int GetMedicalCardNumber() => medicalCardNumber;
    public string GetDiagnosis() => diagnosis;

  
    public void Show()
    {
        Console.WriteLine($"ФИО: {lastName} {firstName} {middleName}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Номер мед. карты: {medicalCardNumber}");
        Console.WriteLine($"Диагноз: {diagnosis}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
     
        Patient[] patients = new Patient[]
        {
            new Patient("Иванов", "Иван", "Иванович", "ул. Ленина, 10", 12345, "Грипп"),
            new Patient("Петров", "Петр", "Петрович", "ул. Пушкина, 5", 12346, "Ангина"),
            new Patient("Сидорова", "Мария", "Сергеевна", "ул. Гагарина, 15", 12347, "Грипп"),
            new Patient("Кузнецов", "Алексей", "Викторович", "ул. Садовая, 20", 12348, "Бронхит"),
            new Patient("Смирнова", "Ольга", "Игоревна", "ул. Мира, 3", 12349, "Ангина")
        };

     
        Console.WriteLine("Введите диагноз для поиска:");
        string searchDiagnosis = Console.ReadLine();
        Console.WriteLine($"\nПациенты с диагнозом '{searchDiagnosis}':");

        bool foundDiagnosis = false;
        foreach (Patient p in patients)
        {
            if (p.GetDiagnosis().Equals(searchDiagnosis, StringComparison.OrdinalIgnoreCase))
            {
                p.Show();
                foundDiagnosis = true;
            }
        }
        if (!foundDiagnosis) Console.WriteLine("Пациентов с таким диагнозом не найдено.\n");


        Console.WriteLine("Введите начальный номер мед. карты:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите конечный номер мед. карты:");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nПациенты с номером мед. карты от {start} до {end}:");

        bool foundCards = false;
        foreach (Patient p in patients)
        {
            int cardNum = p.GetMedicalCardNumber();
            if (cardNum >= start && cardNum <= end)
            {
                p.Show();
                foundCards = true;
            }
        }
        if (!foundCards) Console.WriteLine("Пациентов в указанном диапазоне не найдено.\n");
    }
}




*/








