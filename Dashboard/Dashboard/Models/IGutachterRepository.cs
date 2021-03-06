﻿using System.Collections.Generic;

namespace Dashboard.Models
{
    /// <summary>
    /// Anforderung: Idiotensicher
    /// </summary>
    public interface IGutachterRepository
    {
        int Create(string vorname, string nachname, string mail);

        void Update(Gutachter gutachter);

        Gutachter Read(int id);

        IEnumerable<Gutachter> ReadAll();

        void Delete(int id);
    }
}