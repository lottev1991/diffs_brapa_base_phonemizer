using OpenUtau.Api;

namespace OpenUtau.Core.DiffSinger
{
    [Phonemizer("DiffSinger BRAPA Base Phonemizer", "DIFFS BRAPA-B", language: "PT")]
    public class DiffSingerBRAPABasePhonemizer : DiffSingerBasePhonemizer
    {
        protected override string GetDictionaryName()=>"dsdict-brapa.yaml";
        public override string GetLangCode()=>"pt";
    }
}
