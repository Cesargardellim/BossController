using System;
using SQLite.Net.Interop;

namespace BossController.Entity
{
    public interface IConfig
    {

        string DiretoryDB { get; }
        ISQLitePlatform Plataform { get; }



    }
}
