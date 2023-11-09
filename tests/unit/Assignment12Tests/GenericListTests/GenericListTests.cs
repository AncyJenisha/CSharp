using CollectionAndGenerics;

namespace GenericListTests
{
    public class GenericListTests
    {
        public static GenericList<string> ListObj { get; set; } = new GenericList<string>();

        [Fact]
        public void ValidBookNameGiven_Add_UpdatedList()
        {
            Console.SetIn(new StringReader("The Alchemist"));
            ListofBooks.AddBooks();
            Assert.True(ListObj.Count == 2);
        }

        [Fact]
        public void ValidIndexGiven_RemoveBooks_UpdatedList()
        {
            ListObj.Add("Red Ray Of Hope");
            ListObj.Add("Paradise Lost");
            Console.SetIn(new StringReader("1"));
            ListofBooks.RemoveBooks();
            Assert.True(ListObj.Count == 1);
        }
    }
}