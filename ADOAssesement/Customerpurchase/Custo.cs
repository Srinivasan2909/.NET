using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Customerpurchase
{
    class Custo
    {
        private int customer_id;
        private int product_id, no_of_products, total_bill_amount;
        private string name, supplier_name;
        private int supplier_id, price;
        private string location;







        public int Customer_id { get => customer_id; set => customer_id = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public int No_of_products { get => no_of_products; set => no_of_products = value; }
        public int Total_bill_amount { get => total_bill_amount; set => total_bill_amount = value; }
        public string Name { get => name; set => name = value; }
        public string Supplier_name { get => supplier_name; set => supplier_name = value; }
        public int Supplier_id { get => supplier_id; set => supplier_id = value; }
        public int Price { get => price; set => price = value; }
        public string Location { get => location; set => location = value; }

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

       


        public void dispcustomer()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=IN5CG9214YQ9;database=assingment;integrated security=true";


            cmd.CommandText = "select * from customer";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t {rdr[1]}\t {rdr[2]}\t {rdr[3]}\t {rdr[4]}\t {rdr[5]} ");
            }
            con.Close();
            Console.ReadLine();

        }
        public void insertcustomer()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=IN5CG9214YQ9;database=assingment;integrated security=true";
            Console.WriteLine("Enter the name");
            Custo custo = new Custo();
            custo.Name = Console.ReadLine();

            Console.WriteLine("Enter the product id you want to choose\n 1-Phone\n 2-Televsion \n 3-Shoes");
            custo.Product_id = int.Parse(Console.ReadLine());
            Console.WriteLine("The suppliers available for the product you have choosen are:");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", custo.Product_id);
            cmd.CommandText = "sp_sup";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("SupplierID:\t SupplierName:\t Location:\t Price:\t");
                Console.WriteLine($"{rdr[0]} \t {rdr[1]}\t  {rdr[3]}\t {rdr[4]}\n  ");
            }
            con.Close();


            Console.WriteLine("Choose the supplier you want by selecting the supplierID");
            custo.Supplier_id = int.Parse(Console.ReadLine());
            Console.WriteLine("The supplier you have choosed is:");
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@supid", custo.Supplier_id);
            cmd1.CommandText = "sp_disp_supplier";
            cmd1.Connection = con;
            con.Open();
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {
                Console.WriteLine("SupplierName:\t Location:\t Price:\t");
                Console.WriteLine($" {rdr1[1]}\t {rdr1[3]}\t   {rdr1[4]}\n  ");
            }
            con.Close();

            Console.WriteLine("Enter the quantity you want");
            custo.No_of_products = int.Parse(Console.ReadLine());
            SqlCommand cmd4 = new SqlCommand();
            // cmd4.CommandType = System.Data.CommandType.StoredProcedure;
            cmd4.Parameters.AddWithValue("@id", custo.Supplier_id);
            cmd4.CommandText = "select price from supplier where supplier_id=@id";
            cmd4.Connection = con;
            con.Open();
            var pp = cmd4.ExecuteScalar();
            int price = (int)pp;
            con.Close();
            

            
            custo.Total_bill_amount = custo.No_of_products * price;

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandType = System.Data.CommandType.StoredProcedure;
            cmd3.CommandText = "add1";
            cmd3.Connection = con;

            cmd3.Parameters.AddWithValue("@inserted_name", custo.Name);
            cmd3.Parameters.AddWithValue("@inserted_id", custo.Product_id);
            cmd3.Parameters.AddWithValue("@noofproducts", custo.No_of_products);
            cmd3.Parameters.AddWithValue("@amt", custo.Total_bill_amount);
            cmd3.Parameters.AddWithValue("@sid", custo.Supplier_id);
            con.Open();
            int a = cmd3.ExecuteNonQuery();
            con.Close();

            SqlCommand cmd5 = new SqlCommand();
            cmd5.Parameters.AddWithValue("@name", custo.name);
            cmd5.CommandText = "select customer_id from customer where name=@name";
            cmd5.Connection = con;
            con.Open();
            object id = cmd5.ExecuteScalar();
            int cid = (int)id;
            con.Close();

            Console.WriteLine("Your bill details are:");
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;
            cmd2.CommandText = "disp11";
            cmd2.Parameters.AddWithValue("@id", cid);
            cmd2.Connection = con;
            con.Open();
            object rdr2 = cmd2.ExecuteScalar();
            double total = (double)rdr2;
            Console.WriteLine($"Total Bill = {total}");
            con.Close();

            Console.WriteLine("Your shopping today was:\n");
            SqlCommand cmd6 = new SqlCommand();
            cmd6.CommandType = System.Data.CommandType.StoredProcedure;
            cmd6.CommandText = "sp_dis";
            cmd6.Parameters.AddWithValue("@cid", cid);
            cmd6.Connection = con;
            con.Open(); 
            SqlDataReader rdr6 = cmd6.ExecuteReader();
            while (rdr6.Read())
            {
                Console.WriteLine($" CustomerID:{rdr6[0]}\t Name:{rdr6[1]}\t ProductID:{rdr6[2]}\t No.of.Products:{rdr6[3]}\t Total Bill Amount:{rdr6[4]}\t SupplierId:{rdr6[5]} ");
            }
            con.Close();
            Console.ReadLine();



        }

    }
}