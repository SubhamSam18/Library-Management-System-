using lbs;
using dict;
using Library;
namespace students{
    
    public class stu_info : Librarian{
        public static dit d= new dit();
        public void Details_Of_All_Student()
        {
            Console.WriteLine("Stu_id : Stu_name : Issue_Count");
            foreach (var stu in d.st_name) 
            {
                Console.WriteLine(stu.Key + " : " + stu.Value + " : " + d.st_book_issued[stu.Key]);
            }
        }

        public void Details_of_Single_Student()
        {
             Console.Write("Enter Student_id : ");
            string? stu_id_re =Console.ReadLine();
            if (!d.st_name.ContainsKey(stu_id_re))
            {
                Console.WriteLine("Student Account Not Found");
            }
            else
                Console.Write("Student id : " + stu_id_re + "\nStudent Name : " + d.st_name[stu_id_re] + "\nNo of Book Issued : "+ d.st_book_issued[stu_id_re] + "\nBooks Issued: ");
                if(d.st_book_details[stu_id_re].Count!=0){
                for (int ListIndex = 0; ListIndex < d.st_book_details[stu_id_re].Count; ListIndex++)
                {
                Console.Write(d.st_book_details[stu_id_re][ListIndex] as string + " ");
                }
                Console.WriteLine();
                }
        }


        public void My_Details(string stuid)
        {
            string? id = stuid;
            Console.Write("Student id : " + stuid + "\nStudent Name : " + d.st_name[id] + "\nNo Of Book Issued : "+ d.st_book_issued[id] + "\nBooks Issued: ");
            for (int ListIndex = 0; ListIndex < d.st_book_details[id].Count; ListIndex++)
            {
                Console.Write(d.st_book_details[id][ListIndex] as string + " ");
            }
                Console.WriteLine();
        }
        public void Books_Available(){
            Console.WriteLine("bookid : book name : book count");
            int count_book = 0;
            foreach(var key in d.books)
            {
                if(d.bookscount[key.Key]!=0){
                    Console.WriteLine(key.Key + " : " + key.Value + " : " + d.bookscount[key.Key]);
                    count_book++;
                }

            }
            if(count_book==0)
                Console.WriteLine("----------Books Not Available-----------");
        }
    }
}