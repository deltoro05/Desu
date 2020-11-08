﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Kanji;
using Wacton.Desu.Tests.Kanji;

namespace Wacton.Desu.Tests
{
    public class KanjiEntry
    {
        private IEnumerable<IKanjiEntry> kanjiEntries;

        [OneTimeSetUp]
        public void Setup()
        {
            kanjiEntries = KanjiDictionary.ParseEntries();
        }

        [Test]
        public void 䯂() => AssertEntry(TestEntries.䯂());

        [Test]
        public void 亀() => AssertEntry(TestEntries.亀());

        [Test]
        public void 彁() => AssertEntry(TestEntries.彁());

        [Test]
        public void 鰹() => AssertEntry(TestEntries.鰹());

        [Test]
        public void 夊() => AssertEntry(TestEntries.夊());

        private void AssertEntry(TestEntry testEntry)
        {
            var entry = kanjiEntries.Single(x => x.Literal == testEntry.Literal);
            AssertEntriesAreEqual(entry, testEntry);
        }

        private static void AssertEntriesAreEqual(IKanjiEntry first, IKanjiEntry second)
        {
            Assert.That(first.Literal, Is.EqualTo(second.Literal));
            Assert.That(first.RadicalDecomposition, Is.EqualTo(second.RadicalDecomposition));
            Assert.That(first.Codepoints, Is.EqualTo(second.Codepoints));
            Assert.That(first.StrokePaths, Is.EqualTo(second.StrokePaths));
            Assert.That(first.BushuRadicals, Is.EqualTo(second.BushuRadicals));
            Assert.That(first.IsBushuRadical, Is.EqualTo(second.IsBushuRadical));
            Assert.That(first.Grade, Is.EqualTo(second.Grade));
            Assert.That(first.StrokeCount, Is.EqualTo(second.StrokeCount));
            Assert.That(first.StrokeCommonMiscounts, Is.EqualTo(second.StrokeCommonMiscounts));
            Assert.That(first.Variants, Is.EqualTo(second.Variants));
            Assert.That(first.Frequency, Is.EqualTo(second.Frequency));
            Assert.That(first.RadicalNames, Is.EqualTo(second.RadicalNames));
            Assert.That(first.JLPT, Is.EqualTo(second.JLPT));
            Assert.That(first.References, Is.EqualTo(second.References));
            Assert.That(first.QueryCodes, Is.EqualTo(second.QueryCodes));
            Assert.That(first.Readings, Is.EqualTo(second.Readings));
            Assert.That(first.Meanings, Is.EqualTo(second.Meanings));
            Assert.That(first.Nanoris, Is.EqualTo(second.Nanoris));
        }
    }
}