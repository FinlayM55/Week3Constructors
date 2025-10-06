using Library;
using Week3Constructors;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("C# for beginners", "Bill Gates", "1234567"); 
        Book book1 = new Book("Ultimate C#", "Microsoft", "2233445");
        Book book2 = new Book("C# 2 Electric Boogaloo", "Microsoft", "2233446");
        Console.WriteLine("Current available books");
        book.DisplayInfo();
        book1.DisplayInfo();
        book2.DisplayInfo();

        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);
        Member member2 = new Member(3, "Muhammad Lee", "64 Zoo Lane", 0793786290);
        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();
        member2.DisplayInfo();
    }
}


