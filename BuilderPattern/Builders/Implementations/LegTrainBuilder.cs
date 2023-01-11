﻿using BuilderPattern.Builders;
using BuilderPattern.Entities;

namespace BuilderPattern.Services.Implementations
{
    public class LegTrainBuilder : ILegBuilder
    {
        private Leg _leg;
        public LegTrainBuilder()
        {
            _leg = new Leg();
        }


        public ILegBuilder BuildDetail(string facilitiesStation, DateTime departureDate, DateTime arrivalDate)
        {
            _leg.FacilitiesStation = facilitiesStation;
            _leg.DepartureDate = departureDate;
            _leg.ArrivalDate = arrivalDate;
            _leg.StationType = Common.StationTypeEnume.Train;

            return this;
        }

        public ILegBuilder BuildDepartureCity(string departure)
        {
            _leg.Departure = departure;

            return this;
        }

        public ILegBuilder BuildArrivalCity(string arrival)
        {
            _leg.Arrival = arrival;

            return this;
        }


        public Leg Build() => _leg;
    }
}
