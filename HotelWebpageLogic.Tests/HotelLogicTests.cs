using FluentAssertions;
using HotelWebsite.Data;
using HotelWebsite.Logic;

namespace HotelWebpageLogic.Tests
{
    public class HotelLogicTests
    {
        [Fact]
        public void GetRooms_ShouldReturnListOfHotelRoomModel()
        {
            // Given
            HotelLogic logic = new();


            // When
            var returnedList = logic.GetRooms();

            // Then
            returnedList.Should().NotBeEmpty();
            returnedList.Should().BeOfType<List<HotelRoomModel>>();
        }

        //BookRoom Tests
        [Fact]
        public void BookRoom_ShouldUpdateHotelRoomList()
        {
            // Given
            HotelLogic logic = new();
            int roomID = 101;
            int days = 3;

            List<HotelRoomModel> HotelRoomsList = new List<HotelRoomModel> //Copy of the list of rooms to compare with test
            {
            new HotelRoomModel { RoomNumber = 101, RoomType = "Single", PricePerDay = 150, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 102, RoomType = "Single", PricePerDay = 150, IsVacant = false, BookedDaysLeft = 7},
            new HotelRoomModel { RoomNumber = 103, RoomType = "Double", PricePerDay = 250, IsVacant = false, BookedDaysLeft = 3},
            new HotelRoomModel { RoomNumber = 104, RoomType = "Double", PricePerDay = 250, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 105, RoomType = "Single", PricePerDay = 150, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 201, RoomType = "Single", PricePerDay = 200, IsVacant = false, BookedDaysLeft = 10},
            new HotelRoomModel { RoomNumber = 202, RoomType = "Double", PricePerDay = 300, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 203, RoomType = "Single", PricePerDay = 200, IsVacant = true, BookedDaysLeft = null},
            new HotelRoomModel { RoomNumber = 204, RoomType = "Double", PricePerDay = 300, IsVacant = false, BookedDaysLeft = 5},
            new HotelRoomModel { RoomNumber = 205, RoomType = "Single", PricePerDay = 200, IsVacant = false, BookedDaysLeft = 5},
            new HotelRoomModel { RoomNumber = 301, RoomType = "Penthouse", PricePerDay = 500, IsVacant = true, BookedDaysLeft = null}
            };

            // When
            logic.BookRoom(roomID, days);
            List<HotelRoomModel> roomList = logic.GetRooms();

            // Then
            roomList.Should().NotEqual(HotelRoomsList);
            roomList[0].IsVacant.Should().BeFalse();
            roomList[0].BookedDaysLeft.Should().Be(days);

        }

        [Fact]
        public void BookRoom_RoomIsNotVacant_ShouldThrowErrorMessage() //Could make it impossible to do in UI, but still good to have just in case
        {
            // Given
            HotelLogic logic = new();
            int roomNumber = 102;
            int days = 2;

            //Exact copy of what that room looks like in the static list
            HotelRoomModel roomCopy = new HotelRoomModel { RoomNumber = 102, RoomType = "Single", PricePerDay = 150, IsVacant = false, BookedDaysLeft = 7 };

            // When
            Action test = () => logic.BookRoom(roomNumber, days);
            HotelRoomModel room = logic.GetRooms().FirstOrDefault(r => r.RoomNumber == roomNumber);

            // Then
            test.Should().Throw<Exception>();
            room.Should().BeEquivalentTo(roomCopy);
        }

        [Fact]
        public void BookRoom_RoomNumberDoesNotExist_ShouldThrowInvalidOperationException()
        {
            // Given
            HotelLogic logic = new();
            int roomNumber = -1;
            int days = 2;

            // When
            Action test = () => logic.BookRoom(roomNumber, days);

            // Then
            test.Should().Throw<InvalidOperationException>();
        }

        //CalculatePrice Tests
        [Fact]
        public void CalculatePrice_ShouldReturnCorrectPrice()
        {
            // Given
            HotelLogic logic = new();
            int roomID = 101;
            int days = 3;
            var room = logic.GetRooms().FirstOrDefault(r => r.RoomNumber == roomID);

            // When
            int result = logic.CalculatePrice(roomID, days);

            // Then
            result.Should().Be(room.PricePerDay * days);
        }

        [Fact]
        public void CalculatePrice_NumberOfDaysTooBig_ShouldReturnArgumentOutOfException()
        {
            // Given
            HotelLogic logic = new();
            int roomID = 101;
            int days = int.MaxValue;

            // When
            Action test = () => logic.CalculatePrice(roomID, days);

            // Then
            test.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
