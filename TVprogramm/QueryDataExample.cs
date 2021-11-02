using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Tutorial.SqlConn;
using System.Data.Common;
using MySql.Data.MySqlClient;
namespace TVprogramm
{
    class QueryDataExample
    {
        // static void Main(string[] args)
        public List<Stamp> Query()
        {
            // Получить объект Connection подключенный к DB.
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            {
                return QueryEmployee(conn);
            }

            {

                //  return(e.StackTrace);

            }

            {
                // Закрыть соединение.
                conn.Close();
                // Уничтожить объект, освободить ресурс.
                conn.Dispose();
            }
            Console.Read();
        }

        private static List<Stamp> QueryEmployee(MySqlConnection conn)
        {
            string sql = "select id, data, start_time, end_time, TV, TV_show from tvprogramma;";
            string ret = "";
            string id = "";
            string data = "";
            string start_time = "";
            string end_time = "";
            string TV = "";
            string TV_show = "";
            List<Stamp> stl = new List<Stamp>();
            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Индекс (index) столбца Emp_ID в команде SQL.
                        // int empIdIndex = reader.GetOrdinal("country_id"); // 0


                        // long empId = Convert.ToInt64(reader.GetValue(0));

                        // Столбец Emp_No имеет index = 1.
                        //  string empNo = reader.GetString(1);
                        // int Section_nameIndex = reader.GetOrdinal("country");// 2 этапа плдучения информации ordinal возвращает индекс столбца а второй этап использует уже  
                        //  string empName = reader.GetString(Section_nameIndex);

                        // int empid = reader.GetOrdinal("id");

                        //long id_country = Convert.ToInt64(reader.GetValue(0));
                        //string empName = reader.GetString(empNameIndex);

                        // Индекс (index) столбца Mng_Id в команде SQL.
                        // int mngIdIndex = reader.GetOrdinal("last_update");

                        //long? mngId = null;

                        // Проверить значение данного столбца может являться null или нет.
                        //    if (!reader.IsDBNull(mngIdIndex))
                        //   {
                        //       mngId = Convert.ToInt64(reader.GetValue(mngIdIndex));
                        //    }

                        //  Console.WriteLine("empIdIndex:" + empIdIndex);
                        //  ret +="coutry: " +empName;
                        //ret+= " id_country: " + id_country+"\n";
                        //  Console.WriteLine("EmpNo:" + empNo);
                        // Console.WriteLine("EmpName:" + empName);
                        //   Console.WriteLine("MngId:" + mngId);
                        id = Convert.ToString(reader.GetValue(0));
                        data = Convert.ToString(reader.GetValue(0));
                        start_time = Convert.ToString(reader.GetValue(0));
                        end_time = Convert.ToString(reader.GetValue(0));
                        TV = Convert.ToString(reader.GetValue(0));
                        TV_show = Convert.ToString(reader.GetValue(0));
                        Stamp st = new Stamp(id, data,start_time, end_time, TV, TV_show);
                        stl.Add(st);







                    }
                }
            }
            return stl;
        }
    }
}