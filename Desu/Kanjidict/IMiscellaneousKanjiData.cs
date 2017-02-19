﻿namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;

    public interface IMiscellaneousKanjiData
    {
        Grade Grade { get; }
        int StrokeCount { get; }
        IEnumerable<int> StrokeCommonMiscounts { get; }
        IEnumerable<IVariant> Variants { get; }
        int? Frequency { get; }
        IEnumerable<string> RadicalNames { get; } 
        int? JLPT { get; }
    }
}
