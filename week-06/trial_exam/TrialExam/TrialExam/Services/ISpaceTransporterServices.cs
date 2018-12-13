using System.Collections.Generic;
using TrialExam.Models;
using TrialExam.ViewModels;

namespace TrialExam.Services
{
    public interface ISpaceTransporterServices
    {
        IEnumerable<Planet> FindAllPlanets();

        Spaceship FindSpaceship();
        
        Planet FindPlanet(long id);

        SpaceTransporterViewModel CreatViewModel();
        
        void MoveShipToPlanet(long id);

        void MovePeopleToShip();

        void MovePeopleToPlanet();
    }
}