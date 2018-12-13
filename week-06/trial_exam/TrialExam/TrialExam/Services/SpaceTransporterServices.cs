using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialExam.Models;
using TrialExam.ViewModels;

namespace TrialExam.Services
{
    public class SpaceTransporterServices : ISpaceTransporterServices
    {
        private readonly SpaceTransporterContext spaceTransporterContext;

        public SpaceTransporterServices(SpaceTransporterContext spaceTransporterContext)
        {
            this.spaceTransporterContext = spaceTransporterContext;
        }

        public IEnumerable<Planet> FindAllPlanets()
        {
            return spaceTransporterContext.Planets;
        }

        public Spaceship FindSpaceship()
        {
            return spaceTransporterContext.Spaceships.ToList().Find(x => x.SpaceshipId == 1);
        }

        public Planet FindPlanet(long id)
        {
            return spaceTransporterContext.Planets.ToList().Find(x => x.PlanetId == id);
        }

        public SpaceTransporterViewModel CreatViewModel()
        {
            SpaceTransporterViewModel model = new SpaceTransporterViewModel();
            model.PlanetList = spaceTransporterContext.Planets.ToList();
            model.Spaceship = FindSpaceship();

            return model;
        }

        public void MoveShipToPlanet(long id)
        {
            FindSpaceship().PlanetId = id;
            FindSpaceship().Location = spaceTransporterContext.Planets.ToList().Find(x => x.PlanetId == id).Name;

            spaceTransporterContext.SaveChanges();
        }

        public void MovePeopleToShip()
        {
            var planetId = FindSpaceship().PlanetId;
            var population = FindPlanet(planetId).Population;
            var availableSeats = FindSpaceship().Capacity - FindSpaceship().CurrentPassengers;
            long transporterNumber = 0;

            if (availableSeats > 0)
            {
                if (population > availableSeats) transporterNumber = availableSeats;
                else if (population <= availableSeats) transporterNumber = population;
            }

            FindPlanet(planetId).Population -= transporterNumber;
            FindSpaceship().CurrentPassengers += transporterNumber;

            spaceTransporterContext.SaveChanges();
        }

        public void MovePeopleToPlanet()
        {
            var planetId = FindSpaceship().PlanetId;
            FindPlanet(planetId).Population += FindSpaceship().CurrentPassengers;
            FindSpaceship().CurrentPassengers = 0;

            spaceTransporterContext.SaveChanges();
        }
    }
}
