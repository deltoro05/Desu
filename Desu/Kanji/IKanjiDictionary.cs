﻿namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    public interface IKanjiDictionary
    {
        IEnumerable<IKanjiEntry> GetEntries();
    }
}
