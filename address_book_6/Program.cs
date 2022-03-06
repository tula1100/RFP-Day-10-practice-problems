using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book_6
{
    internal class Address
    {
        public string firstName, firstName2, firstName3, lastName, lastName2, lastName3, address, address2, address3, city, city2, city3, state, state2, state3, zip, zip2, zip3, phoneNo, phoneNo2, phoneNo3, email, email2, email3;
        public int value;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Address a = new Address();
            ArrayList addbook = new ArrayList();
            ArrayList addbook2 = new ArrayList();
            choice();
            void choice()
            {
                Console.WriteLine("\nEnter 1 to Add Details");
                Console.WriteLine("Enter 2 to Add 2nd Person Details");
                Console.WriteLine("Enter 3 to Edit Existing Details");
                Console.WriteLine("Enter 4 to Delete Existing Detials");
                Console.WriteLine("Enter 5 to Add 3rd Person Details");
                a.value = Convert.ToInt32(Console.ReadLine());
                switch (a.value)
                {
                    case 1:

                        Console.WriteLine("Enter First Name ");
                        a.firstName = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.firstName);
                        Console.WriteLine("Enter Last Name");
                        a.lastName = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.lastName);
                        Console.WriteLine("Enter Address ");
                        a.address = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.address);
                        Console.WriteLine("Enter city");
                        a.city = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.city);
                        Console.WriteLine("Enter state");
                        a.state = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.state);
                        Console.WriteLine("Enter zip");
                        a.zip = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.zip);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo);
                        Console.WriteLine("Enter Email");
                        a.email = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.email);

                        Console.WriteLine("\nGiven Detail Are : \n");
                        Console.WriteLine("First Name = " + addbook[0]);
                        Console.WriteLine("Lastt Name = " + addbook[1]);
                        Console.WriteLine("Address = " + addbook[2]);
                        Console.WriteLine("City = " + addbook[3]);
                        Console.WriteLine("State = " + addbook[4]);
                        Console.WriteLine("Zip = " + addbook[5]);
                        Console.WriteLine("Phone Number = " + addbook[6]);
                        Console.WriteLine("Email = " + addbook[7]);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name ");
                        a.firstName2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.firstName2);
                        Console.WriteLine("Enter Last Name");
                        a.lastName2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.lastName2);
                        Console.WriteLine("Enter Address ");
                        a.address2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.address2);
                        Console.WriteLine("Enter city");
                        a.city = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.city2);
                        Console.WriteLine("Enter state");
                        a.state2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.state2);
                        Console.WriteLine("Enter zip");
                        a.zip2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.zip2);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo2);
                        Console.WriteLine("Enter Email");
                        a.email2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.email2);

                        Console.WriteLine("\nGiven new Details Are : \n");
                        Console.WriteLine("First Name = " + addbook[8]);
                        Console.WriteLine("Lastt Name = " + addbook[9]);
                        Console.WriteLine("Address = " + addbook[10]);
                        Console.WriteLine("City = " + addbook[11]);
                        Console.WriteLine("State = " + addbook[12]);
                        Console.WriteLine("Zip = " + addbook[13]);
                        Console.WriteLine("Phone Number = " + addbook[14]);
                        Console.WriteLine("Email = " + addbook[15]);
                        break;
                    case 3:
                        Console.WriteLine("Enter the First Name and Last Name of that Person");
                        string fname = Convert.ToString(Console.ReadLine());
                        string lname = Convert.ToString(Console.ReadLine());

                        if ((a.firstName == fname) && (a.lastName == lname))
                        {
                            Console.WriteLine("Enter First Name ");
                            a.firstName = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.firstName);
                            Console.WriteLine("Enter Last Name");
                            a.lastName = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.lastName);
                            Console.WriteLine("Enter Address ");
                            a.address = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.address);
                            Console.WriteLine("Enter city");
                            a.city = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.city);
                            Console.WriteLine("Enter state");
                            a.state = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.state);
                            Console.WriteLine("Enter zip");
                            a.zip = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.zip);
                            Console.WriteLine("Enter Phone Number");
                            a.phoneNo = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.phoneNo);
                            Console.WriteLine("Enter Email");
                            a.email = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.email);

                            Console.WriteLine("\nGiven new Details Are : \n");
                            Console.WriteLine("First Name = " + addbook[0]);
                            Console.WriteLine("Lastt Name = " + addbook[1]);
                            Console.WriteLine("Address = " + addbook[2]);
                            Console.WriteLine("City = " + addbook[3]);
                            Console.WriteLine("State = " + addbook[4]);
                            Console.WriteLine("Zip = " + addbook[5]);
                            Console.WriteLine("Phone Number = " + addbook[6]);
                            Console.WriteLine("Email = " + addbook[7]);
                        }
                        else if ((a.firstName2 == fname) && (a.lastName2 == lname))
                        {
                            Console.WriteLine("Enter First Name ");
                            a.firstName2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.firstName2);
                            Console.WriteLine("Enter Last Name");
                            a.lastName2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.lastName2);
                            Console.WriteLine("Enter Address ");
                            a.address2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.address2);
                            Console.WriteLine("Enter city");
                            a.city = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.city2);
                            Console.WriteLine("Enter state");
                            a.state2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.state2);
                            Console.WriteLine("Enter zip");
                            a.zip2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.zip2);
                            Console.WriteLine("Enter Phone Number");
                            a.phoneNo2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.phoneNo2);
                            Console.WriteLine("Enter Email");
                            a.email2 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.email2);

                            Console.WriteLine("\nGiven new Details Are : \n");
                            Console.WriteLine("First Name = " + addbook[8]);
                            Console.WriteLine("Lastt Name = " + addbook[9]);
                            Console.WriteLine("Address = " + addbook[10]);
                            Console.WriteLine("City = " + addbook[11]);
                            Console.WriteLine("State = " + addbook[12]);
                            Console.WriteLine("Zip = " + addbook[13]);
                            Console.WriteLine("Phone Number = " + addbook[14]);
                            Console.WriteLine("Email = " + addbook[15]);

                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name and Last Name of the person to delete his record");
                        string fname1 = Convert.ToString(Console.ReadLine());
                        string lname2 = Convert.ToString(Console.ReadLine());
                        if ((a.firstName == fname1) && (a.lastName == lname2))
                        {
                            addbook.RemoveRange(0, 7);

                            Console.WriteLine("\n Record Deleted: \n");

                        }
                        else if ((a.firstName2 == fname1) && (a.lastName2 == lname2))
                        {
                            addbook.RemoveRange(8, 15);
                            Console.WriteLine("\n Record Deleted: \n");

                        }
                        else if ((a.firstName3 == fname1) && (a.lastName3 == lname2))
                        {
                            addbook2.RemoveRange(0, 7);
                            Console.WriteLine("\n Record Deleted: \n");
                        }
                        break;
                    case 5:

                        Console.WriteLine("Enter First Name ");
                        a.firstName3 = Convert.ToString(Console.ReadLine());
                        addbook2.Add(a.firstName3);
                        Console.WriteLine("Enter Last Name");
                        a.lastName3 = Convert.ToString(Console.ReadLine());
                        addbook2.Add(a.lastName3);
                        Console.WriteLine("Enter Address ");
                        a.address3 = Convert.ToString(Console.ReadLine());
                        addbook2.Add(a.address3);
                        Console.WriteLine("Enter city");
                        a.city3 = Convert.ToString(Console.ReadLine());
                        addbook2.Add(a.city3);
                        Console.WriteLine("Enter state");
                        a.state3 = Convert.ToString(Console.ReadLine());
                        addbook2.Add(a.state3);
                        Console.WriteLine("Enter zip");
                        a.zip3 = Convert.ToString(Console.ReadLine());
                        addbook2.Add(a.zip3);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo3 = Convert.ToString(Console.ReadLine());
                        addbook2.Add(a.phoneNo3);
                        Console.WriteLine("Enter Email");
                        a.email3 = Convert.ToString(Console.ReadLine());
                        addbook2.Add(a.email3);

                        Console.WriteLine("\nGiven Detail Are : \n");
                        Console.WriteLine("First Name = " + addbook2[0]);
                        Console.WriteLine("Lastt Name = " + addbook2[1]);
                        Console.WriteLine("Address = " + addbook2[2]);
                        Console.WriteLine("City = " + addbook2[3]);
                        Console.WriteLine("State = " + addbook2[4]);
                        Console.WriteLine("Zip = " + addbook2[5]);
                        Console.WriteLine("Phone Number = " + addbook2[6]);
                        Console.WriteLine("Email = " + addbook2[7]);
                        break;
                }
                choice();
            }
        }
    }
}
