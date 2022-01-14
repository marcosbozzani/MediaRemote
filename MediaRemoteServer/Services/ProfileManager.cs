using Duck.MediaRemote.Server.Models;
using Duck.MediaRemote.Server.Properties;
using System.ComponentModel;
using System.Linq;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Duck.MediaRemote.Server.Services
{
    public class ProfileManager
    {
        private static readonly ISerializer serializer = new SerializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();

        private static readonly IDeserializer deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();

        public static readonly BindingList<Profile> Profiles;

        static ProfileManager()
        {
            Profiles = deserializer.Deserialize<BindingList<Profile>>(Settings.Default.Profiles);
            if (Profiles == null)
            {
                Profiles = new BindingList<Profile>();
                Profiles.Add(new Profile());
            }
        }

        public static void Save()
        {
            if (Profiles != null)
            {
                Settings.Default.Profiles = serializer.Serialize(Profiles);
                Settings.Default.Save();
            }
        }

        public static Profile GetDefaultProfile()
        {
            return Profiles[0];
        }

        public static bool IsDefaultProfile(Profile profile)
        {
            return Profiles.IndexOf(profile) == 0;
        }

        public static Profile GetActiveProfile(string activeProcessName)
        {
            var profile = Profiles.FirstOrDefault(p => p.Name == activeProcessName);
            return profile ?? GetDefaultProfile();
        }

        public static void AddProfile(Profile profile)
        {
            Profiles.Add(profile);
            Save();
        }

        public static void RemoveProfile(Profile profile)
        {
            int index = Profiles.IndexOf(profile);
            if (index != 0)
            {
                Profiles.RemoveAt(index);
                Save();
            }
        }
    }
}
