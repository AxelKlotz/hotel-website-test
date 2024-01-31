using FluentAssertions;
using HotelWebsite.Data;
using HotelWebsite.Logic;

namespace HotelWebpageLogic.Tests
{
    public class HotelLogicTests
    {
        [Fact]
        public void GetRooms_ShouldReturnListOfHotelModel()
        {
            // Given
            HotelLogic logic = new();


            // When
            var returnedList = logic.GetRooms();

            // Then
            returnedList.Should().NotBeEmpty();
            returnedList.Should().BeOfType<List<HotelRoomModel>>();
        }
    }
}
