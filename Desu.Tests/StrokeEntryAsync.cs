﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wacton.Desu.Strokes;
using Wacton.Desu.Tests.Strokes;

namespace Wacton.Desu.Tests
{
    public class StrokeEntryAsync
    {
        private IDictionary<string, IEnumerable<string>> kanjiToStrokes;

        [OneTimeSetUp]
        public async Task Setup()
        {
            kanjiToStrokes = await StrokeLookup.ParseKanjiToStrokesAsync();
        }

        [Test]
        public void Codepoint04BC2䯂() => StrokeAssert.AssertList(TestEntries.Codepoint04BC2䯂(), () => kanjiToStrokes["04bc2"]);

        [Test]
        public void Codepoint04E80亀() => StrokeAssert.AssertList(TestEntries.Codepoint04E80亀(), () => kanjiToStrokes["04e80"]);

        [Test]
        public void Codepoint05F41彁() => StrokeAssert.AssertList(TestEntries.Codepoint05F41彁(), () => kanjiToStrokes["05f41"]);

        [Test]
        public void Codepoint09C39鰹() => StrokeAssert.AssertList(TestEntries.Codepoint09C39鰹(), () => kanjiToStrokes["09c39"]);

        [Test]
        public void Codepoint0590A夊() => StrokeAssert.AssertList(TestEntries.Codepoint0590A夊(), () => kanjiToStrokes["0590a"]);

        [Test]
        public void Codepoint00021() => StrokeAssert.AssertList(TestEntries.Codepoint00021(), () => kanjiToStrokes["00021"]); // first entry in kanjivg (! - exclamation mark)

        [Test]
        public void Codepoint26951() => StrokeAssert.AssertList(TestEntries.Codepoint26951(), () => kanjiToStrokes["26951"]); // last entry in kanjivg (𦥑 - variant form of 臼)
    }
}