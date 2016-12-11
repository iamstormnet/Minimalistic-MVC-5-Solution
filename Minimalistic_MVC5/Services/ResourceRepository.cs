using Minimalistic_MVC5.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Minimalistic_MVC5.Services
{
    public class ResourceRepository : Repository<Resource>
    {
        AdoNetContext _connection;

        public ResourceRepository(AdoNetContext context) : base(context)
        {
            _connection = context;
        }

        //public void Create(Employee employee)
        //{
        //    using (var command = _connection.CreateCommand())
        //    {
        //        command.CommandText = @"INSERT INTO Employees (Name) VALUES(@name)";
        //        command.AddParameter("name", employee.Name);
        //        command.ExecuteNonQuery();
        //    }

        //    //todo: Get identity. Depends on the db engine.
        //}


        public void Create(Resource resource)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Employees (Name) VALUES(@name);SELECT SCOPE_IDENTITY();";
                command.AddParameter("name", resource.Name);

                decimal employeeId = (decimal)command.ExecuteScalar();
                resource.Id = (int)employeeId;
            }
        }

        public void Update(Resource resource)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"UPDATE Resource SET Name = @name WHERE Id = @id";
                command.AddParameter("name", resource.Name);
                command.AddParameter("id", resource.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"DELETE FROM Employees WHERE Id = @id";
                command.AddParameter("id", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Resource> FindUsers(string name)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM Employees WHERE Name LIKE @name";
                command.AddParameter("name", name + "%");
                return ToList(command);
            }
        }

        //public IEnumerable<Employee> FindBlocked()
        //{
        //    using (var command = _connection.CreateCommand())
        //    {
        //        command.CommandText = @"SELECT * FROM Users WHERE Status = -1";
        //        return ToList(command);
        //    }
        //}

        protected override void Map(IDataRecord record, Resource resource)
        {
            resource.Name = (string)record["Name"];
            resource.Id = (int)record["Id"];
        }
    }
}