

using System.Diagnostics.Tracing;

namespace AddressList.Tests
{
    public class AddressBook_tests
    {
        [Fact]
        public void AddPersonToJson_Should_AddOnePersonToList_ThenReturnTrue()
        {
            //Arange
            AddressBook addressBook = new AddressBook();
            Address address = new Address("Storgatan", "122", "266 55", "Helsingborg");
            Person person = new Person("per.andersson@gmail.com", "Per", "Andersson", "0702304333", address);
            List<Person> list = new List<Person>();
            list.Add(person);

            //Act
            bool result = addressBook.WriteToJsonFile(list);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ReadFromLJson_Should_ReturnAllPersonsFromList()
        {
            //Arange
            AddressBook addressBook = new AddressBook();

            //Act
            List<Person> result = addressBook.ReadJson();

            //Assert
            Assert.NotNull(result);
            Person person = result.FirstOrDefault();
            Assert.NotNull(person);
        }

        [Fact]
        public void JsonFile_Should_Return_JsonFileNotNull ()
        {
            //Arange
            AddressBook addressBook = new AddressBook();

            //Act
            var json = addressBook.ReadJson();

            //Assert
            Assert.NotNull(json);
        }
    }
}
