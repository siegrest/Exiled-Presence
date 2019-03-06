using Newtonsoft.Json;

namespace Service {
    public class Settings {
        [JsonIgnore] public const string DiscordAppId = "551089446460850176";
        [JsonIgnore] public const string ProgramName = "Exiled Presence";
        [JsonIgnore] public const string GameWindowTitle = "Path of Exile";
        [JsonIgnore] public const string ConfigFileName = "config.json";
        [JsonIgnore] public const string Version = "v1.0";
        [JsonIgnore] public const int CharacterUpdateDelaySec = 60;
        [JsonIgnore] public const int PresencePollDelayMs = 500;

        public string AccountName { get; set; }
        public string PoeSessionId { get; set; }

        /// <summary>
        /// Returns an obfuscated sessID for display purposes
        /// </summary>
        public string GetObfuscatedSessId() {
            return PoeSessionId == null ? null : new string('*', 28) + PoeSessionId.Substring(28);
        }

        /// <summary>
        /// Loads in settings from another instance
        /// </summary>
        public void Update(Settings settings) {
            AccountName = settings.AccountName;
            PoeSessionId = settings.PoeSessionId;
        }
    }
}