using CommunityToolkit.Mvvm.ComponentModel;

namespace Bloxstrap.Models
{
    public class Executor : ObservableObject
    {
        public string Name { get; set; } = "";

        private bool _enabled;
        public bool Enabled
        {
            get => _enabled;
            set => SetProperty(ref _enabled, value);
        }

        private string _folder = "";
        public string Folder
        {
            get => _folder;
            set => SetProperty(ref _folder, value);
        }
    }
}