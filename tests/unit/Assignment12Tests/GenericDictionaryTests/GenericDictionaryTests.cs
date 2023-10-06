using CollectionAndGenerics;

namespace CollectionAndGenericsTests
{
    public class GenericDictionaryTests
    {
        public static GenericDictionary<string, float> StudentDetails { get; set; } = new();

        [Fact]
        public void ValidNameAndGradeGiven_AddDetails_UpdatedDictionary()
        {
            Console.SetIn(new StringReader("Ancy\n8.2"));
            DictionaryofStudentDetails.AddDetails();
            Console.SetIn(new StringReader("Jenisha\n8.75"));
            DictionaryofStudentDetails.AddDetails();
            Assert.True(StudentDetails.GenericDictionaryCount == 2);
        }

        [Fact]
        public void ValidStudentNameGiven_RemoveDetails_UpdatedDictionary()
        {
            StudentDetails.AddStudentDetails("Ancy", 7.25F);
            Console.SetIn(new StringReader("Ancy"));
            DictionaryofStudentDetails.RemoveDetails();
            Assert.True(StudentDetails.GenericDictionaryCount == 0);
        }
    }
}
