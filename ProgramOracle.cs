// // See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Types;

using Oracle.ManagedDataAccess.Client;
using static Myfirst.DBOracleUtils;

// // namespace ConnectOracleWithoutClient
// // {
// //     static class Program
// //     {
// //         static void Main(string[] args)
// //         {

// //             OracleConnection conn = DBUtils.GetDBConnection();

// //             Console.WriteLine("Get Connection: " + conn);
// //             try
// //             {
// //                 conn.Open();

// //                 Console.WriteLine(conn.ConnectionString, "Successful Connection");
// //             }
// //             catch (Exception ex)
// //             {
// //                 Console.WriteLine("## ERROR: " + ex.Message);
// //                 Console.Read();
// //                 return;
// //             }

// //             Console.WriteLine("Connection successful!");
// //             OracleCommand cmd = new OracleCommand();
// //             cmd.CommandText = "select * from  THUVIEN";
// //             cmd.Connection = conn;
// //             OracleDataReader dr = cmd.ExecuteReader();
// //             Console.OutputEncoding = Encoding.UTF8; //chuyển sang UTF8

// //             while (dr.Read())
// //             {
// //                 Console.Write(dr["MATHUVIEN"].ToString() + "\n");
// //                 Console.Write(dr["TENTHUVIEN"].ToString() + "\n");
// //             }
// //             conn.Close();
// //             Console.Read();
// //         }
// //     }
// // }

namespace Myfirst;

public class MyOracle
{

    public List<string> ConnectOracle()
    {


        Console.WriteLine("Oracle");


        OracleConnection conn = DBUtils.GetDBConnection();

        Console.WriteLine("Get Connection: " + conn);
        try
        {
            conn.Open();

            Console.WriteLine(conn.ConnectionString, "Successful Connection");
        }
        catch (Exception ex)
        {
            Console.WriteLine("## ERROR: " + ex.Message);
            Console.Read();
        }

        Console.WriteLine("Connection successful!");

        OracleCommand cmd = new OracleCommand();
        cmd.CommandText = "select * from  THUVIEN";
        cmd.Connection = conn;
        OracleDataReader dr = cmd.ExecuteReader();
        Console.OutputEncoding = Encoding.UTF8; //chuyển sang UTF8
        List<string> arr = new List<string>();

        while (dr.Read())
        {

            arr.Add(dr["TENTHUVIEN"].ToString());


        }
        // foreach (string str in arr)
        // {
        //     Console.WriteLine("FROM PROGRAM");
        //     Console.WriteLine(str);
        // }


        conn.Close();
        return arr;




    }
}
public class test
{
    public string Export()
    {
        return "Run From Export";
    }
}
