using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10
{
    internal class Program
    {
        static void display()
        {

            Console.WriteLine("# +=========================================================================================================================================================+ #");
            Console.WriteLine("# |.........................................................................................................................................................| #");
            Console.WriteLine("# |...............................................................SCHOOL MANAGMENT SYSTEM...................................................................| #");
            Console.WriteLine("# |.........................................................................................................................................................| #");
            Console.WriteLine("# +=========================================================================================================================================================+ #");

        }
        static void Main(string[] args)
        {
            int staffcount = 0;
            int studentcount = 0;
            string principalusername = "adnan";
            string principalpassword = "12345";
            string[] teacherusername = new string[100];
            string[] teacherpassword = new string[100];
            string[] studentusername=new string[100];
            string[] studentpassword=new string[100];

            while (true)
            {
                Console.Clear();
                display();
                Console.WriteLine("1.LOGIN ");
                Console.WriteLine("2.Exit ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    while(true)
                    {
                        Console.Clear();
                        display();

                        string inputUsername, inputPassword;

                        Console.WriteLine("Enter Username:");
                        Console.WriteLine("__________________");

                        inputUsername = Console.ReadLine();


                        Console.WriteLine("Enter Password:");
                        Console.WriteLine("__________________");

                        inputPassword = Console.ReadLine();
                        string role = "";
                        if (CheckLoginIdentity(inputUsername, inputPassword, principalusername, principalpassword, ref role, teacherusername, teacherpassword, staffcount, studentusername, studentpassword, studentcount))
                        {
                            if (role == "principal")
                            {
                                Console.WriteLine("PRINCIPAL LOGIN SUCCESFULLY");
                                Console.ReadKey();
                            }
                            else if (role == "staff")
                            {
                                Console.WriteLine("TEACEHR LOGIN SUCCESSFULL :");
                                Console.ReadKey();
                            }
                            else if (role == "student")
                            {
                                Console.WriteLine("STUDENT LOGIN SUCCESFYLLY :");
                                Console.ReadKey();
                            }
                        }
                        else
                        {

                            Console.WriteLine("Invalid login!");
                            Console.ReadKey();

                        }

                    }
                   
                }

                else if (option == "2")
                {
                }
                else
                {
                    Console.WriteLine("TRY AGAIN!  Wrong Option ");
                    Console.ReadKey();
                }

            }

        }
       static bool CheckLoginIdentity(string inputUsername,string inputPassword, string principalUsername, string principalPassword, ref string role, string[] staffUsername, string[] staffPassword, int staffCount, string[] studentUsername,string[] studentPassword,int studentCount)
               
       {
            if (inputUsername == principalUsername && inputPassword == principalPassword)
            {
                role = "principal";
                return true;
            }

            for (int i = 0; i < staffCount; i++)
            {
                if (staffUsername[i] == inputUsername && staffPassword[i] == inputPassword)
                {
                    role = "staff";
                    return true;
                }
            }

            for (int i = 0; i < studentCount; i++)
            {
                if (studentUsername[i] == inputUsername && studentPassword[i] == inputPassword)
                {
                    role = "student";
                    return true;
                }
            }

            return false;
       }

    }
}
