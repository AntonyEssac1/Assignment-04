using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //book.copiesInStock = 15;

            //Console.WriteLine(book.copiesInStock);   //  ---->Does it compile? [ Yes ]
            //  Whay ? 

            // Because it is declared as internal, which allows access

            // from any class in the same project (assembly).
            #endregion

            #region // Question 3

            // book.Title = "Tony";

            //Console.WriteLine(book.Title);




            #endregion

            #region // Question 4

            //book.gener = Gener.Science;
            //Console.WriteLine(book.gener);
            #endregion

            #region // Question 5

            /*Using the Genre enum above, print the underlying int value ofGenre.Fiction,
            Genre.NonFiction, and Genre.Science by casting each to int.*/


            //Console.WriteLine((int)Gener.Science);

            #endregion

            #region // Question 6

            // Given int genreNumber = 1;, cast it into a Genre value and print the result.

            //int genreNumber = 1;
            //Gener gener = (Gener)genreNumber;
            //Console.WriteLine(gener);

            #endregion

            #region // Question 7

            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.

            //Gener gener = Gener.Fiction;
            //string genderName = gener.ToString();
            //Console.WriteLine(genderName);
            //Console.WriteLine(genderName is string); //  ---> For test
            #endregion

            #region // Question 8

            /*Given string genreText = "Science";, convert it into a Genre value 
            using Enum.Parse() and print the result.*/

            //string genreText = "Science";
            //Gener genre = Enum.Parse<Gener>(genreText);
            //Console.WriteLine(genre);
            //Console.WriteLine(genre.GetType());
            #endregion

            #region  // Question 9

            /*Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to
            attempt the conversion. Print "Unknown genre" if it fails.*/

            string genreText = "Mystery";
            if (Enum.TryParse(genreText , out Gener gener))
            {
                Console.WriteLine(gener);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }


            #endregion


        }
    }
}
