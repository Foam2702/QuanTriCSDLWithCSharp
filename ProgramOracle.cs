// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Types;

using Oracle.ManagedDataAccess.Client;
using static Myfirst.DBOracleUtils;

// namespace ConnectOracleWithoutClient
// {
//     static class Program
//     {
//         static void Main(string[] args)
//         {

//             OracleConnection conn = DBUtils.GetDBConnection();

//             Console.WriteLine("Get Connection: " + conn);
//             try
//             {
//                 conn.Open();

//                 Console.WriteLine(conn.ConnectionString, "Successful Connection");
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("## ERROR: " + ex.Message);
//                 Console.Read();
//                 return;
//             }

//             Console.WriteLine("Connection successful!");
//             OracleCommand cmd = new OracleCommand();
//             cmd.CommandText = "select * from  THUVIEN";
//             cmd.Connection = conn;
//             OracleDataReader dr = cmd.ExecuteReader();
//             Console.OutputEncoding = Encoding.UTF8; //chuyển sang UTF8

//             while (dr.Read())
//             {
//                 Console.Write(dr["MATHUVIEN"].ToString() + "\n");
//                 Console.Write(dr["TENTHUVIEN"].ToString() + "\n");
//             }
//             conn.Close();
//             Console.Read();
//         }
//     }
// }

namespace Myfirst;

static class Oracle
{
    public static string[] ConnectOracle()
    {

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
        int count = 0;
        while (dr.Read())
        {
            count++;
        }
        string[] arr = new string[count];
        for (int i = 0; i < count; i++)
        {
            dr.Read();
            arr[i] = dr["TENTHUVIEN"].ToString();
        }

        return arr;
        conn.Close();
        Console.Read();
    }
}
