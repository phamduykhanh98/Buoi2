//
namespace Buoi2 {
    class Program
    {
        public static void Main()
        {
            //Cho người dùng nhập vào danh sách học viên, khi người dùng nhập chữ "in" thì in toàn bộ danh sách vừa lưu lên màn hình
            //List và vòng lặp vô tận


            List<string> studentList = new List<string>();

            while (true)
            {
                Console.WriteLine("Nhap ten hoc vien, hoac nhap in de in ra danh sach hoc vien");
                string input = Console.ReadLine();
                if (input != null && input == "in")
                {
                    break;
                } else if (input == "xoa")
                {
                    ///
                }

                studentList.Add(input);
            }

            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine(studentList[i]);
            }
        }
    }
}