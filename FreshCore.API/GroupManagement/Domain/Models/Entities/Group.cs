using FreshCore.API.ContainerManagement.Domain.Models.Entities;
using FreshCore.API.GroupManagement.Domain.Models.ValueObject;
using FreshCore.API.UserProfile.Domain.Models.Entities;

namespace FreshCore.API.GroupManagement.Domain.Models.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Location Location { get; set; }
        public int AccountId { get; set; }
        public FacilityType FacilityType { get; }
        public int LocationId { get; set; }

        public int ContainerCount { get; set; }
        public int ProfileCount { get; set; }
        public ICollection<Container> Containers { get; set; } = new List<Container>();
        public ICollection<Profile> Profiles { get; set; } = new List<Profile>(); 



        public Group(){}

        public Group(int accountId, string name, Location location, FacilityType facilityType, int? containerCount, int? profileCount)
        {
            AccountId = accountId;
            Name = name;
            Location = location;
            FacilityType = facilityType;
            ContainerCount = containerCount ?? 0;
            ProfileCount = profileCount ?? 0;
        }

        public void UpdateGroupLocation(Location location)
        {
            Location = location;
        }

        public void UpdateGroupName(string name)
        {
            Name = name;
        }
    }
}