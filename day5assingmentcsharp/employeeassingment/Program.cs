using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeassingment
{
    class employee
    {
        private int id;
        private string name, designation, location;
        int salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Location { get => location; set => location = value; }
        public int Salary { get => salary; set => salary = value; }

      
    }
    class employeelists1
    {
        
        static void Main(string[] args)
        {
            List<employee> data = new List<employee>();
            data.Add(new employee { Id = 1, Name = "Srini0", Designation = "Trainee", Location = "Chennai", Salary = 40000 });
            data.Add(new employee { Id = 2, Name = "Messi", Designation = "Student", Location = "DElhi", Salary = 20000 });
            data.Add(new employee { Id = 3, Name = "Kroos", Designation = "Admin", Location = "Europe", Salary = 30000 });
            data.Add(new employee { Id = 4, Name = "Torres", Designation = "Teacher", Location = "Russia", Salary = 60000 });

            foreach (employee emp in data)
            {
                Console.WriteLine("\n ID:"+emp.Id);
                Console.WriteLine("\n Name:"+emp.Name);
                Console.WriteLine("\n Designation:"+emp.Designation);
                Console.WriteLine("\n Location:"+emp.Location);
                Console.WriteLine("\n Salary:"+emp.Salary);
            }
            String y;
            
            employee em = new employee();
            int a;
        l1:
            {
                Console.WriteLine("What do you want to do?\n 1-Add a new entry\n 2-Delete a entry 3-Edit a entry 4-Display the data");

                a = Convert.ToInt32(Console.ReadLine());
                
                

                switch (a)
                {
                    case 1:
                        Console.WriteLine("Enter the id,name,location,designation,salary one by one");
                        data.Add(new employee { Id = Convert.ToInt32(Console.ReadLine()), Name = Console.ReadLine(), Designation = Console.ReadLine(), Location = Console.ReadLine(), Salary = Convert.ToInt32(Console.ReadLine()) });
                        foreach (employee emp in data)
                        {
                            Console.WriteLine("\n ID:" + emp.Id);
                            Console.WriteLine("\n Name:" + emp.Name);
                            Console.WriteLine("\n Designation:" + emp.Designation);
                            Console.WriteLine("\n Location:" + emp.Location);
                            Console.WriteLine("\n Salary:" + emp.Salary);
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter the id you want to delete");
                        int c = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            foreach (employee item in data)
                            {
                                if (item.Id == c)
                                {

                                    data.Remove(item);

                                    foreach (employee emp in data)
                                    {
                                        Console.WriteLine("\n ID:" + emp.Id);
                                        Console.WriteLine("\n Name:" + emp.Name);
                                        Console.WriteLine("\n Designation:" + emp.Designation);
                                        Console.WriteLine("\n Location:" + emp.Location);
                                        Console.WriteLine("\n Salary:" + emp.Salary);
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write(e);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the element(by id) you want to edit");
                        int b = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            foreach (employee item1 in data)
                            {
                                if (item1.Id == b)
                                {
                                    data.Remove(item1);
                                    //    Console.WriteLine("Enter the field you wanted to edit \n 2-name\n 3-designation\n 4-location\n 5-salary");
                                    //    int k = Convert.ToInt32(Console.ReadLine());
                                    //    if (k == 2)
                                    //    {

                                    //        data.Insert(b - 1, new employee { Id = 2, Name = Console.ReadLine(), Designation = "Student", Location = "DElhi", Salary = 20000 });
                                    //    }
                                    //    else if(k==3)
                                    //    {
                                    //        data.Insert(b - 1, new employee { Id = 2, Name = Console.ReadLine(), Designation = "Student", Location = "DElhi", Salary = 20000 });
                                    //    }

                                    //    foreach (employee emp in data)
                                    //    {
                                    //        Console.WriteLine("\n ID:" + emp.Id);
                                    //        Console.WriteLine("\n Name:" + emp.Name);
                                    //        Console.WriteLine("\n Designation:" + emp.Designation);
                                    //        Console.WriteLine("\n Location:" + emp.Location);
                                    //        Console.WriteLine("\n Salary:" + emp.Salary);
                                    //    }
                                    //}
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write(e);
                        }
                        Console.WriteLine("Enter the updated id,name,location,designation,salary one by one");
                        data.Add(new employee { Id = Convert.ToInt32(Console.ReadLine()), Name = Console.ReadLine(), Designation = Console.ReadLine(), Location = Console.ReadLine(), Salary = Convert.ToInt32(Console.ReadLine()) });
                        foreach (employee emp in data)
                        {
                            Console.WriteLine("\n ID:" + emp.Id);
                            Console.WriteLine("\n Name:" + emp.Name);
                            Console.WriteLine("\n Designation:" + emp.Designation);
                            Console.WriteLine("\n Location:" + emp.Location);
                            Console.WriteLine("\n Salary:" + emp.Salary);
                        }

                        break;
                    case 4:
                        foreach (employee emp in data)
                        {
                            Console.WriteLine("\n ID:" + emp.Id);
                            Console.WriteLine("\n Name:" + emp.Name);
                            Console.WriteLine("\n Designation:" + emp.Designation);
                            Console.WriteLine("\n Location:" + emp.Location);
                            Console.WriteLine("\n Salary:" + emp.Salary);
                        }
                        break;

                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }


            }
            Console.WriteLine("Enter y if u want to continue");
            y=Console.ReadLine();
            if (y == "Y" || y == "y")
            {
                goto l1;
            }
            else
            {
                Console.WriteLine("Bye!");
            }
            }



        }
    }
    

