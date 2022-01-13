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

            Settings.Default.Profiles = "";
            Settings.Default.Save();

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

        public static Profile GetActiveProfile(string activeProcessName)
        {
            var profile = Profiles.FirstOrDefault(p => p.Name == activeProcessName);
            return profile ?? Profiles[0];
        }
    }
}
