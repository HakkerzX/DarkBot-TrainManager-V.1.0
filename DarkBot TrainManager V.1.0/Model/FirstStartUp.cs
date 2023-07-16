using DarkBotTrainManager.Services;
using Newtonsoft.Json;

namespace DarkBotTrainManager.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class FirstStartUp : BaseNotifyPropertyChangedService
    {
        private string _darkBotFilePath;
        private string _darkBotInstallFolderPath;

        public string DarkBotFilePath
        {
            get { return _darkBotFilePath; }
            set
            {
                _darkBotFilePath = value;
                OnPropertyChanged(nameof(DarkBotFilePath));
            }
        }
        [JsonProperty]
        public string DarkBotInstallFolderPath
        {
            get { return _darkBotInstallFolderPath; }
            set
            {
                _darkBotInstallFolderPath = value;
                OnPropertyChanged(nameof(DarkBotInstallFolderPath));
            }
        }
    }
}

