using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11.Models.DataAccess
{
    interface IUnitOfWork
    {
        Repository<Trip> Trips { get; }

        Repository<Destination> Destinations { get; }

        Repository<Accommodation> Accomodations { get; }

        Repository<Activity> Activities { get; }

        void Save();
    }
}
