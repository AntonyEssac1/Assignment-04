namespace Session_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Book book = new Book();


            #region // Question 1

            //book.pass                  --->  // not found because it private Field

            //Console.WriteLine(book);

            #endregion

            #region // Question 2

            book.copiesInStock = 15;

            Console.WriteLine(book.copiesInStock);   //  ---->Does it compile? [ Yes ]
            //  Whay ? 

            // Because it is declared as internal, which allows access

            // from any class in the same project (assembly).
            #endregion



        }
    }
}
