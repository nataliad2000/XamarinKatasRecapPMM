﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1MasterMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage1MasterMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage1MasterMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage1MasterMasterViewModel : INotifyPropertyChanged
        {
           
            public ObservableCollection<MasterDetailPage1MenuItemMenuItem> MenuItems { get; set; }

            public MasterDetailPage1MasterMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage1MenuItemMenuItem>(new[]
                {
                    new MasterDetailPage1MenuItemMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailPage1MenuItemMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailPage1MenuItemMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailPage1MenuItemMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailPage1MenuItemMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}