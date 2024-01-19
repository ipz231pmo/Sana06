
Library.People[] peoples = new Library.People[5];
peoples[0] = new Library.People("Ivan", "Ivanov", 31, 07, 2006);
peoples[1] = new Library.Student("Stepan", "Stepanov", 23, 2, 1992, 1, "FBI-23", "Security Faculty", "University of Toronto");
peoples[2] = new Library.Abiturient("Petro", "Petrov", 14, 07, 1982, 159.4f, 10.4f, "Liceum");
peoples[3] = new Library.Lector("Dmitro", "Dmitrov", 7, 11, 1999, "profesor", "Department of interpretation", "Unknown University");
peoples[4] = new Library.LibraryUser("Oleksandr", "Olexandrov", 4, 10, 2001, 1, "22.05.2023", 12);
for (int i = 0; i < peoples.Length; i++)
    Console.Write(peoples[i].ShowInfo());