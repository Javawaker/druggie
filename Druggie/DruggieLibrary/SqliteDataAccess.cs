using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace DruggieLibrary
{
    static public class SqliteDataAccess
    {
        static private string sqlComm;
        public static string LoadConnectionString(string id = "Default")
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<UserModeModel> LoadUserModes()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModeModel>("select * from UserMode", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<DrugModelConstructed> LoadDrugConstructed()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.name, d.manufacturer_name, m.Country_name as Manufacturer_country, d.inn " +
                    "FROM Drug d, Manufacturer m " +
                    "WHERE d.manufacturer_name = m.name " +
                    "GROUP BY d.name";

                var output = cnn.Query<DrugModelConstructed>(sqlComm, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<DrugModelConstructed> LoadDrugConstructedByActiveIngredient(string activeIngredient)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.name, d.manufacturer_name, m.Country_name as Manufacturer_country, d.inn " +
                    "FROM Drug d, Manufacturer m INNER JOIN DrugActiveIngredient da on d.name = da.drug_name " +
                    "WHERE d.manufacturer_name = m.name AND da.activeIngredient_name = @activeIngredient " +
                    "GROUP BY d.name";

                var parameters = new Dictionary<string, object>() { ["activeIngredient"] = activeIngredient };
                var output = cnn.Query<DrugModelConstructed>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }

        public static List<DrugModelConstructed> LoadDrugConstructedByIndication(string indication)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.name, d.manufacturer_name, m.Country_name as Manufacturer_country, d.inn " +
                    "FROM Drug d, Manufacturer m INNER JOIN DrugIndication di on d.name = di.drug_name " +
                    "WHERE d.manufacturer_name = m.name AND di.indication_name = @indication " +
                    "GROUP BY d.name";

                var parameters = new Dictionary<string, object>() { ["indication"] = indication };
                var output = cnn.Query<DrugModelConstructed>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }

        public static List<DrugModelConstructed> LoadDrugConstructedByClass(string drugClass)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.name, d.manufacturer_name, m.Country_name as Manufacturer_country, d.inn " +
                    "FROM Drug d, Manufacturer m " +
                    "WHERE d.manufacturer_name = m.name AND d.drugClass_name = @drugClass " +
                    "GROUP BY d.name";

                var parameters = new Dictionary<string, object>() { ["drugclass"] = drugClass };
                var output = cnn.Query<DrugModelConstructed>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }

        public static List<DrugModelConstructed> LoadDrugConstructedByManufacturer(string manufacturer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.name, d.manufacturer_name, m.Country_name as Manufacturer_country, d.inn " +
                    "FROM Drug d INNER JOIN Manufacturer m ON d.manufacturer_name = m.name " +
                    "WHERE d.manufacturer_name LIKE @manufacturer " +
                    "GROUP BY d.name";

                var parameters = new Dictionary<string, object>() { ["manufacturer"] = manufacturer};
                var output = cnn.Query<DrugModelConstructed>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }

        public static List<ActiveIngredientModel> LoadDrugActiveIngredients(string drugName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT dai.activeIngredient_name as 'name' " +
                    "FROM DrugActiveIngredient dai " +
                    "WHERE dai.drug_name = @drugName " +
                    "GROUP BY dai.activeIngredient_name";

                var parameters = new Dictionary<string, object>() { ["drugName"] = drugName };
                var output = cnn.Query<ActiveIngredientModel>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }

        public static string LoadDrugClass(string drugName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.drugClass_name " +
                    "FROM Drug d " +
                    "WHERE d.name = @drugName " +
                    "GROUP BY d.drugClass_name";

                var parameters = new Dictionary<string, object>() { ["drugName"] = drugName };
                var output = cnn.Query<string>(sqlComm, new DynamicParameters(parameters));
                return output.First();
            }
        }

        public static List<ActiveIngredientModel> LoadDrugIndications(string drugName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT di.indication_name as 'name'" +
                    "FROM DrugIndication di " +
                    "WHERE di.drug_name = @drugName " +
                    "GROUP BY di.indication_name";

                var parameters = new Dictionary<string, object>() { ["drugName"] = drugName };
                var output = cnn.Query<ActiveIngredientModel>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }

        public static List<UserDrugModel> LoadUserDrug(string username, string drugName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT * " +
                    "FROM UserDrug ud " +
                    "WHERE ud.user_username = @username AND ud.drug_name = @drugName";

                var parameters = new Dictionary<string, object>()
                {
                    ["username"] = username,
                    ["drugName"] = drugName
                };
                var output = cnn.Query<UserDrugModel>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }
        
        public static List<DrugModelConstructed> LoadDrugConstructedByName(string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.name, d.manufacturer_name, m.Country_name as Manufacturer_country, d.inn " +
                    "FROM Drug d INNER JOIN Manufacturer m ON d.manufacturer_name = m.name " +
                    "WHERE d.name LIKE @name " +
                    "GROUP BY d.name";

                var parameters = new Dictionary<string, object>() { ["name"] = $"%{name}%" };
                var output = cnn.Query<DrugModelConstructed>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }

        public static List<DrugModelConstructed> LoadDrugConstructedByUserDrugs(string username)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.name, d.manufacturer_name, m.Country_name as Manufacturer_country, d.inn, ud.quantity " +
                    "FROM Drug d INNER JOIN Manufacturer m ON d.manufacturer_name = m.name INNER JOIN UserDrug ud ON d.name = ud.drug_name " +
                    "WHERE ud.user_username = @username " +
                    "GROUP BY d.name";

                var parameters = new Dictionary<string, object>() { ["username"] = username };
                var output = cnn.Query<DrugModelConstructed>(sqlComm, new DynamicParameters(parameters));
                return output.ToList();
            }
        }
        public static List<CountryModel> LoadCountries()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT * FROM Country " +
                    "GROUP BY Country.name";

                var output = cnn.Query<CountryModel>(sqlComm, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ManufacturerModel> LoadManufacturers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT * FROM Manufacturer " +
                    "GROUP BY Manufacturer.name";

                var output = cnn.Query<ManufacturerModel>(sqlComm, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ActiveIngredientModel> LoadActiveIngredients()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT * FROM ActiveIngredient " +
                    "GROUP BY ActiveIngredient.name";

                var output = cnn.Query<ActiveIngredientModel>(sqlComm, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<IndicationModel> LoadIndications()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT * FROM Indication " +
                    "GROUP BY Indication.name";

                var output = cnn.Query<IndicationModel>(sqlComm, new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ClassModel> LoadClasses()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT * FROM Class " +
                    "GROUP BY Class.name";

                var output = cnn.Query<ClassModel>(sqlComm, new DynamicParameters());
                return output.ToList();
            }
        }

        public static string LoadInstruction(string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "SELECT d.instruction FROM Drug d WHERE d.name = @name";

                var parameters = new Dictionary<string, object>() { ["name"] = name };
                var output = cnn.Query<String>(sqlComm, new DynamicParameters(parameters));
                return output.First();
            }
        }
        public static void SaveAndUpdateUsers(List<UserModel> users)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "UPDATE User " +
                   $"SET userMode_name = @UserMode_name " +
                   $"WHERE username = @Username";
                foreach (var user in users)
                    cnn.Execute(sqlComm, user);
            }
        }

        public static void AddUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))//это подключение к базе
            {
                sqlComm = "INSERT INTO User (username, UserMode_name, hash, salt) values (@Username, @UserMode_name, @Hash, @Salt)";//sql команда, поля в values берутся из объекта
                cnn.Execute(sqlComm, user);//выполнить команду, передав объект user. Values будут браться отсюда
            }
        }

        public static void AddCountry(CountryModel country)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlComm = "INSERT INTO Country (Name)" +
                    "values (@Name)";
                cnn.Execute(sqlComm, country);
            }
        }

        public static void AddClass(ClassModel classModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlComm = "INSERT INTO Class (Name)" +
                    "values (@Name)";
                cnn.Execute(sqlComm, classModel);
            }
        }

        public static void AddManufacturer(ManufacturerModel manufacturer)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlComm = "INSERT INTO Manufacturer (Name, country_name)" +
                    "values (@Name, @Country_name)";
                cnn.Execute(sqlComm, manufacturer);
            }
        }

        public static void AddActiveIngredient(ActiveIngredientModel activeIngredient)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlComm = "INSERT INTO ActiveIngredient (Name)" +
                    "values (@Name)";
                cnn.Execute(sqlComm, activeIngredient);
            }
        }

        public static void AddIndication(IndicationModel indication)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlComm = "INSERT INTO Indication (Name)" +
                    "values (@Name)";
                cnn.Execute(sqlComm, indication);
            }
        }

        public static void AddDrugActiveIngredient(string drug_name, string activeIngredient_name)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                var cmd = new SQLiteCommand(cnn);
                cmd.CommandText = "INSERT INTO DrugActiveIngredient(drug_name, activeIngredient_name)" +
                    "VALUES(@drug_name, @activeIngredient_name)";

                cmd.Parameters.AddWithValue("@drug_name", drug_name);
                cmd.Parameters.AddWithValue("@activeIngredient_name", activeIngredient_name);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void AddDrugIndication(string drug_name, string indication_name)
        {
            using (var cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                var cmd = new SQLiteCommand(cnn);
                cmd.CommandText = "INSERT INTO DrugIndication(drug_name, indication_name)" +
                    "VALUES(@drug_name, @indication_name)";

                cmd.Parameters.AddWithValue("@drug_name", drug_name);
                cmd.Parameters.AddWithValue("@indication_name", indication_name);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void UpdateUserDrug(UserDrugModel userDrug)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "UPDATE UserDrug " +
                   $"SET quantity = @Quantity " +
                   $"WHERE user_username = @User_username AND drug_name = @Drug_name";
                cnn.Execute(sqlComm, userDrug);
            }
        }
        public static void AddUserDrug(UserDrugModel drug)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlComm = "INSERT INTO UserDrug (user_username, drug_name, quantity) " +
                    "values (@User_username, @Drug_name, @Quantity)";
                cnn.Execute(sqlComm, drug);
            }
        }

        public static void AddDrug(DrugModel drug)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlComm = "INSERT INTO Drug (name, drugClass_name, manufacturer_name, inn, instruction)" +
                    "values (@Name, @DrugClass_name, @Manufacturer_name, @Inn, @Instruction)";
                cnn.Execute(sqlComm, drug);
            }
        }
        public static void DeleteDrug(DrugModelConstructed drug)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlComm = "DELETE FROM UserDrug WHERE drug_name = @Name; " +
                    "DELETE FROM DrugActiveIngredient WHERE drug_name = @Name; " +
                    "DELETE FROM DrugIndication WHERE drug_name = @Name; " +
                    "DELETE FROM Drug WHERE name = @Name; ";

                cnn.Execute(sqlComm, drug);
            }
        }

        public static void DeleteUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = "DELETE FROM UserDrug WHERE user_username = @UserName; " +
                    "DELETE FROM User WHERE username = @UserName";
                cnn.Execute(sqlComm, user);
            }
        }

        public static void DeleteUserDrug(UserDrugModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                sqlComm = $"DELETE FROM UserDrug WHERE drug_name = @Drug_name";
                cnn.Execute(sqlComm, user);
            }
        }
    }
}