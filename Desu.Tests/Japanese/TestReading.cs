﻿using System.Collections.Generic;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;

namespace Wacton.Desu.Tests.Japanese
{
    public class TestReading : IReading
    {
        public string Text { get; set; }
        public bool IsTrueKanjiReading { get; set; } = true;
        public IEnumerable<string> Restriction { get; set; } = new List<string>();
        public IEnumerable<ReadingInformation> Informations { get; set; } = new List<ReadingInformation>();
        public IEnumerable<Priority> Priorities { get; set; } = new List<Priority>();

        public override string ToString()
        {
            return this.Text;
        }
    }
}