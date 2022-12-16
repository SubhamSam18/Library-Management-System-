using lbs;
using dict;
using students;
using Library;


namespace book_info{
    public class bo_in : Librarian{
        // dit d= new dit();
        
        public void book_infor()
        {
            int length = 25;
            int l=8;
            Console.WriteLine("BookID   : Book Name                 : Book Count");
                    
                        foreach (var book in stu_info.d.books) 
                        {
                            string source = book.Value;
                            string x = book.Key.ToString();
                            Console.WriteLine(x.PadRight(l).Substring(0, l) + " : " + source.PadRight(length).Substring(0, length) + " : " + stu_info.d.bookscount[book.Key]);
                        }
                        Console.WriteLine("\n");
        }
    }
}

// source.PadRight(length).Substring(0, length);