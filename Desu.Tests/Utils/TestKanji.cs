﻿using System;
using System.Collections.Generic;
using System.Text;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;

namespace Wacton.Desu.Tests
{
    public class TestKanji : IKanji
    {
        public string Text { get; set; }
        public IEnumerable<KanjiInformation> Informations { get; set; } = new List<KanjiInformation>();
        public IEnumerable<Priority> Priorities { get; set; } = new List<Priority>();

        public override string ToString()
        {
            return this.Text;
        }
    }
}
