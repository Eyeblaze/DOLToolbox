﻿using DOL.Database;

namespace MannikToolbox.Services
{
    public class MobService
    {
        public Mob GetMob(string mobId)
        {
            return DatabaseManager.Database.FindObjectByKey<Mob>(mobId);
        }

        public void SaveMob(Mob mob)
        {
            if (string.IsNullOrWhiteSpace(mob.ObjectId))
            {
                DatabaseManager.Database.AddObject(mob);
                return;
            }
            
            DatabaseManager.Database.SaveObject(mob);
        }
    }
}