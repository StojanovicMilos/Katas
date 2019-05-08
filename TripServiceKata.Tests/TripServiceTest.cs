using System.Collections.Generic;
using TripServiceKata.Exception;
using TripServiceKata.Trip;
using Xunit;

namespace TripServiceKata.Tests
{
    public class TripServiceTest
    {
        private static readonly User.User Anonymous = null;
        private static readonly User.User AnyUser = new User.User();
        private static readonly User.User AnyLoggedInUser = new User.User();
        private static User.User _loggedInUser = null;

        private static readonly Trip.Trip ToLondon = new Trip.Trip();
        private static readonly Trip.Trip ToParis = new Trip.Trip();



        [Fact]
        public void TripServiceTestsWork()
        {
            Assert.True(true);
        }

        [Fact]
        public void ShouldThrowExceptionIfUserIsNotLoggedIn()
        {
            //arrange
            TripService tripService = new TripService();
            User.User user = AnyUser;
            _loggedInUser = Anonymous; 

            //act

            //assert
            Assert.Throws<UserNotLoggedInException>(() => tripService.GetTripsByUser(user, _loggedInUser));
        }

        [Fact]
        public void ShouldReturnNoTripsWhenUserHasNoFriends()
        {
            //arrange
            TripService tripService = new TripService();
            User.User friendlessUser = AnyUser;
            _loggedInUser = AnyLoggedInUser;
            
            //act
            var trips = tripService.GetTripsByUser(friendlessUser, _loggedInUser);
            
            //assert
            Assert.Empty(trips);
        }

        [Fact]
        public void ShouldReturnNoTripsWhenUserIsNotFriendsWithLoggedInUser()
        {
            //arrange
            TripService tripService = new TripService();
            User.User friendfulUser = new User.User();
            friendfulUser.AddFriend(AnyUser);
            _loggedInUser = AnyLoggedInUser;

            //act
            var trips = tripService.GetTripsByUser(friendfulUser, _loggedInUser);

            //assert
            Assert.Empty(trips);
        }

        [Fact]
        public void ShouldReturnTripsWhenUserHasAFriend()
        {
            //arrange
            MockTripDAO mockTripDAO = new MockTripDAO();
            TripService tripService = new TripService(mockTripDAO);
            User.User friendfulUser = new User.User();
            _loggedInUser = AnyLoggedInUser;
            friendfulUser.AddFriend(_loggedInUser);
            friendfulUser.AddTrip(ToLondon);
            friendfulUser.AddTrip(ToParis);
            const int expectedNumberOfTrips = 2;

            //act
            var trips = tripService.GetTripsByUser(friendfulUser, _loggedInUser);

            //assert

            Assert.NotEmpty(trips);
            Assert.Equal(expectedNumberOfTrips, trips.Count);
        }

        private class MockTripDAO : TripDAO
        {
            public override List<Trip.Trip> FindTripsByUser(User.User user)
            {
                return user.Trips();
            }
        }
    }
}
