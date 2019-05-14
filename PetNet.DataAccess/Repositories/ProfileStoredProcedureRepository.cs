using PetNet.DomainModel.Entities;
using PetNet.DomainModel.Interfaces.Repositories;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNet.DataAccess.Repositories
{
    class ProfileStoredProcedureRepository : IProfileRepository
    {
        private SqlConnection _sqlConnection = new SqlConnection(DataAccess.
            Properties.Settings.Default.DbConnectionString);


        public void Create(Profile profile)
        {
            var sqlCommand = new SqlCommand("CreateProfile", _sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("Id", profile.Id);
            sqlCommand.Parameters.AddWithValue("Name", profile.Name);
            sqlCommand.Parameters.AddWithValue("Birthday", profile.Birthday);
            sqlCommand.Parameters.AddWithValue("Address", profile.Address);
            sqlCommand.Parameters.AddWithValue("PhotoUrl", profile.PhotoUrl);
            sqlCommand.Parameters.AddWithValue("Country", profile.Country);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void Delete(Guid post)
        {
            var sqlCommand = new SqlCommand("DeletePost", _sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("Id", post);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        public Profile Read(Guid post)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Profile> ReadAll()
        {
            var sqlCommand = new SqlCommand("GetAllProfile", _sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            var reader = sqlCommand.ExecuteReader();
            var profiles = new List<Profile>(); //function result
            while (reader.Read())
            {
                //
                var currentProfile = new Profile();
                currentProfile.Id = Guid.Parse(reader["Id"].ToString());
                currentProfile.Name = reader["Name"].ToString();
                currentProfile.Birthday = DateTime.Parse(reader["Birthday"].ToString());
                currentProfile.PhotoUrl = reader["PhotoUrl"].ToString();

                profiles.Add(currentProfile);
            }
            _sqlConnection.Close();
            return profiles;
        }

        public void Update(Profile profile)
        {
            var sqlCommand = new SqlCommand("UpdateProfile", _sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("Id", profile.Id);
            sqlCommand.Parameters.AddWithValue("Name", profile.Name);
            sqlCommand.Parameters.AddWithValue("Birthday", profile.Name);
            sqlCommand.Parameters.AddWithValue("Address", profile.Name);
            sqlCommand.Parameters.AddWithValue("PhotoUrl", profile.Name);
            sqlCommand.Parameters.AddWithValue("Country", profile.Name);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
