using PetNet.DomainModel.Entities;
using PetNet.DomainModel.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetNet.DataAccess.Repositories
{
    class GroupStoredProcedureRepository : IGroupRepository
    {
        private SqlConnection _sqlConnection = new SqlConnection(DataAccess.
        Properties.Settings.Default.DbConnectionString);

        public void Create(Group group)
        {
            var sqlCommand = new SqlCommand("CreateGroups", _sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("Name", group.Name);
            sqlCommand.Parameters.AddWithValue("Subject", group.Subject);
        }

        public void Delete(Guid groupId)
        {
            var sqlCommand = new SqlCommand("DeleteGroup", _sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("GroupId", groupId);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public Profile Read(Guid group)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Group> ReadAll()
        {
            var sqlCommand = new SqlCommand("GetAllGroup", _sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            var reader = sqlCommand.ExecuteReader();
            var groups = new List<Group>(); 

            while (reader.Read())
            {
                var currentGroup = new Group();
                currentGroup.Name = reader["Name"].ToString();
                currentGroup.Subject = reader["Subject"].ToString();

                groups.Add(currentGroup);
            }
            _sqlConnection.Close();
            return groups;
        }

        public void Update(Group group)
        {
            var sqlCommand = new SqlCommand("UpdateGroup", _sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            _sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("Name", group.Name);
            sqlCommand.Parameters.AddWithValue("Subject", group.Subject);
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
