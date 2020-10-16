using DevExpress.Mvvm;
using FoundYou.Core.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FoundYou.Core
{
    public class MainWindowVM : ViewModelBase, INotifyPropertyChanged
    {
        new public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private MainWindow _window;
        private AmongUs _amongUs;
        private string _imposters = "NONE";
        public string Imposters { get => _imposters; set { _imposters = value; NotifyPropertyChanged(); } }
        public MainWindowVM(MainWindow window)
        {
            _window = window;
            Task.Factory.StartNew(() =>
            {
                _amongUs = new AmongUs();
                _amongUs.Connect();
                while (true)
                {
                    var players = _amongUs.Collect();
                    _amongUs.ResetTimer();
                   // game.Rainbow();
                  //  game.Teleport();
                    Imposters = string.Join(" & ", players.Where(x => x.Imposter).Select(x => x.Colour.ToString()));
                    Thread.Sleep(1000);
                }
            });
        }
        public ICommand Teleport => new DelegateCommand(() =>
        {
            _amongUs.Teleport(1099566129, -1069473652);
        });
        public ICommand Skip => new DelegateCommand(() =>
        {
            _amongUs.NoVoting();
        });
        public ICommand Rainbow => new DelegateCommand(() =>
        {
            _amongUs.Rainbow();
        });
        public ICommand InstantKill => new DelegateCommand(() =>
        {
            _amongUs.Rainbow();
        });
        public ICommand Flash => new DelegateCommand(() =>
        {
            _amongUs.Flash();
        });

    }
}
