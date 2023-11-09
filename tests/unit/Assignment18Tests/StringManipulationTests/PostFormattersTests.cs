namespace StringManipulationTests
{
    using StringManipualtion;
    using System.Text;

    public class PostFormaterTests
    {
        [Fact]
        public static void ValidStringGiven_FormatPost_FormatesString()
        {
            string original = "This is a test\n\n.This is a new test.\n";
            PostFormater postFormater = new PostFormater();
            string expectedResult = "This is a test<p /><p />.This is a new test.<p />";
            
            string actualResult = postFormater.FormatPost(original);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public static void StringWithTagsGiven_ExtractTags_ListOfStringsWithTagsCreated()
        {
            string original = "It is a good day #GoodDay #TagExtraction";
            PostFormater postFormatter = new PostFormater();
            
            List<string> listOfTags = postFormatter.ExtractTags(original);

            Assert.Contains("#GoodDay", listOfTags);
        }

        [Theory]
        [InlineData("GoodMorning", "Good" , true)]
        [InlineData("Ancy Jenisha", "Ancy" , true)]
        [InlineData("Where the mind is wihout fear", "let", false)]
        public static void ValidQueryToSearchGiven_SearchPost_GivesTrueIf(string contentToCheck,string queryToSearch,  bool expectedResult)
        {
            PostFormater postFormater = new PostFormater();

            bool actualResult = postFormater.SearchPost(queryToSearch, contentToCheck);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ValidStringGiven_AnalyzeText_GivesDictionaryOfNumberOfWordOccurance()
        {
            string content = "This a test for analyze text test";
            PostFormater postFormater = new PostFormater();
            Dictionary<string, int> dictionaryOfActualWordOccurance = postFormater.AnalyzeText(content);
            Dictionary<string, int> dictionaryOfExpectedWordOccurance = new Dictionary<string, int>(){ { "a", 1 }, { "test",2}, {"for",1}, {"analyze", 1}, { "text", 1 } };
            Assert.Equal(dictionaryOfExpectedWordOccurance, dictionaryOfActualWordOccurance);
        }

        [Theory]
        [InlineData("Ancy Jenisha","Ancy Jenisha", 1.00)]
        [InlineData("Good Day","Good Morning", 0.5)]
        [InlineData("Its about the Journey","Go", 0.0)]
        public static void TwoValidStringsGiven_ComparePosts_GivesSimilarityIndex(string firstContent, string secondContent, double expectedSimilarityIndex)
        {
            PostFormater postFormater = new PostFormater();
            double actualSimilarityIndex = postFormater.ComparePosts(firstContent, secondContent);
            Assert.Equal(expectedSimilarityIndex, actualSimilarityIndex);
        }

        [Theory]
        [InlineData("|http://www.iuma.com/IUMA-2.0/ftp/volume2/Wallace,_Dorothy/ Link to get the book", "|http://www.iuma.com/IUMA-2.0/ftp/volume2/Wallace,_Dorothy/")]
        [InlineData("|http://www.iuma.com/IUMA-2.0/ftp/volume2/The_Whistle_Pigs/ Link to get the book", "|http://www.iuma.com/IUMA-2.0/ftp/volume2/The_Whistle_Pigs/")]
        public static void ValidStringWithUrlGiven_ParseUrl_ReturnsListOfUrl(string content, string url)
        {
            PostFormater postFormater = new PostFormater();
            List<string> listOfUrls = postFormater.ParseURLs(content);

            Assert.Contains(url, listOfUrls);
        }

        [Theory]
        [InlineData("<TITLE>The Title</TITLE>","The Title\n")]
        public static void ValidStringGiven_ConcatenateTitles_AppendsStringBuilder(string content,string title)
        {
            PostFormater postFormater = new PostFormater();
            StringBuilder stringBuilder = new StringBuilder();
            string actualTitles = postFormater.ConcatenateTitles(content, stringBuilder);
            Assert.Equal(title, actualTitles);
        }
    }
}