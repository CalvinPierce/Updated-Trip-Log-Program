using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private TripLogContext context { get; set; }

        public UnitOfWork(TripLogContext ctx) => context = ctx;

        private Repository<Trip> trips;
        public Repository<Trip> Trips
        {
            get
            {
                if (trips == null)
                {
                    trips = new Repository<Trip>(context);
                }
                return trips;
            }
        }

        private Repository<Destination> destinations;
        public Repository<Destination> Destinations
        {
            get
            {
                if (destinations == null)
                {
                    destinations = new Repository<Destination>(context);
                }
                return destinations;
            }
        }

        private Repository<Accommodation> accomodations;
        public Repository<Accommodation> Accomodations
        {
            get
            {
                if (accomodations == null)
                {
                    accomodations = new Repository<Accommodation>(context);
                }
                return accomodations;
            }
        }

        private Repository<Activity> activities;
        public Repository<Activity> Activities
        {
            get
            {
                if (activities == null)
                {
                    activities = new Repository<Activity>(context);
                }
                return activities;
            }
        }

        public void Save() => context.SaveChanges();
    }
}
