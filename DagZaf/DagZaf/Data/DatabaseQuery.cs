using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DagZaf.Model;
using SQLite;

namespace DagZaf.Data
{
    public class DatabaseQuery
    {
        #region Creacion - Tabla - DbPath
        readonly SQLiteAsyncConnection _database;

        public DatabaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<TodoModel>().Wait();
        }
        #endregion

        #region CRUD

        public Task<TodoModel> GetTodoModelAsync(int ID)
        {
            return _database.Table<TodoModel>().Where(i => i.TaskTodoID == ID).FirstOrDefaultAsync();
        }

        //Select o Busqueda de informacion
        public Task<List<User>> GetUser()
        {
            return _database.QueryAsync<User>("Select * From User");
        }

        //Insertar y Actualizar

        public Task<int> SaveUserAsync(User user)
        {
            if(user.ID != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }

        //Eliminar

        public Task<int> DeleteUserAsync(User user)
        {
            return _database.DeleteAsync(user);
        }

        #endregion
    }
}
