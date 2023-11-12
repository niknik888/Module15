namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department() {Id = 1, Name = "Программирование"},
                new Department() {Id = 2, Name = "Продажи"}
            };


            var employees = new List<Employee>()
            {
                new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
                new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
                new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
                new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };

            var result = from e in employees // выберем сотрудников
                join d in departments on e.DepartmentId equals d.Id // соединим по общему ключу
                select new //   спроецируем выборку в новую анонимную сущность
                {
                    Name = e.Name,
                    Department = d.Name,
                    
                };

            // выведем результаты
            foreach (var item in result)
                Console.WriteLine($"{item.Name} работает в отделе {item.Department}");

        }


    }
}