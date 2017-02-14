﻿namespace Wacton.Desu.Kanjidict
{
    public class CharacterElementData
    {
        public string Content { get; }
        public string CodepointTypeAttribute { get; }
        public string LanguageAttribute { get; }

        public CharacterElementData(string content, string codepointTypeAttribute, string languageAttribute)
        {
            this.Content = content;
            this.CodepointTypeAttribute = codepointTypeAttribute;
            this.LanguageAttribute = languageAttribute;
        }

        public override string ToString()
        {
            return this.Content;
        }
    }
}