using Common;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BCMS_Data
{
    public class TablePricesDataAccess
    {
        /// <summary>
        /// DB'deki Table TablePrices tablosundaki tüm kayıtları alır.
        /// </summary>
        /// <returns>TablePrices data table</returns>
        public static DataTable GetPrices()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                string query = "SELECT * FROM TablePrices";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.HasRows)
                            {
                                dt.Load(read);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(
                            System.Diagnostics.EventLogEntryType.Warning,
                            "An Error occurred while getting prices",
                            "TablePricesDataAccess",
                            ex);
                    }
                }
            }

            return dt;
        }


        /// <summary>
        /// ID'si verilen TablePrices kaydını bulur.
        /// Bulursa tüm alanları ilgili parametrelere yükler.
        /// </summary>
        /// <returns>
        /// TablePrices kaydı varsa true, yoksa false döner.
        /// </returns>
        public static bool Find(  int priceID,  ref int createdByUserID,  ref string description,ref decimal pricePerHour)
        {
            using (SqlConnection connection =new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                string query =
                    "SELECT * FROM TablePrices WHERE PriceID = @PriceID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PriceID", priceID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                createdByUserID = Convert.ToInt32(read["CreatedByUserID"]);

                                description = read["Description"]?.ToString() ?? null;

                                pricePerHour = Convert.ToDecimal(read["pricePerHour"]);

                                return true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(
                            System.Diagnostics.EventLogEntryType.Warning,
                            "An Error occurred while finding price",
                            "TablePricesDataAccess",
                            ex);

                        return false;
                    }
                }
            }

            return false;
        }


        /// <summary>
        /// ID'si verilen TablePrices kaydının DB'de olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="priceID">Kontrol edilecek TablePrices ID</param>
        /// <returns>
        /// Kayıt varsa true, yoksa false döner.
        /// </returns>
        public static bool IsPriceExists(int priceID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                string query ="SELECT Found = 1 FROM TablePrices WHERE PriceID = @PriceID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PriceID", priceID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(
                            System.Diagnostics.EventLogEntryType.Warning,
                            "An Error occurred while checking for price existence",
                            "TablePricesDataAccess",
                            ex);

                        return false;
                    }
                }
            }

            return isFound;
        }


        /// <summary>
        /// Yeni TablePrices kaydı ekler.
        /// </summary>
        /// <returns>
        /// DB tarafından otomatik verilen PriceID.
        /// Hata durumunda -1 döner.
        /// </returns>
        public static int AddNewPrice(    int createdByUserID, string description, decimal pricePerHour)
        {
            int priceID = -1;

            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                string query = @"
                    INSERT INTO TablePrices
                    (
                        CreatedByUserID,
                        Description,
                        pricePerHour
                    )
                    VALUES
                    (
                        @CreatedByUserID,
                        @Description,
                        @pricePerHour
                    );

                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue(
                        "@CreatedByUserID",
                        createdByUserID);

                    if (!string.IsNullOrEmpty(description))
                        cmd.Parameters.AddWithValue("@Description", description);
                    else
                        cmd.Parameters.AddWithValue(
                            "@Description",
                            System.DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@pricePerHour",
                        pricePerHour);

                    try
                    {
                        connection.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null &&
                            int.TryParse(result.ToString(), out int insertedID))
                        {
                            priceID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(
                            System.Diagnostics.EventLogEntryType.Warning,
                            "An Error occurred while adding price",
                            "TablePricesDataAccess",
                            ex);

                        return -1;
                    }
                }
            }

            return priceID;
        }


        /// <summary>
        /// ID'si verilen TablePrices kaydını günceller.
        /// </summary>
        /// <returns>
        /// Update işlemi başarılıysa true, değilse false.
        /// </returns>
        public static bool UpdatePrice(  int priceID,int createdByUserID,string description, decimal pricePerHour)
        {
            int rowsAffected = -1;

            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                string query = @"
                    UPDATE TablePrices
                    SET
                        CreatedByUserID = @CreatedByUserID,
                        Description = @Description,
                        pricePerHour = @pricePerHour
                    WHERE PriceID = @PriceID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PriceID", priceID);

                    cmd.Parameters.AddWithValue(
                        "@CreatedByUserID",
                        createdByUserID);

                    if (!string.IsNullOrEmpty(description))
                        cmd.Parameters.AddWithValue("@Description", description);
                    else
                        cmd.Parameters.AddWithValue(
                            "@Description",
                            System.DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@pricePerHour",
                        pricePerHour);

                    try
                    {
                        connection.Open();

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(
                            System.Diagnostics.EventLogEntryType.Warning,
                            "An Error occurred while updating price",
                            "TablePricesDataAccess",
                            ex);

                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }


        /// <summary>
        /// ID'si verilen TablePrices kaydını siler.
        /// </summary>
        /// <param name="priceID">Silinecek TablePrices ID</param>
        /// <returns>
        /// Delete işlemi başarılıysa true, değilse false.
        /// </returns>
        public static bool DeletePrice(int priceID)
        {
            int rowsAffected = -1;

            using (SqlConnection connection =
                new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                string query =
                    "DELETE TablePrices WHERE PriceID = @PriceID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PriceID", priceID);

                    try
                    {
                        connection.Open();

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(
                            System.Diagnostics.EventLogEntryType.Warning,
                            "An Error occurred while deleting price",
                            "TablePricesDataAccess",
                            ex);

                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
    }
}