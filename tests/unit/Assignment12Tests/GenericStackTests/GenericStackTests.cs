using CollectionAndGenerics;

namespace CollectionAndGenericsTests
{
    public class GenericStackTests
    {

        [Fact]
        public void ValidCharacterGiven_AddCharactersToStack_UpdatedStack()
        {
            GenericStack<char> StackOfCharactersObject = new();
            Console.SetIn(new StringReader("A"));
            StackOfCharacters.PushCharacterToStack();
            Assert.Equal(2,StackOfCharactersObject.GenericStackCount);
        }

        [Fact]
        public void NonEmptyStack_PopCharacterToStack_UpdatedStack()
        {
            GenericStack<char> StackOfCharactersObject = new();
            StackOfCharactersObject.AddCharactersToStack('A');
            StackOfCharactersObject.AddCharactersToStack('J');
            StackOfCharacters.PopCharacterToStack();
            Assert.Equal(1,StackOfCharactersObject.GenericStackCount);
        }

    }
}
