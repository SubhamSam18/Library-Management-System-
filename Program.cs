using System.Security;
using Library;
using dict;
using authenticate;
using students;
using book_info;
using logo;

namespace lbs{

    public class library
    {
        

        static void Main()
        {
               
               

            


            dit d = new dit();
            authen at=new authen();
            Librarian lb = new Librarian();
            stu_info si = new stu_info();
            bo_in bo = new bo_in();
            logos lo = new logos();
            
            bool fc2=true;
            while(fc2){
            Console.WriteLine(lo.logo);
            Console.WriteLine(lo.home);
            Console.WriteLine("1.Librarian login \n2.Student Login \n3.Student registration\n4.exit");
            string? q = Console.ReadLine();
            
                
            switch(q)
            {
                case "1":
                Console.WriteLine("Enter user name");
                 string? username=Console.ReadLine();

                Console.WriteLine("Enter password");
                bool fc=false;

                string password=validation();
                
                if(at.authlib.ContainsKey(username)){
                    if(at.authlib[username]==password){
                        fc=true;
                    }
                    else{
                        Console.WriteLine("Invalid password");
                        goto case "1";
                    }

                } else{
                        Console.WriteLine("Invalid username");
                        goto case "1";
                    }
                 while(fc){
                   
                    //Console. Clear();

                    Console.WriteLine(lo.logo);
                    Console.WriteLine(lo.lib);
                    bool flag=false;
                    // const int maxlen = 10;

                    Console.WriteLine("1.Librarian access \n2.Student access\n3.Books Info access \n4.Logout");
                    Console.Write("Enter your choice : ");
                    string? n;
                    n=Console.ReadLine();

                    switch(n)
                    {

                        case "1":
                        //Console.Clear();
                        Console.WriteLine(lo.logo);
                        Console.WriteLine(lo.lib);
                        Console.WriteLine("1.Add Book Stock \n2.Search Books \n3.Issue Book \n4.Return book \n5.Return To Previous Menu");
                        string? x;
                        Console.Write("Enter your choice : ");
                        x= Console.ReadLine();

                            switch(x)
                            {
                                case "1":
                                    lb.Add_Book_Stock();
                                    loop();
                                break;
                                case "2":
                                    lb.Search_Books();
                                    loop();
                                break;
                                case "3":
                                    lb.Issue_Book();
                                    loop();
                                break;
                                case "4": 
                                    lb.return_book();
                                    loop();
                                break;
                                case "5":

                                break;
                                default :
                                    Console.WriteLine("Invaild Option");
                                break;
                            }
                        break;

                        case "2":
                            //Console.Clear();
                            Console.WriteLine(lo.logo);
                            Console.WriteLine(lo.lib);
                            Console.WriteLine("1.Details Of All Student \n2.Details of Single Student \n3.Books Available \n4.Return To Previous Menu");
                            Console.Write("Enter your choice : ");
                            string? h = Console.ReadLine();
                            

                            switch(h)
                            {
                                case "1":
                                    si.Details_Of_All_Student();
                                    loop();
                                break;

                                case "2":
                                si.Details_of_Single_Student();
                                loop();
                                break;
                                case "3":
                                    si.Books_Available();
                                   loop();
                                break;
                                case "4":
                                break;
                                default :
                                    Console.WriteLine("Invaild Option");
                                break;

                            }

                        break;

                        case "3":
                            bo.book_infor();
                            loop();
                           
                        break; 
                        case "4":
                            flag=true;
                        break;

                        default :
                            Console.WriteLine("Invaild Option");
                        break;
                    }

                    if(flag)
                    break;
            }

                break;
                case "2":
                Console.WriteLine("Enter user id");
                string? stuuser=Console.ReadLine();

                Console.WriteLine("Enter password");
                bool fb=false;

                string? stupass=validation();
                
                if(at.authstu.ContainsKey(stuuser)){
                    if(at.authstu[stuuser]==stupass){
                        fb=true;
                    }
                    else{
                        Console.WriteLine("Invalid password");
                        goto case "2";
                    }

                } else{
                        Console.WriteLine("Invalid username");
                        goto case "2";
                    }
                    while(fb){

                    Console.WriteLine(lo.logo);
                    Console.WriteLine(lo.stu);
                    bool flag=false;
                    const int maxlen = 10;

                    Console.WriteLine("1.Student \n2.Books Info \n3.Logout");
                    Console.Write("Enter your choice : ");
                    string? n;
                    n=Console.ReadLine();

                    switch(n)
                    {
                        case "1":
                            Console.WriteLine(lo.logo);
                            Console.WriteLine(lo.stu);
                            Console.WriteLine("1.My Details \n2.Books Available\n3.Return");
                            Console.Write("Enter your choice : ");
                            string? h = Console.ReadLine();
                            

                            switch(h)
                            {
                                case "1":
                                    si.My_Details(stuuser);
                                    loop();
                                break;
                                case "2":
                                    si.Books_Available();
                                    loop();
                                break;
                                case "3":
                                break;
                                default :
                                    Console.WriteLine("Invaild Option");
                                break;
                            }

                        break;

                        case "2":
                            bo.book_infor();
                            loop();
                            
                        break; 
                        case "3":
                        flag=true;
                        break;

                        default :
                            Console.WriteLine("Invaild Option");
                        break;
                }
               if(flag)
                    break;
        }
        break;
        case "3":
        
        Console.WriteLine("Enter new studentID for registration");
        string? stunewid=Console.ReadLine();
        if(!at.authstu.ContainsKey(stunewid))
        {
            Console.WriteLine("Enter your name");
            string? stunewname=Console.ReadLine();
            Console.WriteLine("Enter password for student registration");
            string? stunewpass=Console.ReadLine();
            
            string? converted=stunewid;
            at.authstu.Add(stunewid,stunewpass);
            stu_info.d.st_name.Add(converted,stunewname);
        
            stu_info.d.st_book_issued.Add(converted,0);
            stu_info.d.st_book_details.Add(converted, new List<string> { });
        }
        else{
            Console.WriteLine("User already exists\n ");
            Console.WriteLine("please Re-enter the vaild user ID");
            goto case "3";
            
        }
        
        Console.WriteLine("Enter your login credentials here");

        goto case "2";
        
        case "4":
            fc2=false;
        break;
        default :
            Console.WriteLine("Invaild Option");
        break;
    }
    
    }

}
public static void loop()
{
     bool bbb = true;
    while(bbb){
        Console.WriteLine("Press 1 to Return to Previous Menu");
        string? bb = Console.ReadLine();
    
        switch(bb)
        {
            case "1":
            bbb = false;
            break;
            default :
                Console.WriteLine("Invaild Option");
            break;
        }
    }
}

public static string validation()
{
    string? pwd = "";
               
            SecureString pass = new SecureString();
            ConsoleKeyInfo key;
            
            bool key1 = true;
            while (key1)
            {
                key = Console.ReadKey(true);
               
                if(key.Key == ConsoleKey.Enter)
                    key1 = false;
                else if (key.Key != ConsoleKey.Backspace )
                {
                    pwd+= key.KeyChar;
                    pass.AppendChar(key.KeyChar);
                    Console.Write("*");
                }
                else if(key.Key == ConsoleKey.Backspace && pwd.Length!=0)
                {
                    pass.RemoveAt(pass.Length - 1);
                    pwd = pwd.Remove(pwd.Length - 1);
                    Console.Write("\b \b");
                }
            }
            
            return pwd;
}

}
}




 