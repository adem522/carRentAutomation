using System;
using System.Data;
using Npgsql;

class vtIslemleri
{
    NpgsqlConnection connection1 = new NpgsqlConnection("Server=localhost; Port=5432; Database=rapor2; User Id=postgres; Password=sifre1234");
    public void executeSql(string sql)
    {
        NpgsqlCommand dbcmd = connection1.CreateCommand();
        try
        {
            connection1.Open();           
            dbcmd.CommandText = sql;
            dbcmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
    }
    public DataSet executeSqlReturnDataSet(string sql)
    {
        DataSet dataSet = new DataSet();
        NpgsqlCommand dbcmd = connection1.CreateCommand();
        try
        {
            connection1.Open();
            dbcmd.CommandText = sql;
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataSet);

        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return dataSet;
    }
    public DataSet listele(string table)
    {
        DataSet dataSet = new DataSet();
        try
        {
            connection1.Open();
            string sql = String.Format("select * from public.\"{0}\"", table);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataSet);
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return dataSet;
    }
    public string oneDataReturnWithWhere(string table, string column ,string where, int whereData)
    {
        string data1;
        DataTable dataTable= new DataTable();
        try
        {
            connection1.Open();
            string sql = String.Format("select {3} from public.\"{0}\" where {1}={2} ", table, where, whereData,column);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataTable);
            data1 = dataTable.Rows[0].ItemArray[0].ToString();
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return data1;
    }
    public string oneDataReturnWithWhereString(string table, string column, string where, string whereData)
    {
        string data1;
        DataTable dataTable = new DataTable();
        try
        {
            connection1.Open();
            string sql = String.Format("select {3} from public.\"{0}\" where {1}='{2}' ", table, where, whereData, column);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataTable);
            data1 = dataTable.Rows[0].ItemArray[0].ToString();
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return data1;
    }
    public DataSet aramaString(string table,string where,string whereData)
    {
        DataSet dataSet = new DataSet();
        try
        {
            connection1.Open();
            string sql = String.Format("select * from public.\"{0}\" where {1}='{2}' ", table,where,whereData);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataSet);
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return dataSet;
    }
    public DataSet aramaInt(string table, string where, int whereData)
    {
        DataSet dataSet = new DataSet();
        try
        {
            connection1.Open();
            string sql = String.Format("select * from public.\"{0}\" where {1}={2} ", table, where, whereData);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataSet);
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return dataSet;
    }
    public void guncelleString(string table, string column, string data, int id)
    {
        try
        {
            connection1.Open();
            string sql = String.Format("update public.\"{0}\"set {1}='{2}' where id={3}", table, column, data, id);
            NpgsqlCommand command1 = new NpgsqlCommand(sql, connection1);
            command1.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
    }
    public void guncelleInt(string table, string column, int data, int id)
    {
        try
        {
            connection1.Open();
            string sql = String.Format("update public.\"{0}\"set {1}={2} where id={3}", table, column, data, id);
            NpgsqlCommand command1 = new NpgsqlCommand(sql, connection1);
            command1.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
    }
    public void deleteColumn(string table, int id)
    {
        try
        {
            connection1.Open();
            string sql = String.Format("delete from public.\"{0}\" where id={1}", table, id);
            NpgsqlCommand command1 = new NpgsqlCommand(sql, connection1);
            command1.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
    }
    public DataTable comboFill(string table, string column)
    {
        DataTable dataTable = new DataTable();
        try
        {
            connection1.Open();
            string sql = String.Format("select {0} from public.\"{1}\" ORDER BY {0} ", column, table);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataTable);
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return dataTable;
    }
    public DataTable comboFillWithWhere(string table, string column, string where, string whereData)
    {
        DataTable dataTable = new DataTable();
        try
        {
            connection1.Open();
            string sql = String.Format("select {0} from public.\"{1}\" where {2}='{3}'", column, table, where, whereData);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataTable);
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return dataTable;
    }
    public DataTable comboFillWith2Where(string table, string column, string where, string whereData, string where2, string whereData2)
    {
        DataTable dataTable = new DataTable();
        try
        {
            connection1.Open();
            string sql = String.Format("select {0} from public.\"{1}\" where {2}='{3}' and {4}='{5}'", column, table, where, whereData, where2, whereData2);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataTable);
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return dataTable;
    }
    public DataTable comboFillWith3Where(string table, string column, string where, string whereData, string where2, string whereData2,string where3, string whereData3)
    {
        DataTable dataTable = new DataTable();
        try
        {
            connection1.Open();
            string sql = String.Format("select {0} from public.\"{1}\" where {2}='{3}' and {4}='{5}' and {6}='{7}'", column, table, where, whereData, where2, whereData2,where3,whereData3);
            NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, connection1);
            add.Fill(dataTable);
        }
        catch (Exception ex)
        {
            throw;
        }
        connection1.Close();
        return dataTable;
    }
}