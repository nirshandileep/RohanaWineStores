using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace RWS.DAL
{
    public class Common
    {
        protected static void AssignDataReaderToEntity(IDataReader dataReader, object entity)
        {
            System.Reflection.PropertyInfo entityProperty;

            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                if (dataReader[i] != DBNull.Value)
                {
                    string fieldName = dataReader.GetName(i);

                    // fieldName is case sensitive, check the entity class members to match up with
                    // the field names returned by the database query for case sensitivity
                    entityProperty = entity.GetType().GetProperty(fieldName);

                    //If we couldnt find the property, do a case insensitive search
                    if (entityProperty == null)
                    {
                        entityProperty = entity.GetType().GetProperty(fieldName,
                                BindingFlags.IgnoreCase |
                                BindingFlags.Public |
                                BindingFlags.Instance);
                    }

                    // If the property exists on this entity:
                    if (entityProperty != null)
                    {
                        // And if the property is writable:
                        if (entityProperty.CanWrite)
                        {
                            // Assign the datareader value to the entity
                            entityProperty.SetValue(entity, dataReader[i], null);

                        }
                    }
                }
            }
        }

        public static List<T> GetDataList<T>(int pid) where T : new()
        {
            using (SqlConnection conn = new SqlConnection(Connection.DBConnectionString))
            {
                string TypeName = typeof(T).Name;

                using (SqlCommand cmd = new SqlCommand("Get" + TypeName + "s", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@" + TypeName + "Id", pid);
                    List<T> entityList = new List<T>();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            T entity = new T();
                            Common.AssignDataReaderToEntity(dr, entity);
                            entityList.Add(entity);
                        }
                    }
                    return entityList;
                }
            }
        }
    
    }
}