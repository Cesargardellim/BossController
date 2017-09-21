using System;
using SQLite;

namespace BossController.Entity
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
