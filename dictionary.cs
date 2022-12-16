

namespace dict{
    public class dit{
        public Dictionary<string,string> books = new Dictionary<string,string>();
        public Dictionary<string,int> bookscount = new Dictionary<string,int>();
        public Dictionary<string,string> st_name = new Dictionary<string, string>();
        public Dictionary<string, int> st_book_issued = new Dictionary<string, int>();
        public Dictionary<string, List<string>> st_book_details = new Dictionary<string, List<string>>();
        public dit(){
        // dictionaries for libraian
        //Console.WriteLine("dictionary class --------");
            books.Add( "111","One Indian Girl");
            books.Add("222", "One Night At Call Center");
            books.Add("333", "The Girl In Room 109");
            books.Add("444", "Three man in a boat");
            bookscount.Add("111",3);
            bookscount.Add("222",2);
            bookscount.Add("333",1);
            bookscount.Add("444",2);
            



            // dictionaries for student 
            
            st_name.Add("51","Subham");
            st_name.Add("52","Akshay");
            st_name.Add("53","Vamshi");
            st_book_issued.Add("51",0);
            st_book_issued.Add("52",0);
            st_book_issued.Add("53",0);
            st_book_details.Add("51", new List<string> { });
            st_book_details.Add("52", new List<string> { });
            st_book_details.Add("53", new List<string> { });

        }
    }
}
            
            
            