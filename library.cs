using lbs;
using dict;
using students;
namespace Library
{
public class Librarian : dit
{
    // dit d= new dit();

    public void Add_Book_Stock()
    {
        library lib = new library();
        Console.Write("Enter Book id: ");
        string? id = Console.ReadLine();
        
        int quantity;
        if (!stu_info.d.books.ContainsKey(id))
        {
            Console.Write("Enter Book Name  : ");
            string? name = Console.ReadLine();
            Console.Write("Enter Number of Book(s) : ");
            quantity = Convert.ToInt32(Console.ReadLine());
            stu_info.d.books.Add(id,name);
            stu_info.d.bookscount.Add(id,quantity);
            Console.WriteLine("Book added\n\n");
        }
        else
        {
            Console.Write("Enter Number of Book(s) : ");
            quantity = Convert.ToInt32(Console.ReadLine());
            stu_info.d.bookscount[id]+=quantity;
            Console.Write(quantity + "books were added \n\n");
        }         
        
    }

    public void Search_Books()
    {
         Console.Write("Enter bookid : ");
        string? book_id = Console.ReadLine();
        if(!stu_info.d.books.ContainsKey(book_id)){
            Console.WriteLine("Book Not Found");
        }
        else if(stu_info.d.bookscount[book_id] == 0){
            Console.WriteLine("Book Not Available");
        }
        else 
            Console.WriteLine("Book is available.\n" + "Number of '"+stu_info.d.books[book_id] + "' = " + stu_info.d.bookscount[book_id] );
    }


    public void Issue_Book()
    {
         Console.Write("Enter Student_id : ");
        string? stu_id =Console.ReadLine();
        if (!stu_info.d.st_name.ContainsKey(stu_id))
        {
            Console.WriteLine("Student Account Not Found");
        }
        else
        {
            Console.WriteLine("Student id : " + stu_id + "\nStudent Name : " + stu_info.d.st_name[stu_id] + "\nBook Issued : "+ stu_info.d.st_book_issued[stu_id]);
            
            Console.Write("Enter book id :");
            string? is_id = Console.ReadLine();
            if(!stu_info.d.books.ContainsKey(is_id))
            {
                Console.WriteLine("Book Not Found");
            }    
            else
            {
                bool flag = false;
                if(stu_info.d.st_book_details.ContainsKey(stu_id))
                {
                    
                    for (int ListIndex = 0; ListIndex < stu_info.d.st_book_details[stu_id].Count; ListIndex++)
                    {
                        if(stu_info.d.st_book_details[stu_id][ListIndex] == stu_info.d.books[is_id])
                        {
                            flag=true;
                        }
                        // Console.Write(stu_info.d.st_book_details[stu_id][ListIndex] as string + ",");
                    }
                    if(flag)
                    {
                        Console.WriteLine("The book is already issued to you");
                    }
                    else
                        stu_info.d.st_book_details[stu_id].Add(stu_info.d.books[is_id]);
                }
                else
                {
                    stu_info.d.st_book_details.Add(stu_id, new List<string> { stu_info.d.books[is_id] });
                }
                if(!flag)
                {
                stu_info.d.bookscount[is_id]--;
                stu_info.d.st_book_issued[stu_id]++;
                Console.WriteLine("Book Issued");
                }   
            }
        }
    }


    public void return_book()
    {
        Console.Write("Enter Student_id : ");
        string? stu_id_re =Console.ReadLine();
        if (!stu_info.d.st_name.ContainsKey(stu_id_re))
        {
            Console.WriteLine("Student Account Not Found");
        }
        else{   
            Console.WriteLine("Student id : " + stu_id_re + "\nStudent Name : " + stu_info.d.st_name[stu_id_re] + "\nBook Issued : "+ stu_info.d.st_book_issued[stu_id_re]);
            Console.Write("Enter book id :");
            string? is_id_re = Console.ReadLine();
            if(!stu_info.d.books.ContainsKey(is_id_re))
            {
                Console.WriteLine("Book Not Found");
            }    
            else
            {
                bool flag = false;
                if(stu_info.d.st_book_details.ContainsKey(stu_id_re))
                {
                    
                    for (int ListIndex = 0; ListIndex < stu_info.d.st_book_details[stu_id_re].Count; ListIndex++)
                    {
                        if(stu_info.d.st_book_details[stu_id_re][ListIndex] == stu_info.d.books[is_id_re])
                        {
                            flag=true;
                        }
                        // Console.Write(stu_info.d.st_book_details[stu_id][ListIndex] as string + ",");
                    }
                    if(!flag)
                    {
                        Console.WriteLine("The book was not issued to you");
                    }
                    else
                    {
                        stu_info.d.bookscount[is_id_re]++;
                        stu_info.d.st_book_issued[stu_id_re]--;
                        Console.WriteLine("Book Returned");
                    }
                }

        }
        
    }
}
}
}
