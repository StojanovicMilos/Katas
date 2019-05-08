using System;
using System.Collections.Generic;
using TripServiceKata.Exception;

namespace TripServiceKata.Trip
{
    public class TripService
    {
        private readonly TripDAO _tripDAO;

        public TripService() : this(new TripDAO())
        {
            
        }

        public TripService(TripDAO tripDao)
        {
            _tripDAO = tripDao ?? throw new ArgumentNullException(nameof(tripDao));
        }

        public List<Trip> GetTripsByUser(User.User user, User.User loggedUser)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (loggedUser == null) throw new UserNotLoggedInException();

            return user.IsFriendWith(loggedUser) ? GetTripsBy(user) : new List<Trip>();
        }

        protected virtual List<Trip> GetTripsBy(User.User user)
        {
            return _tripDAO.FindTripsByUser(user);
        }
    }
}
