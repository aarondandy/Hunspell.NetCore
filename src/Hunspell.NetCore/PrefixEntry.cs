﻿namespace Hunspell
{
    public sealed class PrefixEntry : AffixEntry
    {
        public override string Key
        {
            get
            {
                return Append;
            }
        }
    }
}
